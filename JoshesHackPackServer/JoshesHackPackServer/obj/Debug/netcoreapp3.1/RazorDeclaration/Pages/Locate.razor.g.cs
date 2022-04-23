// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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