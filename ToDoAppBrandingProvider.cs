using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ToDoApp.Web;

[Dependency(ReplaceServices = true)]
public class ToDoAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ToDoApp";
}
