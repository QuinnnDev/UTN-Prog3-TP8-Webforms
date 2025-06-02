<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="VISTAS.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 228px;
        }
        .auto-style3 {
            width: 188px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 228px;
            height: 23px;
        }
        .auto-style6 {
            width: 188px;
            height: 23px;
        }
        .auto-style7 {
            width: 49px;
        }
        .auto-style8 {
            height: 23px;
            width: 49px;
        }
        .auto-style9 {
            height: 27px;
            width: 49px;
        }
        .auto-style10 {
            width: 228px;
            height: 27px;
        }
        .auto-style11 {
            width: 188px;
            height: 27px;
        }
        .auto-style12 {
            height: 27px;
        }
        .auto-style13 {
            height: 63px;
            width: 49px;
        }
        .auto-style14 {
            width: 228px;
            height: 63px;
        }
        .auto-style15 {
            width: 188px;
            height: 63px;
        }
        .auto-style16 {
            height: 63px;
        }
        .auto-style17 {
            height: 35px;
            width: 49px;
        }
        .auto-style18 {
            width: 228px;
            height: 35px;
        }
        .auto-style19 {
            width: 188px;
            height: 35px;
        }
        .auto-style20 {
            height: 35px;
        }
        .auto-style21 {
            width: 49px;
            height: 42px;
        }
        .auto-style22 {
            width: 228px;
            height: 42px;
        }
        .auto-style23 {
            width: 188px;
            height: 42px;
        }
        .auto-style24 {
            height: 42px;
        }
        .auto-style25 {
            height: 31px;
            width: 49px;
        }
        .auto-style26 {
            width: 228px;
            height: 31px;
        }
        .auto-style27 {
            width: 188px;
            height: 31px;
        }
        .auto-style28 {
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:HyperLink ID="HLAgregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar sucursal</asp:HyperLink>
                </td>
                <td class="auto-style11">
                    <asp:HyperLink ID="HLListado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado sucursales</asp:HyperLink>
                </td>
                <td class="auto-style12">
                    <asp:HyperLink ID="HLEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar sucursal</asp:HyperLink>
                </td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style13"></td>
                <td class="auto-style14">
                </td>
                <td class="auto-style15">
                </td>
                <td class="auto-style16">
                </td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td class="auto-style17"></td>
                <td class="auto-style18">
                    <asp:Label ID="lblEliminarSucursal" runat="server" Font-Bold="True" Text="Eliminar Sucursal" Font-Size="20pt"></asp:Label>
                </td>
                <td class="auto-style19"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
                <td class="auto-style20"></td>
            </tr>
            <tr>
                <td class="auto-style21"></td>
                <td class="auto-style22">
                    <asp:Label ID="lblIngresarId" runat="server" Text="Ingresar ID de sucursal:"></asp:Label>
                </td>
                <td class="auto-style23">
                    <asp:TextBox ID="tbxEliminarSucursal" runat="server" Width="163px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
                </td>
                <td class="auto-style24">
                    <asp:RegularExpressionValidator ID="revIDSucursal" runat="server" ControlToValidate="tbxEliminarSucursal" ErrorMessage="INGRESE UN NÚMERO" ForeColor="Red" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
                <td class="auto-style24"></td>
            </tr>
            <tr>
                <td class="auto-style25"></td>
                <td class="auto-style26">
                    <asp:Label ID="lblMensaje" runat="server" ForeColor="#990000"></asp:Label>
                </td>
                <td class="auto-style27"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
                <td class="auto-style28"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            </table>
        
        </div>
    </form>
</body>
</html>
