#pragma checksum "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "782506144cbe80fc959dbd1f6bf5bd6a48faae06"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Employeelist : EmployeeList
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
#nullable restore
#line 8 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
     if (employees != null)
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
     foreach (var employee in employees)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-header");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, 
#nullable restore
#line 15 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
                     employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
                                         employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "card-img-top");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 18 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
                                            employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-footer text-center");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "href", 
#nullable restore
#line 20 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
                           $"employedetails/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "class", "btn btn-primary m-1");
            __builder.AddContent(21, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.AddMarkupContent(23, "<a href=\"#\" class=\"btn btn-primary m-1\">Edit</a>\r\n                ");
            __builder.AddMarkupContent(24, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"


    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\AbhisheekHayagreev\OneDrive - Genzeon Corporation\Desktop\Blazor_API\BlazorTutorial\EmployeeManagement.Web\Pages\Employeelist.razor"
     
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591