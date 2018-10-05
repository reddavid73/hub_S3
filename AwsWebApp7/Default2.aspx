<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="AwsWebApp7.Default2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
    <style type="text/css">
        .auto-style4 {
            width: 10px;
            text-align: right;
        }
        .auto-style6 {
            width: 11px;
        }
        .auto-style7 {
            height: 313px;
            width: 1082px;
        }
    .auto-style10 {
        width: 37px;
    }
    .auto-style16 {
        width: 10px;
        text-align: right;
        height: 90px;
    }
    .auto-style17 {
        height: 90px;
    }
    .auto-style32 {
        width: 109px;
    }
        .auto-style41 {
            height: 90px;
            width: 7px;
        }
        .auto-style42 {
            width: 7px;
        }
        .auto-style44 {
            height: 90px;
            width: 162px;
        }
        .auto-style46 {
            width: 162px;
        }
        .auto-style47 {
            width: 174px;
            text-align: right;
            height: 90px;
        }
        .auto-style48 {
            width: 174px;
            text-align: right;
        }
    </style>
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="Scripts/bootstrap.min.js"></script>

  <div class="content">
      
<%--<script type = "text/javascript">
function scrollWin() {
    window.scrollTo(0, 500);
}
</script>--%>


        <a href="#menu-toggle" class="btn btn-secondary" id="menu-toggle">HUB-Dashboard</a>

       <form id="form1" runat="server">
 <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
</asp:ScriptManager>
<div>
<%--Your Name :
<asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>
<input id="btnGetTime" type="button" value="Show Current Time" onclick="ShowCurrentTime()"/>--%>
</div>
  <div id="content1" class="container">

        <div class="row">
            
                <div class="panel panel-primary">
                    <div class="panel-heading">
          
                        
         
                        <h3 class="panel-title"><img src="images/searchIcon.png"/>  Panello Ricerca : <input type="text" id="conta" style="color:#ccff33;width:400px;"/></h3>
                        <span class="pull-right clickable close-icon"><i class="fa fa-times"></i></span>
                        <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                    </div>
                    <div class="panel-body">
                        <input type="text" id="myInput" onkeyup="myFunction()" placeholder="Search for vat_number.." title="Type in a vat_number">
                        <input type="text" id="myInput2" onkeyup="myFunction2()" placeholder="Search for nome Azienda.." title="Type in a business_name">

                    </div>
                </div>
           
        </div>
   </div>


  <div id="content" class="container">


    <table      id="myTable">
                    <thead>
                 <tr>
                <th>vat_number</th>
                <th>business_name</th>
                <th>created_date</th>
                <th>activation_status</th>
                <th>stats_hub_activation_message</th>
                </tr>
                </thead>
              <%--  <tbody>
                <tr>
                  <td>                   
                <asp:PlaceHolder ID="DBDataPlaceHolder" runat="server"></asp:PlaceHolder>
                    </td>
               </tbody>--%>  
         <tbody>
                <tr>
                    <td>
                        <button class="btnSelect" type="button"></button>
                    </td>
                    <td>707</td>
                    <td>2018-04-23 10:29:21</td>
                    <td>2018-04-23 10:29:23</td>
                    <td>p6CS9Kdui3jY9rCAmblU8TYz/7E37ZsR3J7ODOQ8o2lfojl6xa2nUy50z/ADLZtb</td>
                    <td>ACQUIS BIANCA</td>
                    <td>COMPANY</td>
                    <td>Attivata da Lynfa</td>
                    <td>CQSBNC46H44A757K</td>
                    <td>8741</td>
                    <td>00698810256</td>
                    <td>ACTIVATED</td>
                    <td>ACTIVATED</td>
                </tr>
                <tr>
                    <td>
                        <button class="btnSelect" type="button"></button>
                    </td>
                    <td>794</td>
                    <td>2018-07-09 14:24:32</td>
                    <td>2018-07-09 14:24:33</td>
                    <td>T21rUuQj7h7Rq42v0L8Zgnv9LQe7J0CRP5G6FCdkVY60hRHRjTmp7qRcsSkonosy</td>
                    <td>AZIENDA AGRICOLA ROSSO ARANCIO S.S.</td>
                    <td>COMPANY</td>
                    <td>Attivata da Lynfa</td>
                    <td>04141414141</td>
                    <td>9088</td>
                    <td>04141414141</td>
                    <td>ACTIVATED</td>
                    <td>ACTIVATED</td>
                </tr>

            <%--</tbody>--%>
    </table>

      <asp:TextBox ID="TextBox5" runat="server" hidden="true"></asp:TextBox>
      <input type="text" id="fvar" style="visibility:hidden;">

