using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SwaggerDemo.Models;
namespace SwaggerDemo.Context
{
    public interface ITestLoginContext
    {
        DbSet<Usertest> Usertest { get; set; }
        DbSet<Dep> Dep { get; set; }

    }
    public class TestLoginContext : DbContext,ITestLoginContext
    {

        public TestLoginContext() : base("name=TestLogin")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TestLoginContext>());
        }
        public virtual DbSet<Usertest> Usertest { get; set; }
        public virtual DbSet<Dep> Dep { get; set; }

    }
}