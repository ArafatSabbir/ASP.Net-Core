#pragma checksum "C:\Users\sabbi\Desktop\ASP.Net-Core\BookList\BookList\Pages\BookList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c620485f7c1c081162120bc6e24908d7cd360a9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookList.Pages.BookList.Pages_BookList_Index), @"mvc.1.0.razor-page", @"/Pages/BookList/Index.cshtml")]
namespace BookList.Pages.BookList
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
#line 1 "C:\Users\sabbi\Desktop\ASP.Net-Core\BookList\BookList\Pages\_ViewImports.cshtml"
using BookList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c620485f7c1c081162120bc6e24908d7cd360a9a", @"/Pages/BookList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c16bfd9a6b929ffe3e706563af3e77494643ee84", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n\r\n<div class=\"container row m-0 p-0\">\r\n    <div class=\"col-9\">\r\n        <h2 class=\"text-info\">Book Info</h2>\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <a class=\"btn btn-info form-control\">Create New Book</a>  \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookList.IndexModel>)PageContext?.ViewData;
        public BookList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591