#pragma checksum "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d26e72745b9d8cf00adfe5f13c3c716f4340452a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26e72745b9d8cf00adfe5f13c3c716f4340452a", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/join"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/leave"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header>\n    <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\n        <div class=\"container\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d26e72745b9d8cf00adfe5f13c3c716f4340452a6363", async() => {
                WriteLiteral("ActivityCenter");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse""
                aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse collapse d-sm-inline-flex "">
                <ul class=""navbar-nav flex-grow-1 flex-sm-row-reverse"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d26e72745b9d8cf00adfe5f13c3c716f4340452a8521", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </li>\n                    <li class=\"me-3 nav-item\">\n                        <h4>Welcome, ");
#nullable restore
#line 16 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                                Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h4>\n                    </li>\n                </ul>\n            </div>\n        </div>\n    </nav>\n</header>\n<div>\n    <h1>Dojo Activity Center</h1>\n</div>\n<h1>");
#nullable restore
#line 26 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
Write(ViewBag.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<table class=\"table table-striped\">\n    <tr>\n        <th>Activity</th>\n        <th>Date and Time</th>\n        <th>Duration</th>\n        <th>Event Coordinator</th>\n        <th>No. of Participants</th>\n        <th>Actions</th>\n    </tr>\n");
#nullable restore
#line 36 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
      
        foreach (Shindig s in ViewBag.allShindigs)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1507, "\"", 1538, 2);
            WriteAttributeValue("", 1514, "/oneShindig/", 1514, 12, true);
#nullable restore
#line 40 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1526, s.shindigId, 1526, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 40 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                                                  Write(s.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                <td>");
#nullable restore
#line 41 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
               Write(s.date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 41 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                                              Write(s.startTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 42 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
               Write(s.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 43 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
               Write(s.UserRef.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 44 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
               Write(s.connections.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 45 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                  
                    // checks for ownership
                    if (s.userId == Model.userId)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1965, "\"", 1992, 2);
            WriteAttributeValue("", 1972, "/delete/", 1972, 8, true);
#nullable restore
#line 50 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1980, s.shindigId, 1980, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Delete</a>\n                        </td>\n");
#nullable restore
#line 52 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"

                    }
                    else
                    {
                        if (s.connections.Count > 0)
                        {
                            User_Shindig us = s.connections.Find(c => c.userId == Model.userId);
                            if (us == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d26e72745b9d8cf00adfe5f13c3c716f4340452a14675", async() => {
                WriteLiteral("\n                                        <input type=\"submit\" value=\"Join\" class=\"btn btn-primary\">\n                                        <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("Value", " Value=\"", 2661, "\"", 2682, 1);
#nullable restore
#line 64 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2669, Model.userId, 2669, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                        <input type=\"hidden\" name=\"shindigId\"");
                BeginWriteAttribute("Value", " Value=\"", 2762, "\"", 2782, 1);
#nullable restore
#line 65 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2770, s.shindigId, 2770, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n");
#nullable restore
#line 68 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d26e72745b9d8cf00adfe5f13c3c716f4340452a17606", async() => {
                WriteLiteral("\n                                        <input type=\"submit\" value=\"Leave\" class=\"btn btn-primary\">\n                                        <input type=\"hidden\" name=\"user_ShindigId\"");
                BeginWriteAttribute("Value", " Value=\"", 3252, "\"", 3278, 1);
#nullable restore
#line 74 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3260, us.user_ShindigId, 3260, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n");
#nullable restore
#line 77 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d26e72745b9d8cf00adfe5f13c3c716f4340452a20108", async() => {
                WriteLiteral("\n                                    <input type=\"submit\" value=\"Join\" class=\"btn btn-primary\">\n                                    <input type=\"hidden\" name=\"userId\"");
                BeginWriteAttribute("Value", " Value=\"", 3740, "\"", 3761, 1);
#nullable restore
#line 84 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3748, Model.userId, 3748, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                    <input type=\"hidden\" name=\"shindigId\"");
                BeginWriteAttribute("Value", " Value=\"", 3837, "\"", 3857, 1);
#nullable restore
#line 85 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 3845, s.shindigId, 3845, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </td>\n");
#nullable restore
#line 88 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
                        }
                    }


                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 94 "/Users/clarissavinciguerra/CSharpFeb22/ActivityCenter/Views/Home/Dashboard.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n<div class=\"d-flex justify-content-end\">\n    <a href=\"form\" class=\"btn btn-primary\">Add New Activity</a>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
