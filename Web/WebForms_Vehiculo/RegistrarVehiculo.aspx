<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistrarVehiculo.aspx.cs" Inherits="Web.WebForms_Vehiculo.RegistrarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 32px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">

     <br />
    <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Registrar Vehículo"></asp:Label></div></center>
  <br />
    <div>
        <center>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblMarca" runat="server" Text="Marca:" ></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrDoListMarca" runat="server" Height="16px" Width="131px">
                        </asp:DropDownList>
                        <asp:Button ID="BtnAgregarMarca" runat="server" Font-Bold="False" OnClick="BtnAgregarMarca_Click" Text="+" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblDominio" runat="server" Text="Dominio:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxDominio" runat="server"></asp:TextBox>
                    </td>
                </tr>
    
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblModelo" runat="server" Text="Modelo:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrDoListModelo" runat="server" Height="16px" Width="131px">
                        </asp:DropDownList>
                        <asp:Button ID="BtnAgregarModelo" runat="server" Font-Bold="False" OnClick="BtnAgregarModelo_Click" Text="+" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblKilometraje" runat="server" Text="Kilometraje:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxKilometraje" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblVersión" runat="server" Text="Versión:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrDoListVersion" runat="server" Height="16px" Width="131px">
                        </asp:DropDownList>
                        <asp:Button ID="BtnAgregarVersion" runat="server" Font-Bold="False" OnClick="BtnAgregarVersion_Click" Text="+" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblValorAdquisicion" runat="server" Text="Valor de Adquisición:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxValorAdquisicion" runat="server"></asp:TextBox>
                    </td>
                </tr>
    
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblUsoVehiculo" runat="server" Text="Uso del vehículo:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrDoListUsoVehiculo" runat="server" Height="16px" Width="131px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblValorVenta" runat="server" Text="Valor de venta:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxValorVenta" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblAñoPatentamiento" runat="server" Text="Año de patentamiento:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxAñoPatentamiento" runat="server" Height="16px" Width="131px"></asp:TextBox>
                        <asp:CheckBox ID="ChkBoxPatentado" runat="server" EnableTheming="True" Text="   " />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblNroChasis" runat="server" Text="Número de chasis:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxNroChasis" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblColor" runat="server" Text="Color:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DrDoListColor" runat="server" Height="16px" Width="131px">
                        </asp:DropDownList>
                        <asp:Button ID="BtnAgregarColor" runat="server" Font-Bold="False" OnClick="BtnAgregarColor_Click" Text="+" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblNroMotor" runat="server" Text="Número de motor:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxNroMotor" runat="server" Width="170px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblObservaciones" runat="server" Text="Observaciones:"></asp:Label>
                    </td>
                    <td></td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>

                <tr>
                    <td colspan="2" rowspan="3">
                        <asp:TextBox ID="TxtBoxObservaciones" runat="server" Height="60px" Width="380px"></asp:TextBox>
                    </td>
                    <td class="auto-style1"></td>                  
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>

                <tr>
                    
                    <td class="auto-style1"></td>                     
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>

                <tr>
                     
                    <td class="auto-style1"></td>                    
                    <td class="auto-style5"></td>
                    <td></td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5"></td>
                    <td></td>
                </tr>
                              

                <tr>
                    <td class="auto-style4"></td>
                    <td>
                        <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" Width="111px" OnClick="BtnCancelar_Click" />
                    </td>
                    <td class="auto-style1"></td>
                    <td class="auto-style5">
                        <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" Width="111px" OnClick="BtnRegistrar_Click" />
                    </td>
                    <td></td>
                </tr>

            </table>


        </center>        
    </div>

</asp:Content>
