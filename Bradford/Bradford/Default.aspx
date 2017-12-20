<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bradford.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">   
    <title>Bradford Factor Calculator</title>
</head>
<body>
    <link href="StyleSheet.css" rel="stylesheet" /> 
<h1><b>Bradford Factor</b></h1>
<%--Left column - text only--%>
        <div class="row">
  <div class="column" style="background-color:#c6e3ff;">
    <h2>Information</h2>
    <p>The bradford factor or bradford formula is used in human resource management
        as a means of measuring worker absenteeism. The theory is that short, frequent
        and unplanned absences are more disruptive than longer absences.
        <br /> <br />
        <u>Suggested score meaning:</u>
<br />Score 45: A manager to show concern and investigate the situation
<br />Score 100: A manager to consider disciplinary action
<br />Score 900: A manager to escalate disciplinary action, including possible dismissal
    </p>
      <p>For more information on the bradford factor see <a href="https://en.wikipedia.org/wiki/Bradford_Factor" target = "_blank">this link</a>.</p>
  </div>

<%--Right column - calculator--%>
  <div class="column" style="background-color:#c6d7ff;">
      <form id="form1" runat="server"> 
    <h2>Calculator</h2>
    <p>
            Please enter total number of absence occurrences below.
            <br /><br />
            <asp:TextBox ID="TextBox1" runat="server"  Width="60px" />
            <br /><br />

            Please enter total number days of absence below.
            <br /><br />

            <asp:TextBox ID="TextBox2" runat="server" Width="60px" />
            <br /><br />

            <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" />
            <br /><br />
            <%--Output/Result Label--%>
            <b><asp:Label ID="ResultLabel" runat="server"  Text=""></asp:Label></b>
    </p>
          </form>
  </div>
</div>
</body>
</html>