</div>
                      <%--**********************************  PRIMO CONTAINER--%>     
  
<div id="content3" class="container">

        <div class="row">
            
                <div class="panel panel-primary">
                    <div class="panel-heading">
                        <h3 class="panel-title">Pannello Dettaglio Azienda : <input type="text" id="fvar2" style="color:#ccff33;width:400px;" /></h3>
                        <span class="pull-right clickable close-icon"><i class="fa fa-times"></i></span>
                        <span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
                    </div>
                    <div class="panel-body">
                     <div class="row">

 <div class="col-md-4">
          <div class="panel panel-success">
            <div class="panel-heading">Dettaglio Azienda</div>



                <table>
    <tr><td>id Azienda</td><td> <input type="text" id="dettNome" ></td></tr>
    <tr><td>id Azienda</td><td> <input type="text" id="dettvat" ></td></tr>
                    
<%--    <tr><td>vat_number</td><td><asp:TextBox ID="TextBox2" runat="server" Width="100px"></asp:TextBox></td></tr>
    <tr><td>Nome</td><td><asp:TextBox ID="TextBox3" runat="server" Width="100px"></asp:TextBox>  </td></tr>
    <tr><td>Date</td><td><asp:TextBox ID="TextBox4" runat="server" Width="100px"></asp:TextBox></td></tr>--%>

                    
</table>

     
               
                 
                                                                                                                        
       

       
          </div>
        </div>
            
                          <div class="col-md-4">
          <div class="panel panel-success">
            <div class="panel-heading">Device</div>
            <div class="panel-body">
             


            </div>
          </div>
        </div>


 <div class="col-md-4">
          <div class="panel panel-success">
            <div class="panel-heading">Dipartimenti</div>
            <div class="panel-body">
              Isi Panel
            </div>
          </div>
        </div>


                    </div>
                </div>
       
        </div>

</div>         
<div id="content4" class="container"> 
        <div class="row">
   
            <div class="container-fluid" style="max-width:1000px; margin:auto; min-width:450px;">
   <div class="page-header">
      <h1>Bootstrap Panels <small>with tabs</small></h1>
   </div>
   <div class="row">
 
   </div>
</div>



        </div>
</div>     





                        <%--********************************* FINE RIGA DETTAGLIO--%>




        </div>

           <asp:TextBox ID="TxbSESS3" runat="server"></asp:TextBox>
           <asp:TextBox ID="TxbSESS2" runat="server"></asp:TextBox>

            </form>     
      
             
       <!--SCRIPT -->

       <%-- <script>
            function onRowClick(tableId, callback) {
                var table = document.getElementById(tableId),
                    rows = table.getElementsByTagName("tr"),
                    i;
                for (i = 0; i < rows.length; i++) {
                    table.rows[i].onclick = function (row) {
                        return function () {
                            callback(row);
                             
                        };
                    }(table.rows[i]);
                }
            };
 
            onRowClick("myTable", function (row){
                var value = row.getElementsByTagName("td")[1].innerHTML;
                                                                      


                var col1 = value;
                document.getElementById("fvar").value = col1.trim();
                document.getElementById("fvar2").value = col1.trim();
                document.getElementById('<%=TextBox5.ClientID %>').value = col1.trim();                                    
                PageMethods.GetCurrentTime(document.getElementById("<%=TextBox5.ClientID%>").value, OnSuccess);
           
                function OnSuccess(response, userContext, methodName) {

                    //document.getElementById("dettaglio").value = response;
                    //alert(response);
                  
                                        
                     var input = response;

                    var fields = input.split('|');

                    document.getElementById("dettNome").value = fields[18];
                    document.getElementById("dettvat").value = fields[16];
                    var street = fields[1];



                 }
            });

 </script>

      --%>


       <!--FINE SCRIPT -->



    </div>
</asp:Content>