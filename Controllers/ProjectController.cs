using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MacAppMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MacAppMVC.Controllers
{
    public class ProjectController : Controller
    {
        [HttpGet]
        [Route("api/persons")]
        public List<Project> Get()
        {
            TaskManagerDBContext taskManagerDBContext = new TaskManagerDBContext();
            List<Project> Persons = taskManagerDBContext.Project.ToList();
            return Persons;
        }
    }
}