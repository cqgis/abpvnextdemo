using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using demo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace demo.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits demo.Web.Pages.demoPage
     */
    public abstract class demoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<demoResource> L { get; set; }
    }
}
