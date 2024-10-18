using Microsoft.AspNetCore.Mvc;
using ToDoList.Core.Interfaces;

namespace ToDoList.Controllers
{
    [Route("[controller]/[action]")]
    public class ToDosController : Controller
    {
        private readonly IToDosService _todoItemService;
        public ToDosController(IToDosService toDoService)
        {
            _todoItemService = toDoService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _todoItemService.GetAllAsync());
        }
    }
}
