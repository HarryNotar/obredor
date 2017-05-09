<%@ Page Title="Consultar Comisión" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ConsultarComision.aspx.cs" Inherits="Web.WebForms_Comisión.ConsultarComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">
        
 <br />
     <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Consulta de Comisión"></asp:Label></div></center>
  <br />

  <div> 
     <center>
       <table style="width: 415px"> 
        <tr> 
           <td class="auto-style1"><asp:Label ID="LblPorcentaje" runat="server" Text="Porcentaje: (%)"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxPorcentaje" runat="server" Type="Double" ValidateRequestMode="Disabled"  Width="168px" ReadOnly="True" ></asp:TextBox></td>
        </tr>

        <tr> 
           <td class="auto-style1"><asp:Label ID="LblFechaDesde" runat="server" Text="Fecha de registro:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxFechaDesde" runat="server" ValidateRequestMode="Disabled" Width="168px" ReadOnly="True"></asp:TextBox></td>
        </tr>
      </table>
     </center>
      <br />
      <center><asp:Button ID="BtnSalir" runat="server" Text="Salir" OnClick="BtnSalir_Click" Width="77px"></asp:Button></center>
  </div>

</asp:Content>
