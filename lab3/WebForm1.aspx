<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="\/" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="/\" />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>1.jpg</asp:ListItem>
            <asp:ListItem>2.jpg</asp:ListItem>
            <asp:ListItem>3.jpg</asp:ListItem>
            <asp:ListItem>4.jpg</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        </p>
    </form>
</body>
</html>
