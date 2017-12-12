<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bradford.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">



<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome</h1>

            Please enter total number of absence occurances below.
            <br /><br />


            <asp:TextBox ID="TextBox1" runat="server"  Width="60px" />
            <br /><br />

            Please enter total number days of absence below.
            <br /><br />

            <asp:TextBox ID="TextBox2" runat="server" Width="60px" />
            <br /><br />

            <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" />
            <br />

            <asp:Label ID="CheckBoxLabel" runat="server" Text=""></asp:Label>




        </div>




        <footer>
            <asp:Label ID="footerLabel" runat="server" />
        </footer>
    </form>
</body>
</html>
