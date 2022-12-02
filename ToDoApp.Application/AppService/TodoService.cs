using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.DTOs;
using ToDoApp.Entities;
using ToDoApp.IAppService;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ToDoApp.AppService
{
    public class TodoService : ApplicationService, IToDoService
    {

        private readonly IRepository<ToDoItem , Guid> _todoItemRepository;

        public TodoService(IRepository<ToDoItem, Guid> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        public async Task<ToDoItemDto> CreateAsync(string text)
        {
            var todoItem = await _todoItemRepository.InsertAsync(
        new ToDoItem { Text = text }
    );

            return new ToDoItemDto
            {
                Id = todoItem.Id,
                Text = todoItem.Text
            };
        }
        public async Task<List<ToDoItemDto>> GetListAsync()
        {
            var items = await _todoItemRepository.GetListAsync();
            return items
                .Select(item => new ToDoItemDto
                {
                    Id = item.Id,
                    Text = item.Text
                }).ToList();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _todoItemRepository.DeleteAsync(id);
        }
    }
}
