<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="QualityLeague.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1">
  
      <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

</head>
<body>
    
      
    <form id="form1" runat="server">
            <div class="jumbotron text-center">
     <h1>BSA3 Quality League</h1>
 </div>
     <div class="container">
      <ul class="nav nav-tabs">
    <li class="active"><a data-toggle="tab" href="#teamscores">Team Scores</a></li>
    <li><a data-toggle="tab" href="#playerscores">Player Scores</a></li>
  </ul>

  <div class="tab-content">
    <div id="teamscores" class="tab-pane fade in active">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TeamName" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="TeamName" HeaderText="TeamName" ReadOnly="True" SortExpression="TeamName" />
                <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
            </Columns>
        </asp:GridView>
     
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QualityConnection %>" SelectCommand="SELECT * FROM [TeamTable]"></asp:SqlDataSource>
     
    </div>
    <div id="playerscores" class="tab-pane fade">
      <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Name" DataSourceID="SqlDataSource2">
          <Columns>
              <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
              <asp:BoundField DataField="TeamName" HeaderText="TeamName" SortExpression="TeamName" />
              <asp:BoundField DataField="PlayerScore" HeaderText="PlayerScore" SortExpression="PlayerScore" />
              <asp:BoundField DataField="CF" HeaderText="CF" SortExpression="CF" />
          </Columns>
        </asp:GridView>
   
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QualityConnection %>" SelectCommand="SELECT * FROM [PlayerTable]"></asp:SqlDataSource>
   
    </div>  
  </div>
    </div>

    </form>
       
</body>
</html>
