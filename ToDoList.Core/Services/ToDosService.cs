using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Interfaces;
using ToDoList.Data.Data;
using ToDoList.Models.Models;

namespace ToDoList.Services
{
    public class ToDosService : IToDosService
    {
        private readonly AppDbContext _context;
        public ToDosService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ToDo>> GetAllAsync()
        {
            return await _context.ToDos.ToListAsync();
        }

        public Task<ToDo> GetItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
