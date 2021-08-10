using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainingMVCApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public string Password { get; set; }
    }
}