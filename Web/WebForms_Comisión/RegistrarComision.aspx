<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarComision.aspx.cs" Inherits="Web.WebForms_Comisión.ConsultarComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">
         
 <br />
     <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Registro de Comisión"></asp:Label></div></center>
  <br />

  <div> 
     <center>
       <table style="width: 415px"> 
        <tr> 
           <td class="auto-style1"><asp:Label ID="LblPorcentaje" runat="server" Text="Porcentaje: (%)"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxPorcentaje" runat="server" ValidateRequestMode="Disabled" Width="168px"></asp:TextBox></td>
        </tr>

         <tr> 
           <td class="auto-style1"><asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" OnClick="BtnCancelar_Click" Width="89px"></asp:Button></td>
           <td class="auto-style2"><asp:Button ID="BtnGuardar" runat="server" Text="Guardar" OnClick="BtnGuardar_Click" Width="89px"></asp:Button></td>
       </tr>

      </table>
     </center>
      <br />
  </div>

</asp:Content>
