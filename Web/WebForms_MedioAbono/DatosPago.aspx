<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatosPago.aspx.cs" Inherits="Web.WebForms_MedioAbono.DatosPago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">

      
<br />
    <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Datos del pago"></asp:Label></div></center>
  <br />
   <div>
   <center>
    <table style="width: 415px">

    <tr> 
           <td class="auto-style1"><asp:Label ID="LblTotalAAbonar" runat="server" Text="Total a abonar:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxTotalAAbonar" runat="server" ValidateRequestMode="Disabled" Width="168px" ReadOnly="True"></asp:TextBox></td>
   </tr>

        <tr> 
           <td class="auto-style1"><asp:Label ID="LblMontoSinAsignar" runat="server" Text="Monto restante sin asignar:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxMontoSinAsignar" runat="server" ValidateRequestMode="Disabled" Width="168px" ReadOnly="True"></asp:TextBox></td>
   </tr>

       <tr> 
           <td class="auto-style1"><asp:Label ID="LblMontoEfectivo" runat="server" Text="Monto en efectivo:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxMontoEfectivo" runat="server" ValidateRequestMode="Disabled" Width="168px"></asp:TextBox></td>
           
       </tr>

       <tr> 
           <td class="auto-style1"><asp:Label ID="LblMontoFinanciado" runat="server" Text="Monto financiado:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxMontoFinanciado" runat="server" ValidateRequestMode="Disabled" Width="168px"></asp:TextBox></td>
            
       </tr>

        <tr> 
           <td class="auto-style1"><asp:Label ID="LblTasaInteres" runat="server" Text="Tasa de interés anual:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxTasaInteres" runat="server" ValidateRequestMode="Disabled" Width="168px"></asp:TextBox></td>
            
       </tr>

        <tr> 
           <td class="auto-style1"><asp:Label ID="LblCantidadCuotas" runat="server" Text="Cantidad de cuotas:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxCantidadCuotas" runat="server" ValidateRequestMode="Disabled" Width="168px"></asp:TextBox></td>
   </tr>

        <tr> 
           <td class="auto-style1"><asp:Label ID="LblMontoCuota" runat="server" Text="Monto por cuota:"></asp:Label></td>
           <td class="auto-style2"><asp:TextBox ID="TxtBoxMontoCuota" runat="server" ValidateRequestMode="Disabled" Width="168px"></asp:TextBox></td>
   </tr>

         <tr> 
           <td class="auto-style1"><asp:Button ID="BtnAtras" runat="server" Text="Atrás" OnClick="BtnAtras_Click" Width="89px"></asp:Button></td>
           <td class="auto-style2"><asp:Button ID="BtnRealizarVenta" runat="server" Text="Realizar Venta" OnClick="BtnRealizarVenta_Click" Width="89px"></asp:Button></td>
       </tr>

     </table>
        </center>
<br />
   </div>

</asp:Content>
