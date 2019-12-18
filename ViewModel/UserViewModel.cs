using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerDemo.ViewModel
{
    public class UserViewModel
    {
        public int id { get; set; }
        public string LoginId { get; set; }
        public string Pwd { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}