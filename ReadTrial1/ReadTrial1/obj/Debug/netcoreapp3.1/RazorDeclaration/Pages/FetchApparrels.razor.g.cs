#pragma checksum "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95debbe532ab2a22b6d40997d96cc96d3547aa76"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ReadTrial1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using ReadTrial1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\_Imports.razor"
using ReadTrial1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
using ReadTrial1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class FetchApparrels : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\arshb\source\repos\ReadTrial1\ReadTrial1\Pages\FetchApparrels.razor"
       
    private List<Product> apparels;

    protected override async Task OnInitializedAsync()
    {
        int id = 1;
        apparels = await ApparelService.GetProductByGenderId();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenderApparelService ApparelService { get; set; }
    }
}
#pragma warning restore 1591
