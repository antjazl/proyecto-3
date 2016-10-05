<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Interfaces.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="odsTaxa" runat="server" DataObjectTypeName="Interfaces.serviciosTaxa.taxa" DeleteMethod="eliminarTaxa" InsertMethod="insertarTaxa" SelectMethod="SeleccionarTaxas" TypeName="Interfaces.serviciosTaxa.SOAP" UpdateMethod="actualizarTaxa" OnDeleting="odsTaxa_Deleting"></asp:ObjectDataSource>
    
    </div>
        <asp:FormView ID="fvwTaxa" runat="server" DataSourceID="odsTaxa">
            <EditItemTemplate>
                especies:
                <asp:TextBox ID="especiesTextBox" runat="server" Text='<%# Bind("especies") %>' />
                <br />
                multimedias:
                <asp:TextBox ID="multimediasTextBox" runat="server" Text='<%# Bind("multimedias") %>' />
                <br />
                nombrecomuns:
                <asp:TextBox ID="nombrecomunsTextBox" runat="server" Text='<%# Bind("nombrecomuns") %>' />
                <br />
                taxapublicacions:
                <asp:TextBox ID="taxapublicacionsTextBox" runat="server" Text='<%# Bind("taxapublicacions") %>' />
                <br />
                IdTaxa:
                <asp:TextBox ID="IdTaxaTextBox" runat="server" Text='<%# Bind("IdTaxa") %>' />
                <br />
                Nombre:
                <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                <br />
                NombreCorto:
                <asp:TextBox ID="NombreCortoTextBox" runat="server" Text='<%# Bind("NombreCorto") %>' />
                <br />
                EnEcuador:
                <asp:CheckBox ID="EnEcuadorCheckBox" runat="server" Checked='<%# Bind("EnEcuador") %>' />
                <br />
                Endemica:
                <asp:CheckBox ID="EndemicaCheckBox" runat="server" Checked='<%# Bind("Endemica") %>' />
                <br />
                IdTaxaPadre:
                <asp:TextBox ID="IdTaxaPadreTextBox" runat="server" Text='<%# Bind("IdTaxaPadre") %>' />
                <br />
                IdCatalogo:
                <asp:TextBox ID="IdCatalogoTextBox" runat="server" Text='<%# Bind("IdCatalogo") %>' />
                <br />
                PublicarEnWeb:
                <asp:CheckBox ID="PublicarEnWebCheckBox" runat="server" Checked='<%# Bind("PublicarEnWeb") %>' />
                <br />
                FechaModificacion:
                <asp:TextBox ID="FechaModificacionTextBox" runat="server" Text='<%# Bind("FechaModificacion") %>' />
                <br />
                UsuarioModificacion:
                <asp:TextBox ID="UsuarioModificacionTextBox" runat="server" Text='<%# Bind("UsuarioModificacion") %>' />
                <br />
                IdPublicacionReporte:
                <asp:TextBox ID="IdPublicacionReporteTextBox" runat="server" Text='<%# Bind("IdPublicacionReporte") %>' />
                <br />
                Ano:
                <asp:TextBox ID="AnoTextBox" runat="server" Text='<%# Bind("Ano") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </EditItemTemplate>
            <InsertItemTemplate>
                especies:
                <asp:TextBox ID="especiesTextBox" runat="server" Text='<%# Bind("especies") %>' />
                <br />
                multimedias:
                <asp:TextBox ID="multimediasTextBox" runat="server" Text='<%# Bind("multimedias") %>' />
                <br />
                nombrecomuns:
                <asp:TextBox ID="nombrecomunsTextBox" runat="server" Text='<%# Bind("nombrecomuns") %>' />
                <br />
                taxapublicacions:
                <asp:TextBox ID="taxapublicacionsTextBox" runat="server" Text='<%# Bind("taxapublicacions") %>' />
                <br />
                IdTaxa:
                <asp:TextBox ID="IdTaxaTextBox" runat="server" Text='<%# Bind("IdTaxa") %>' />
                <br />
                Nombre:
                <asp:TextBox ID="NombreTextBox" runat="server" Text='<%# Bind("Nombre") %>' />
                <br />
                NombreCorto:
                <asp:TextBox ID="NombreCortoTextBox" runat="server" Text='<%# Bind("NombreCorto") %>' />
                <br />
                EnEcuador:
                <asp:CheckBox ID="EnEcuadorCheckBox" runat="server" Checked='<%# Bind("EnEcuador") %>' />
                <br />
                Endemica:
                <asp:CheckBox ID="EndemicaCheckBox" runat="server" Checked='<%# Bind("Endemica") %>' />
                <br />
                IdTaxaPadre:
                <asp:TextBox ID="IdTaxaPadreTextBox" runat="server" Text='<%# Bind("IdTaxaPadre") %>' />
                <br />
                IdCatalogo:
                <asp:TextBox ID="IdCatalogoTextBox" runat="server" Text='<%# Bind("IdCatalogo") %>' />
                <br />
                PublicarEnWeb:
                <asp:CheckBox ID="PublicarEnWebCheckBox" runat="server" Checked='<%# Bind("PublicarEnWeb") %>' />
                <br />
                FechaModificacion:
                <asp:TextBox ID="FechaModificacionTextBox" runat="server" Text='<%# Bind("FechaModificacion") %>' />
                <br />
                UsuarioModificacion:
                <asp:TextBox ID="UsuarioModificacionTextBox" runat="server" Text='<%# Bind("UsuarioModificacion") %>' />
                <br />
                IdPublicacionReporte:
                <asp:TextBox ID="IdPublicacionReporteTextBox" runat="server" Text='<%# Bind("IdPublicacionReporte") %>' />
                <br />
                Ano:
                <asp:TextBox ID="AnoTextBox" runat="server" Text='<%# Bind("Ano") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            </InsertItemTemplate>
            <ItemTemplate>
                especies:
                <asp:Label ID="especiesLabel" runat="server" Text='<%# Bind("especies") %>' />
                <br />
                multimedias:
                <asp:Label ID="multimediasLabel" runat="server" Text='<%# Bind("multimedias") %>' />
                <br />
                nombrecomuns:
                <asp:Label ID="nombrecomunsLabel" runat="server" Text='<%# Bind("nombrecomuns") %>' />
                <br />
                taxapublicacions:
                <asp:Label ID="taxapublicacionsLabel" runat="server" Text='<%# Bind("taxapublicacions") %>' />
                <br />
                IdTaxa:
                <asp:Label ID="IdTaxaLabel" runat="server" Text='<%# Bind("IdTaxa") %>' />
                <br />
                Nombre:
                <asp:Label ID="NombreLabel" runat="server" Text='<%# Bind("Nombre") %>' />
                <br />
                NombreCorto:
                <asp:Label ID="NombreCortoLabel" runat="server" Text='<%# Bind("NombreCorto") %>' />
                <br />
                EnEcuador:
                <asp:CheckBox ID="EnEcuadorCheckBox" runat="server" Checked='<%# Bind("EnEcuador") %>' Enabled="false" />
                <br />
                Endemica:
                <asp:CheckBox ID="EndemicaCheckBox" runat="server" Checked='<%# Bind("Endemica") %>' Enabled="false" />
                <br />
                IdTaxaPadre:
                <asp:Label ID="IdTaxaPadreLabel" runat="server" Text='<%# Bind("IdTaxaPadre") %>' />
                <br />
                IdCatalogo:
                <asp:Label ID="IdCatalogoLabel" runat="server" Text='<%# Bind("IdCatalogo") %>' />
                <br />
                PublicarEnWeb:
                <asp:CheckBox ID="PublicarEnWebCheckBox" runat="server" Checked='<%# Bind("PublicarEnWeb") %>' Enabled="false" />
                <br />
                FechaModificacion:
                <asp:Label ID="FechaModificacionLabel" runat="server" Text='<%# Bind("FechaModificacion") %>' />
                <br />
                UsuarioModificacion:
                <asp:Label ID="UsuarioModificacionLabel" runat="server" Text='<%# Bind("UsuarioModificacion") %>' />
                <br />
                IdPublicacionReporte:
                <asp:Label ID="IdPublicacionReporteLabel" runat="server" Text='<%# Bind("IdPublicacionReporte") %>' />
                <br />
                Ano:
                <asp:Label ID="AnoLabel" runat="server" Text='<%# Bind("Ano") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Editar" />
                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Eliminar" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="Nuevo" />
            </ItemTemplate>
        </asp:FormView>
        <asp:GridView ID="gvwTaxa" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="odsTaxa" OnRowDeleting="gvwTaxa_RowDeleting">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="IdTaxa" HeaderText="IdTaxa" SortExpression="IdTaxa" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                <asp:BoundField DataField="NombreCorto" HeaderText="NombreCorto" SortExpression="NombreCorto" />
                <asp:CheckBoxField DataField="EnEcuador" HeaderText="EnEcuador" SortExpression="EnEcuador" />
                <asp:CheckBoxField DataField="Endemica" HeaderText="Endemica" SortExpression="Endemica" />
                <asp:BoundField DataField="IdTaxaPadre" HeaderText="IdTaxaPadre" SortExpression="IdTaxaPadre" />
                <asp:BoundField DataField="IdCatalogo" HeaderText="IdCatalogo" SortExpression="IdCatalogo" />
                <asp:CheckBoxField DataField="PublicarEnWeb" HeaderText="PublicarEnWeb" SortExpression="PublicarEnWeb" />
                <asp:BoundField DataField="FechaModificacion" HeaderText="FechaModificacion" SortExpression="FechaModificacion" />
                <asp:BoundField DataField="UsuarioModificacion" HeaderText="UsuarioModificacion" SortExpression="UsuarioModificacion" />
                <asp:BoundField DataField="IdPublicacionReporte" HeaderText="IdPublicacionReporte" SortExpression="IdPublicacionReporte" />
                <asp:BoundField DataField="Ano" HeaderText="Ano" SortExpression="Ano" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
