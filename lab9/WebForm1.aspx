<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Який відсоток від доходу Вашої Сім'ї складають комунальні послуги</h1>
            <h2>Введіть данні своєї сім'ї щоб дізнатись скільки становлитимуть Ваші комунальні виплати у разі оформлення супсидій</h2>
            
        </div>
        <asp:Table ID="Table1" runat="server" Width="232px">
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Середньомісячний дохід сім'ї(грн)</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Чисельність осіб зареєстрованих у квартирі(Будинку)</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Середньомісячний сукупний дохід на одну особу(грн)</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Відсоток обов'язкового платежу за ЖКП</asp:TableCell>
                <asp:TableCell runat="server">
                    <p>У 2015 році</p>
                    <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <p>У 2016 році</p>
                    <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">Макимальна сума яку заплатить родина за ЖКП</asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    <asp:Button ID="Button1" runat="server" Text="Визначити" OnClick="Button2_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>

<footer>
    зроблено Шпаковським Дмитром В'ячеславовичом для Рівненьського Коледжа Національного Університету Біоресурсів і Природокористування
</footer>

