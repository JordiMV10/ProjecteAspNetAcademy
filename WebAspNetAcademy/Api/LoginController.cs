﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebAspNetAcademy.Models;

namespace WebAspNetAcademy.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // POST: api/Login
        [HttpPost]
        public Task<bool> Post([FromBody] LoginDto login)
        {
            return Task.Run(() =>
            {

                if (!string.IsNullOrEmpty(login.Email) &&
                    !string.IsNullOrEmpty(login.Password))
                    return true;

                else
                    return false;
            });
        }
    }

}
