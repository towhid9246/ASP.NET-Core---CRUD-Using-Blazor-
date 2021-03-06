#pragma checksum "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b86832c2dd46de822a567c327f961efa659ac4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/listUser")]
    public partial class ListUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css\" rel=\"stylesheet\">\r\n");
            __builder.AddMarkupContent(1, @"<style>
    .sort-th {
        cursor: pointer;
    }

    .fa {
        float: right;
    }

    .btn-custom {
        color: black;
        float: left;
        padding: 8px 16px;
        text-decoration: none;
        transition: background-color .3s;
        border: 2px solid #000;
        margin: 0px 5px 0px 5px;
    }
</style>
");
            __builder.AddMarkupContent(2, "<a class=\"btn btn-primary\" href=\"/addUser/0\">Add new User</a>\r\n");
#nullable restore
#line 24 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 27 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row col-md-3 pull-right");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "id", "txtSearch");
            __builder.AddAttribute(12, "placeholder", "Search Names...");
            __builder.AddAttribute(13, "class", "form-control");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                      SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "thead");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "tr");
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "class", "sort-th");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                                () => SortTable("UserId")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                   User Id");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "fa" + " " + (
#nullable restore
#line 39 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                            SetSortIcon("UserId")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "class", "sort-th");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                () => SortTable("UserName")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                    User Name\r\n                    ");
            __builder.OpenElement(37, "span");
            __builder.AddAttribute(38, "class", "fa" + " " + (
#nullable restore
#line 44 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                      SetSortIcon("UserName")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "th");
            __builder.AddAttribute(42, "class", "sort-th");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                () => SortTable("Password")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                    Password\r\n                    ");
            __builder.OpenElement(45, "span");
            __builder.AddAttribute(46, "class", "fa" + " " + (
#nullable restore
#line 49 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                      SetSortIcon("Password")

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                \r\n                ");
            __builder.AddMarkupContent(49, "<th>Action</th>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "tbody");
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 56 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
             if (users == null || users.Count == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                ");
            __builder.AddMarkupContent(55, "<tr>\r\n                    <td colspan=\"3\">\r\n                        No Records to display\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 63 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
            }
            else
            {
                foreach (var user in users)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                    ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddMarkupContent(60, "\r\n                            <hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(61, 
#nullable restore
#line 71 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                             user.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "td");
            __builder.AddMarkupContent(65, "\r\n                            <hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(66, 
#nullable restore
#line 75 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                             user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
            __builder.AddMarkupContent(70, "\r\n                            <hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.AddContent(71, 
#nullable restore
#line 79 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                             user.Password

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        \r\n                        ");
            __builder.OpenElement(74, "td");
            __builder.AddMarkupContent(75, "\r\n                            <hr style=\"padding:0px; margin:0px;\">\r\n                            ");
            __builder.OpenElement(76, "a");
            __builder.AddAttribute(77, "class", "btn btn-primary");
            __builder.AddAttribute(78, "href", "/editUser/" + (
#nullable restore
#line 85 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                                user.UserId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(79, "\r\n                                &#8194;Edit&#8194;\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "&#8194;\r\n                            ");
            __builder.OpenElement(81, "a");
            __builder.AddAttribute(82, "class", "btn btn-warning");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                                                 () =>
                        DeleteUser(user.UserId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 92 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"

                }
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "pagination");
            __builder.AddMarkupContent(93, "\r\n        ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "class", "btn btn-custom");
            __builder.AddAttribute(96, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                                  async ()=>
              await NavigateToPage("previous")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(97, "\r\n            ???\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 102 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
         for (int i = startPage; i <= endPage; i++)
        {
            var currentPage = i;

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "            ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "class", "btn" + " btn-custom" + " pagebutton" + "\r\n                 " + (
#nullable restore
#line 106 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                   currentPage==curPage?"btn-info":""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                               async () =>
                 await refreshRecords(currentPage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.AddContent(104, 
#nullable restore
#line 109 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                 currentPage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 111 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "        ");
            __builder.OpenElement(108, "button");
            __builder.AddAttribute(109, "class", "btn btn-custom");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
                                                  async ()=>
              await NavigateToPage("next")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(111, "\r\n            ???\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 117 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\TOWHID\Desktop\Blazor Project Final\Trust\Trust\Pages\ListUser.razor"
       
    private string searchTerm;
    private string SearchTerm
    {
        get { return searchTerm; }
        set { searchTerm = value; FilterRecords(); }
    }
    List<User> users;
    #region Pagination
    int totalPages;
    int totalRecords;
    int curPage;
    int pagerSize;
    int pageSize;
    int startPage;
    int endPage;
    string sortColumnName = "UserId";
    string sortDir = "ASC";
    #endregion
    protected override async Task OnInitializedAsync()
    {
        //display total page buttons
        pagerSize = 3;
        pageSize = 5;
        curPage = 1;
        users = await UserService.ListAll((curPage - 1) *
           pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        totalRecords = await UserService.Count(searchTerm);
        totalPages = (int)Math.Ceiling
                     (totalRecords / (decimal)pageSize);
        SetPagerSize("forward");
    }
    protected async Task DeleteUser(int UserId)
    {
        await UserService.Delete(UserId);
        users = await UserService.ListAll((curPage - 1) *
           pageSize, pageSize, sortColumnName, sortDir, searchTerm);
    }
    private bool isSortedAscending;
    private string activeSortColumn;
    private async Task<List<User>>
            SortRecords(string columnName, string dir)
    {
        return await UserService.ListAll((curPage - 1) * pageSize,
           pageSize, columnName, dir, searchTerm);
    }
    private async Task SortTable(string columnName)
    {
        if (columnName != activeSortColumn)
        {
            users = await SortRecords(columnName, "ASC");
            isSortedAscending = true;
            activeSortColumn = columnName;
        }
        else
        {
            if (isSortedAscending)
            {
                users = await SortRecords(columnName, "DESC");
            }
            else
            {
                users = await SortRecords(columnName, "ASC");
            }
            isSortedAscending = !isSortedAscending;
        }
        sortColumnName = columnName;
        sortDir = isSortedAscending ? "ASC" : "DESC";
    }
    private string SetSortIcon(string columnName)
    {
        if (activeSortColumn != columnName)
        {
            return string.Empty;
        }
        if (isSortedAscending)
        {
            return "fa-sort-up";
        }
        else
        {
            return "fa-sort-down";
        }
    }
    public async Task refreshRecords(int currentPage)
    {
        users = await UserService.ListAll((currentPage - 1)
           * pageSize, pageSize, sortColumnName, sortDir, searchTerm);
        curPage = currentPage;
        this.StateHasChanged();
    }
    public void SetPagerSize(string direction)
    {
        if (direction == "forward" && endPage < totalPages)
        {
            startPage = endPage + 1;
            if (endPage + pagerSize < totalPages)
            {
                endPage = startPage + pagerSize - 1;
            }
            else
            {
                endPage = totalPages;
            }
            this.StateHasChanged();
        }
        else if (direction == "back" && startPage > 1)
        {
            endPage = startPage - 1;
            startPage = startPage - pagerSize;
        }
        else
        {
            startPage = 1;
            endPage = totalPages;
        }
    }
    public async Task NavigateToPage(string direction)
    {
        if (direction == "next")
        {
            if (curPage < totalPages)
            {
                if (curPage == endPage)
                {
                    SetPagerSize("forward");
                }
                curPage += 1;
            }
        }
        else if (direction == "previous")
        {
            if (curPage > 1)
            {
                if (curPage == startPage)
                {
                    SetPagerSize("back");
                }
                curPage -= 1;
            }
        }
        await refreshRecords(curPage);
    }
    public void FilterRecords()
    {
        endPage = 0;
        this.OnInitializedAsync().Wait();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
