<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QualityLeague.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BSA3 Quality League</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
     <div class="jumbotron text-center">
     <h1>BSA3 Quality League</h1>
 </div>
    <div class="container-fluid">
       <h4>Rules and Regulation:</h4>
  <div class="card">
    <div class="card-body">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Properties/Screenshot (29).png" Width="100%" Height="100%" />
      
    </div>
      
  </div><br>
       
         <asp:Button ID="Button1" runat="server" type="button" class="btn btn-primary" style="width:15%;margin-left:800px" Text="Continue" OnClick="Button1_Click" />
</div>
       
   </form>
</body>
</html>
