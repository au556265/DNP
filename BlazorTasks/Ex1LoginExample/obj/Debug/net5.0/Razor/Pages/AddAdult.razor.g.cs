#pragma checksum "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea035778b1d6c9d4399c45c8bd8ac6d40de96e9e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
using Ex1LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
using Ex1LoginExample.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddAdult</h3>\r\n\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                          newAdultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                        AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "Job title<br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(12);
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                newAdultItem.JobPosition.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.JobPosition.JobTitle = __value, newAdultItem.JobPosition.JobTitle))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.JobPosition.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        \r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "Salary<br>\r\n                    ");
                __Blazor.Ex1LoginExample.Pages.AddAdult.TypeInference.CreateInputNumber_0(__builder2, 20, 21, 
#nullable restore
#line 19 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                              newAdultItem.JobPosition.Salary

#line default
#line hidden
#nullable disable
                , 22, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.JobPosition.Salary = __value, newAdultItem.JobPosition.Salary)), 23, () => newAdultItem.JobPosition.Salary);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        \r\n                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "ID <br>\r\n                    ");
                __Blazor.Ex1LoginExample.Pages.AddAdult.TypeInference.CreateInputNumber_1(__builder2, 28, 29, 
#nullable restore
#line 23 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                              newAdultItem.Id

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Id = __value, newAdultItem.Id)), 31, () => newAdultItem.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        \r\n                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "Firstname<br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(36);
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                newAdultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.FirstName = __value, newAdultItem.FirstName))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        \r\n                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "Lastname<br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(44);
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                newAdultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.LastName = __value, newAdultItem.LastName))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        \r\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "Haircolor<br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(52);
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                newAdultItem.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.HairColor = __value, newAdultItem.HairColor))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.HairColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        \r\n                ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "Eyecolor<br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(60);
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                newAdultItem.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.EyeColor = __value, newAdultItem.EyeColor))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.EyeColor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        \r\n                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "Age<br>\r\n                    ");
                __Blazor.Ex1LoginExample.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 68, 69, 
#nullable restore
#line 43 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                              newAdultItem.Age

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Age = __value, newAdultItem.Age)), 71, () => newAdultItem.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        \r\n                ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddMarkupContent(75, "Weight<br>\r\n                    ");
                __Blazor.Ex1LoginExample.Pages.AddAdult.TypeInference.CreateInputNumber_3(__builder2, 76, 77, 
#nullable restore
#line 47 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                              newAdultItem.Weight

#line default
#line hidden
#nullable disable
                , 78, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Weight = __value, newAdultItem.Weight)), 79, () => newAdultItem.Weight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n        \r\n                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "Height<br>\r\n                    ");
                __Blazor.Ex1LoginExample.Pages.AddAdult.TypeInference.CreateInputNumber_4(__builder2, 84, 85, 
#nullable restore
#line 51 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                              newAdultItem.Height

#line default
#line hidden
#nullable disable
                , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Height = __value, newAdultItem.Height)), 87, () => newAdultItem.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        \r\n                ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "Sex <br>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(92);
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
                                                newAdultItem.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdultItem.Sex = __value, newAdultItem.Sex))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdultItem.Sex));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n        \r\n            ");
                __builder2.AddMarkupContent(97, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Create</button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\fatem\RiderProjects\BlazorIntroduction\BlazorTasks\Ex1LoginExample\Pages\AddAdult.razor"
       
    private Adult newAdultItem = new Adult();

    private void AddNewAdult()
    {
        InjectedAdultData.AddAdult(newAdultItem);
        NavigationManager.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsData InjectedAdultData { get; set; }
    }
}
namespace __Blazor.Ex1LoginExample.Pages.AddAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
