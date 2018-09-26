<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AppCliente.Register" %>

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
         <legend><span class="glyphicon glyphicon-user" aria-hidden="true"></span> Formulario de Registracion de Usuario</legend>

        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtNombre">Nombre</label>  
          <div class="col-md-4">
          <input runat="server" id="txtNombre" name="txtNombre" placeholder="Nombre" class="form-control input-md" required="" type="text"/>
          </div>
        </div>
        <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtEmail">Email</label>  
          <div class="col-md-4">
          <input runat="server" id="txtEmail" name="txtEmail" placeholder="Email" class="form-control input-md" required="" type="text"/>
          </div>
        </div>
         <!-- Text input-->
        <div class="form-group">
          <label class="col-md-4 control-label" for="txtPassword">Password</label>  
          <div class="col-md-4">
          <input  runat="server" id="txtPassword" name="txtPassword" placeholder="Password" class="form-control input-md" required="" type="text"/>
          </div>
        </div>
    </div>
         <div class="form-group">
             <label class="col-md-4 control-label" for="btnGuardar"></label>
            <div class="col-md-4">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" class="btn btn-danger" OnClick="btnGuardar_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
