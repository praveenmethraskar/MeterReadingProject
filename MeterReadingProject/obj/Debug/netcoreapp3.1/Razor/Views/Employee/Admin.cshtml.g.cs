#pragma checksum "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdb2e0b07d97abb4f61ac5d21bc1c2d7c4c2d11c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Admin), @"mvc.1.0.view", @"/Views/Employee/Admin.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\_ViewImports.cshtml"
using MeterReadingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\_ViewImports.cshtml"
using MeterReadingProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Admin.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdb2e0b07d97abb4f61ac5d21bc1c2d7c4c2d11c", @"/Views/Employee/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babb7c25cd151e82f5358ea0afc2133fa57ebf1c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bdb2e0b07d97abb4f61ac5d21bc1c2d7c4c2d11c4851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<link href='https://unpkg.com/boxicons@2.1.1/css/boxicons.min.css' rel='stylesheet'>

<div class=""sidebar active"">
    <div class=""logo_content"">
        <div class=""logo"">
            <i class='bx bxl-c-plus-plus' style=""font-size: 30px;""></i>
            <div class=""logoname"" style=""margin-left: 5px;"">Meter Reading</div>
        </div>
        <i class='bx bx-menu-alt-right' id=""btn"" style=""font-size: 25px;""></i>
    </div>
    <ul class=""nav_list"">
        <li>

            <i class='bx bx-search'></i>
            <input type=""text"" placeholder=""Search..."">
            <span class=""tooltip"">Search</span>
        </li>
        <li>
            <a href=""#"">
                <i class='bx bx-grid-alt'></i>
                <span class=""link_names"">Dashboard</span>
            </a>
            <span class=""tooltip"">Dashboard</span>
        </li>
        <li>
            <a href=""https://localhost:44355/Employee/AddMeters"">
                <i class='bx bx-user'></i>
                <sp");
            WriteLiteral(@"an class=""link_names"">Add Meters</span>
            </a>
            <span class=""tooltip"">Add Meters</span>
        </li>
        <li>
            <a href=""https://localhost:44355/Employee/meters"">
                <i class='bx bx-chat'></i>
                <span class=""link_names"">Add Meter Readings</span>
            </a>
            <span class=""tooltip"">Add Meter Readings</span>
        </li>
        <li>
            <a href=""https://localhost:44355/Employee/ListMeterReading"">
                <i class='bx bx-pie-chart-alt-2'></i>
                <span class=""link_names"">List Meter Readings</span>
            </a>
            <span class=""tooltip"">Report</span>
        </li>
");
            WriteLiteral("    </ul>\r\n    <div class=\"profile_content\">\r\n        <div class=\"profile\">\r\n            <div class=\"profile_details\">\r\n\r\n                <div class=\"name_job\">\r\n                    <div class=\"name\">");
#nullable restore
#line 87 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Admin.cshtml"
                                 Write(Context.Session.GetString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"job\">");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Admin.cshtml"
                                Write(Context.Session.GetString("RoleName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdb2e0b07d97abb4f61ac5d21bc1c2d7c4c2d11c8731", async() => {
                WriteLiteral(" <i class=\'bx bx-log-out\' id=\"log_out\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""home_content"">
    <div class=""text"">Home Content Here...</div>
</div>
<script>
    let btn = document.querySelector(""#btn"");
    let sidebar = document.querySelector("".sidebar"");
    let searchBtn = document.querySelector("".bx-search"")

    btn.onclick = function () {
        sidebar.classList.toggle(""active"");
    }
    searchBtn.onclick = function () {
        sidebar.classList.toggle(""active"");
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
