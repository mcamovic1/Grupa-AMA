#pragma checksum "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd64398d6b0a0ad009a384a5d3d4a612b15dffd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvod_Search), @"mvc.1.0.view", @"/Views/Proizvod/Search.cshtml")]
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
#line 1 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\_ViewImports.cshtml"
using AMA_cosmetics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\_ViewImports.cshtml"
using AMA_cosmetics.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd64398d6b0a0ad009a384a5d3d4a612b15dffd7", @"/Views/Proizvod/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73845ac7fdfd5c0c7d52bc26244ac22bf3b5adaf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Proizvod_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Proizvod>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n\r\n    h2 {\r\n      color: #F8BBD0; /* Bledo roze boja */\r\n    }\r\n  </style>\r\n\r\n<h2>Rezultati pretrage</h2>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
 if (Model.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
     foreach (var Proizvod in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"product\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 261, "\"", 302, 1);
#nullable restore
#line 17 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
WriteAttributeValue("", 267, Url.Content(Proizvod.SlikaPutanja), 267, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 303, "\"", 324, 1);
#nullable restore
#line 17 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
WriteAttributeValue("", 309, Proizvod.Naziv, 309, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 200px; height: 150px;\" />\r\n            <h3>");
#nullable restore
#line 18 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
           Write(Proizvod.Naziv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 19 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
          Write(Proizvod.Opis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 20 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
          Write(Proizvod.Cijena);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Nema rezultata za prikaz.</p>\r\n");
#nullable restore
#line 27 "C:\Users\melid\source\repos\AMA_cosmetics\AMA_cosmetics\Views\Proizvod\Search.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Proizvod>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591