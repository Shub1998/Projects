<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="QualityLeague.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Scorer DashBoard</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
    <link href="bootstrap.min.css" rel="stylesheet" />
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script>
        n = new Date();
        y = n.getFullYear();
        m = n.getMonth() + 1;
        d = n.getDate();

        document.getElementById("date").innerHTML = m + "/" + d + "/" + y;
    </script>
  <style>
      body{
          font-size: 15px;
      }
      .borderless td, .borderless th {
    border: none !important;
}
      .row{
          margin-top: 10px;
          margin-bottom: 10px;
      }
      .card{
          padding: 8px !important;
      }
      .modal {
  display: none; /* Hidden by default */
  position: fixed; /* Stay in place */
  z-index: 1; /* Sit on top */
  padding-top: 100px; /* Location of the box */
  left: 0;
  top: 0;
  width: 100%; /* Full width */
  height: 100%; /* Full height */
  overflow: auto; /* Enable scroll if needed */
  background-color: rgb(0,0,0); /* Fallback color */
  background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
}

/* Modal Content */
.modal-content {
  position: relative;
  background-color: #fefefe;
  margin: auto;
  padding: 0;
  border: 1px solid #888;
  width: 80%;
  box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
  -webkit-animation-name: animatetop;
  -webkit-animation-duration: 0.4s;
  animation-name: animatetop;
  animation-duration: 0.4s
}

/* Add Animation */
@-webkit-keyframes animatetop {
  from {top:-300px; opacity:0} 
  to {top:0; opacity:1}
}

@keyframes animatetop {
  from {top:-300px; opacity:0}
  to {top:0; opacity:1}
}

/* The Close Button */
.close {
  color: white;
  float: right;
  font-size: 28px;
  font-weight: bold;
}

.close:hover,
.close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
}

.modal-header {
  padding: 2px 16px;

  background-color: #6e7bd9;
  color: white;
}

.modal-body {padding: 30px;
             height:300px;
             width: auto !important,
             //align-content:center;
}

.modal-footer {
  padding: 2px 16px;
  background-color: #5cb85c;
  color: white;
}
      .panel
      {
          margin-top: 40px;
      }

      .panel-heading{
          text-align: center;
      }
      


  </style>
    <style>
body {
width: 100%;
margin: 5px;
}

.table-condensed tr th {
border: 0px solid #6e7bd9;
color: white;
background-color: #6e7bd9;

}
.highlight{
    background-color:yellow !important;
    font-weight:bold;
}

.table-condensed, .table-condensed tr td {
border: 1px solid #000;
}

tr:nth-child(even) {
background: #f8f7ff
}

