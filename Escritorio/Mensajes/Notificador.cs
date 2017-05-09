using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Mensajes
{
    public static class Notificador
    {
        public enum TipoDato { CantCuotas, Comision, NoExistenVehiculosDisponibles, NoExistenVehiculos, ClienteNoValido, UsuarioNoRegistrado, EmpleadoNoRegistrado, ClientNoRegistrado, NroDoc, Apellido, Nombre, Telefono1, Telefono23, Email, Localidad, Direccion, Contraseña, Cliente, Dominio, Kilometraje, NroMotor, NroChasis, Marca, Modelo, Version, MarcaModeloVersion, Color, Vehiculo, MontoSinAsignar, MontoSobreAsignado}


        /// <summary>
        /// Muestra un mensaje notificando que la operación se realizó con éxito y asigna el valor "OK" a DialogResult.
        /// </summary>
        public static void NotificarOperacionRealizada()
        {
            MessageBox.Show("La operación ha sido realizada satisfactoriamente", "Operación realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Muestra un mensaje notificando que falta ingresar un dato obligatorio.
        /// </summary>
        public static void NotificarAdvertencia(TipoDato tipoDato)
        {
            String info = "";

            switch(tipoDato)
            {
                case TipoDato.CantCuotas:
                    info = "La cantidad de cuotas no puede ser 0 (cero) si se financiará una parte de la venta.";
                    break;
                case TipoDato.Comision:
                    info = "No existe ninguna comisión registrada.";
                    break;
                case TipoDato.NoExistenVehiculosDisponibles:
                    info = "No existen vehículos con las características requeridas que estén disponibles para su venta.";
                    break;
                case TipoDato.NoExistenVehiculos:
                    info = "No existen vehículos con las características requeridas.";
                    break;
                case TipoDato.ClienteNoValido:
                    info = "El número de documento y la dirección de e-mail ingresadas no corresponden a un usuario válido. Por favor, vuelva a intentarlo.";
                    break;
                case TipoDato.UsuarioNoRegistrado:
                    info = "El número de documento y la contraseña ingresadas no corresponden a un usuario válido. Por favor, vuelva a intentarlo.\nSi aún no se ha registrado, solicite el registro al Administrador.";
                    break;
                case TipoDato.EmpleadoNoRegistrado:                    
                    info = "El empleado no está registrado. Por favor, regístrelo para continuar.";
                    break;
                case TipoDato.ClientNoRegistrado:
                    info = "El cliente no está registrado. Por favor, regístrelo para continuar.";
                    break;
                case TipoDato.NroDoc:
                    info = "El campo DNI es obligatorio.";
                    break;
                case TipoDato.Apellido:
                    info = "El campo Apellido es obligatorio.";
                    break;
                case TipoDato.Nombre:
                    info = "El campo Nombre es obligatorio.";
                    break;
                case TipoDato.Localidad:
                    info = "El campo Localidad es obligatorio.";
                    break;
                case TipoDato.Direccion:
                    info = "El campo Dirección es obligatorio.";
                    break;
                case TipoDato.Telefono1:
                    info = "Se debe indicar, al menos, un número de teléfono.";
                    break;
                case TipoDato.Telefono23:
                    info = "El campo de teléfono secundario está incompleto. Por favor, complételo.";
                    break;
                case TipoDato.Email:
                    info = "El campo Dirección de e-mail es obligatorio.";
                    break;
                case TipoDato.Contraseña:
                    info = "El campo Contraseña es obligatorio y debe tener 8 caracteres.";
                    break;
                case TipoDato.Cliente:
                    info = "Debe seleccionar un cliente para continuar.";
                    break;
                case TipoDato.Dominio:
                    info = "El campo Dominio es obligatorio.";
                    break;
                case TipoDato.Kilometraje:
                    info = "Un Vehículo usado debe tener un kilometraje distinto de 0. Por favor, corrija el Uso o el Kilometraje del Vehículo para continuar.";
                    break;
                case TipoDato.NroChasis:
                    info = "El campo Número de chasis es obligatorio.";
                    break;
                case TipoDato.NroMotor:
                    info = "El campo Número de motor es obligatorio.";
                    break;
                case TipoDato.Marca:
                    info = "Debe seleccionar una marca para continuar.";
                    break;
                case TipoDato.Modelo:
                    info = "Debe seleccionar un modelo para continuar.";
                    break;
                case TipoDato.Version:
                    info = "Debe seleccionar un versión para continuar.";
                    break;
                case TipoDato.Color:
                    info = "Debe seleccionar un color para continuar.";
                    break;
                case TipoDato.Vehiculo:
                    info = "Debe seleccionar un vehículo para continuar.";
                    break;
                case TipoDato.MontoSinAsignar:
                    info = "Aún resta dinero que no se ha asignado a ningún medio de pago. Por favor, asigne el total del monto de la venta a algún/os medios de pago para continuar.";
                    break;
                case TipoDato.MontoSobreAsignado:
                    info = "Se ha sobreasignado dinero y se superó el monto requerido para realizar la venta. Por favor, asigne nuevamente el monto a algún/os medios de pago para continuar.";
                    break;
            }

            MessageBox.Show(info, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        /// <summary>
        /// Muestra un mensaje notificando que se produjo un error inesperado.
        /// Este mensaje sirve para los casos donde se captura una excepcion.
        /// </summary>
        /// <param name="e"></param>
        public static void NotificarErrorInesperado(Exception e)
        {
            MessageBox.Show(e.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
