#pragma checksum "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "647d8e39ab22ab486def2edf2b04cc4e294dd9b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Show), @"mvc.1.0.view", @"/Views/Employee/Show.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647d8e39ab22ab486def2edf2b04cc4e294dd9b9", @"/Views/Employee/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"babb7c25cd151e82f5358ea0afc2133fa57ebf1c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MeterReadingProject.Models.MetersReadingData>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Dashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
  
    //ViewData["Title"] = "Show";
    ViewBag.Title = "Show";
    var displayedMeterNames = new List<int>();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "647d8e39ab22ab486def2edf2b04cc4e294dd9b95318", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "647d8e39ab22ab486def2edf2b04cc4e294dd9b96432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            <a href=""https://localhost:44355/Employee/ListMeterReadings"">
                <i class='bx bx-pie-chart-alt-2'></i>
                <span class=""link_names"">List Meter Readings</span>
            </a>
            <span class=""tooltip"">Report</span>
        </li>

    </ul>
    <div class=""profile_content"">
        <div class=""profile"">
            <div class=""profile_details"">

                <div class=""name_job"">
                    <div class=""name"">");
#nullable restore
#line 128 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                                 Write(Context.Session.GetString("Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"job\">");
#nullable restore
#line 129 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                                Write(Context.Session.GetString("RoleName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "647d8e39ab22ab486def2edf2b04cc4e294dd9b910272", async() => {
                WriteLiteral(" <i class=\'bx bx-log-out\' id=\"log_out\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"home_content\">\r\n    <div class=\"text\">\r\n        \r\n        <div>\r\n\r\n");
#nullable restore
#line 141 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
 foreach (var item in ViewBag.Model)
{
    if (!displayedMeterNames.Contains(item.MeterName))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group pull-right\">\r\n");
#nullable restore
#line 146 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
             using (Html.BeginForm("Export", "Employee", new { id = item.MeterName }, FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" value=\"Export\" class=\"btn btn-sucess\" />\r\n");
#nullable restore
#line 149 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 151 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
        displayedMeterNames.Add(item.MeterName);
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!--Table-->\r\n            <table class=\"table table-striped w-auto\">\r\n\r\n                <!--Table head-->\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
#nullable restore
#line 160 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                       Write(Html.DisplayNameFor(model => model.date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th> ");
#nullable restore
#line 161 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                        Write(Html.DisplayNameFor(model => model.MeterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th> ");
#nullable restore
#line 162 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                        Write(Html.DisplayNameFor(model => model.MeterReading));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th> ");
#nullable restore
#line 163 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                        Write(Html.DisplayNameFor(model => model.BranchName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 164 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                       Write(Html.DisplayNameFor(model => model.units));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>Price</th>\r\n\r\n                    </tr>\r\n                </thead>\r\n                <!--Table head-->\r\n                <!--Table body-->\r\n                <tbody>\r\n\r\n");
#nullable restore
#line 173 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                     foreach (var item in ViewBag.Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"table-info\">\r\n\r\n                            <td> ");
#nullable restore
#line 177 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                            Write(item.date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td> ");
#nullable restore
#line 178 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                            Write(item.MeterName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 179 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                            Write(item.MeterReading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td> ");
#nullable restore
#line 180 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                            Write(item.BranchName1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 182 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                           Write(item.units);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                               Rs ");
#nullable restore
#line 185 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                              Write(@item.units * 5);

#line default
#line hidden
#nullable disable
            WriteLiteral("/-\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 188 "C:\Users\Admin\Desktop\MeterReading\MeterReadingProject\MeterReadingProject\Views\Employee\Show.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     
                </tbody>
                <!--Table body-->


            </table>
            <!--Table-->
            
        </div>
         
    </div>


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
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MeterReadingProject.Models.MetersReadingData>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
