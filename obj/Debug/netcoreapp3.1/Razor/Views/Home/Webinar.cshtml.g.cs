#pragma checksum "C:\Users\user\source\repos\test\test\Views\Home\Webinar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ab139e81fd29f60cce730c9803c359707309fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Webinar), @"mvc.1.0.view", @"/Views/Home/Webinar.cshtml")]
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
#line 1 "C:\Users\user\source\repos\test\test\Views\_ViewImports.cshtml"
using test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\test\test\Views\_ViewImports.cshtml"
using test.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ab139e81fd29f60cce730c9803c359707309fc", @"/Views/Home/Webinar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04aae2d41d7a1f2a1b7badf4f453e10febdd2915", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Webinar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user\source\repos\test\test\Views\Home\Webinar.cshtml"
  
    ViewData["Title"] = "Webinaire";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-xl"">
    <div class=""row"" style=""margin-top:134px;"">
        <div class=""col-12 px-0 text-center"">
            <h2 class=""x2-title-cornerStyle x2-title-cornerStyleRed x2-font--Title text-uppercase font-weight-light my-5"">Nos <span class=""font-weight-bold"">actualit??s</span></h2>
        </div>
    </div>
    <div class=""row"">
        <div class=""col text-center"">
            <div>
                Filtrez vos actualit??s :
                <select style=""border-radius:5px;padding:2px;padding-right: 50px;"" class=""border-0 text-white x2-bg-red"" name=""filter"" id=""filter"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70ab139e81fd29f60cce730c9803c359707309fc4131", async() => {
                WriteLiteral("Filtre");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12 my-2"">
            <div class=""x2-bgActuGrey"">
                <div class=""x2-actuBlock h-100"">
                    <img src=""img/actu-wide.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 981, "\"", 987, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid d-xl-block d-none under\">\r\n                    <img src=\"img/actu-blockgrey.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1086, "\"", 1092, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid d-xl-block d-none over"">
                    <div class=""x2-actuContentGrey ml-md-auto text-center text-md-left pt-xl-5 h-100"">
                        <img src=""img/actu-wide.jpg"" class=""x2-customActuContentGrey img-fluid d-block d-xl-none float-md-left mr-4"" />
                        <div class=""p-4 h-100"">
                            <h5>Titre article</h5>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...</p>
                            <a style=""border-color:black !important;"" class=""btn x2-actuMore font-weight-bold font-italic"" href=""actu-single.html"">> Lire la suite</a>

                            <span id=""btnDrop1"" class=""p-2 m-1 x2-actuShare"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-share-alt""></i>
                            </span>
                            <div class=""dropdown-menu text");
            WriteLiteral(@"-left"" id=""btnDroplist1"">
                                <a class=""dropdown-item"">
                                    <i style=""font-size:1.3em;"" class=""x2-color-red fab fa-linkedin""></i> Linkedin
                                </a>
                                <a class=""dropdown-item"">
                                    <i style=""font-size:1.3em;"" class=""x2-color-red fab fa-twitter""></i> Twitter
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-6 my-2"">
            <div class=""x2-bgActu"">
                <div class=""x2-actuBlock h-100"">
                    <img src=""img/shutterstock_751298770.png""");
            BeginWriteAttribute("alt", " alt=\"", 2944, "\"", 2950, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid d-xl-block d-none under\">\r\n                    <img src=\"img/actu-block.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3045, "\"", 3051, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid d-xl-block d-none over\">\r\n                    <div class=\"text-white x2-actuContent ml-md-auto text-center text-xl-left pt-xl-5\">\r\n                        <img src=\"img/shutterstock_751298770.png\"");
            BeginWriteAttribute("alt", " alt=\"", 3266, "\"", 3272, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid d-block d-xl-none"">
                        <div class=""p-4 p-xl-0"">
                            <h5>Titre article</h5>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...</p>
                            <a class=""btn x2-actuMore font-weight-bold font-italic text-white"" href=""actu-single.html"">> Lire la suite</a>

                            <span id=""btnDrop1"" class=""p-2 m-1 x2-actuShare"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-share-alt x2-color-red""></i>
                            </span>
                            <div class=""dropdown-menu text-left"" id=""btnDroplist1"">
                                <a class=""dropdown-item"">
                                    <i style=""font-size:1.3em;"" class=""x2-color-red fab fa-linkedin""></i> Linkedin
                                </a>
                    ");
            WriteLiteral(@"            <a class=""dropdown-item"">
                                    <i style=""font-size:1.3em;"" class=""x2-color-red fab fa-twitter""></i> Twitter
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 my-2"">
            <div class=""x2-bgActu"">
                <div class=""x2-actuBlock h-100"">
                    <img src=""img/shutterstock_751298770.png""");
            BeginWriteAttribute("alt", " alt=\"", 4829, "\"", 4835, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid d-xl-block d-none under\">\r\n                    <img src=\"img/actu-block.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4930, "\"", 4936, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid d-xl-block d-none over\">\r\n                    <div class=\"text-white x2-actuContent ml-md-auto text-center text-xl-left pt-xl-5\">\r\n                        <img src=\"img/shutterstock_751298770.png\"");
            BeginWriteAttribute("alt", " alt=\"", 5151, "\"", 5157, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid d-block d-xl-none"">
                        <div class=""p-4 p-xl-0"">
                            <h5>Titre article</h5>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua...</p>
                            <a class=""btn x2-actuMore font-weight-bold font-italic text-white"" href=""actu-single.html"">> Lire la suite</a>
                            <span id=""btnDrop2"" class=""p-2 m-1 x2-actuShare"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <i class=""fas fa-share-alt x2-color-red""></i>
                            </span>
                            <div class=""dropdown-menu text-left"" id=""btnDroplist2"">
                                <a class=""dropdown-item"">
                                    <i style=""font-size:1.3em;"" class=""x2-color-red fab fa-linkedin""></i> Linkedin
                                </a>
                      ");
            WriteLiteral(@"          <a class=""dropdown-item"">
                                    <i style=""font-size:1.3em;"" class=""x2-color-red fab fa-twitter""></i> Twitter
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col text-center mx-auto my-4"">
            <a class=""btn font-weight-bold x2-border-red x2-color-red x2-borderRadius-0"" href=""#"">Voir plus d'actualit??s <i class=""fas fa-plus""></i></a>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
