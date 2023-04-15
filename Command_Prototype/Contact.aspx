<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Command_Prototype.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Panel ID="Panel1" runat="server">
        <h2 style="text-align: center">Alta y Baja de Stock Computadoras</h2>
        <br />
        <div style="text-align: center">
            <asp:Label runat="server" Text="Ingrese la cantidad de Computadoras que existen:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtCantidadProducto" runat="server" ToolTip="Representa la cantidad del producto"></asp:TextBox>

        </div>
        <br />
        <div style="text-align: center">
            <asp:Label runat="server" Text="Ingrese la cantidad de Computadoras para dar de Alta:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtAlta" runat="server" ToolTip="Representa la cantidad del producto"></asp:TextBox>

        </div>
        <br />
        
        <div style="text-align: center">
            <asp:Label runat="server" Text="Ingrese la cantidad de Computadoras para dar de Baja:" Font-Size="Medium"></asp:Label><br />
            <asp:TextBox ID="txtBaja" runat="server" ToolTip="Representa la cantidad del producto"></asp:TextBox>

        </div>
        <br />
            

        <div style="text-align: center">
            <asp:Button runat="server" Text="Hecho" OnClick="Hecho_Click" Width="150px" />&nbsp;&nbsp;&nbsp;
            <!--<asp:Button runat="server" Text="Baja" OnClick="BajaStock_Click" Width="150px" />-->
        </div>
        <br />
        <br />
        <h3 runat="server" id="h1Resultado" style="text-align: center">Resultado de la operación      
    
        </h3>
        <br />
        <div style="text-align: center">
            <asp:Label ID="lblAltaStock" runat="server" Font-Size="Small" ></asp:Label>
            <br />
            <asp:Label ID="lblBajaStok" runat="server" Font-Size="Small"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Font-Size="Medium"></asp:Label>
        </div>
        <br />
    </asp:Panel>
</asp:Content>
