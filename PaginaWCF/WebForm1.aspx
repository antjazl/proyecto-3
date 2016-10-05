<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PaginaWCF.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="seleccionarTaxaPorId" TypeName="PaginaWCF.Service_Taxa_WCF.ServiceWCFTaxaClient">
            <SelectParameters>
                <asp:QueryStringParameter Name="idTaxa" QueryStringField="Id" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="seleccionarTaxa" TypeName="PaginaWCF.Service_Taxa_WCF.ServiceWCFTaxaClient"></asp:ObjectDataSource>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="ObjectDataSource1" OnPageIndexChanging="FormView1_PageIndexChanging">
            <EditItemTemplate>
                ExtensionData:
                <asp:TextBox ID="ExtensionDataTextBox" runat="server" Text='<%# Bind("ExtensionData") %>' />
                <br />
                Ano:
                <asp:TextBox ID="AnoTextBox" runat="server" Text='<%# Bind("Ano") %>' />
                <br />
                EnEcuador:
                <asp:CheckBox ID="EnEcuadorCheckBox" runat="server" Checked='<%# Bind("EnEcuador") %>' />
                <br />
                Endemica:
                <asp:CheckBox ID="EndemicaCheckBox" runat="server" Checked='<%# Bind("Endemica") %>' />
                <br />
                FechaModificacion:
                <asp:TextBox ID="FechaModificacionTextBox" runat="server" Text='<%# Bind("FechaModificacion") %>' />
                <br />
                IdCatalogo:
                <asp:TextBox ID="IdCatalogoTextBox" runat="server" Text='<%# Bind("IdCatalogo") %>' />
                <br />
                IdPublicacionReporte:
                <asp:TextBox ID="IdPublicacionReporteTextBox" runat="server" Text='<%# Bind("IdPublicacionReporte") %>' />
                <br />
                IdTaxa:
                <asp:TextBox ID="IdTaxaTextBox" runat="server" Text='<%# Bind("IdTaxa") %>' />
                <br />
                IdTaxaPadre:
                <asp:TextBox ID="IdTaxaPadreTextBox" runat="server" Text='<%# Bind("IdTaxaPadre") %>' />
                <br />
                Nombre:
                <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                <br />
                NombreCorto:
                <asp:TextBox ID="NombreCortoTextBox" runat="server" Text='<%# Bind("NombreCorto") %>' />
                <br />
                PublicarEnWeb:
                <asp:CheckBox ID="PublicarEnWebCheckBox" runat="server" Checked='<%# Bind("PublicarEnWeb") %>' />
                <br />
                UsuarioModificacion:
                <asp:TextBox ID="UsuarioModificacionTextBox" runat="server" Text='<%# Bind("UsuarioModificacion") %>' />
                <br />
                especies:
                <asp:TextBox ID="especiesTextBox" runat="server" Text='<%# Bind("especies") %>' />
                <br />
                especimen:
                <asp:TextBox ID="especimenTextBox" runat="server" Text='<%# Bind("especimen") %>' />
                <br />
                multimedias:
                <asp:TextBox ID="multimediasTextBox" runat="server" Text='<%# Bind("multimedias") %>' />
                <br />
                nombrecomuns:
                <asp:TextBox ID="nombrecomunsTextBox" runat="server" Text='<%# Bind("nombrecomuns") %>' />
                <br />
                ordenamientotaxas:
                <asp:TextBox ID="ordenamientotaxasTextBox" runat="server" Text='<%# Bind("ordenamientotaxas") %>' />
                <br />
                sinonimoes:
                <asp:TextBox ID="sinonimoesTextBox" runat="server" Text='<%# Bind("sinonimoes") %>' />
                <br />
                taxa1:
                <asp:TextBox ID="taxa1TextBox" runat="server" Text='<%# Bind("taxa1") %>' />
                <br />
                taxa2:
                <asp:TextBox ID="taxa2TextBox" runat="server" Text='<%# Bind("taxa2") %>' />
                <br />
                taxapublicacions:
                <asp:TextBox ID="taxapublicacionsTextBox" runat="server" Text='<%# Bind("taxapublicacions") %>' />
                <br />
                tipoes:
                <asp:TextBox ID="tipoesTextBox" runat="server" Text='<%# Bind("tipoes") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                ExtensionData:
                <asp:TextBox ID="ExtensionDataTextBox" runat="server" Text='<%# Bind("ExtensionData") %>' />
                <br />
                Ano:
                <asp:TextBox ID="AnoTextBox" runat="server" Text='<%# Bind("Ano") %>' />
                <br />
                EnEcuador:
                <asp:CheckBox ID="EnEcuadorCheckBox" runat="server" Checked='<%# Bind("EnEcuador") %>' />
                <br />
                Endemica:
                <asp:CheckBox ID="EndemicaCheckBox" runat="server" Checked='<%# Bind("Endemica") %>' />
                <br />
                FechaModificacion:
                <asp:TextBox ID="FechaModificacionTextBox" runat="server" Text='<%# Bind("FechaModificacion") %>' />
                <br />
                IdCatalogo:
                <asp:TextBox ID="IdCatalogoTextBox" runat="server" Text='<%# Bind("IdCatalogo") %>' />
                <br />
                IdPublicacionReporte:
                <asp:TextBox ID="IdPublicacionReporteTextBox" runat="server" Text='<%# Bind("IdPublicacionReporte") %>' />
                <br />
                IdTaxa:
                <asp:TextBox ID="IdTaxaTextBox" runat="server" Text='<%# Bind("IdTaxa") %>' />
                <br />
                IdTaxaPadre:
                <asp:TextBox ID="IdTaxaPadreTextBox" runat="server" Text='<%# Bind("IdTaxaPadre") %>' />
                <br />
                Nombre:
                <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                <br />
                NombreCorto:
                <asp:TextBox ID="NombreCortoTextBox" runat="server" Text='<%# Bind("NombreCorto") %>' />
                <br />
                PublicarEnWeb:
                <asp:CheckBox ID="PublicarEnWebCheckBox" runat="server" Checked='<%# Bind("PublicarEnWeb") %>' />
                <br />
                UsuarioModificacion:
                <asp:TextBox ID="UsuarioModificacionTextBox" runat="server" Text='<%# Bind("UsuarioModificacion") %>' />
                <br />
                especies:
                <asp:TextBox ID="especiesTextBox" runat="server" Text='<%# Bind("especies") %>' />
                <br />
                especimen:
                <asp:TextBox ID="especimenTextBox" runat="server" Text='<%# Bind("especimen") %>' />
                <br />
                multimedias:
                <asp:TextBox ID="multimediasTextBox" runat="server" Text='<%# Bind("multimedias") %>' />
                <br />
                nombrecomuns:
                <asp:TextBox ID="nombrecomunsTextBox" runat="server" Text='<%# Bind("nombrecomuns") %>' />
                <br />
                ordenamientotaxas:
                <asp:TextBox ID="ordenamientotaxasTextBox" runat="server" Text='<%# Bind("ordenamientotaxas") %>' />
                <br />
                sinonimoes:
                <asp:TextBox ID="sinonimoesTextBox" runat="server" Text='<%# Bind("sinonimoes") %>' />
                <br />
                taxa1:
                <asp:TextBox ID="taxa1TextBox" runat="server" Text='<%# Bind("taxa1") %>' />
                <br />
                taxa2:
                <asp:TextBox ID="taxa2TextBox" runat="server" Text='<%# Bind("taxa2") %>' />
                <br />
                taxapublicacions:
                <asp:TextBox ID="taxapublicacionsTextBox" runat="server" Text='<%# Bind("taxapublicacions") %>' />
                <br />
                tipoes:
                <asp:TextBox ID="tipoesTextBox" runat="server" Text='<%# Bind("tipoes") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                ExtensionData:
                <asp:Label ID="ExtensionDataLabel" runat="server" Text='<%# Bind("ExtensionData") %>' />
                <br />
                Ano:
                <asp:Label ID="AnoLabel" runat="server" Text='<%# Bind("Ano") %>' />
                <br />
                EnEcuador:
                <asp:CheckBox ID="EnEcuadorCheckBox" runat="server" Checked='<%# Bind("EnEcuador") %>' Enabled="false" />
                <br />
                Endemica:
                <asp:CheckBox ID="EndemicaCheckBox" runat="server" Checked='<%# Bind("Endemica") %>' Enabled="false" />
                <br />
                FechaModificacion:
                <asp:Label ID="FechaModificacionLabel" runat="server" Text='<%# Bind("FechaModificacion") %>' />
                <br />
                IdCatalogo:
                <asp:Label ID="IdCatalogoLabel" runat="server" Text='<%# Bind("IdCatalogo") %>' />
                <br />
                IdPublicacionReporte:
                <asp:Label ID="IdPublicacionReporteLabel" runat="server" Text='<%# Bind("IdPublicacionReporte") %>' />
                <br />
                IdTaxa:
                <asp:Label ID="IdTaxaLabel" runat="server" Text='<%# Bind("IdTaxa") %>' />
                <br />
                IdTaxaPadre:
                <asp:Label ID="IdTaxaPadreLabel" runat="server" Text='<%# Bind("IdTaxaPadre") %>' />
                <br />
                Nombre:
                <asp:Label ID="NombreLabel" runat="server" Text='<%# Bind("Nombre") %>' />
                <br />
                NombreCorto:
                <asp:Label ID="NombreCortoLabel" runat="server" Text='<%# Bind("NombreCorto") %>' />
                <br />
                PublicarEnWeb:
                <asp:CheckBox ID="PublicarEnWebCheckBox" runat="server" Checked='<%# Bind("PublicarEnWeb") %>' Enabled="false" />
                <br />
                UsuarioModificacion:
                <asp:Label ID="UsuarioModificacionLabel" runat="server" Text='<%# Bind("UsuarioModificacion") %>' />
                <br />
                especies:
                <asp:Label ID="especiesLabel" runat="server" Text='<%# Bind("especies") %>' />
                <br />
                especimen:
                <asp:Label ID="especimenLabel" runat="server" Text='<%# Bind("especimen") %>' />
                <br />
                multimedias:
                <asp:Label ID="multimediasLabel" runat="server" Text='<%# Bind("multimedias") %>' />
                <br />
                nombrecomuns:
                <asp:Label ID="nombrecomunsLabel" runat="server" Text='<%# Bind("nombrecomuns") %>' />
                <br />
                ordenamientotaxas:
                <asp:Label ID="ordenamientotaxasLabel" runat="server" Text='<%# Bind("ordenamientotaxas") %>' />
                <br />
                sinonimoes:
                <asp:Label ID="sinonimoesLabel" runat="server" Text='<%# Bind("sinonimoes") %>' />
                <br />
                taxa1:
                <asp:Label ID="taxa1Label" runat="server" Text='<%# Bind("taxa1") %>' />
                <br />
                taxa2:
                <asp:Label ID="taxa2Label" runat="server" Text='<%# Bind("taxa2") %>' />
                <br />
                taxapublicacions:
                <asp:Label ID="taxapublicacionsLabel" runat="server" Text='<%# Bind("taxapublicacions") %>' />
                <br />
                tipoes:
                <asp:Label ID="tipoesLabel" runat="server" Text='<%# Bind("tipoes") %>' />
                <br />

            </ItemTemplate>
        </asp:FormView>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
            <Columns>
                <asp:BoundField DataField="Ano" HeaderText="Ano" SortExpression="Ano" />
                <asp:CheckBoxField DataField="EnEcuador" HeaderText="EnEcuador" SortExpression="EnEcuador" />
                <asp:CheckBoxField DataField="Endemica" HeaderText="Endemica" SortExpression="Endemica" />
                <asp:BoundField DataField="FechaModificacion" HeaderText="FechaModificacion" SortExpression="FechaModificacion" />
                <asp:BoundField DataField="IdCatalogo" HeaderText="IdCatalogo" SortExpression="IdCatalogo" />
                <asp:BoundField DataField="IdPublicacionReporte" HeaderText="IdPublicacionReporte" SortExpression="IdPublicacionReporte" />
                <asp:BoundField DataField="IdTaxa" HeaderText="IdTaxa" SortExpression="IdTaxa" />
                <asp:BoundField DataField="IdTaxaPadre" HeaderText="IdTaxaPadre" SortExpression="IdTaxaPadre" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="NombreCorto" HeaderText="NombreCorto" SortExpression="NombreCorto" />
                <asp:CheckBoxField DataField="PublicarEnWeb" HeaderText="PublicarEnWeb" SortExpression="PublicarEnWeb" />
                <asp:BoundField DataField="UsuarioModificacion" HeaderText="UsuarioModificacion" SortExpression="UsuarioModificacion" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
