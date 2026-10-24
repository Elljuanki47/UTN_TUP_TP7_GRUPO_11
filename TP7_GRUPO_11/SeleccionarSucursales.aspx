<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarSucursales.aspx.cs" Inherits="TP7_GRUPO_11.SeleccionarSucursales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="hlListado" runat="server" NavigateUrl="~/SeleccionarSucursales.aspx">Listado de sucursales</asp:HyperLink>
    &nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="hlSeleccionadas" runat="server" NavigateUrl="~/ListadoSucursalesSeleccionados.aspx">Mostrar sucursales seleccionadas</asp:HyperLink>

            <br /><br />
            
            Buscar sucursal:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBuscarSucursal" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
&nbsp;<h2>Listado de sucursales</h2>

    <asp:ListView ID="lvSucursales" runat="server" GroupItemCount="3">
        <LayoutTemplate>
            <table border="1">
                <asp:PlaceHolder ID="groupPlaceholder" runat="server" />
            </table>
        </LayoutTemplate>
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server" />
            </tr>
        </GroupTemplate>
        <ItemTemplate>
            <td>
                <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("NombreSucursal") %>' Font-Bold="true" />
                <br />
                <asp:ImageButton ID="imgSucursal" runat="server" ImageUrl='<%# Eval("URL_Imagen_Sucursal") %>' Width="150px" Height="150px" />
                <br />
                <asp:Label ID="lblDescripcion" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                <br />
                <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" CommandArgument='<%# Eval("Id_Sucursal") %>' />
            </td>
        </ItemTemplate>
    </asp:ListView>
        </div>
    </form>
</body>
</html>
