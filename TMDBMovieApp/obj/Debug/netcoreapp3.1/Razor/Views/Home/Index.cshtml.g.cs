#pragma checksum "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baa1ad1d683b9029e48e852554856f5c059b6858"
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
#line 1 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\_ViewImports.cshtml"
using TMDBMovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\_ViewImports.cshtml"
using TMDBMovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baa1ad1d683b9029e48e852554856f5c059b6858", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c25c61ceaf00d71aff7a55b4fb3196217c4e5fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrendingResults>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n    <div class=\"container\">\n        <div class=\"row\">\n");
#nullable restore
#line 10 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\Home\Index.cshtml"
             for (var i = 0; i < Model.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col\">\n                    <div class=\"card\" style=\"width: 15rem;\">\n                        <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 337, "\"", 396, 2);
            WriteAttributeValue("", 343, "https://image.tmdb.org/t/p/w185/", 343, 32, true);
#nullable restore
#line 14 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 375, Model[i].poster_path, 375, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                        <div class=\"card-body\">\n                            <h5 class=\"card-title text-center\">");
#nullable restore
#line 16 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\Home\Index.cshtml"
                                                          Write(Model[i].title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        </div>\n                    </div>\n\n                </div>\n");
#nullable restore
#line 21 "H:\Visual Studio Projects\2019\TMDBMovieApp\TMDBMovieApp\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrendingResults>> Html { get; private set; }
    }
}
#pragma warning restore 1591