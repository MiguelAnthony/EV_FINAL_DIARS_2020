#pragma checksum "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d981f87bc3227e38fe0860e8fc11e947fa8fdc8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota___Index), @"mvc.1.0.view", @"/Views/Nota_/_Index.cshtml")]
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
#line 1 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\_ViewImports.cshtml"
using Ev_Final_DIARS_N00036571_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\_ViewImports.cshtml"
using Ev_Final_DIARS_N00036571_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d981f87bc3227e38fe0860e8fc11e947fa8fdc8f", @"/Views/Nota_/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8282f570c8cf283dd22cc5684bd648989631fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota___Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
  
    Layout = null;
    var nota = (List<Nota>)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
 foreach (var item in nota)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item\">\r\n               <a");
            BeginWriteAttribute("href", " href=\"", 223, "\"", 256, 2);
            WriteAttributeValue("", 230, "/Nota_/Detalle?Id=", 230, 18, true);
#nullable restore
#line 11 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
WriteAttributeValue("", 248, item.Id, 248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 11 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
                                                       Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a>\r                <br />\r                <span>\r                    <strong>Contenido: </strong>\r");
#nullable restore
#line 15 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
                     if (item.Contenido.Length > 50)

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 17 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
                            Write(item.Contenido.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial>\r");
#nullable restore
#line 18 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 21 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
                            Write(item.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>\r");
#nullable restore
#line 22 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n\r\n                <div align=\"right\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 778, "\"", 812, 2);
            WriteAttributeValue("", 785, "/Nota_/Eliminar?id=", 785, 19, true);
#nullable restore
#line 26 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
WriteAttributeValue("", 804, item.Id, 804, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:20px;\" class=\"btn btn-danger float-lg-right\">Eliminar</a>\r\n                    <button id=\"editModal\" style=\"margin-right:20px;\" class=\"btn btn-primary float-lg-right\" href=\"#\" data-toggle=\"modal\" data-target=\"#edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1049, "\"", 1111, 7);
            WriteAttributeValue("", 1059, "selCuenta(", 1059, 10, true);
#nullable restore
#line 27 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
WriteAttributeValue("", 1069, item.Id, 1069, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1077, ",\'", 1077, 2, true);
#nullable restore
#line 27 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
WriteAttributeValue("", 1079, item.Titulo, 1079, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1091, "\',\'", 1091, 3, true);
#nullable restore
#line 27 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
WriteAttributeValue("", 1094, item.Contenido, 1094, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1109, "\')", 1109, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\r\n                </div>\r\n            </li>\r\n        </ul>\r\n        <br />\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Malca Solis Luis\source\repos\Ev_Final_DIARS(N00036571)\Ev_Final_DIARS(N00036571)\Views\Nota_\_Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"" >Guardar</button>
            </div>
        </div>
    </div>
</div>


    <script>
        function selCuenta(id, titulo, contenido) {
            $('#mtxtId').val(id);
            $('#mtxtTitulo').val(titulo);
           ");
            WriteLiteral(@" $('#mtxtContenido').val(contenido);
        };

        $.ajax({
            url: '/Nota_/Edit',
            type: 'get'
        }).done(function (html) {
            $('#editNotita').html(html);
        })

        function submitForm() {
            $('#editNota').submit();
        }

        function editar(event) {
            event.preventDefault();
            var dataString = new FormData($('#edit form')[0]);
            $.ajax({
                url: ""/Nota_/Edit"",
                type: ""post"",
                processData: false,  // Important!
                contentType: false,
                cache: false,
                data: dataString
            }).done(function (html) {
                location.reload();
            }).fail(function (html) {
                $('#editNotita').html(html.responseText);
            });
        }
    </script>");
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