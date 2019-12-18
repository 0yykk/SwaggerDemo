using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SwaggerDemo.Models
{
    [Table("Dep")]
    public class Dep
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string DepCode { get; set; }
        public string Instroduce { get; set; }
        public virtual IList<Usertest> Users { get; set; }
    }
}