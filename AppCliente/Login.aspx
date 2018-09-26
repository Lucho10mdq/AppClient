<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppCliente.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style type="text/css">
         body {
            background-color: white;
            margin: 0;
            display: unset;
        }
         .header {
            position: relative;
            top: 0;
            width: 100vw;
            height: 60px;
            background-color: black;
        }
         .logueado{
             color:white;
            font-size:15px;
            text-align:right;
            padding:10px;
         }
         .footer {
            position: absolute;
            bottom: 0;
            color:black;
             font-size:15px;
            padding:10px;
            text-align:center;
             }

    </style>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous"/>

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>
    <header class="header">
        <div class="logueado">
           <span class="glyphicon glyphicon-user" aria-hidden="true"></span>Usuario:
        </div>
    </header>
    <form id="form1" runat="server" class="form-horizontal">
    <div>
        <nav class="navbar navbar-default">
          <div class="container-fluid">
            <div class="navbar-header">
              <a class="navbar-brand" href="Login.aspx">
               <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
              </a>
              <a class="navbar-brand">Bienvenidos</a>
              <a class="navbar-brand" href="Register.aspx"><span class="glyphicon glyphicon-user" aria-hidden="true"></span>Registrarse</a>  
            </div>
          </div>
        </nav>
        <!-- Form Name -->
        <div align="center">
            <legend> Iniciar sesion</legend>
        </div>
       
        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtEmail">Email</label>  
            <div class="col-md-4">
             <div class="input-group">
               <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-envelope" aria-hidden="true"></span></span> 
              <input runat="server" id="txtEmail" name="txtEmail" placeholder="Email" class=" form-control input-md" required="" type="text"/>
            </div>
          </div>
        </div>

        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtPass">Password</label>  
          <div class="col-md-4">
              <div class="input-group">
                  <span class="input-group-addon" id="basic-addon1"><span class="glyphicon glyphicon-lock" aria-hidden="true"></span></span> 
                 <input  runat="server" id="txtPass" name="txtPass" placeholder="Password" class="form-control input-md" required="" type="text"/>
             </div>
          </div>
        </div>
        <!-- Button -->
        <div class="form-group">
          <label class="col-md-6 control-label" for="btnIngresar"></label>
          <div class="col-md-6">  
              <asp:Button ID="btnIngresar" runat="server" class="btn btn-success" Text="Ingresar" OnClick="btnIngresar_Click" />
          </div>
        </div>
      </div>   
    </form>
    <br />
    <br />
     <div class="row">
         <footer>
           <div class="col-md-12 col-xs-12">
              <p class="text-center">
                  Developed by Luis Hoyos
                  <br>
                   Email:luchomdq10@gmail.com
               </p>
            </div>
         </footer>
        </div>
   
</body>
</html>
