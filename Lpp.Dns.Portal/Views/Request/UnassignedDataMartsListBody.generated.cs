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

namespace Lpp.Dns.Portal.Views.Request
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
    
    #line 1 "..\..\Views\Request\UnassignedDataMartsListBody.cshtml"
    using Lpp.Dns.DTO;
    
    #line default
    #line hidden
    using Lpp.Dns.Portal;
    using Lpp.Dns.Portal.Controllers;
    using Lpp.Dns.Portal.Models;
    using Lpp.Dns.Portal.Views;
    using Lpp.Mvc;
    using Lpp.Mvc.Application;
    using Lpp.Mvc.Controls;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Request/UnassignedDataMartsListBody.cshtml")]
    public partial class UnassignedDataMartsListBody : System.Web.Mvc.WebViewPage<ListModel<DataMartListDTO, RequestChildrenGetModel>>
    {
        public UnassignedDataMartsListBody()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Request\UnassignedDataMartsListBody.cshtml"
   Layout = null; 
            
            #line default
            #line hidden
WriteLiteral(" \r\n\r\n");

            
            #line 5 "..\..\Views\Request\UnassignedDataMartsListBody.cshtml"
Write(Html.Partial<DataMartsListBody>().WithModel( new DataMartsListModel
{
    DataMarts = Model,
    HiddenFieldName = "AddDataMarts",
    ReloadUrl = Url.Action<RequestController>( c => c.UnassignedDataMartsListBody( Model.ModelForReload() ) )
} ));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
