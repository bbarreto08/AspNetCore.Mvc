#pragma checksum "D:\GitPessoal\AspNetCore.Mvc\src\AspNetCoreIdentity\Views\Home\SecretClaimGravar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4d9713bd859a299a2c8d5e36e9f272a778291f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SecretClaimGravar), @"mvc.1.0.view", @"/Views/Home/SecretClaimGravar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SecretClaimGravar.cshtml", typeof(AspNetCore.Views_Home_SecretClaimGravar))]
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
#line 1 "D:\GitPessoal\AspNetCore.Mvc\src\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity;

#line default
#line hidden
#line 2 "D:\GitPessoal\AspNetCore.Mvc\src\AspNetCoreIdentity\Views\_ViewImports.cshtml"
using AspNetCoreIdentity.Models;

#line default
#line hidden
#line 1 "D:\GitPessoal\AspNetCore.Mvc\src\AspNetCoreIdentity\Views\Home\SecretClaimGravar.cshtml"
using AspNetCoreIdentity.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4d9713bd859a299a2c8d5e36e9f272a778291f", @"/Views/Home/SecretClaimGravar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b55bec701bb5c4324487dfe3a90e1f98fbf801d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SecretClaimGravar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitPessoal\AspNetCore.Mvc\src\AspNetCoreIdentity\Views\Home\SecretClaimGravar.cshtml"
  
    ViewData["Title"] = "Secreta";

#line default
#line hidden
            BeginContext(81, 121, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Essa página só acessa quem tem a claim \"PodeGravar\"</h1>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
