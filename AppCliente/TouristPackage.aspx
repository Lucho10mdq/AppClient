﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TouristPackage.aspx.cs" Inherits="AppCliente.TouristPackage" %>


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
         .nav nav-pills-center {
                  position: relative;
                  text-align: center;
               
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
                <asp:Label ID="lblUser" runat="server" ForeColor="White"></asp:Label>
            </div>
        </header>
        <form id="form1" runat="server">
        <div>
            <nav class="navbar navbar-default">
              <div class="container-fluid">
                <div class="navbar-header">
                  <a class="navbar-brand" href="Main.aspx">
                   <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
                  </a>
                  <a class="navbar-brand">Bienvenidos</a>
                  <a class="navbar-brand" href="Add.aspx"><span class="glyphicon glyphicon-user" aria-hidden="true"></span>Agregar Clientes</a>  
                  <a class="navbar-brand" href="List.aspx"><span class="glyphicon glyphicon-th-list" aria-hidden="true"></span>Listado de Clientes</a>
                  <a class="navbar-brand" href="Search.aspx"><span class="glyphicon glyphicon-th-list" aria-hidden="true"></span>Buscar Cliente</a>
                    <a class="navbar-brand" href="TouristPackage.aspx"><span class="glyphicon glyphicon-th-list" aria-hidden="true"></span>Paquete Turistico</a>
                     <a class="navbar-brand" href="BookingAdd.aspx"><span class="glyphicon glyphicon-th-list" aria-hidden="true"></span>Contrataciones</a>
                  <a class="navbar-brand" href="Login.aspx"><span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>Salir</a>  
                </div>
              </div>
            </nav>
            <div style="text-align:center">
              <ul class="nav nav-pills" style="display:inline-table">
                 <li style="display:inline"><a href="AddPackage.aspx">Agregar Paquete</a></li>
                 <li style="display:inline"><a href="ListPackage.aspx">Listar Paquetes</a></li>
                 <li style="display:inline"><a href="ModifyPackage.asp">Modificar Paquete</a></li>
                 <li style="display:inline" role="presentation" class="dropdown">
                 <a class="dropdown-toggle" data-toggle="dropdown" href="#" role="button" aria-haspopup="true" aria-expanded="false">
                     Dropdown <span class="caret"></span>
                  </a>
                  <ul class="dropdown-menu">      
                  </ul>
                  </li>    
                </ul>
            </div>
        </div>
        </form>
         <br />
         <br />
        <div class="row">
           <div class="col-md-12 col-xs-12">
              <p class="text-center">
                  Developed by Luis Hoyos
                  <br>
                   Email:luchomdq10@gmail.com
               </p>
            </div>
        </div>
    </body>
</html>
