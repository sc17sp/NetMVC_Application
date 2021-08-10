using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TodoController : Controller
    {
        static IList<Todo> todoList = new List<Todo>
        {
            new Todo() { TodoId = 1, Message = "Go do some shopping"},
            new Todo() { TodoId = 2, Message = "Call mum"},
            new Todo() { TodoId = 3, Message = "Learn some SQL"},
            new Todo() { TodoId = 4, Message = "Learn to fly"}
        };
        // GET: Todo
        public ActionResult Index()
        {

            return View(todoList);
        }

        [HttpPost]
        public ActionResult Index(Todo todo) {
            todo.TodoId = 6;
            todoList.Add(todo);
            return RedirectToAction("Index");
        }
    }
}