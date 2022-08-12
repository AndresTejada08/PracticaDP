<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br>
            <asp:Button ID="Button1" runat="server" Text="Suma" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Resta" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Multiplicacion" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Division" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="Potencia" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="Inverso" OnClick="Button6_Click" />
            <asp:Button ID="Button8" runat="server" Text="Seno" OnClick="Button8_Click" />
            <asp:Button ID="Button7" runat="server" Text="Coseno" OnClick="Button7_Click" />
            <asp:Button ID="Button9" runat="server" Text="Tangente" OnClick="Button9_Click" />
            <asp:Button ID="Button10" runat="server" Text="Factorial" OnClick="Button10_Click" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
    </form>
</body>
</html>
