<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Welcome.aspx.vb" Inherits="WebApp.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>    
  <title>Test Environment</title>
</head>
<body>
    <div class="container">
      <h2>Miscelanious Inquiries</h2>     
        <ul  class = "nav nav-tabs mytab">
        <li class="mytab active"> <a data-toggle= "tab" href = "#lostItemsData"> Lost Items</a></li>
        <li><a data-toggle ="tab" href="#complaintData">Complaints</a></li>
        </ul>
        <div class="tab-content">
          <div class="tab-pane fade in active" id="lostItemsData">

          </div>
          <div class ="tab-pane fade" id="complaintData">
              
          </div>
        </div>
    </div>


</body>
</html>
