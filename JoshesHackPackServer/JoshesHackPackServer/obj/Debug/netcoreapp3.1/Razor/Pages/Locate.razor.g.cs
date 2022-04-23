#pragma checksum "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d43cd33011abd445252e278b25eb351da8e8992b"
// <auto-generated/>
#pragma warning disable 1591
namespace JoshesHackPackServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using JoshesHackPackServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\_Imports.razor"
using JoshesHackPackServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
using HackLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/locate")]
    public partial class Locate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"css/buttons.css\">\r\n");
            __builder.AddMarkupContent(1, "<h1>Ip Geolocation Triangulator</h1>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h3>Enter 3 IP addresses to triangulate on one central location</h3>\r\n\r\n");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "button-5");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                                   RandomIPS

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Fill Random IPs");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n<br>\r\n<hr>\r\n");
            __builder.OpenElement(8, "table");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<thead>\r\n        <tr>\r\n            <th>IP Address</th>\r\n            <th style=\"width: 100%\">Approximate Location</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                              ip1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ip1 = __value, ip1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "style", "width: 30%");
            __builder.AddAttribute(26, "readonly", true);
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                                                 ipdata1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ipdata1 = __value, ipdata1));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                              ip2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ip2 = __value, ip2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "style", "width: 30%");
            __builder.AddAttribute(45, "readonly", true);
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                                                  ipdata2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ipdata2 = __value, ipdata2));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "td");
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                              ip3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ip3 = __value, ip3));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "td");
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "style", "width: 30%");
            __builder.AddAttribute(64, "readonly", true);
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                                                  ipdata3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ipdata3 = __value, ipdata3));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "tr");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "td");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "style", "width: 90%");
            __builder.AddAttribute(76, "class", "button-5");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                                                                     DoLocate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Locate");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.OpenElement(81, "td");
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "style", "width: 30%");
            __builder.AddAttribute(85, "readonly", true);
            __builder.AddAttribute(86, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                                                 result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => result = __value, result));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n<hr>\r\n<br>\r\n\r\n");
            __builder.OpenElement(93, "div");
            __builder.AddMarkupContent(94, "\r\n    ");
            __builder.OpenElement(95, "img");
            __builder.AddAttribute(96, "src", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
                     url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => url = __value, url));
            __builder.SetUpdatesAttributeName("src");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\joshi\source\repos\JoshesHackPackServer\JoshesHackPackServer\Pages\Locate.razor"
       
    private string url = "";

    private string ipdata1 = "";
    private string ipdata2 = "";
    private string ipdata3 = "";

    private string ip1;
    private string ip2;
    private string ip3;
    private string result;

    private async Task DoLocate()
    {
        result = "Loading...";
        Triangulate.ClearPoints();

        ipdata1 = await Triangulate.LocationDetails(await Triangulate.GrabLocation(ip1));
        ipdata2 = await Triangulate.LocationDetails(await Triangulate.GrabLocation(ip2));
        ipdata3 = await Triangulate.LocationDetails(await Triangulate.GrabLocation(ip3));

        url = Triangulate.GraphURL();
        result = await Triangulate.LocationDetails(Triangulate.GrabLocation(Triangulate.GetCenter().Item1, Triangulate.GetCenter().Item2));
    }
    private async Task RandomIPS()
    {
        ip1 = await Triangulate.RandomIPAsync();
        ip2 = await Triangulate.RandomIPAsync();
        ip3 = await Triangulate.RandomIPAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
