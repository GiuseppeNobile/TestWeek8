#pragma checksum "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "403a4eb9825091c292bcc24d43e83222c7a9ef25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Piatti_Index), @"mvc.1.0.view", @"/Views/Piatti/Index.cshtml")]
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
#line 1 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\_ViewImports.cshtml"
using TestWeek8.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\_ViewImports.cshtml"
using TestWeek8.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"403a4eb9825091c292bcc24d43e83222c7a9ef25", @"/Views/Piatti/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42fb736b7263884830ba392c9bb6774c5faf92c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Piatti_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PiattoViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Descrizione</th>
            <th scope=""col"">Tipologia</th>
            <th scope=""col"">Prezzo</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
               Write(item.IdPiatto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
               Write(item.Descrizione);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
               Write(item.Tipologia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
               Write(item.Prezzo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\g.nobile\source\repos\TestWeek8\TestWeek8.MVC\Views\Piatti\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PiattoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
