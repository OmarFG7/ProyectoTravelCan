#pragma checksum "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd87869d85b66b9911d4f38360e6d16392b3fe7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\_ViewImports.cshtml"
using ProyectoTravelCan;

#line default
#line hidden
#line 2 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\_ViewImports.cshtml"
using ProyectoTravelCan.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd87869d85b66b9911d4f38360e6d16392b3fe7e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85aad397460caa4f636b3163b46d88dfba1ccb20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Viaje>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 10; width: 10;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReservarViaje", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#line 5 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
 if (TempData["mensaje"] != null) {

#line default
#line hidden
            BeginContext(102, 47, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            EndContext();
            BeginContext(150, 19, false);
#line 7 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
   Write(TempData["mensaje"]);

#line default
#line hidden
            EndContext();
            BeginContext(169, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 9 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(186, 3418, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Bienvenido</h1>
</div>

<div class=""bd-example"">        
    <div id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
      <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleCaptions"" data-slide-to=""0"" class=""active""></li>
        <li data-target=""#carouselExampleCaptions"" data-slide-to=""1""></li>
        <li data-target=""#carouselExampleCaptions"" data-slide-to=""2""></li>
        <li data-target=""#carouselExampleCaptions"" data-slide-to=""3""></li>
      </ol>
      <div class=""carousel-inner"">
        <div class=""carousel-item active"">
          <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR8VMwOw379e3AtFfqhUerOiniE6xi4LVO2X0VCfLk91nH7ogVL"" height=""800"" class=""d-block w-100"" alt=""..."">
          <div class=""carousel-caption d-none d-md-block"">
            <h5>Viaje con nosotros</h5>
            <p>Estas personas disfrutaron de la caminata hacia la catarata velo de novia junto a");
            WriteLiteral(@" sus amigos peludos</p>
          </div>
        </div>
        <div class=""carousel-item"">
          <img src=""https://scontent.flim5-2.fna.fbcdn.net/v/t1.0-9/74231809_941215849568916_1782902248112652288_o.jpg?_nc_cat=101&_nc_oc=AQk4NyrBmckgC8Xs94b6UyeTtgJZZ76Kt5KOIPp6gk0lzZmfZuRzNj_C7Ox3WMuKFWo&_nc_ht=scontent.flim5-2.fna&oh=f66b3a806fc3aa4a620d553cb6069156&oe=5E59CDB6"" class=""d-block w-100"" alt=""..."">
          <div class=""carousel-caption d-none d-md-block"">
            <h5>No te arrepentirás</h5>
            <p style=""color: black;""> <strong>Juan y Marcela disfrutaron junto a Firu</strong></p>
          </div>
        </div>
        <div class=""carousel-item"">
          <img src=""https://scontent.flim5-4.fna.fbcdn.net/v/t1.0-9/74237753_936774143346420_6098672067886972928_o.jpg?_nc_cat=102&_nc_oc=AQl_D-_jQfTTVvkr5qFAj1dEPBrUjQL3pLzgwmWV1E5yRO6CRr42qVyWamcwXr5bdYg&_nc_ht=scontent.flim5-4.fna&oh=7953a6a336c7fcb10bada6052819a278&oe=5E17F753"" class=""d-block w-100"" alt=""..."">
          <div class=""");
            WriteLiteral(@"carousel-caption d-none d-md-block"">
            <h5>Una Imagen dice mas que mil palabras</h5>
            <p>Dale el bienestar que se merecen</p>
          </div>
        </div>

      
      <div class=""carousel-item"">
        <img src=""https://scontent.flim5-2.fna.fbcdn.net/v/t1.0-9/73145175_930301947326973_9037588175584755712_o.jpg?_nc_cat=100&_nc_oc=AQlWB9LOxFSOvs-7a6vTKYFeWaKK6Y1zq5Y2foDSuw-CB5Pix5TlXaRtt_22odOD2Qw&_nc_ht=scontent.flim5-2.fna&oh=118a1d6ae8e36845d80d85e14383947f&oe=5E5F83EF"" class=""d-block w-100"" alt=""..."">
        <div class=""carousel-caption d-none d-md-block"">
          <h5>Una Imagen dice mas que mil palabras</h5>
          <p>Dale el bienestar que se merecen</p>
        </div>
      </div>
      
    </div>
      <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
      </a>
      <a class=""carouse");
            WriteLiteral(@"l-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
      </a>
    </div>
  </div>
<h1><span class=""badge badge-pill badge-info"">Proximos Viajes (Modo Verano)</span></h1>

<div class=""row"">
");
            EndContext();
#line 69 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
   foreach (var v in Model)
      {

#line default
#line hidden
            BeginContext(3642, 119, true);
            WriteLiteral("          <div class=\"col-6\">\r\n            <div class=\"card\" style=\"width: 30rem;\">\r\n              \r\n              <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3761, "\"", 3774, 1);
#line 74 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
WriteAttributeValue("", 3767, v.Foto, 3767, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3775, 112, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n              <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(3888, 13, false);
#line 76 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
                                  Write(v.Descripcion);

#line default
#line hidden
            EndContext();
            BeginContext(3901, 26, true);
            WriteLiteral("   </h5>\r\n                ");
            EndContext();
            BeginContext(3927, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd87869d85b66b9911d4f38360e6d16392b3fe7e10685", async() => {
                BeginContext(4034, 11, true);
                WriteLiteral("Más Detalle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
                                              WriteLiteral(v.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4049, 49, true);
            WriteLiteral("\r\n                <p class=\"card-text\">Precio:S/.");
            EndContext();
            BeginContext(4099, 7, false);
#line 78 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
                                          Write(v.Costo);

#line default
#line hidden
            EndContext();
            BeginContext(4106, 148, true);
            WriteLiteral(" por persona</p>\r\n              </div>\r\n              <ul class=\"list-group list-group-flush\">\r\n                <li class=\"list-group-item\">Salida: ");
            EndContext();
            BeginContext(4255, 15, false);
#line 81 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
                                               Write(v.nombrePartida);

#line default
#line hidden
            EndContext();
            BeginContext(4270, 60, true);
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Destino: ");
            EndContext();
            BeginContext(4331, 15, false);
#line 82 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
                                                Write(v.nombreDestino);

#line default
#line hidden
            EndContext();
            BeginContext(4346, 58, true);
            WriteLiteral("</li>\r\n                <li class=\"list-group-item\">Fecha: ");
            EndContext();
            BeginContext(4405, 7, false);
#line 83 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
                                              Write(v.Fecha);

#line default
#line hidden
            EndContext();
            BeginContext(4412, 83, true);
            WriteLiteral("</li>\r\n              </ul>\r\n              <div class=\"card-body\">\r\n                ");
            EndContext();
            BeginContext(4495, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd87869d85b66b9911d4f38360e6d16392b3fe7e15232", async() => {
                BeginContext(4552, 5, true);
                WriteLiteral("Somos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4561, 78, true);
            WriteLiteral("\r\n              </div>\r\n              \r\n            </div>\r\n          </div>\r\n");
            EndContext();
#line 91 "C:\Users\Luis\Downloads\ProyectoTravelCan_revisado\ProyectoTravelCan\ProyectoTravelCan\Views\Home\Index.cshtml"
  }

#line default
#line hidden
            BeginContext(4644, 14, true);
            WriteLiteral("  </div>\r\n  \r\n");
            EndContext();
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
