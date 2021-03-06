﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Academy.Lib.DAL;
using Academy.Lib.Models;

namespace WebAspNetAcademy.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentExamsController : ControllerBase
    {
        private readonly AcademyDbContext _context;

        public StudentExamsController(AcademyDbContext context)
        {
            _context = context;
        }

        // GET: api/StudentExams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentExam>>> GetStudentExams()
        {
            return await _context.StudentExams.ToListAsync();
        }

        // GET: api/StudentExams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentExam>> GetStudentExam(Guid id)
        {
            var studentExam = await _context.StudentExams.FindAsync(id);

            if (studentExam == null)
            {
                return NotFound();
            }

            return studentExam;
        }

        // PUT: api/StudentExams/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentExam(Guid id, StudentExam studentExam)
        {
            if (id != studentExam.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentExam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExamExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/StudentExams
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<StudentExam>> PostStudentExam(StudentExam studentExam)
        {
            _context.StudentExams.Add(studentExam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentExam", new { id = studentExam.Id }, studentExam);
        }

        // DELETE: api/StudentExams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentExam>> DeleteStudentExam(Guid id)
        {
            var studentExam = await _context.StudentExams.FindAsync(id);
            if (studentExam == null)
            {
                return NotFound();
            }

            _context.StudentExams.Remove(studentExam);
            await _context.SaveChangesAsync();

            return studentExam;
        }

        private bool StudentExamExists(Guid id)
        {
            return _context.StudentExams.Any(e => e.Id == id);
        }
    }
}
