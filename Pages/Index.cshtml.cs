//using Microsoft.EntityFrameworkCore;
//using ToDoApp.Entities;
//using Volo.Abp.AuditLogging.EntityFrameworkCore;
//using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
//using Volo.Abp.Data;
//using Volo.Abp.DependencyInjection;
//using Volo.Abp.EntityFrameworkCore;
//using Volo.Abp.FeatureManagement.EntityFrameworkCore;
//using Volo.Abp.Identity;
//using Volo.Abp.Identity.EntityFrameworkCore;
//using Volo.Abp.OpenIddict.EntityFrameworkCore;
//using Volo.Abp.PermissionManagement.EntityFrameworkCore;
//using Volo.Abp.SettingManagement.EntityFrameworkCore;
//using Volo.Abp.TenantManagement;
//using Volo.Abp.TenantManagement.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.AppService;
using ToDoApp.DTOs;
using ToDoApp.IAppService;
using ToDoApp.Web.Pages;

namespace TodoApp.Web.Pages
{

    public class IndexModel : ToDoAppPageModel
    {
        public List<ToDoItemDto> ToDoItems { get; set; }

        private readonly IToDoService _todoappservice;

        public IndexModel(TodoService todoappservice)
        {
            _todoappservice = todoappservice;
        }

        public async Task OnGetasync()
        {
            ToDoItems = await _todoappservice.GetListAsync();
        }
    }

}


//@page
//    @model TodoApp.Web.Pages.IndexModel
//    @section styles {
//    <abp-style src = "/Pages/Index.css" />
//}
//@section scripts
//{
//    <abp-script src="/Pages/Index.js" />
//}
//< div class= "container" >
//    < abp - card >
//        < abp - card - header >
//            < abp - card - title >
//                TODO LIST
//            </ abp - card - title >
//        </ abp - card - header >
//        < abp - card - body >
//            < !--FORM FOR NEW TODO ITEMS -->
//            <form id="NewItemForm" class= "row row-cols-lg-auto g-3 align-items-center" >
//                < div class= "col-12" >
//                    < div class= "input-group" >
//                        < input id = "NewItemText" type = "text" class= "form-control" placeholder = "enter text..." >
//                    </ div >
//                </ div >
//                < div class= "col-12" >
//                  < button type = "submit" class= "btn btn-primary" > Submit </ button >
//                </ div >
//            </ form >
//            < !--TODO ITEMS LIST -->
//            <ul id="TodoList">
//                @foreach (var todoItem in Model.TodoItems)
//                {
//                    < li data - id = "@todoItem.Id" >
//                        < i class= "fa fa-trash-o" ></ i > @todoItem.Text
//                    </ li >
//                }
//            </ ul >
//        </ abp - card - body >
//    </ abp - card >
//</ div >
