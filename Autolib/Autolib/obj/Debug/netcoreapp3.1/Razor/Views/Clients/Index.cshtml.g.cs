#pragma checksum "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ecf42320e91ed0cfad939b975efed14ecbc2498"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
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
#line 1 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Clients\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ecf42320e91ed0cfad939b975efed14ecbc2498", @"/Views/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9ef8183c4b9a4737e68ffa525cefee29b2fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Autolib.Models.Domain.Client>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Clients\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5>Informations du compte</h5>
                    <ul class=""list-group list-group-flush"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ecf42320e91ed0cfad939b975efed14ecbc24984743", async() => {
                WriteLiteral(@"

                        <li class=""list-group-item"">Nom : <input type=""text"" id=""nom"" name=""nom"" class=""form-control"" value=""<?=$controllerData["" nom""]?>""  required/></li>
                        <li class=""list-group-item"">Prénom : <input type=""text"" id=""prenom"" name=""prenom"" class=""form-control"" value=""<?=$controllerData["" prenom""]?>""  required/></li>
                        <li class=""list-group-item"">Login : <input type=""text"" id=""username"" name=""username"" class=""form-control"" value=""<?=$controllerData["" username""] ?>"" required/></li>
                        <li class=""list-group-item"">Mot de Passe : <input type=""password"" name=""password"" id=""password"" class=""form-control"" placeholder=""Nouveau mot de passe"" pattern=""^\S{6,}$"" onchange=""this.setCustomValidity(this.validity.patternMismatch ? 'Must have at least 6 characters' : ''); if(this.checkValidity()) form.password_two.pattern = this.value;""></li>
                        <li class=""list-group-item""><input type=""password"" name=""cpassword"" id=""cp");
                WriteLiteral(@"assword"" class=""form-control"" pattern=""^\S{6,}$"" onchange=""this.setCustomValidity(this.validity.patternMismatch ? 'Please enter the same Password as above' : '');"" placeholder=""Répétez le mot de passe""></li>

                        <li class=""list-group-item""><input type=""submit"" id=""submit"" name=""modify"" class=""btn btn-validate btn-block"" value=""Modifier"" /></li>

                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 25 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Clients\Index.cshtml"
                         if (Context.Session.GetInt32("id") > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 2009, "\"", 2093, 1);
#nullable restore
#line 27 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Clients\Index.cshtml"
WriteAttributeValue("", 2016, Url.Action("Delete", "Clients", new { id = Context.Session.GetInt32("id") }), 2016, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <li class=\"list-group-item\"><button id=\"submit\" name=\"delete\" class=\"btn btn-danger btn-block\" > Supprimer </button></li></a>\r\n");
#nullable restore
#line 29 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Clients\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-8"">
            <div class=""card"" style=""max-height:500px"">
                <div class=""card-header"">Historique de commandes</div>
                <div class=""card-body"">
                    <ul>
                        <?=$controllerData[""commandes""]?>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<h1>Index</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Autolib.Models.Domain.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
