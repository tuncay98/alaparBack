#pragma checksum "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d0d8d4b5d8ad5654e1a9388214f3a181e8ac250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Bina_Views_BinaAdsPersonals_Delete), @"mvc.1.0.view", @"/Areas/Bina/Views/BinaAdsPersonals/Delete.cshtml")]
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
#line 1 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\_ViewImports.cshtml"
using AlApar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\_ViewImports.cshtml"
using AlApar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0d8d4b5d8ad5654e1a9388214f3a181e8ac250", @"/Areas/Bina/Views/BinaAdsPersonals/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6df741ecb402a02c9d79d04daa0fbc2f91183bf", @"/Areas/Bina/Views/_ViewImports.cshtml")]
    public class Areas_Bina_Views_BinaAdsPersonals_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlApar.Models.BinaAdsPersonal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Bina/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>BinaAdsPersonal</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FromDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FromDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TillDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TillDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AreaSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AreaSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HasLicense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HasLicense));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HasMortgage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HasMortgage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FloorAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FloorAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Viewed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Viewed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdPackage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdPackage.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdStatus.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Currency.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LandAppointment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LandAppointment.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Metro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Metro.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PersonalContact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PersonalContact.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Region.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 166 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RentPaymentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 169 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RentPaymentType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 172 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SellType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 175 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SellType.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 178 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Village));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 181 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Village.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0d8d4b5d8ad5654e1a9388214f3a181e8ac25024728", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d0d8d4b5d8ad5654e1a9388214f3a181e8ac25024995", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 186 "C:\Users\tunca\Desktop\AlApar_master\asp.net\AlApar\AlApar\Areas\Bina\Views\BinaAdsPersonals\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0d8d4b5d8ad5654e1a9388214f3a181e8ac25026810", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlApar.Models.BinaAdsPersonal> Html { get; private set; }
    }
}
#pragma warning restore 1591
