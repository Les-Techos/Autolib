#pragma checksum "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Connexion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc49c0b8c1460b7c84fc02fd7ff58d37609b6d43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Connexion_Index), @"mvc.1.0.view", @"/Views/Connexion/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc49c0b8c1460b7c84fc02fd7ff58d37609b6d43", @"/Views/Connexion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9ef8183c4b9a4737e68ffa525cefee29b2fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Connexion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("singninFrom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("singnupFrom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Connexion\Index.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-sm-12 ml-auto mr-auto"" id=""signincontent"">
    <?= $controllerData ?>
    <ul class=""nav nav-pills nav-fill mb-1"" id=""pills-tab"" role=""tablist"">
        <li class=""nav-item""> <a class=""nav-link active"" id=""pills-signin-tab"" data-toggle=""pill"" href=""#pills-signin"" role=""tab"" aria-controls=""pills-signin"" aria-selected=""true"">Se connecter</a> </li>
        <li class=""nav-item""> <a class=""nav-link"" id=""pills-signup-tab"" data-toggle=""pill"" href=""#pills-signup"" role=""tab"" aria-controls=""pills-signup"" aria-selected=""false"">S'inscrire</a> </li>
    </ul>
    <div class=""tab-content"" id=""pills-tabContent"">
        <div class=""tab-pane fade show active"" id=""pills-signin"" role=""tabpanel"" aria-labelledby=""pills-signin-tab"">
            <div class=""col-sm-12 border border-primary shadow rounded pt-2"" id=""card-signin"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc49c0b8c1460b7c84fc02fd7ff58d37609b6d435545", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">identifiant <span class=""text-danger"">*</span></label>
                        <input type=""texte"" name=""username"" id=""username"" class=""form-control"" placeholder=""Rentrer votre identifiant"" required>
                    </div>
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">Mot de passe <span class=""text-danger"">*</span></label>
                        <input type=""password"" name=""password"" id=""password"" class=""form-control"" placeholder=""***********"" required>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" name=""submit"" id=""signupsubmit"" value=""Se connecter"" class=""btn btn-block btn-primary"">
                    </div>
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
            WriteLiteral(@"
            </div>
        </div>
        <div class=""tab-pane fade"" id=""pills-signup"" role=""tabpanel"" aria-labelledby=""pills-signup-tab"">
            <div class=""col-sm-12 border border-primary shadow rounded pt-2"" id=""card-signin"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc49c0b8c1460b7c84fc02fd7ff58d37609b6d438245", async() => {
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">Prénom <span class=""text-danger"">*</span></label>
                        <input type=""text"" name=""signupforname"" id=""signupforname"" class=""form-control"" placeholder=""Prénom"" required onkeypress=""return(testString(event));"">
                    </div>
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">Nom <span class=""text-danger"">*</span></label>
                        <input type=""text"" name=""signupname"" id=""signupname"" class=""form-control"" placeholder=""nom"" required onkeypress=""return(testString(event));"">
                    </div>
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">Nom d'utilisateur <span class=""text-danger"">*</span></label>
                        <input type=""text"" name=""signupusername"" id=""signupusername"" class=""form-control"" placeholder=""Choississez votre identifiant"" requir");
                WriteLiteral(@"ed>
                        <div class=""text-danger""><em>Ce sera votre identifiant de connexion !</em></div>
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">Mot de passe<span class=""text-danger"">*</span></label>
                        <input type=""password"" name=""signuppassword"" id=""signuppassword"" class=""form-control"" placeholder=""***********"" pattern=""^\S{6,}$"" onchange=""this.setCustomValidity(this.validity.patternMismatch ? 'Must have at least 6 characters' : ''); if(this.checkValidity()) form.password_two.pattern = this.value;"" required>
                    </div>
                    <div class=""form-group"">
                        <label class=""font-weight-bold"">Confirmer votre Mot de passe<span class=""text-danger"">*</span></label>
                        <input type=""password"" name=""signupcpassword"" id=""signupcpassword"" class=""form-control"" pattern=""^\S{6,}$"" onchange=""this.setCustomValidity(this.validity.patternMismatch ? 'Please enter the s");
                WriteLiteral(@"ame Password as above' : '');"" placeholder=""***********"" required>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" name=""signupsubmit"" id=""signupsubmit"" value=""S'inscrire"" class=""btn btn-block btn-primary"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Connexion\Index.cshtml"
AddHtmlAttributeValue("", 2179, Url.Action("Controle", "Connexion"), 2179, 36, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"" integrity=""sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"" integrity=""sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k"" crossorigin=""anonymous""></script>
");
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
