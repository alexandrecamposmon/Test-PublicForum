#pragma checksum "C:\Users\alexa\Downloads\PublicForum\PublicForum\PublicForum\Pages\Account\SignedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8efe6ab4e235ea9300e7d5fa997188d8b9be17ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicForum.Pages.Account.Pages_Account_SignedOut), @"mvc.1.0.razor-page", @"/Pages/Account/SignedOut.cshtml")]
namespace PublicForum.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\alexa\Downloads\PublicForum\PublicForum\PublicForum\Pages\_ViewImports.cshtml"
using PublicForum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\alexa\Downloads\PublicForum\PublicForum\PublicForum\Pages\Account\_ViewImports.cshtml"
using PublicForum.Pages.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8efe6ab4e235ea9300e7d5fa997188d8b9be17ba", @"/Pages/Account/SignedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47a589ca42d5de266b91bbd84d4108270a283b78", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242571dd4063f7a815557ea49e46b15fdf86b21d", @"/Pages/Account/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Account_SignedOut : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\alexa\Downloads\PublicForum\PublicForum\PublicForum\Pages\Account\SignedOut.cshtml"
   ViewData["Title"] = "Signed out"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "C:\Users\alexa\Downloads\PublicForum\PublicForum\PublicForum\Pages\Account\SignedOut.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>\r\n    You have successfully signed out.\r\n</p>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PublicForum.Pages.Account.SignedOutModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PublicForum.Pages.Account.SignedOutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PublicForum.Pages.Account.SignedOutModel>)PageContext?.ViewData;
        public PublicForum.Pages.Account.SignedOutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
