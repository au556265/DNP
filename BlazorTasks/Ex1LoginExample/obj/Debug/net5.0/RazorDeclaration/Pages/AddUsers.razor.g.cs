// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Ex1LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Ex1LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\_Imports.razor"
using Ex1LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddUsers.razor"
using Ex1LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddUsers.razor"
using Ex1LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddUsers.razor"
using Ex1LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddUsers.razor"
using Microsoft.AspNetCore.Cors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddUsers.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddUsers")]
    public partial class AddUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddUsers.razor"
       
    private User newUserItem = new User();
    public bool message;
    private string errorMsg = "";
    private async Task AddNewUser()
    {
        try
        {
            await InjectedUserService.RegisterUser(newUserItem);
            message = true;
            errorMsg = "";
            StateHasChanged();
            await Task.Delay(2000);
            newUserItem = new User();
            message = false;
        }
        catch (Exception e)
        {
            errorMsg = e.Message;
        }
        
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService InjectedUserService { get; set; }
    }
}
#pragma warning restore 1591
