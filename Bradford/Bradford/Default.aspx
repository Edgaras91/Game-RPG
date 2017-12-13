<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bradford.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">




<head runat="server">
    <title>Bradford Index Calculator</title>
<style>
* {
    box-sizing: border-box;
}

    body {
        margin: 50px 0px 50px 0px; 
        background: lightblue;
        background-image: url('http://valius.co.uk/img/Absence.jpg'); 
        background-repeat: repeat-x;  
        background-attachment: fixed;
    background-position:  50% 400px; 
    }

/* Create two equal columns that floats next to each other */
.column {

    float: left;
    width: 50%;
    padding: 10px;
    height: 300px; 
}

/* Clear floats after the columns */
.row:after {
    content: "";
    display: table;
    clear: both;
}

/* Responsive layout - makes the two columns stack on top of each other instead of next to each other */
@media (max-width: 800px) {
    .column {width: 100%;}
    body{background-position:  50% 700px; }

}

</style>
</head>
<body>
    <form id="form1" runat="server">

        <h1><center><b>Bradford Factor</b></center></h1>

        <div class="row">
  <div class="column" style="background-color:#c6e3ff;">
    <h2>Information</h2>
    <p>The Bradford Factor or Bradford Formula is used in human resource management as a means of measuring worker absenteeism. The theory is that short, frequent, and unplanned absences are more disruptive than longer absences.
        <br />
        <br />
        <u>Suggested Score meaning:</u>
<br />Score 45: A manager to show concern and advise on possible disciplinary.
<br />Score 100: A manager to start disciplinary action
<br />Score 900: A manager to consider dismissal
    </p>
        <p>         
          <asp:Label ID="footerLabel" runat="server" />
     </p>
  </div>
  <div class="column" style="background-color:#c6d7ff;">
    <h2>Calculator</h2>
    <p>


                    Please enter total number of absence occurances below.
            <br /><br />


            <asp:TextBox ID="TextBox1" runat="server"  Width="60px" />
            <br /><br />

            Please enter total number days of absence below.
            <br /><br />

            <asp:TextBox ID="TextBox2" runat="server" Width="60px" />
            <br /><br />

            <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" />
            <br /><br />

            <b><asp:Label ID="CheckBoxLabel" runat="server"  Text=""></asp:Label></b>



    </p>
  </div>
</div>



        <footer>
   
        </footer>
    </form>
</body>
</html>
