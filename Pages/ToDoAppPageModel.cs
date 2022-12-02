using ToDoApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ToDoApp.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ToDoAppPageModel : AbpPageModel
{
    protected ToDoAppPageModel()
    {
        LocalizationResourceType = typeof(ToDoAppResource);
    }
}