tr:nth-child(odd) {
background: #fff;
}
        .auto-style1 {
            width: 274px;
            height: 270px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron text-center">
     <h1>BSA3 Quality League Finals</h1>
 </div>
    <div class="container-fluid">
     <div class ="row">
         <div class="col-sm-4"><p style="margin-left:20px;float:left;font-size:20px"> Team 1: <b>DOVE</b> </p></div>
        <div class="col-sm-4"><p style="text-align:center;font-size:20px;"><b><%= DateTime.Now.ToString("dddd, MMMM dd") %></b>  </p></div>
          <div class="col-sm-4"><p style="margin-left:20px;float:left;font-size:20px">Team 2: <b>Conquerors</b> </p></div>
         <%--<div class="col-sm-4"><p style="float:right;margin-right:20px;font-size:20px">Date : <b><%= DateTime.Now.ToString("dddd, MMMM dd") %></b>  </p></div>--%>
         
     </div>


        
        <div class="row">
             
                <!-- Card 1-->
                   <div class="col-md-4">
                   <div class="col-xm-6">
                    <div class="card bg-warning">
                    <div class="card-body">
                      <p class="card-text"><b>Select home team members:</b></p>
                        <div class="row">
                            <asp:DropDownList ID="DropDownList1"  class="form-control col-md-5" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem Selected="True">--Select Member--</asp:ListItem>
                            </asp:DropDownList>
                             
                            
                        </div>
                        <div class="row" style="margin-top: 20px !important;">
                            <p><b>Answer's Remarks: </b></p>
                        </div>
                        <div class="row" style="margin-top: 10px !important;">
                             <asp:Button ID="Button3" class="btn btn-success" runat="server" Text="Correct" OnClick="Button3_Click1" />&nbsp;&nbsp;
                             <asp:Button ID="Button4" class="btn btn-danger" runat="server" Text="Incorrect" OnClick="Button4_Click" />&nbsp;&nbsp;
                             <asp:Button ID="Button8" class="btn btn-primary" runat="server" Text="Time Out" OnClick="Button8_Click" />&nbsp;&nbsp;
                             <asp:Button ID="Button15" class="btn btn-danger" runat="server" Text="Target" OnClick="Button15_Click" />
                        </div>


                    </div>
                  </div>
              </div><br><br /><br />
               <div class="col-xm-6">
               <div class="card bg-info">
                <div class="card-body">
                <p class="card-text"><b>Select other team members:</b></p>
                    <div class="row">
                        <asp:DropDownList ID="DropDownList2"  class="form-control col-md-5" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>--Select Team--</asp:ListItem>
                                 <asp:ListItem>Conquerors</asp:ListItem>
                                <asp:ListItem>DOVE</asp:ListItem>
                            </asp:DropDownList>
                        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Properties/forward.png"  onclick="Button1_Click" Height="27px" Width="34px" style="margin-top:1%;margin-left:30px;"/> 
                        <div class="col-md-1"></div>
                        <asp:DropDownList ID="DropDownList3"  class="form-control col-md-5" style="margin-left: -30px;" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>--Select Member--</asp:ListItem>
                            </asp:DropDownList>
                    </div>
                    <div class="row" style="margin-top: 20px !important;">
                        <p><b>Question's Remarks: </b></p>
                    </div>
                    <div class="row" style="margin-top: 10px !important;">
                        <asp:Button ID="Button1" class="btn btn-success" runat="server" Text="Valid" OnClick="Button1_Click1" />&nbsp;&nbsp;
                         <asp:Button ID="Button2" class="btn btn-danger" runat="server" Text="Invalid" OnClick="Button2_Click" />&nbsp;&nbsp;
                        
                       
                        
                    </div>
                </div>
              </div>

               </div>
              </div>

           
     
 
          <div class="col-sm-4">
           <div class="col-xm-12" style="margin-right:2%;margin-top:8%">
               <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                       <table style="width:500px;margin-top:-25px;">
                        <tr>
                        <td style ="font-weight:bold;"> 
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TeamName" DataSourceID="SqlDataSource1"  UseAccessibleHeader="true" CssClass="table table-condensed table-hover" Width="100%"   >
            <Columns>
                <asp:BoundField DataField="TeamName" HeaderText="TeamName" ReadOnly="True" SortExpression="TeamName" />
                <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
            </Columns>
        </asp:GridView>
                     </td>
              
     </tr>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QualityConnection %>" SelectCommand="SELECT * FROM [TeamTable] ORDER BY [Score] DESC"></asp:SqlDataSource>
                           <caption>
                               <br />
                               <tr>
                                   <td style="font-weight:bold;">
                                       <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" CssClass="table table-condensed table-hover" DataKeyNames="Name" DataSourceID="SqlDataSource2" Height="143px" UseAccessibleHeader="true" Width="100%">
                                           <Columns>
                                               <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" SortExpression="Name" />
                                               <asp:BoundField DataField="PlayerScore" HeaderText="PlayerScore" SortExpression="PlayerScore" />
                                           </Columns>
                                       </asp:GridView>
                                   </td>
                               </tr>
                           </caption>
            </table>      
   
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QualityConnection %>" SelectCommand="SELECT TOP 5 [Name], [PlayerScore] FROM [PlayerTable] ORDER BY [PlayerScore] DESC"></asp:SqlDataSource>
                            
                    </ContentTemplate>
                </asp:UpdatePanel>
           </div>
          
          </div>

                   <!-- Card 2 -->
       <div class="col-sm-4">
               <div class="col-xm-6">
                    <div class="card bg-warning">
                    <div class="card-body">
                      <p class="card-text"><b>Select home team members:</b></p>
                        <div class="row">
                            <asp:DropDownList ID="DropDownList4"  class="form-control col-md-5" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem Selected="True">--Select Member--</asp:ListItem>
                            </asp:DropDownList>
                             
                            
                        </div>
                        <div class="row" style="margin-top: 20px !important;">
                            <p><b>Answer's Remarks: </b></p>
                        </div>
                        <div class="row" style="margin-top: 10px !important;">
                             <asp:Button ID="Button9" class="btn btn-success" runat="server" Text="Correct" OnClick="Button9_Click1" />&nbsp;&nbsp;
                             <asp:Button ID="Button10" class="btn btn-danger" runat="server" Text="Incorrect" OnClick="Button10_Click" />&nbsp;&nbsp;
                             <asp:Button ID="Button11" class="btn btn-primary" runat="server" Text="Time Out" OnClick="Button11_Click" />&nbsp;&nbsp;
                            <asp:Button ID="Button16" class="btn btn-danger" runat="server" Text="Target" OnClick="Button16_Click" />
                        </div>


                    </div>
                  </div>
              </div><br><br /><br />
               <div class="col-xm-6">
               <div class="card bg-info">
                <div class="card-body">
                <p class="card-text"><b>Select other team members:</b></p>
                    <div class="row">
                        <asp:DropDownList ID="DropDownList5"  class="form-control col-md-5" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>--Select Team--</asp:ListItem>
                                 <asp:ListItem>Conquerors</asp:ListItem>
                                <asp:ListItem>DOVE</asp:ListItem>
                            </asp:DropDownList>
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Properties/forward.png"  onclick="Button2_Click1" Height="27px" Width="34px" style="margin-top:1%;margin-left:30px;"/> 
                        <div class="col-md-1"></div>
                        <asp:DropDownList ID="DropDownList6"  class="form-control col-md-5" style="margin-left: -30px;" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>--Select Member--</asp:ListItem>
                            </asp:DropDownList>
                    </div>
                    <div class="row" style="margin-top: 20px !important;">
                        <p><b>Question's Remarks: </b></p>
                    </div>
                    <div class="row" style="margin-top: 10px !important;">
                        <asp:Button ID="Button12" class="btn btn-success" runat="server" Text="Valid" OnClick="Button12_Click1" />&nbsp;&nbsp;
                         <asp:Button ID="Button13" class="btn btn-danger" runat="server" Text="Invalid" OnClick="Button13_Click" />&nbsp;&nbsp;
                         
                        
                    </div>
                </div>
              </div>

               </div>
              
    </div>
             
            </div> <br /><br />
        
        <asp:Button ID="Button5" class="btn btn-primary" style="width:15%;margin-left:800px" runat="server" Text="Submit" OnClick="Button5_Click" /><br /><br />
        </div>
       
       <div id="myModal" class="modal" runat ="server" >
                <!-- Modal content -->
                 <div class="modal-content">
                      <div class="modal-header"><h2>SDM Feedback</h2>
                          <asp:LinkButton ID="LinkButton1" runat="server" CssClass="close" OnClick ="onCrossClicked">&times;</asp:LinkButton>
             
                             
                      </div>
                      <div class="modal-body">
                          <div class="row">
                              <div class ="col-md-4"></div>
                              <div class="col-md-4">
                                   <asp:DropDownList ID="DropDownList7"  class="form-control col-md-5" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                <asp:ListItem>--Select Team--</asp:ListItem>
                                 <asp:ListItem>Conquerors</asp:ListItem>
                                <asp:ListItem>DOVE</asp:ListItem>
                            </asp:DropDownList>
                              </div>
                          </div>
                          <div class="row">
                              <div class ="col-md-4"></div>
                              <div class="col-md-4">
                              <asp:TextBox class="form-control" ID="TextBox2" type="text" runat="server" placeholder="Enter Score"></asp:TextBox>
                                  </div>
                              
                              <div class ="col-md-4"></div>
                              </div>
                               <div class="row">
                              <div class ="col-md-4"></div>
                              <div class="col-md-4">
                              <asp:Button class="btn btn-success" ID="Button6" runat="server" Text="Submit" OnClick="onSubmitClicked" />
                                  </div>
                          
                      </div>
                 </div>
               </div>
        </div>

         
    </form>
</body>
</html>
