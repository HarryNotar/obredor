<%@ Page Title="Registrar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="Interfaz.Web.Persona.Registrar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <div class="page-header">
            <label class="control-label" ><asp:Label ID="titulo" runat="server" Text=""></asp:Label></label>
        </div>
            
        <div class="row">
           
            <div class="col-sm-6">  
                 <div class="form-group" >
	    	        <label class="control-label" for="txt_apellido">Apellido *</label>
                    <asp:TextBox ID="txt_apellido" runat="server" type="text" class="form-control" placeholder="Ingresá el apellido" required="true"></asp:TextBox>
	  	        </div>

                 <div class="form-group" >
	    	        <label class="control-label" for="txt_nombre">Nombre *</label>
                    <asp:TextBox ID="txt_nombre" runat="server" type="text" class="form-control" placeholder="Ingresá el nombre" required="true"></asp:TextBox>
	  	        </div>

                <div class="form-group" runat="server" id="div_direccion">
                    <label class="control-label" ><asp:Label ID="lbl_direccion" class="control-label" for="txt_direccion" runat="server" Text="Dirección *"></asp:Label></label>
                    <asp:TextBox ID="txt_direccion" runat="server" type="text" class="form-control" placeholder="Ingresá la dirección" required="true"></asp:TextBox>
	  	        </div>

                <div class="form-group">
	    	        <label class="control-label" for="txt_email">Dirección de e-mail *</label>
                    <asp:TextBox ID="txt_email" runat="server" type="email" class="form-control" placeholder="Ingresá el e-mail" required="true"></asp:TextBox>
	  	        </div>
            </div>

            <div class="col-sm-6">
                    
                <div class="form-group" runat="server" id="div_perfil">
                    <label class="control-label" ><asp:Label ID="lbl_perfil" for="cmb_perfil" runat="server" Text="Perfil *"></asp:Label></label>
                    <asp:DropDownList ID="cmb_perfil" runat="server" class="form-control">
                        <asp:ListItem>Administrador</asp:ListItem>
                        <asp:ListItem>General</asp:ListItem>
                        <asp:ListItem>Consultor</asp:ListItem>
                    </asp:DropDownList>
	  	        </div>

                 <div class="form-group" >
	    	        <label class="control-label" for="txt_nroDoc">DNI *</label>
                    <asp:TextBox ID="txt_nroDoc" runat="server" type="text" class="form-control" placeholder="Ingresá el DNI" pattern="[0-9]{2}[,][0-9]{3}[,][0-9]{3}" title="99,999,999" required="true"></asp:TextBox>
	  	        </div>

                <div class="form-group" runat="server" id="div_localidad">
                    <label class="control-label" ><asp:Label ID="lbl_localidad" class="control-label" for="txt_localidad" runat="server" Text="Localidad *"></asp:Label></label>
                    <asp:TextBox ID="txt_localidad" runat="server" type="text" class="form-control" placeholder="Ingresá la localidad" required="true"></asp:TextBox>
	  	        </div>
            
                <div class="form-group" >
	    	        <label class="control-label" for="txt_telefono">Tel&eacute;fono *</label>
                    <asp:TextBox ID="txt_telefono" runat="server" type="text" class="form-control" placeholder="Ingresá el teléfono" pattern="[0-9]{4}[-][0-9]{6}" title="9999-999999" required="true"></asp:TextBox>
	  	        </div>
            
                <div class="form-group">
	    	        <label class="control-label" for="txt_observaciones">Observaciones *</label>
                    <asp:TextBox ID="txt_observaciones" runat="server" type="text" class="form-control" placeholder="Ingresá alguna/s observaciones" TextMode="MultiLine"></asp:TextBox>
	  	        </div>

            </div>
        </div>
        
        <div class="row">
            <div class="col-sm-6">
                <div class="form-group"> 
                    <asp:Button ID="btnSubmit" class="btn btn-default" runat="server" Text="Registrar" OnClick="btnSubmit_Click" />
	  	        </div>
            </div>
        </div>
        <div class="row">
            <div class="alert alert-success fade-in" runat="server" id="div_exito">
                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                <strong><asp:Label ID="lbl_mensaje_exito" runat="server" Text=""></asp:Label></strong>
            </div>

            <div class="alert alert-danger fade-in" runat="server" id="div_error">
                <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                <strong><asp:Label ID="lbl_mensaje_error" runat="server" Text=""></asp:Label></strong>
            </div>
        </div>
        
</asp:Content>
