<%@ Page Title="Recuperar Contraseña" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RecuperarContraseña.aspx.cs" Inherits=" Web.WebForms_Login.RecuperarContraseña" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">
    
<br />
    <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Recuperar Contraseña"></asp:Label></div></center>
  <br />
    <div>
   <center>
    <table>
       <tr> 

           <td class="auto-style1"><asp:Label ID="LblDNI" runat="server" Text="DNI:*"></asp:Label></td>
           <td><asp:TextBox ID="TxtBoxDNI" runat="server" ValidateRequestMode="Disabled" Width="131px"></asp:TextBox></td>
             
       </tr>

        <tr> 
           <td class="auto-style1"><asp:Label ID="LblEmail" runat="server" Text="Dirección de e-mail:*"></asp:Label></td>
           <td><asp:TextBox ID="TxtBoxEmail" runat="server" ValidateRequestMode="Disabled" Width="131px"></asp:TextBox></td>
       </tr>
       
        <tr>             
           <td><asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click"></asp:Button></td>
           <td><asp:Button ID="BtnRecuperarContraseña" runat="server" Text="RecuperarContraseña" OnClick="BtnRecuperarContraseña_Click"></asp:Button></td>
       </tr>

    </table>
<br />

   </center>
</div>

</asp:Content>
