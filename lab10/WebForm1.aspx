<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Table ID="Table1" runat="server" Width="574px">
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Сума Кредиту</asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Процентна ставка (%)</asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Дата видачі кредиту</asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">Дата Погашення кредиту</asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow runat="server">
                    <asp:TableCell runat="server">
                        <asp:Label ID="Label1" runat="server" Text="" BackColor="Red"></asp:Label>
                        <asp:Label ID="Label2" runat="server" Text="" BackColor="Red"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell runat="server">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
