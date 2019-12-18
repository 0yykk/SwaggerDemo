using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SwaggerDemo.Context;
using SwaggerDemo.ViewModel;

namespace SwaggerDemo.Controllers
{
    public class UsersController : ApiController
    {
        private readonly TestLoginContext db = new TestLoginContext();
        public List<UserViewModel> GetUserList()
        {
            var udl = db.Usertest.ToList();
            List<UserViewModel> list = new List<UserViewModel>();
            foreach(var u in udl)
            {
                var udt = new UserViewModel()
                {
                    id = u.id,
                    LoginId=u.LoginID,
                    Name = u.Name,
                    Age = u.Age,
                    Pwd = u.Pwd,
                    Sex = u.Sex
                };
            }
            return list;
        }
        public UserViewModel GetUsers(int id)
        {
            var user = db.Usertest.Find(id);
            var ud = new UserViewModel()
            {
                id=user.id,
                LoginId=user.LoginID,
                Name=user.Name,
                Age=user.Age,
                Pwd=user.Pwd,
                Sex=user.Sex
            };
            return ud;
        }
    }
}
