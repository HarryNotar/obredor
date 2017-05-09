<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SeleccionarVehiculo.aspx.cs" Inherits="Web.WebForms_Vehiculo.SeleccionarVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 218px;
        }
        .auto-style3 {
            width: 31px;
        }
        .auto-style4 {
            width: 173px;
        }
        .auto-style5 {
            width: 181px;
        }
        .auto-style6 {
            height: 94px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CuerpoPaginaUnico" runat="server">

    <br />
    <center><div><asp:Label ID="LblNombrePagina" runat="server" Text="Seleccionar Vehículo y realizar venta"></asp:Label></div></center>
  <br />
    <div>
        <center>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblMarca" runat="server" Text="Marca:" ></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DrDoListMarca" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
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
                    <td class="auto-style2">
                        <asp:DropDownList ID="DrDoListModelo" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
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
                    <td class="auto-style2">
                        <asp:DropDownList ID="DrDoListVersion" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
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
                    <td class="auto-style2">
                        <asp:DropDownList ID="DrDoListUsoVehiculo" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
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
                    <td class="auto-style2">
                        <asp:TextBox ID="TxtBoxAñoPatentamiento" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
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
                    <td class="auto-style2">
                        <asp:DropDownList ID="DrDoListColor" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3"></td>
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
                    <td class="auto-style2"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">
                        <asp:Label ID="LblFechaRegistro" runat="server" Text="Fecha de registro:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxFechaRegistro" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td colspan="2" rowspan="3">
                        <asp:TextBox ID="TxtBoxObservaciones" runat="server" Height="60px" Width="380px"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>                  
                    <td class="auto-style5">
                        <asp:Label ID="LblEstado" runat="server" Text="Estado:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxEstado" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    
                    <td class="auto-style3"></td>                     
                    <td class="auto-style5">
                        <asp:Label ID="LblFechaEstado" runat="server" Text="Fecha de estado:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtBoxFechaEstado" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                     
                    <td class="auto-style3"></td>                    
                    <td class="auto-style5"></td>
                    <td></td>
                </tr>

                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="LblVehiculo" runat="server" Text="Vehículo:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" Width="81px" />
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style5"></td>
                    <td></td>
                </tr>

                <tr>
                    <td colspan="5" class="auto-style6"> 
                        <asp:GridView ID="GridViewVehiculos" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                            <Columns>
                                <asp:BoundField HeaderText="Marca" />
                                <asp:BoundField HeaderText="Modelo" />
                                <asp:BoundField HeaderText="Versión" />
                                <asp:BoundField HeaderText="Color" />
                                <asp:BoundField HeaderText="Año de Patentamiento" />
                                <asp:BoundField HeaderText="Valor de venta" />
                            </Columns>
                          
                        </asp:GridView>
                    </td>                    
                </tr>

                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style2">
                        <asp:Button ID="BtnCancelar" runat="server" Text="Cancelar" Width="111px" />
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">
                        <asp:Button ID="Button2" runat="server" Text="Button" Width="111px" />
                    </td>
                    <td></td>
                </tr>

            </table>


        </center>        
    </div>

</asp:Content>



