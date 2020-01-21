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
        
        public Bootstrapper()
        {

        }


        public void Init(IDependencyContainer dp, Func<DbContext> dbContextConst)
        {
            RegisterRepositories(dp, dbContextConst);
        }

        void RegisterRepositories(IDependencyContainer dp, Func<DbContext> dbContextConst)
        {
            var studentRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<Student>(dbContextConst());
            });
            //var subjectsRepoBuilder = new Func<object[], object>((parameters) =>
            //{
            //    return new SubjectsRepository(dbContextConst());
            //});

            dp.Register<IRepository<Student>, EfCoreRepository<Student>>(studentRepoBuilder);

            //dp.Register<IRepository<Subject>, SubjectsRepository>(subjectsRepoBuilder);
            //dp.Register<ISubjectsRepository, SubjectsRepository>(subjectsRepoBuilder);
        }

    }

}

