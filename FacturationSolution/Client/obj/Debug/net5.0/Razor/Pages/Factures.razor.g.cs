#pragma checksum "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "146c423becb3910dd8d4c14cb57ea0e322f6e0d6"
// <auto-generated/>
#pragma warning disable 1591
namespace FacturationSolution.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using FacturationSolution.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using FacturationSolution.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\_Imports.razor"
using FacturationSolution.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Factures")]
    public partial class Factures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Factures</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>Retrouver ici toute les informations sur vos factures!</p>");
#nullable restore
#line 7 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
 if (listefactures == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p>Interrogation du serveur...</p>");
#nullable restore
#line 10 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "{\r\n\r\nelse\r\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "<thead><tr><th>client</th>\r\n            <th>emission</th>\r\n            <th>reglementation</th>\r\n            <th>numero</th>\r\n            <th>montants_du</th>\r\n            <th>montants_regler</th></tr></thead>\r\n    ");
            __builder.OpenElement(7, "tbody");
#nullable restore
#line 26 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
         foreach (var facture in listefactures)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "tr");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 29 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
                     facture.client

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 30 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
                     facture.emission

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 31 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
                     facture.reglementation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 32 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
                     facture.numero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 33 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
                     facture.montants_du

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 34 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
                     facture.montants_regler

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n}\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\COURS EPSI\Environnement net\FacturationSolution\FacturationSolution\Client\Pages\Factures.razor"
       
    private IEnumerable<FactureClient> listefactures;

    protected override async Task OnInitializedAsync()
    {
        listefactures = await http.GetFromJsonAsync<IEnumerable<FactureClient>>("api/invoices");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
