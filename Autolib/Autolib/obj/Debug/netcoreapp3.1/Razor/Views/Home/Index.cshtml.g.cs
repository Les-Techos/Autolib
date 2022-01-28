#pragma checksum "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad11d45fed44557f694488d77390b3d0bc69340"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Polytech\Autolib\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Polytech\Autolib\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad11d45fed44557f694488d77390b3d0bc69340", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9ef8183c4b9a4737e68ffa525cefee29b2fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/svg-icon.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"map\">\r\n    <!-- Ici s\'affichera la carte -->\r\n</div>\r\n\r\n<script src=\"https://unpkg.com/leaflet@1.3.1/dist/leaflet.js\" integrity=\"sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw==\"");
            BeginWriteAttribute("crossorigin", " crossorigin=\"", 332, "\"", 346, 0);
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<script type=\'text/javascript\' src=\'https://unpkg.com/leaflet.markercluster@1.3.0/dist/leaflet.markercluster.js\'></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aad11d45fed44557f694488d77390b3d0bc693404194", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    // On initialise la latitude et la longitude de Paris (centre de la carte)
    var lat = 45.756862;
    var lon = 4.836159;
    var macarte = null;
    var stations = [];
    var markerClusters; // Servira à stocker les groupes de marqueurs
    // Nous initialisons une liste de marqueurs

    // Fonction d'initialisation de la carte
    function initMap() {
		var markers = []; // Nous initialisons la liste des marqueurs
		// Nous définissons le dossier qui contiendra les marqueurs
");
#nullable restore
#line 28 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
         if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
     foreach (var st in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t");
            WriteLiteral("var element = {};\r\n\t\t");
            WriteLiteral("element.id = \"ID : ");
#nullable restore
#line 33 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                        Write(st.IdStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.Adresse = \"Adresse : ");
#nullable restore
#line 34 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                                  Write(st.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.Numero = \"Numéro : ");
#nullable restore
#line 35 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                                Write(st.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.Ville = \"Ville : ");
#nullable restore
#line 36 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                              Write(st.Ville);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral(" element.CodePostal = \"Code Postal : ");
#nullable restore
#line 37 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                                          Write(st.CodePostal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.lat = ");
#nullable restore
#line 38 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                   Write(double.Parse(@st.Latitude.ToString(), new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /1000000;\r\n\t\t");
            WriteLiteral("element.lon = ");
#nullable restore
#line 39 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                   Write(double.Parse(@st.Longitude.ToString(), new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /1000000;\r\n        ");
            WriteLiteral("stations.push(element );\r\n");
#nullable restore
#line 41 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"

	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\Polytech\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		var iconBase = 'http://localhost/carte/icons/';
		// Créer l'objet ""macarte"" et l'insèrer dans l'élément HTML qui a l'ID ""map""
		macarte = L.map('map').setView([lat, lon], 11);
		markerClusters = L.markerClusterGroup(); // Nous initialisons les groupes de marqueurs
		// Leaflet ne récupère pas les cartes (tiles) sur un serveur par défaut. Nous devons lui préciser où nous souhaitons les récupérer. Ici, openstreetmap.fr
		L.tileLayer('https://{s}.tile.openstreetmap.fr/osmfr/{z}/{x}/{y}.png', {
			// Il est toujours bien de laisser le lien vers la source des données
			attribution: 'données © OpenStreetMap/ODbL - rendu OSM France',
			minZoom: 1,
			maxZoom: 20
		}).addTo(macarte);
        // Nous parcourons la liste des villes
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(function (position) {
                var latlng = {};
                latlng.lat = position.coords.latitude;
                latlng.lng = position.coords.longitude;
              ");
            WriteLiteral(@"  var marker = new L.Marker.SVGMarker(latlng, { iconOptions: { color: ""rgb(226,0,26)"", fillOpacity: 1} }); // pas de addTo(macarte), l'affichage sera géré par la bibliothèque des clusters
            var popup = L.popup().setContent(""Vous êtes ici"");
            marker.bindPopup(popup);
            //marker._icon.classList.add(""posClient"")
            markerClusters.addLayer(marker); // Nous ajoutons le marqueur aux groupes

            markers.push(marker);
        });
        }
        
        for (station in stations) {
            var latlng = {};
            latlng.lat = stations[station].lat;
            latlng.lng = stations[station].lon;
            var buttonPopup = """";
            buttonPopup += stations[station].id + ""<br/>"" + stations[station].Adresse + ""<br/>"" + stations[station].Numero + ""<br/>"" + stations[station].Ville + ""<br/>"" + stations[station].CodePostal;
            buttonPopup += '<form method=""POST"" action=""/Reservations""><input type = ""hidden"" id = ""numeroStation"" nam");
            WriteLiteral(@"e = ""numeroStation"" value = '+ station.id + ' /><input type=""submit"" class=""btn btn-primary"" id=""Reserve"" name=""Reserve"" value=""Réserver une auto ici"" /></form > ';
            
            var marker = new L.Marker.SVGMarker(latlng, { iconOptions: { color: ""rgb(0,158,224)"", fillOpacity: 1 } });; // pas de addTo(macarte), l'affichage sera géré par la bibliothèque des clusters
            var popup = L.popup().setContent(buttonPopup);
			marker.bindPopup(popup);
			markerClusters.addLayer(marker); // Nous ajoutons le marqueur aux groupes
			markers.push(marker); // Nous ajoutons le marqueur à la liste des marqueurs
		}
        
		var group = new L.featureGroup(markers); // Nous créons le groupe des marqueurs pour adapter le zoom
		macarte.fitBounds(group.getBounds().pad(0.5)); // Nous demandons à ce que tous les marqueurs soient visibles, et ajoutons un padding (pad(0.5)) pour que les marqueurs ne soient pas coupés
		macarte.addLayer(markerClusters);
	}
              window.onload = function () {");
            WriteLiteral("\n\r\n\r\n                  // Fonction d\'initialisation qui s\'exécute lorsque le DOM est chargé\r\n                  initMap();\r\n              };\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
