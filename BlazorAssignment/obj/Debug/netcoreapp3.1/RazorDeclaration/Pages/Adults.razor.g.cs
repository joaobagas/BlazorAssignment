#pragma checksum "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dba07446287545e19a21c250243d30e8773940b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAssignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using BlazorAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\_Imports.razor"
using BlazorAssignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\joaob\Source\Repos\dnp-assignment-1\BlazorAssignment\Pages\Adults.razor"
       
    private IList<BlazorAssignment.Models.Adult> adultsToShow;
    private IList<BlazorAssignment.Models.Adult> allAdults;
    private int? filterByAge;
    private double? filterByHeight;

    private void FilterByAge(ChangeEventArgs changeEventArgs)
    {
        filterByAge = null;
        try
        {
            filterByAge = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e) { }
        ExecuteFilter();
    }
    private void FilterByHeight(ChangeEventArgs changeEventArgs)
    {
        filterByHeight = null;
        try
        {
            filterByHeight = double.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e) { }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsToShow = allAdults.Where(t =>
        (filterByAge != null && t.Age == filterByAge || filterByAge == null) &&
        (filterByHeight != null && t.Height == filterByHeight || filterByHeight == null)).ToList();
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = FamiliesManager.GetAdults();
        adultsToShow = allAdults;
    }
    private void RemoveAdult(Adult adult)
    {
        FamiliesManager.RemoveAdult(adult);
        allAdults.Remove(adult);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorAssignment.Data.FamilyManagerInterface FamiliesManager { get; set; }
    }
}
#pragma warning restore 1591
