#pragma checksum "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2364983026691038ace93ecf1a31e51dd0579b08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ScopeListItem), @"mvc.1.0.view", @"/Views/Shared/_ScopeListItem.cshtml")]
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
#line 1 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2364983026691038ace93ecf1a31e51dd0579b08", @"/Views/Shared/_ScopeListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"006d45f54c892aa41ae6f574ad35634ca97cf035", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ScopeListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ScopeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<li class=\"list-group-item\">\n    <label>\n        <input class=\"consent-scopecheck\"\n               type=\"checkbox\"\n               name=\"ScopesConsented\"");
            BeginWriteAttribute("id", "\n               id=\"", 174, "\"", 213, 2);
            WriteAttributeValue("", 194, "scopes_", 194, 7, true);
#nullable restore
#line 8 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 201, Model.Value, 201, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", "\n               value=\"", 214, "\"", 249, 1);
#nullable restore
#line 9 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 237, Model.Value, 237, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", "\n               checked=\"", 250, "\"", 289, 1);
#nullable restore
#line 10 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 275, Model.Checked, 275, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("disabled", "\n               disabled=\"", 290, "\"", 331, 1);
#nullable restore
#line 11 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 316, Model.Required, 316, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 12 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Required)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"hidden\"\n                   name=\"ScopesConsented\"");
            BeginWriteAttribute("value", "\n                   value=\"", 449, "\"", 488, 1);
#nullable restore
#line 16 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 476, Model.Value, 476, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n");
#nullable restore
#line 17 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <strong>");
#nullable restore
#line 18 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
           Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 19 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
         if (Model.Emphasize)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"glyphicon glyphicon-exclamation-sign\"></span>\n");
#nullable restore
#line 22 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </label>\n");
#nullable restore
#line 24 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Required)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span><em>(required)</em></span>\n");
#nullable restore
#line 27 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
     if (Model.Description != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"consent-description\">\n            <label");
            BeginWriteAttribute("for", " for=\"", 861, "\"", 886, 2);
            WriteAttributeValue("", 867, "scopes_", 867, 7, true);
#nullable restore
#line 31 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
WriteAttributeValue("", 874, Model.Value, 874, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 33 "D:\source\repos\GalaxyMedico\GalaxyMedico.Services.Identity\Views\Shared\_ScopeListItem.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ScopeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
