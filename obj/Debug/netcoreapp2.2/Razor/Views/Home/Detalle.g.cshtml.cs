#pragma checksum "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23c249a94a385d961a88cc7e92b25a44aa88685e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detalle), @"mvc.1.0.view", @"/Views/Home/Detalle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detalle.cshtml", typeof(AspNetCore.Views_Home_Detalle))]
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
#line 1 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\_ViewImports.cshtml"
using ProyectoTravelCan;

#line default
#line hidden
#line 2 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\_ViewImports.cshtml"
using ProyectoTravelCan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c249a94a385d961a88cc7e92b25a44aa88685e", @"/Views/Home/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85aad397460caa4f636b3163b46d88dfba1ccb20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Viaje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReservarViaje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 175, true);
            WriteLiteral("<style>\r\n    body{\r\n      background-image: url(https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5Do3FbKWYX2XO7PyLZmYPCoHGGb7D4z9OOpv0mSwgJmyhnSVw);\r\n    }\r\n</style>\r\n");
            EndContext();
#line 7 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
 foreach(var v in Model){

#line default
#line hidden
            BeginContext(222, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 230, "\"", 243, 1);
#line 8 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
WriteAttributeValue("", 236, v.Foto, 236, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 96, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n      <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(341, 21, false);
#line 10 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
                          Write(v.DescripcionCompleta);

#line default
#line hidden
            EndContext();
            BeginContext(362, 47, true);
            WriteLiteral(" </h5>\r\n        <p class=\"card-text\">Precio:S/.");
            EndContext();
            BeginContext(410, 7, false);
#line 11 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
                                  Write(v.Costo);

#line default
#line hidden
            EndContext();
            BeginContext(417, 124, true);
            WriteLiteral(" por persona</p>\r\n      </div>\r\n      <ul class=\"list-group list-group-flush\">\r\n        <li class=\"list-group-item\">Salida: ");
            EndContext();
            BeginContext(542, 15, false);
#line 14 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
                                       Write(v.nombrePartida);

#line default
#line hidden
            EndContext();
            BeginContext(557, 52, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Destino: ");
            EndContext();
            BeginContext(610, 15, false);
#line 15 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
                                        Write(v.nombreDestino);

#line default
#line hidden
            EndContext();
            BeginContext(625, 50, true);
            WriteLiteral("</li>\r\n        <li class=\"list-group-item\">Fecha: ");
            EndContext();
            BeginContext(676, 7, false);
#line 16 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
                                      Write(v.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(683, 59, true);
            WriteLiteral("</li>\r\n      </ul>\r\n      <div class=\"card-body\">\r\n        ");
            EndContext();
            BeginContext(742, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23c249a94a385d961a88cc7e92b25a44aa88685e7181", async() => {
                BeginContext(799, 5, true);
                WriteLiteral("Somos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(808, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 21 "C:\Users\Luis\Documents\Multiplataforma\.Net\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Detalle.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Viaje>> Html { get; private set; }
    }
}
#pragma warning restore 1591
