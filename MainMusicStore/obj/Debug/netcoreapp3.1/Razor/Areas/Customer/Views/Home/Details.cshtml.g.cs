#pragma checksum "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91b453b20cf60dd0b7f8bebb93e5d1ff1e002cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Details), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\_ViewImports.cshtml"
using MainMusicStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\_ViewImports.cshtml"
using MainMusicStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91b453b20cf60dd0b7f8bebb93e5d1ff1e002cc", @"/Areas/Customer/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5cf704dcfa229d1eee9a7c1cb2d58cb1f700b19", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainMusicStore.Models.DbModels.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<br />
<br />
<br />
<div class=""row u-pt20 border"">
    <div class=""col-md-5 col-sm-12 col-xs-12 product-photos"">
        <div class=""product-photos__showcase slick-initialized slick-slider"">
            <div aria-live=""polite"" class=""slick-list draggable"">
                <div class=""slick-track"" style=""opacity: 1; width: 456px; transform: translate3d(0px, 0px, 0px);"" role=""listbox"">
                    <a href=""https://www.do-re.com.tr/pearl-river-up115m5-akustik-duvar-piyanosu-maun-c68fba03f21bd89ea9186a63823d19cf-b18ee24e621f90696ef20ddc58694e9e-max-pp.jpg"" data-lightbox=""main"" data-title=""Pearl River UP115M5 Akustik Duvar Piyanosu (Maun)<br>Foto??raf: 1/1"" class=""slick-slide slick-current slick-active"" data-slick-index=""0"" aria-hidden=""false"" style=""width: 456px;"" tabindex=""-1"" role=""option"" aria-describedby=""slick-slide10"">
                        <div>
                            <img");
            BeginWriteAttribute("src", " src=\"", 1018, "\"", 1039, 1);
#nullable restore
#line 18 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
WriteAttributeValue("", 1024, Model.ImageUrl, 1024, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top"" />
                            
                        </div>
                    </a>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-7 col-sm-12 col-xs-12 product-detail__info border"">
        <h1 class=""border"">&nbsp;");
#nullable restore
#line 27 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
                            Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"info-value u-pt30\">\r\n            <br />\r\n            <span class=\"font-weight-bold\">&nbsp;??r??n Kodu: </span>  <span>&nbsp; ");
#nullable restore
#line 30 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
                                                                             Write(Model.ProductNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <br />\r\n        <div class=\"info-value\">\r\n            <span class=\"font-weight-bold\">&nbsp;Marka: </span>  <span>&nbsp; ");
#nullable restore
#line 34 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
                                                                         Write(Model.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <br />\r\n        <div class=\"row u-pt20\">\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                <h5 class=\"font-weight-bold\">&nbsp;Liste Fiyat??: <b style=\"color:red\"");
            BeginWriteAttribute("class", " class=\"", 1898, "\"", 1906, 0);
            EndWriteAttribute();
            WriteLiteral(">&nbsp;<strike> ");
#nullable restore
#line 39 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
                                                                                                         Write(Model.ListPrice.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;TL</strike> </b></h5>\r\n                <br /> \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91b453b20cf60dd0b7f8bebb93e5d1ff1e002cc7791", async() => {
                WriteLiteral("??r??nlere Geri D??n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <br>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6 col-xs-12 u-center\">\r\n\r\n                <h4 class=\"font-weight-bold\">&nbsp;Sat???? Fiyat??: <b style=\"color:forestgreen\"");
            BeginWriteAttribute("class", " class=\"", 2297, "\"", 2305, 0);
            EndWriteAttribute();
            WriteLiteral(">&nbsp; ");
#nullable restore
#line 46 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
                                                                                                         Write(Model.Price.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  &nbsp;TL</b></h4>\r\n                <br />\r\n                \r\n                <a style=\"background-color:darkorange\"");
            BeginWriteAttribute("href", " href=\"", 2460, "\"", 2467, 0);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2468, "\"", 2478, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn text-white btn-lg"">SEPETE EKLE</a>
            </div>
        </div>
        <br />
        <div class=""row product-detail-warranty border"">

            &nbsp;&nbsp; <h5 class=""font-weight-bold"">&nbsp;&nbsp;??r??n A????klamas?? </h5>
            <br /><br />
            <div>
                <p>");
#nullable restore
#line 58 "C:\Users\Alican\Desktop\MainMusicStore\MainMusicStore\Areas\Customer\Views\Home\Details.cshtml"
              Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainMusicStore.Models.DbModels.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
