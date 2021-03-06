#pragma checksum "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c638b93ad56aa233400490b0f074dd65620361d"
// <auto-generated/>
#pragma warning disable 1591
namespace Facturation.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Facturation.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/_Imports.razor"
using Facturation.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    table > tfoot > tr {\n        background-color: #c9efff;\n        border-top: 1px solid #4eacd4 !important;\n    }\n\n        table > tfoot > tr > td {\n            text-align: right;\n            font-weight: bold;\n        }\n</style>\n\n");
            __builder.AddMarkupContent(1, "<h1>Factures</h1>\n\n    ");
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Client</th>\n            <th>Numéro</th>\n            <th>Date Emission</th>\n            <th>Date Réglement</th>\n            <th>Montant Dû</th>\n            <th>Montant Réglé</th>\n            <th>Reste à recevoir</th></tr></thead>\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 34 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
          
            float totalDu = 0;
            float totalRegle = 0;
            float totalReste = 0;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
         foreach (var facture in lesFactures)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 43 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.Client

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 46 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.Numero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 49 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.DateEmission

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 52 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.DateReglement

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "style", "text-align: right");
            __builder.AddContent(21, 
#nullable restore
#line 55 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.MontantDu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "text-align: right");
            __builder.AddContent(25, 
#nullable restore
#line 58 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.MontantRegle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "style", "text-align: right");
            __builder.AddContent(29, 
#nullable restore
#line 61 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                     facture.ResteARecevoir

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"

            totalDu += facture.MontantDu;
            totalRegle += facture.MontantRegle;
            totalReste += facture.ResteARecevoir;

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n        ");
            __builder.OpenElement(31, "tfoot");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "<td colspan=\"4\"></td>\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 75 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                 totalDu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 78 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                 totalRegle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 81 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
                 totalReste

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "/Users/louis/Documents/Ecole/DEV/C#/FacturationNew/Facturation/Client/Pages/FetchData.razor"
  

        private IEnumerable<Facture> lesFactures = null;
        
        protected override async Task OnInitializedAsync()
        {
            lesFactures = await http.GetFromJsonAsync<IEnumerable<Facture>>("api/facture");
        }
        

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
