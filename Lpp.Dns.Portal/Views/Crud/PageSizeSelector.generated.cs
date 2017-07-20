﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lpp.Dns.Portal.Views.Crud
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Lpp;
    using Lpp.Dns;
    using Lpp.Dns.Data;
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Controllers;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Crud/PageSizeSelector.cshtml")]
    public partial class PageSizeSelector : System.Web.Mvc.WebViewPage<PageSizeSelectorModel>
    {
        public PageSizeSelector()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Crud\PageSizeSelector.cshtml"
   var id = Html.UniqueId();  
            
            #line default
            #line hidden
WriteLiteral("\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 85), Tuple.Create("\"", 129)
, Tuple.Create(Tuple.Create("", 92), Tuple.Create<System.Object, System.Int32>(Href("~/__r/Lpp.Mvc.Controls/-/dropdown.css")
, 92), false)
);

WriteLiteral(" />\r\n<div");

WriteLiteral(" class=\"PageSizeSelector\"");

WriteLiteral(">\r\n    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"ui-dropdown-button\"");

WriteAttribute("id", Tuple.Create(" id=\"", 209), Tuple.Create("\"", 217)
            
            #line 5 "..\..\Views\Crud\PageSizeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 214), Tuple.Create<System.Object, System.Int32>(id
            
            #line default
            #line hidden
, 214), false)
);

WriteLiteral(">");

            
            #line 5 "..\..\Views\Crud\PageSizeSelector.cshtml"
                                               Write(Model.CurrentText);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    <div");

WriteLiteral(" class=\"ui-dropdown FilterOptions\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n");

            
            #line 7 "..\..\Views\Crud\PageSizeSelector.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\Crud\PageSizeSelector.cshtml"
     foreach ( var lines in Model.Options )
    {

            
            #line default
            #line hidden
WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 372), Tuple.Create("\"", 416)
            
            #line 9 "..\..\Views\Crud\PageSizeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 379), Tuple.Create<System.Object, System.Int32>(Html.Raw( Model.ReloadUrl( lines ) )
            
            #line default
            #line hidden
, 379), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 417), Tuple.Create("\"", 488)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("GridReloadLink", 425), true)
            
            #line 9 "..\..\Views\Crud\PageSizeSelector.cshtml"
, Tuple.Create(Tuple.Create("", 439), Tuple.Create<System.Object, System.Int32>( lines == Model.CurrentSize ? " Selected" : ""
            
            #line default
            #line hidden
, 439), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\Views\Crud\PageSizeSelector.cshtml"
                                                                                                                           Write(Model.Text( lines ));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 10 "..\..\Views\Crud\PageSizeSelector.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 546), Tuple.Create("\"", 588)
, Tuple.Create(Tuple.Create("", 552), Tuple.Create<System.Object, System.Int32>(Href("~/__r/Lpp.Mvc.Controls/-/dropdown.js")
, 552), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(document).ready(function () {\r\n            $(\"#");

            
            #line 15 "..\..\Views\Crud\PageSizeSelector.cshtml"
            Write(id);

            
            #line default
            #line hidden
WriteLiteral("\").dropdown();\r\n        });\r\n    </script>\r\n</div>");

        }
    }
}
#pragma warning restore 1591