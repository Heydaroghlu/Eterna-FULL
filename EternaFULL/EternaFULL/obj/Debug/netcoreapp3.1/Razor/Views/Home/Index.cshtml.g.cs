#pragma checksum "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0538622210ee5146a0cb97a57edb5fd5aeb06f57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\_ViewImports.cshtml"
using EternaFULL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\_ViewImports.cshtml"
using EternaFULL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0538622210ee5146a0cb97a57edb5fd5aeb06f57", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bed8286677af5ef34838fda936702468edbb0f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <main>\r\n        <section>\r\n            <div class=\"main-first\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <p><a");
            BeginWriteAttribute("href", " href=\"", 201, "\"", 208, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: #e96b56;\" id=\"a1\">Home</a>/ <a");
            BeginWriteAttribute("href", " href=\"", 254, "\"", 261, 0);
            EndWriteAttribute();
            WriteLiteral(@">Services</a></p>
                    </div>
                    <div class=""row"">
                        <h3>Services</h3>
                    </div>
                </div>
            </div>
        </section>
        <section>
            <div class=""services"">
                <div class=""container"">
                    <div class=""row"">
");
#nullable restore
#line 19 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\Home\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-xl-4  col-lg-6  col-md-6 col-sm-12 col-12"">
                                <div class=""card"" style=""width: 22rem; height: 20rem;"">

                                    <div class=""card-body"">
                                        <div class=""card-icon"">
                                            ");
#nullable restore
#line 26 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\Home\Index.cshtml"
                                       Write(Html.Raw(item.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <h3 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\Home\Index.cshtml"
                                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                        <p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\Home\Index.cshtml"
                                                        Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 34 "C:\Users\tu201906065\Desktop\EternaFULL\EternaFULL\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </section>
        <section>
            <div class=""skills"">
                <div class=""container"">
                    <div class=""row"">
                        <h3>Our Skills</h3>

                        <p id=""p1"">Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
                    </div>
                    <div class=""row"">
                        <div class=""col-6"">
                            <img src=""https://bootstrapmade.com/demo/templates/Eterna/assets/img/skills-img.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2216, "\"", 2222, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""col-6"">
                            <h2>Voluptatem dignissimos provident quasi corporis voluptates</h2>
                            <i>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda</i>

                            <div class=""progress"">

                                <div class=""progress-bar w-50"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar w-75"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                            <div class=""progress"">
                                <div class=""progress-bar w-75"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </");
            WriteLiteral(@"div>
                            <div class=""progress"">
                                <div class=""progress-bar w-75"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>
   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591
