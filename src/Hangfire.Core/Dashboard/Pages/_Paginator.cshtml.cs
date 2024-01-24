#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "../../Dashboard/Pages/_Paginator.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 3 "../../Dashboard/Pages/_Paginator.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class Paginator : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



WriteLiteral("\r\n");


WriteLiteral("<div class=\"btn-toolbar\">\r\n");


            
            #line 7 "../../Dashboard/Pages/_Paginator.cshtml"
     if (_pager.TotalPageCount > 1)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"btn-group paginator\">\r\n");


            
            #line 10 "../../Dashboard/Pages/_Paginator.cshtml"
             foreach (var page in _pager.PagerItems)
            {
                switch (page.Type)
                {
                    case Pager.ItemType.Page:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"");


            
            #line 15 "../../Dashboard/Pages/_Paginator.cshtml"
                            Write(_pager.PageUrl(page.PageIndex));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default ");


            
            #line 15 "../../Dashboard/Pages/_Paginator.cshtml"
                                                                                     Write(_pager.CurrentPage == page.PageIndex ? "active" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 16 "../../Dashboard/Pages/_Paginator.cshtml"
                       Write(page.PageIndex);

            
            #line default
            #line hidden
WriteLiteral("  \r\n                        </a>\r\n");


            
            #line 18 "../../Dashboard/Pages/_Paginator.cshtml"
                        break;
                    case Pager.ItemType.NextPage:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"");


            
            #line 20 "../../Dashboard/Pages/_Paginator.cshtml"
                            Write(_pager.PageUrl(page.PageIndex));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default ");


            
            #line 20 "../../Dashboard/Pages/_Paginator.cshtml"
                                                                                     Write(page.Disabled ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 21 "../../Dashboard/Pages/_Paginator.cshtml"
                       Write(Strings.Paginator_Next);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n");


            
            #line 23 "../../Dashboard/Pages/_Paginator.cshtml"
                        break;
                    case Pager.ItemType.PrevPage:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"");


            
            #line 25 "../../Dashboard/Pages/_Paginator.cshtml"
                            Write(_pager.PageUrl(page.PageIndex));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn btn-default ");


            
            #line 25 "../../Dashboard/Pages/_Paginator.cshtml"
                                                                                     Write(page.Disabled ? "disabled" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            ");


            
            #line 26 "../../Dashboard/Pages/_Paginator.cshtml"
                       Write(Strings.Paginator_Prev);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n");


            
            #line 28 "../../Dashboard/Pages/_Paginator.cshtml"
                        break;
                    case Pager.ItemType.MorePage:

            
            #line default
            #line hidden
WriteLiteral("                        <a href=\"#\" class=\"btn btn-default disabled\">\r\n          " +
"                  …\r\n                        </a>\r\n");


            
            #line 33 "../../Dashboard/Pages/_Paginator.cshtml"
                        break;
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n");



WriteLiteral("        <div class=\"btn-toolbar-spacer\"></div>\r\n");


            
            #line 38 "../../Dashboard/Pages/_Paginator.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div class=\"btn-toolbar-label\">\r\n        ");


            
            #line 41 "../../Dashboard/Pages/_Paginator.cshtml"
   Write(Strings.Paginator_TotalItems);

            
            #line default
            #line hidden
WriteLiteral(": ");


            
            #line 41 "../../Dashboard/Pages/_Paginator.cshtml"
                                  Write(_pager.TotalRecordCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</div>\r\n");


        }
    }
}
#pragma warning restore 1591
