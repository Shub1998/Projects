<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Chatbot.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <link href="https://fonts.googleapis.com/css?family=Teko:600&display=swap" rel="stylesheet"/>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
 <link rel="stylesheet" href="./bot.css" />
    <style>
        .wc-header {
            background-color:black !important;
        }
    </style>

</head>

<body>
    <form id="form1" runat="server">
     <div class="container-fluid">
  <div class="row">
    <div class="col-sm-7" style="background-color:blueviolet;height:100vh">
        <asp:Image ID="Image1" runat="server" Height="200px"  ImageUrl="~/chatbot.png" Width="250px" CssStyle="text-align:center;" style="margin-left:33%;margin-top:20%"/><br />
        <p style="font-family: 'Teko', sans-serif;color:white;font-size:50px;text-align:center">SMT BOT</p>
    </div>
    <div class="col-sm-5" >
     <div class="shadow p-3 mb-5 bg-white rounded" style="height:91vh;margin-top:4%">
         <iframe src='https://webchat.botframework.com/embed/demochatbot1234-bot?s=0fZGQ5dZI2g.32wmEv3k4_K3h9-ki0DUQ1tDFsb7mmHYQWscR0XDTeo' style='min-width: 400px; width: 100%; min-height: 530px;'></iframe> 
        
     </div>
      
    </div>
        </div>
  

</div>
        
   
          
    
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        
   
          
    
    
    </form>
</body>
</html>
