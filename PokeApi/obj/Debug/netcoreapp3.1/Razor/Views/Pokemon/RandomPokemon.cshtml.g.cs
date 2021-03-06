#pragma checksum "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b72fe33fd3a8c382c380874b63912322bb83f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_RandomPokemon), @"mvc.1.0.view", @"/Views/Pokemon/RandomPokemon.cshtml")]
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
#line 6 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
using PokeApi.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b72fe33fd3a8c382c380874b63912322bb83f0", @"/Views/Pokemon/RandomPokemon.cshtml")]
    public class Views_Pokemon_RandomPokemon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
  
    Layout = "Layout";
    ViewData["Title"] = "List of Pokemon";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" style=\"text-align: center;\">\r\n    <article class=\"pokemon-container\"");
            BeginWriteAttribute("style", " style=\"", 244, "\"", 319, 8);
            WriteAttributeValue("", 252, "background-color:", 252, 17, true);
#nullable restore
#line 9 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
WriteAttributeValue("", 269, Model.color, 269, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 281, ";border:", 281, 8, true);
            WriteAttributeValue(" ", 289, "1px", 290, 4, true);
            WriteAttributeValue(" ", 293, "solid", 294, 6, true);
            WriteAttributeValue(" ", 299, "gray;", 300, 6, true);
            WriteAttributeValue(" ", 305, "padding:", 306, 9, true);
            WriteAttributeValue(" ", 314, "8px;", 315, 5, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <figure class=\"pokemon-container-image\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 389, "\"", 412, 1);
#nullable restore
#line 11 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
WriteAttributeValue("", 395, Model.sprites[0], 395, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </figure>\r\n        <div class=\"pokemon-container-content\">\r\n            <h3 class=\"pokemon-container-title\">");
#nullable restore
#line 14 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p class=\"pokemon-container-attribute\">Height: ");
#nullable restore
#line 15 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                                      Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"pokemon-container-attribute\">Weight: ");
#nullable restore
#line 16 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                                      Write(Model.weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <div class=\"collapse multi-collapse\"");
            BeginWriteAttribute("id", " id=\"", 756, "\"", 770, 1);
#nullable restore
#line 17 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
WriteAttributeValue("", 761, Model.id, 761, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div>\r\n                    <p class=\"pokemon-container-attribute\">Hp: ");
#nullable restore
#line 19 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                                          Write(Model.hp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"pokemon-container-attribute\">Atk: ");
#nullable restore
#line 20 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                                           Write(Model.attack);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"pokemon-container-attribute\">Def: ");
#nullable restore
#line 21 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                                           Write(Model.defense);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1094, 2);
            WriteAttributeValue("", 1071, "/pokemon/byId/", 1071, 14, true);
#nullable restore
#line 22 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
WriteAttributeValue("", 1085, Model.id, 1085, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"text-align: center;\" class=\"card-link\">More Details</a>\r\n                </div>\r\n            </div>\r\n            <button class=\"btn btn-primary\" type=\"button\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 25 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
                                                                                          Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1331, "\"", 1356, 1);
#nullable restore
#line 25 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
WriteAttributeValue("", 1347, Model.id, 1347, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                details\r\n            </button>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1422, "\"", 1455, 2);
            WriteAttributeValue("", 1429, "/user/addPokemon/", 1429, 17, true);
#nullable restore
#line 28 "C:\Users\jupit\source\repos\PokeApi\PokeApi\Views\Pokemon\RandomPokemon.cshtml"
WriteAttributeValue("", 1446, Model.id, 1446, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-link\" style=\"text-align: center;\">Add to Collection</a>\r\n        </div>\r\n    </article>\r\n    <a href=\"/Pokemon/RandomPokemon\">Continue</a>\r\n</div>");
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
