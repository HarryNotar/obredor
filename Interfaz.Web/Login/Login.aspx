<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Interfaz.Web.Login.Login" %>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <title>Obredor Automotores</title>

    <!-- Bootstrap core CSS -->
    <link href="/Content/bootstrap.min.css" rel="stylesheet">

  </head>

  <body style="background-color: #f2f2f2;">
      <div class="row">
          <div class="col-sm-offset-4 col-sm-4">
              <form runat="server">
                <div class="container">
                  <div class="form-signin" style="padding-top:30%;">

                    <div class="form-group" >
                        <label for="txt_nroDoc"  class="control-label">Número de documento *</label>
                        <asp:TextBox ID="txt_nroDoc" runat="server" pattern="[0-9]{2}[,][0-9]{3}[,][0-9]{3}" title="99,999,999" class="form-control" placeholder="Ingrese su número de documento" required="true"></asp:TextBox>
	    	        </div>

                    <div class="form-group" >
                        <label for="txt_contraseña" class="control-label">Contraseña *</label>
                        <asp:TextBox ID="txt_contraseña"  type="password" runat="server" class="form-control" placeholder="Ingrese su contraseña" required="true"></asp:TextBox>
                    </div>

                 </div>
                    <asp:Button ID="btn_ingresar" runat="server" Text="Ingresar" class="btn btn-lg btn-primary btn-block" OnClick="btn_ingresar_Click"/>
                </div>
              </form>
          </div>
      </div>
      <br />
      <div class="row">
          <div class="col-sm-offset-2 col-sm-8">
                <div class="alert alert-warning fade-in" runat="server" id="div_advertencia">
                    <strong><asp:Label ID="lbl_mensaje_advertencia" runat="server" Text=""></asp:Label></strong>
                </div>

                <div class="alert alert-danger fade-in" runat="server" id="div_error">
                    <strong><asp:Label ID="lbl_mensaje_error" runat="server" Text=""></asp:Label></strong>
                </div>
          </div>
    </div>
  </body>
</html>
