using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SwaggerDemo.Models
{
    [Table("Usertest")]
    public class Usertest
    {
        [Key]
        public int id { get; set; }

        [StringLength(20,ErrorMessage="Login Id too Long")]
        [Column("LoginID",TypeName="nvarchar")]
        [Display(Name ="LoginID")]
        public string LoginID { get; set; }

        public string Pwd { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get;set; }
        [ForeignKey("Dep")]
        public int DepId { get; set; }
        public virtual Dep Dep { get; set; }

    }
}