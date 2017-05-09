<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EliminarMarca.aspx.cs" Inherits="Web.WebForms_Vehiculo.AB_Marca.EliminarMarca" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <br />
     <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Eliminar Marca"></asp:Label></div></center>
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
           <td class="auto-style4">
               <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" Width="79px" OnClick="BtnCancelar_Click" />
            </td>
           <td class="auto-style4">
               <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" Width="79px" OnClick="BtnEliminar_Click" />
            </td>
        </tr>
      </table>
     </center>
      <br />
  </div>


</asp:Content>
