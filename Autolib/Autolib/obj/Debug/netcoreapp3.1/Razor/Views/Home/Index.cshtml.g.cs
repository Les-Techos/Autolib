#pragma checksum "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f57adacaae898de76defab321bcf028553e18d02"
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
#line 1 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\_ViewImports.cshtml"
using Autolib.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f57adacaae898de76defab321bcf028553e18d02", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf9ef8183c4b9a4737e68ffa525cefee29b2fe7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div id=\"map\">\r\n    <!-- Ici s\'affichera la carte -->\r\n</div>\r\n<script src=\"https://unpkg.com/leaflet@1.3.1/dist/leaflet.js\" integrity=\"sha512-/Nsx9X4HebavoBvEBuyp3I7od5tA0UzAxs+j83KgC8PU0kgB4XiK4Lfe4y4cgBtaRJQEIFCW+oC506aPT2L1zw==\"");
            BeginWriteAttribute("crossorigin", " crossorigin=\"", 330, "\"", 344, 0);
            EndWriteAttribute();
            WriteLiteral(@"></script>
<script type='text/javascript' src='https://unpkg.com/leaflet.markercluster@1.3.0/dist/leaflet.markercluster.js'></script>
<script type=""text/javascript"">
    // On initialise la latitude et la longitude de Paris (centre de la carte)
    var lat = 48.852969;
    var lon = 2.349903;
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
#line 26 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
         if (Model != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
     foreach (var st in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t");
            WriteLiteral("var element = {};\r\n\t\t");
            WriteLiteral("element.id = \"ID : ");
#nullable restore
#line 31 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                        Write(st.IdStation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.Adresse = \"Adresse : ");
#nullable restore
#line 32 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                                  Write(st.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.Numero = \"Numéro : ");
#nullable restore
#line 33 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                                Write(st.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.Ville = \"Ville : ");
#nullable restore
#line 34 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                              Write(st.Ville);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral(" element.CodePostal = \"Code Postal : ");
#nullable restore
#line 35 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                                          Write(st.CodePostal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\t\t");
            WriteLiteral("element.lat = ");
#nullable restore
#line 36 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                   Write(double.Parse(@st.Latitude.ToString(), new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /1000000;\r\n\t\t");
            WriteLiteral("element.lon = ");
#nullable restore
#line 37 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
                   Write(double.Parse(@st.Longitude.ToString(), new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /1000000;\r\n        ");
            WriteLiteral("stations.push(element );\r\n");
#nullable restore
#line 39 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"

	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\A les docs de Romain\Superieur\Semestre 5\isi c#\Autolib\Autolib\Autolib\Autolib\Views\Home\Index.cshtml"
     
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
        for (station in stations) {

			var marker = L.marker([stations[station].lat, stations[station].lon]); // pas de addTo(macarte), l'affichage sera géré par la bibliothèque des clusters
            var popup = L.popup().setContent(stations[station].id + ""<br/>"" + stations");
            WriteLiteral(@"[station].Adresse + ""<br/>"" + stations[station].Numero + ""<br/>"" + stations[station].Ville + ""<br/>"" + stations[station].CodePostal );
			marker.bindPopup(popup);
			markerClusters.addLayer(marker); // Nous ajoutons le marqueur aux groupes
			markers.push(marker); // Nous ajoutons le marqueur à la liste des marqueurs
		}
		var group = new L.featureGroup(markers); // Nous créons le groupe des marqueurs pour adapter le zoom
		macarte.fitBounds(group.getBounds().pad(0.5)); // Nous demandons à ce que tous les marqueurs soient visibles, et ajoutons un padding (pad(0.5)) pour que les marqueurs ne soient pas coupés
		macarte.addLayer(markerClusters);
	}
              window.onload = function () {


                  // Fonction d'initialisation qui s'exécute lorsque le DOM est chargé
                  initMap();
              };
</script>
");
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
