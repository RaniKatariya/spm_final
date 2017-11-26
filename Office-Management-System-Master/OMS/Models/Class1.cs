using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OMS.Models
{
    public class Class1
    {
        public int id { get; set; }
        public string sname { get; set; }
        public int course { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public int password { get; set; }
    }
    public class Class2
    {
        [Key]
        public int sid { get; set; }
        public string tname { get; set; }
        public int course { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public int password { get; set; }
        [ForeignKey("id")]
        public int id { get; set; }
    }
    public class Class3
    {
        [Key]
        public int cid { get; set; }
        public string cname { get; set; }
        public int course { get; set; }
        public int year { get; set; }
        public string email { get; set; }
        public int password { get; set; }
        [ForeignKey("id")]
        public int id { get; set; }
    }
}
