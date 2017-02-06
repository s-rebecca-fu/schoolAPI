using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APILab.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}