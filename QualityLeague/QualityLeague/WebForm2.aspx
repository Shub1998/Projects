<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="QualityLeague.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Select Home Team</title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    
</head>
 <script>
     var myvar = <%= dropdownvalue %>;
     
 </script>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="jumbotron text-center">
     <h1>BSA3 Quality League</h1>
 </div>
    </div>
       <div class="container-fluid">
           <h3>Select Your Home Team :</h3>
           <div class="card">
               <div class="row">
                <asp:Image ID="Image1" runat="server" Height="40px" ImageUrl="~/Properties/home.png" Width="54px" style="margin-left:400px;margin-top:40px;margin-bottom:20px"/>
                <asp:DropDownList ID="DropDownList1" style="margin-top:45px;margin-left:30px;margin-bottom:20px;width:30%;" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>---Select Team--</asp:ListItem>
                    <asp:ListItem>Immortal CAT</asp:ListItem>
                    <asp:ListItem>The FRONTLINE</asp:ListItem>
                    <asp:ListItem>Perfect Strikers</asp:ListItem>
                    <asp:ListItem>Conquerors</asp:ListItem>
                    <asp:ListItem>DOVE</asp:ListItem>
                </asp:DropDownList>
               
                   <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Properties/forward.png"  onclick="Button1_Click" Height="30px" Width="40px" style="margin-top:45px;margin-left:20px;"/>
                   </div>
               
           </div><br />
   <h3>Select Available Players :</h3><br />
   <div class="container-fluid">
  <div class="card">
  <table class="table">
  <thead class="thead-dark">
    <tr>
      <th scope="col">Player Name</th>
      <th scope="col">Availability</th>
      
    </tr>
  </thead>
  <tbody>
  <% if (DropDownList1.SelectedValue == "Immortal CAT")
      {
     %>
    
    <tr>
      
      <td>Ajeet Singh</td>
      <td>
          <asp:CheckBox ID="CheckBox1" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Che Cong Quang</td>
      <td>
          <asp:CheckBox ID="CheckBox2" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Ho Nguyen Cong Thanh </td>
      <td>
          <asp:CheckBox ID="CheckBox3" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Hoang Pham Dang Khoa </td>
      <td>
          <asp:CheckBox ID="CheckBox4" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Hoang Quoc Hung</td>
      <td>
          <asp:CheckBox ID="CheckBox5" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Le Tran Ke Tuong</td>
      <td>
          <asp:CheckBox ID="CheckBox6" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Nguyen Dac Huynh</td>
      <td>
          <asp:CheckBox ID="CheckBox7" runat="server" /></td>
    </tr>
      <tr>
      <td>Nguyen Tan Anh Khoa</td>
      <td>
          <asp:CheckBox ID="CheckBox8" runat="server" /></td>
    </tr>
      <tr>
      <td>Nguyen Thi Song Huong</td>
      <td>
          <asp:CheckBox ID="CheckBox26" runat="server" /></td>
    </tr>
      <tr>
      <td>Nguyen Trung Dung</td>
      <td>
          <asp:CheckBox ID="CheckBox27" runat="server" /></td>
    </tr>
        <tr>
      <td>Tang Chi Dung</td>
      <td>
          <asp:CheckBox ID="CheckBox30" runat="server" /></td>
    </tr>
        <tr>
      <td>Tran Dang Vi</td>
      <td>
          <asp:CheckBox ID="CheckBox31" runat="server" /></td>
    </tr>
        <tr>
      <td>Trieu Viet Cuong</td>
      <td>
          <asp:CheckBox ID="CheckBox32" runat="server" /></td>
    </tr>
        <tr>
      <td>Trinh Anh Trung</td>
      <td>
          <asp:CheckBox ID="CheckBox33" runat="server" /></td>
    </tr>
        <tr>
      <td>Truong Nhut Vinh</td>
      <td>
          <asp:CheckBox ID="CheckBox34" runat="server" /></td>
    </tr>
        <tr>
      <td>Vuong Truc  Quynh</td>
      <td>
          <asp:CheckBox ID="CheckBox35" runat="server" /></td>
    </tr>
     
  <% } %>   
      
     <% else if (DropDownList1.SelectedValue == "The FRONTLINE")
    { %> 
       <tr>
      
      <td>Dino Paul Paul Copian</td>
      <td>
          <asp:CheckBox ID="CheckBox9" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Kokilavani Dhandapani</td>
      <td>
          <asp:CheckBox ID="CheckBox10" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Piyali Das</td>
      <td>
          <asp:CheckBox ID="CheckBox11" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Shantha Meena Manoraj</td>
      <td>
          <asp:CheckBox ID="CheckBox12" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Shivam Agrawal</td>
      <td>
          <asp:CheckBox ID="CheckBox13" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Shubhanshu Bhadouria</td>
      <td>
          <asp:CheckBox ID="CheckBox28" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Sowmiya Velayudam</td>
      <td>
          <asp:CheckBox ID="CheckBox29" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Tamilselvan Parameswaran</td>
      <td>
          <asp:CheckBox ID="CheckBox36" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Tran Thi Hong Diem</td>
      <td>
          <asp:CheckBox ID="CheckBox37" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Vu Thanh Liem</td>
      <td>
          <asp:CheckBox ID="CheckBox38" runat="server" /></td>
    </tr>

    <% } %> 

       <% else if (DropDownList1.SelectedValue == "Perfect Strikers")
    { %> 
       <tr>
      
      <td>Dilip Kumar Makireddi</td>
      <td>
          <asp:CheckBox ID="CheckBox14" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Harish Kulkarni</td>
      <td>
          <asp:CheckBox ID="CheckBox15" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Ngo Vu Ba Giang </td>
      <td>
          <asp:CheckBox ID="CheckBox16" runat="server" /></td>
    </tr>
        <tr>
      
      <td>Nguyen Dao My Linh </td>
      <td>
          <asp:CheckBox ID="CheckBox39" runat="server" /></td>
    </tr>
        <tr>
      
      <td>Prabanath Chinnasamy </td>
      <td>
          <asp:CheckBox ID="CheckBox40" runat="server" /></td>
    </tr>
        <tr>
      
      <td>Tamilarasan Raju </td>
      <td>
          <asp:CheckBox ID="CheckBox41" runat="server" /></td>
    </tr>
        <tr>
      
      <td>Ta Quang Truong </td>
      <td>
          <asp:CheckBox ID="CheckBox42" runat="server" /></td>
    </tr>
    
    <% } %> 

       <% else if (DropDownList1.SelectedValue == "Conquerors")
    { %> 
       <tr>
      
      <td>Bharathkumar Vijayakumar</td>
      <td>
          <asp:CheckBox ID="CheckBox17" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Chaithra S</td>
      <td>
          <asp:CheckBox ID="CheckBox18" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Gavin Sanish Gnanasingh Dennis</td>
      <td>
          <asp:CheckBox ID="CheckBox19" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Jayasheela H M</td>
      <td>
          <asp:CheckBox ID="CheckBox20" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Manjeet Patel </td>
      <td>
          <asp:CheckBox ID="CheckBox21" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Manuel Joseph Paramanandam</td>
      <td>
          <asp:CheckBox ID="CheckBox22" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Priyanka Selvadurai</td>
      <td>
          <asp:CheckBox ID="CheckBox43" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Sathya Priya Kuppusami</td>
      <td>
          <asp:CheckBox ID="CheckBox44" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Shreemala Chipli Mahabaleshwara</td>
      <td>
          <asp:CheckBox ID="CheckBox45" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Subalakshmi Shenbagamoorthy</td>
      <td>
          <asp:CheckBox ID="CheckBox46" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Sunil Kumar Mishra</td>
      <td>
          <asp:CheckBox ID="CheckBox47" runat="server" /></td>
    </tr>

    <% } %> 

         <% else if (DropDownList1.SelectedValue == "DOVE")
    { %> 
       <tr>
      
      <td>Ankur Rouhan </td>
      <td>
          <asp:CheckBox ID="CheckBox23" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Bui Quy Duc</td>
      <td>
          <asp:CheckBox ID="CheckBox24" runat="server" /></td>
    </tr>
      <tr>
      
      <td>Trinh Minh Cuong</td>
      <td>
          <asp:CheckBox ID="CheckBox25" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Jaishree Panneer Selvam</td>
      <td>
          <asp:CheckBox ID="CheckBox48" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Kasthuri Ganesan</td>
      <td>
          <asp:CheckBox ID="CheckBox49" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Kumar Saumyakanta Jena </td>
      <td>
          <asp:CheckBox ID="CheckBox50" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Phan Van Thinh</td>
      <td>
          <asp:CheckBox ID="CheckBox51" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Tharani Srinivasan</td>
      <td>
          <asp:CheckBox ID="CheckBox52" runat="server" /></td>
    </tr>
       <tr>
      
      <td>Vidhya Radhakrishnan</td>
      <td>
          <asp:CheckBox ID="CheckBox53" runat="server" /></td>
    </tr>
    
    <% } %> 


  </tbody>
</table>
        </div>
            
       </div>
   </div>     
          
        <p>
            &nbsp;</p>
 
        <asp:Button ID="Button1" runat="server"  type="button" class="btn btn-primary" style="width:15%;margin-left:800px" OnClick="Button1_Click1" Text="Proceed" /><br />
          
    </form>
    
</body>
</html>
