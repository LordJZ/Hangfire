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
    
    #line 2 "../../Dashboard/Pages/ServersPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "../../Dashboard/Pages/ServersPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 4 "../../Dashboard/Pages/ServersPage.cshtml"
    using Hangfire.Common;
    
    #line default
    #line hidden
    
    #line 5 "../../Dashboard/Pages/ServersPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "../../Dashboard/Pages/ServersPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "../../Dashboard/Pages/ServersPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class ServersPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");









            
            #line 9 "../../Dashboard/Pages/ServersPage.cshtml"
  
    Layout = new LayoutPage(Strings.ServersPage_Title);
    
    var monitor = Storage.GetMonitoringApi();
    var servers = monitor.Servers();
    var now = StorageUtcNow ?? ApplicationUtcNow;
    var inconclusiveThreshold = TimeSpan.FromMinutes(1);
    var possiblyAbortedThreshold = TimeSpan.FromMinutes(5);


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 id=\"page-title\" cla" +
"ss=\"page-header\">");


            
            #line 21 "../../Dashboard/Pages/ServersPage.cshtml"
                                           Write(Strings.ServersPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 23 "../../Dashboard/Pages/ServersPage.cshtml"
         if (servers.Count == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-warning\">\r\n                ");


            
            #line 26 "../../Dashboard/Pages/ServersPage.cshtml"
           Write(Strings.ServersPage_NoServers);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 28 "../../Dashboard/Pages/ServersPage.cshtml"
        }
        else
        {
            if (servers.Any(x => x.Heartbeat.HasValue && x.Heartbeat.Value < now.Add(-possiblyAbortedThreshold)))
            {

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"alert alert-info\">\r\n                    <h4>");


            
            #line 34 "../../Dashboard/Pages/ServersPage.cshtml"
                   Write(Strings.ServersPage_Note_Title);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                    ");


            
            #line 35 "../../Dashboard/Pages/ServersPage.cshtml"
               Write(Html.Raw(string.Format(Strings.ServersPage_Note_Text, Url.To("/jobs/processing"))));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n");


            
            #line 37 "../../Dashboard/Pages/ServersPage.cshtml"
            }


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"table-responsive\">\r\n                <table class=\"table\" " +
"aria-describedby=\"page-title\">\r\n                    <thead>\r\n                   " +
"     <tr>\r\n                            <th>");


            
            #line 43 "../../Dashboard/Pages/ServersPage.cshtml"
                           Write(Strings.ServersPage_Table_Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");


            
            #line 44 "../../Dashboard/Pages/ServersPage.cshtml"
                           Write(Strings.ServersPage_Table_Workers);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");


            
            #line 45 "../../Dashboard/Pages/ServersPage.cshtml"
                           Write(Strings.ServersPage_Table_Queues);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");


            
            #line 46 "../../Dashboard/Pages/ServersPage.cshtml"
                           Write(Strings.ServersPage_Table_Started);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            <th>");


            
            #line 47 "../../Dashboard/Pages/ServersPage.cshtml"
                           Write(Strings.ServersPage_Table_Heartbeat);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n             " +
"       <tbody>\r\n");


            
            #line 51 "../../Dashboard/Pages/ServersPage.cshtml"
                         foreach (var server in servers)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr>\r\n                                <td>\r\n");


            
            #line 55 "../../Dashboard/Pages/ServersPage.cshtml"
                                     if (server.Heartbeat < now.Add(-possiblyAbortedThreshold))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("<span class=\"glyphicon glyphicon-alert text-danger\" title=\"");


            
            #line 57 "../../Dashboard/Pages/ServersPage.cshtml"
                                                                                                Write(Strings.ServersPage_Possibly_Aborted);

            
            #line default
            #line hidden
WriteLiteral("\"></span>&nbsp;");


            
            #line 57 "../../Dashboard/Pages/ServersPage.cshtml"
                                                                                                                                                    Write(Html.ServerId(server.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 58 "../../Dashboard/Pages/ServersPage.cshtml"
                                    }
                                    else if (server.Heartbeat < now.Add(-inconclusiveThreshold))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("<span class=\"glyphicon margin-right-14p\"></span>&nbsp;");


            
            #line 61 "../../Dashboard/Pages/ServersPage.cshtml"
                                                                                           Write(Html.ServerId(server.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 62 "../../Dashboard/Pages/ServersPage.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        ");

WriteLiteral("<span class=\"glyphicon glyphicon-ok text-success\" title=\"");


            
            #line 65 "../../Dashboard/Pages/ServersPage.cshtml"
                                                                                              Write(Strings.ServersPage_Active);

            
            #line default
            #line hidden
WriteLiteral("\"></span>&nbsp;");


            
            #line 65 "../../Dashboard/Pages/ServersPage.cshtml"
                                                                                                                                        Write(Html.ServerId(server.Name));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 66 "../../Dashboard/Pages/ServersPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                                <td>");


            
            #line 68 "../../Dashboard/Pages/ServersPage.cshtml"
                               Write(server.WorkersCount);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <td>");


            
            #line 69 "../../Dashboard/Pages/ServersPage.cshtml"
                               Write(Html.Raw(String.Join(", ", server.Queues.Select(Html.QueueLabel))));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <td>");


            
            #line 70 "../../Dashboard/Pages/ServersPage.cshtml"
                               Write(Html.RelativeTime(server.StartedAt));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                <td>\r\n");


            
            #line 72 "../../Dashboard/Pages/ServersPage.cshtml"
                                     if (server.Heartbeat.HasValue)
                                    {
                                        
            
            #line default
            #line hidden
            
            #line 74 "../../Dashboard/Pages/ServersPage.cshtml"
                                   Write(Html.RelativeTime(server.Heartbeat.Value));

            
            #line default
            #line hidden
            
            #line 74 "../../Dashboard/Pages/ServersPage.cshtml"
                                                                                  
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                            </tr>\r\n");


            
            #line 78 "../../Dashboard/Pages/ServersPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n");


            
            #line 82 "../../Dashboard/Pages/ServersPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
