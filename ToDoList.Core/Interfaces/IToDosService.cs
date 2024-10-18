using ToDoList.Models.Models;

namespace ToDoList.Core.Interfaces
{
    public interface IToDosService
    {
        Task<IEnumerable<ToDo>> GetAllAsync();
        Task<ToDo> GetItemByIdAsync(int id);
        //Task<bool> DeleteTodoAsync(Guid id, ApplicationUser currentUser);
    }
}
