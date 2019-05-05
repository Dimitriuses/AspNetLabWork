<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab8._Default" Theme="MyStyleSheet1.css" StylesheetTheme="Skin1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <p>
        <a href="http://www.asp.net" class="btn btn-primary btn-lg">Learr more &raquo;</a><asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
    </p>

    

</asp:Content>
