<%@ Page Title="Login" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web.WebForms_Login.Login"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
     <style type="text/css">
         .auto-style1 {
             width: 107px;
         }
     </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">
    
    <br />
    <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Login"></asp:Label></div></center>
  <br />
  <div>
   <center>
    <table>
       <tr> 
           <td class="auto-style1"><asp:Label ID="LblDNI" runat="server" Text="DNI:*"></asp:Label></td>
           <td><asp:TextBox ID="TxtBoxDNI" runat="server" ValidateRequestMode="Disabled" Width="131px"></asp:TextBox></td>
             
       </tr>
        <tr> 
           <td class="auto-style1"><asp:Label ID="LblContraseña" runat="server" Text="Contraseña:*"></asp:Label></td>
           <td><asp:TextBox ID="TxtBoxContraseña" runat="server" ValidateRequestMode="Disabled" Width="131px"></asp:TextBox></td>
       </tr>
        <tr> 
           <td><asp:Button ID="BtnRecuperarContraseña" runat="server" Text="Olvidé mi contraseña" OnClick="BtnRecuperarContraseña_Click"></asp:Button></td>
           <td><asp:Button ID="BtnIngresar" runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" style="height: 26px"></asp:Button></td>
       </tr>
    </table>
<br />

   </center>
</div>

</asp:Content>
