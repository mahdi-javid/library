#pragma checksum "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d3b76e26f3f53ad7b05a6485aabbcb085e68656"
// <auto-generated/>
#pragma warning disable 1591
namespace WebAppHelloWorld.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using WebAppHelloWorld;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\_Imports.razor"
using BookFinder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<link rel=""stylesheet"" href=""MyCss/index.css"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"" integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">  
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css"" integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">     

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container h-100");
            __builder.AddAttribute(3, "style", "margin-top: 10rem; margin-bottom: 10rem;");
            __builder.AddMarkupContent(4, "    \r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex justify-content-center h-100");
            __builder.AddMarkupContent(7, "        \r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                             search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                    FindBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(15);
                __builder2.AddAttribute(16, "style", "color: white; display: block;");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "                \r\n                ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "searchbar");
                __builder2.AddMarkupContent(20, "                \r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "search_input");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                            search.BookName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => search.BookName = __value, search.BookName))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => search.BookName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "                \r\n                    ");
                __builder2.AddMarkupContent(27, "<button class=\"search_icon\" type=\"submit\"><i class=\"fas fa-search\"></i></button>\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "        \r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(29, "        \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "    \r\n");
#nullable restore
#line 22 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
     if (Books.Count != 0)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
         foreach (Book book in Books)
        {            

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "            ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
            __builder.AddAttribute(34, "style", "margin-top: 10rem;");
            __builder.AddMarkupContent(35, "        \r\n                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card");
            __builder.AddAttribute(38, "style", "width: 18rem;");
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 28 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                           book.ImagePath

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "class", "card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-body");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "h5");
            __builder.AddAttribute(48, "class", "card-title");
            __builder.AddContent(49, 
#nullable restore
#line 30 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                            book.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "p");
            __builder.AddAttribute(52, "class", "card-text");
            __builder.AddContent(53, 
#nullable restore
#line 31 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                          book.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "  \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "          \r\n");
            __builder.AddContent(58, "            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "row");
            __builder.AddAttribute(61, "style", "background-color: white;");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-md-11 col-sm-12 p-4");
            __builder.AddMarkupContent(65, "\r\n                    ");
            __builder.OpenElement(66, "label");
            __builder.AddContent(67, "Smooth ");
            __Blazor.WebAppHelloWorld.Pages.Index.TypeInference.CreateRadzenCheckBox_0(__builder, 68, 69, "smooth", 70, 
#nullable restore
#line 38 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                                smooth

#line default
#line hidden
#nullable disable
            , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => smooth = __value, smooth)), 72, () => smooth);
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenChart>(74);
            __builder.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(76, "\r\n                        ");
                __Blazor.WebAppHelloWorld.Pages.Index.TypeInference.CreateRadzenLineSeries_1(__builder2, 77, 78, 
#nullable restore
#line 40 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                   smooth

#line default
#line hidden
#nullable disable
                , 79, 
#nullable restore
#line 40 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                                  analysor.Datas[@book.Name]

#line default
#line hidden
#nullable disable
                , 80, "Words", 81, 
#nullable restore
#line 40 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                                                                                               book.Name

#line default
#line hidden
#nullable disable
                , 82, "RiseOrFall", 83, (__builder3) => {
                    __builder3.AddMarkupContent(84, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenMarkers>(85);
                    __builder3.AddAttribute(86, "MarkerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.Blazor.MarkerType>(
#nullable restore
#line 41 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                       MarkerType.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenCategoryAxis>(89);
                __builder2.AddAttribute(90, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 43 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                     20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "Formatter", new System.Func<System.Object, System.String>(
#nullable restore
#line 43 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                                     Total_Words

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "     \r\n                        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenValueAxis>(93);
                __builder2.AddAttribute(94, "Formatter", new System.Func<System.Object, System.String>(
#nullable restore
#line 44 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                     NegativeOrPositive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(96, " \r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridLines>(97);
                    __builder3.AddAttribute(98, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                                                      true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(99, "\r\n                            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenAxisTitle>(100);
                    __builder3.AddAttribute(101, "Text", "Analysing Books");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(102, "\r\n                        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "                  \r\n");
            __builder.AddContent(107, "            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "row");
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.OpenElement(111, "table");
            __builder.AddAttribute(112, "class", "table");
            __builder.AddMarkupContent(113, "\r\n                ");
            __builder.AddMarkupContent(114, @"<thead class=""thead-dark"">
                    <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Words</th>
                    <th scope=""col"">Positive Words</th>
                    <th scope=""col"">Negative Words</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(115, "tbody");
            __builder.AddAttribute(116, "style", "background-color: white;");
            __builder.AddMarkupContent(117, "\r\n                    ");
            __builder.OpenElement(118, "tr");
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.AddMarkupContent(120, "<th scope=\"row\">1</th>\r\n                    ");
            __builder.OpenElement(121, "td");
            __builder.AddContent(122, 
#nullable restore
#line 65 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                         book.count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                    ");
            __builder.OpenElement(124, "td");
            __builder.AddContent(125, 
#nullable restore
#line 66 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                         book.positive

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n                    ");
            __builder.OpenElement(127, "td");
            __builder.AddContent(128, 
#nullable restore
#line 67 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
                         book.negative

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "                             \r\n");
#nullable restore
#line 72 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\git\AP98992\TA\AW13\WebAppHelloWorld\Pages\Index.razor"
 
    Search search = new Search();
    bool smooth = true; // male nemodar hast
    List <Book> Books = new List <Book> ();    
    public void FindBook() {        
        foreach(Book book in lib.Books) 
            if (book.Name.ToLower().Contains(search.BookName.ToLower()) && !string.IsNullOrEmpty(search.BookName))
                Books.Add(book);
    }
    public string Total_Words(object category) => category.ToString(); // nemodar // Formatter
    public string NegativeOrPositive(object value) => value.ToString(); // nemodar // Formatter
    protected override void OnInitialized()
    {
        int positive = 0;
        int negative = 0;
        int count = 0;

        foreach (Book book in lib.Books)
        {
            foreach(DataItem di in analysor.Datas[book.Name])
            {
                count += di.Words;
                positive += di.PositiveWords;
                negative += di.NegativeWords;
            }                
            book.positive = positive;
            book.negative = negative;
            book.count = count;            
        }            
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Analyzer analysor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Library lib { get; set; }
    }
}
namespace __Blazor.WebAppHelloWorld.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenCheckBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenCheckBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Name", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateRadzenLineSeries_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TItem> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenLineSeries<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Smooth", __arg0);
        __builder.AddAttribute(__seq1, "Data", __arg1);
        __builder.AddAttribute(__seq2, "CategoryProperty", __arg2);
        __builder.AddAttribute(__seq3, "Title", __arg3);
        __builder.AddAttribute(__seq4, "ValueProperty", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591