<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarModelo.aspx.cs" Inherits="Web.WebForms_Vehiculo.AB_Modelo.RegistrarModelo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">

    <br />
     <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Registrar Modelo"></asp:Label></div></center>
  <br />

  <div> 
     <center>
       <table style="width: 415px"> 
        
           <tr> 
           <td class="auto-style3"><asp:Label ID="LblMarca" runat="server" Text="Marca:"></asp:Label></td>
           <td class="auto-style3">
               <asp:DropDownList ID="DrDoListMarca" runat="server" Height="16px" Width="162px">
               </asp:DropDownList>
            </td>
        </tr>

           <tr> 
           <td class="auto-style3"><asp:Label ID="LblNombre" runat="server" Text="Nombre:"></asp:Label></td>
           <td class="auto-style3">
               <asp:TextBox ID="TxtBoxNombre" runat="server" Width="159px"></asp:TextBox>
            </td>
        </tr>

        <tr> 
           <td class="auto-style4">
               <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" Width="79px" OnClick="BtnCancelar_Click" />
            </td>
           <td class="auto-style4">
               <asp:Button ID="BtnGuardar" runat="server" Text="Guardar" Width="79px" OnClick="BtnGuardar_Click"/>
            </td>
        </tr>
      </table>
     </center>
      <br />
  </div>

</asp:Content>
