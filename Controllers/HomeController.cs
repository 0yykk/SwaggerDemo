using SwaggerDemo.Context;
using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwaggerDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestLoginContext db = new TestLoginContext();
        public ActionResult Index()
        {
            //AddDep();
            //AddUsers();
            ViewBag.Title = "Home Page";
            var u = db.Usertest.ToList();
            var d = db.Dep.ToList();

            return View();
        }
        public void AddUsers()
        {
            for (int i = 0; i < 11; i++)
            {
                var depId = 1;
                if (i < 5) { depId = 1; }
                else { depId = 2; }
                var user = new Usertest()
                {
                    id = i + 1,
                    LoginID = "ver00" + i,
                    Pwd = "mima00" + i,
                    Name = "Veritas" + i,
                    Age = 18,
                    Sex = "man",
                    DepId = depId
                };
                db.Usertest.Add(user);
                db.SaveChanges();
            }
        }

        public void AddDep()
        {
            for (int i = 0; i < 2; i++)
            {
                var dep = new Dep()
                {
                    id = i + 1,
                    Name = "Department" + i,
                    Instroduce = "DepartmentTittle00" + i,
                    DepCode = "BM00" + i
                };
                db.Dep.Add(dep);
                db.SaveChanges();
            }
        }
    }
}
