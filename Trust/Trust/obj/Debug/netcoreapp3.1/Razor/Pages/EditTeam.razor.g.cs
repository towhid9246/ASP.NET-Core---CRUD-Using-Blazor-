#pragma checksum "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e0dab8a52525f2d9c48a9dd7321b732f1c4f4b"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h2>\r\n    Edit Author\r\n</h2>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "width", "100%");
            __builder.AddAttribute(5, "cellpadding", "0");
            __builder.AddAttribute(6, "cellspacing", "0");
            __builder.AddAttribute(7, "border", "0");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<td>\r\n                    <label for=\"TeamName\" class=\"control-label\">\r\n                        TeamName\r\n                    </label>\r\n                </td>\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "for", "TeamName");
            __builder.AddAttribute(18, "class", "form-control");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor"
                                   team.TeamName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => team.TeamName = __value, team.TeamName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<td>\r\n                    <label for=\"TeamDesc\" class=\"control-label\">\r\n                        TeamDesc\r\n                    </label>\r\n                </td>\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "for", "TeamDesc");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor"
                                   team.TeamDesc

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => team.TeamDesc = __value, team.TeamDesc));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.AddMarkupContent(39, "<td>\r\n                    <label for=\"TeamStatus\" class=\"control-label\">\r\n                        TeamStatus\r\n                    </label>\r\n                </td>\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "for", "TeamStatus");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor"
                                   team.TeamStatus

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => team.TeamStatus = __value, team.TeamStatus));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\r\n                <td></td>\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.AddMarkupContent(53, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor"
                                      () => UpdateTeam()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "\r\n                        &#8195;Save&#8195;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "&#8194;\r\n                    ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "class", "btn btn-warning");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditTeam.razor"
                                      () => Cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "\r\n                        &#8194;&#8201;Cancel&#8201;&#8194;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
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
