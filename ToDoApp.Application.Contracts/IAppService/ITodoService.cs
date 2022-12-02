using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.DTOs;
using Volo.Abp.Application.Services;

namespace ToDoApp.IAppService
{
    public interface IToDoService : IApplicationService
    {
        Task<List<ToDoItemDto>> GetListAsync();
        Task<ToDoItemDto> CreateAsync(string text);
        Task DeleteAsync(Guid id);
    }
}
