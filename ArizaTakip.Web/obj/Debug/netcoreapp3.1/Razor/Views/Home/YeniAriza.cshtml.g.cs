#pragma checksum "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d647a047e3a9ac385bacf3fd45eb37a1dc8ee34b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YeniAriza), @"mvc.1.0.view", @"/Views/Home/YeniAriza.cshtml")]
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
#line 1 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\_ViewImports.cshtml"
using ArizaTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\_ViewImports.cshtml"
using ArizaTakip.Entites.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d647a047e3a9ac385bacf3fd45eb37a1dc8ee34b", @"/Views/Home/YeniAriza.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f00fb7ba6454494b675511a1a8146fb9b8af608", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_YeniAriza : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArizaTakip.Entites.Concrete.Ariza>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("=form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml"
  
    ViewData["Title"] = "YeniAriza";
    Layout = "~/Views/Shared/_LayoutSideBar.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2><label class=\"font-weight-bold text-xl-right glyphicon glyphicon-plus-sign  pb-4\">&nbsp;YENİ ARIZA EKLEME</label></h2>\r\n<hr />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d647a047e3a9ac385bacf3fd45eb37a1dc8ee34b4354", async() => {
                WriteLiteral("\r\n\r\n    <b>Cihaz</b>\r\n    <div class=\"= mt-3 p-0\">\r\n        ");
#nullable restore
#line 15 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml"
   Write(Html.DropDownListFor(x => x.CihazId, TempData["cihazDropDown"] as List<SelectListItem>, "SEÇİNİZ"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <b>Arıza Kodu</b>\r\n");
                WriteLiteral("    <b>Arıza Tanımı</b>\r\n    ");
#nullable restore
#line 21 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml"
Write(Html.TextBoxFor(x => x.ArizaTanim, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <b>Arıza Açıklama</b>\r\n    ");
#nullable restore
#line 24 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml"
Write(Html.TextBoxFor(x => x.ArizaAciklama, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <b>Arızanın Durumu</b>\r\n    <div class=\"= mt-3 p-0\">\r\n        ");
#nullable restore
#line 28 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml"
   Write(Html.DropDownListFor(x => x.Durum,

                    new List<SelectListItem>{
                    new SelectListItem { Text = "BİLİNMİYOR", Value = "False" },
                    new SelectListItem { Text = "BEKLEMEDE", Value = "False" },
                    new SelectListItem { Text = "ÇALIŞIYOR", Value = "True" },
                    new SelectListItem { Text = "ARIZALI", Value = "False" },

                     }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <b>Arızanın Oluşturulduğu Tarih</b>\r\n    <div class=\"mt-3 p-0\">\r\n        ");
#nullable restore
#line 41 "C:\Users\uzayk\source\repos\ArizaTakip\ArizaTakip.Web\Views\Home\YeniAriza.cshtml"
   Write(Html.EditorFor(model => model.ArizaOlusturulmaTarih, new { @type = "date" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <button class=\"btn btn-dark\"> Arıza Ekle </button>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArizaTakip.Entites.Concrete.Ariza> Html { get; private set; }
    }
}
#pragma warning restore 1591