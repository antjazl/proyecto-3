<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPrueba.Master" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="Interfaces.Prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphFrameLogo" runat="server">
     <table style="width: 100%">
        <tr>
	        <td style="width: 50%">
			    <asp:Image ID="imgLogoFaunaWebEcuador" runat ="server" ImageUrl="~/Recursos/logosNuevos/amphibiaweb.jpg" />		
		    </td>
		    <td style="width: 50%;" align="right">
		         <asp:ImageButton ID="Image3" runat ="server" ImageUrl="~/Recursos/logosNuevos/anfibia1.jpg" PostBackUrl="~/anfibios/AnfibiosEcuador/Default.aspx" ToolTip="AmphibiaWebEcuador" />
		         <asp:ImageButton ID="Image4" runat ="server" ImageUrl="~/Recursos/logosNuevos/mammalia2.jpg" PostBackUrl ="~/mamiferos/MamiferosEcuador/Default.aspx" ToolTip="MammaliaWebEcuador"/>
		         <asp:ImageButton ID="Image5" runat ="server" ImageUrl="~/Recursos/logosNuevos/reptilia3.jpg" PostBackUrl ="~/reptiles/ReptilesEcuador/Default.aspx" ToolTip="ReptiliaWebEcuador" />
		         <asp:ImageButton ID="Image6" runat ="server" ImageUrl="~/Recursos/logosNuevos/aves4.jpg"  PostBackUrl ="~/aves/AvesEcuador/Default.aspx" ToolTip="AvesWebEcuador"/>	
		    </td>
    		
	    </tr>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphTitulo" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphContenido" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="cphBuscar" runat="server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="cphSubMenu" runat="server">
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="cphVideos" runat="server">
</asp:Content>
<asp:Content ID="Content8" ContentPlaceHolderID="cphLogo" runat="server">
</asp:Content>
