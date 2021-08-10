using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        [Required]
        public string Message { get; set; }
    }
}