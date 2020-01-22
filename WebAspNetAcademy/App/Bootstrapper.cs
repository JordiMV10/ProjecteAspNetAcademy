using Academy.Lib.DAL;
using Academy.Lib.DAL.Repositories;
using Academy.Lib.Models;
using Academy.Lib.Repositories;
using Common.Lib.Core;
using Common.Lib.Core.Context;
using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNetAcademy.DbContextFactory;

namespace WebAspNetAcademy.App
{
    public class Bootstrapper
    {
        

        public IDependencyContainer Init()
        {
            var depCon = new SimpleDependencyContainer();

            RegisterRepositories(depCon);

            Entity.DepCon = depCon;

            return depCon;
        }

        public void RegisterRepositories(IDependencyContainer depCon)
        {
            var studentRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new StudentsRepository(GetDbConstructor());
            });

            var subjectsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<Subject>(GetDbConstructor());
            });

            var examsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<Exam>(GetDbConstructor());
            });

            var studentSubjectsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<StudentSubject>(GetDbConstructor());
            });


            var studentsExamsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<StudentExam>(GetDbConstructor());
            });

            depCon.Register<IRepository<Student>, StudentsRepository>(studentRepoBuilder);
            depCon.Register<IStudentsRepository, StudentsRepository>((parameters) => new StudentsRepository(GetDbConstructor()));

            depCon.Register<IRepository<Subject>, EfCoreRepository<Subject>>(subjectsRepoBuilder);
            depCon.Register<IRepository<Exam>, EfCoreRepository<Exam>>(examsRepoBuilder);
            depCon.Register<IRepository<StudentSubject>, EfCoreRepository<StudentSubject>>(studentSubjectsRepoBuilder);

            depCon.Register<IRepository<StudentExam>, EfCoreRepository<StudentExam>>(studentsExamsRepoBuilder);
        }

        private static AcademyDbContext GetDbConstructor()
        {
            var factory = new AcademyContextFactory();
            return factory.CreateDbContext(null);
        }



        //Borrar si procede !!

        //public Bootstrapper()
        //{

        //}


        //public void Init(IDependencyContainer dp, Func<DbContext> dbContextConst)
        //{
        //    RegisterRepositories(dp, dbContextConst);
        //}

        //void RegisterRepositories(IDependencyContainer dp, Func<DbContext> dbContextConst)
        //{
        //    var studentRepoBuilder = new Func<object[], object>((parameters) =>
        //    {
        //        return new EfCoreRepository<Student>(dbContextConst());
        //    });
        //    //var subjectsRepoBuilder = new Func<object[], object>((parameters) =>
        //    //{
        //    //    return new SubjectsRepository(dbContextConst());
        //    //});

        //    dp.Register<IRepository<Student>, EfCoreRepository<Student>>(studentRepoBuilder);

        //    //dp.Register<IRepository<Subject>, SubjectsRepository>(subjectsRepoBuilder);
        //    //dp.Register<ISubjectsRepository, SubjectsRepository>(subjectsRepoBuilder);
        //}

    }

}

