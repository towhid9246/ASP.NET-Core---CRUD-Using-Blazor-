#pragma checksum "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "113713ceabcc2b05326159c254608a82227be660"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editProjectsDetails/{DetailsId:int}")]
    public partial class EditProjectsDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>\r\n    Edit Book\r\n</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"Comments\" class=\"control-label\">Comments</label>\r\n                ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "for", "Comments");
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "onfocus", "this.value=\'\'");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                               projectsDetails.Comments

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => projectsDetails.Comments = __value, projectsDetails.Comments));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<label for=\"Date\" class=\"control-label\">\r\n                    Date\r\n                </label>\r\n                ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "date");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "onfocus", "this.value=\'\'");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                               projectsDetails.ProjectDate

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => projectsDetails.ProjectDate = __value, projectsDetails.ProjectDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group");
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.AddMarkupContent(36, "<label for=\"StatusId\" class=\"control-label\">\r\n                    StatusId\r\n                </label>\r\n                ");
            __builder.OpenElement(37, "select");
            __builder.AddAttribute(38, "for", "StatusId");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                                projectsDetails.StaId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => projectsDetails.StaId = __value, projectsDetails.StaId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "0");
            __builder.AddAttribute(45, "selected", true);
            __builder.AddContent(46, "[Select Status]");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 32 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                     foreach (var status in statuss)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                        ");
            __builder.OpenElement(49, "option");
            __builder.AddAttribute(50, "value", 
#nullable restore
#line 34 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                                        status.StatusId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.AddContent(52, 
#nullable restore
#line 35 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                             status.StatusId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 37 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row");
            __builder.AddMarkupContent(62, "\r\n        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-md-4");
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "form-group");
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                                  () => UpdateProjectsDetails()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "\r\n                    Save\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-warning");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
                                  () => cancel()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(79, "\r\n                    Cancel\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\EditProjectsDetails.razor"
       
    [Parameter]
    public int DetailsId { get; set; }
    ProjectsDetails projectsDetails = new ProjectsDetails();
    List<Status> statuss = new List<Status>();
    protected override async Task OnInitializedAsync()
    {
        projectsDetails = await ProjectsDetailsService.GetById(DetailsId);
        statuss = await StatusService.FetchAll();
    }
    protected async Task UpdateProjectsDetails()
    {
        await ProjectsDetailsService.Update(projectsDetails);
        navigationManager.NavigateTo("/listProjectsDetails");
    }
    void cancel()
    {
        navigationManager.NavigateTo("/listProjectsDetails");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStatusService StatusService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectsDetailsService ProjectsDetailsService { get; set; }
    }
}
#pragma warning restore 1591
