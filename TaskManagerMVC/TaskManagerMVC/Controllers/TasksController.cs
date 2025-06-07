using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TaskManagerMVC.DTOs;
using TaskManagerMVC.Enums;
using TaskManagerMVC.Interfaces;

namespace TaskManagerMVC.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _service;

        public TasksController(ITaskService taskService)
        {
            this._service = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tasks = await _service.GetTasks();
            return View(tasks);
        }

        [HttpGet("/Tasks/Create")]
        public IActionResult Create()
        {
            var prioridades = Enum.GetValues(typeof(Prioridade))
                                            .Cast<Prioridade>()
                                            ;
            ViewBag.Prioridades = prioridades;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(TaskCreateDTO task)
        {
            try
            {
                if (!ModelState.IsValid)
                { 
                    return View(task);
                }


                await _service.Create(task);
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet("/Tasks/{ID}")]
        public IActionResult Update(int ID)
        {
            ViewData["ID"] = ID;
            return View();
        }
    }
}
