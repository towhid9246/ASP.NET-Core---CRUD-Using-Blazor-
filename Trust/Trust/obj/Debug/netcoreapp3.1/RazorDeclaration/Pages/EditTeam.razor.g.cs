// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Trust.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Trust;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Trust.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Trust.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Trust.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\_Imports.razor"
using Trust.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editTeam/{TeamId:int}")]
    public partial class EditTeam : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor"
        
    [Parameter]
    public int TeamId { get; set; }
    Team team= new Team();
    protected override async Task OnInitializedAsync()
    {
        team = await TeamService.ReadByPk(TeamId);
    }
    protected async Task UpdateTeam()
    {
        await TeamService.Update(team);
        navigationManager.NavigateTo("/listTeam");
    }
    void Cancel()
    {
        navigationManager.NavigateTo("/listTeam");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITeamService TeamService { get; set; }
    }
}
#pragma warning restore 1591
