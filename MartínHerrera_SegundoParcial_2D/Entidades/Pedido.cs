using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public class Pedido
    {
        public enum ETipoComida
        {
            Pizza = 400,
            Empanada = 60,
            Hamburguesa = 40,
            Gaseosa = 30,
        }
        public enum ETieneDelivery
        {
            si,
            no
        }

        int idPedido;
        ETipoComida comida;
        ETieneDelivery esConDelivery;
        string direccion;
        double precioFinal;

        public Pedido()
        {

        }
        public Pedido(int idPedido, ETipoComida comida, ETieneDelivery esConDelivery, string direccion, double precioFinal)
        {
            this.idPedido = idPedido;
            this.comida = comida;
            this.esConDelivery = esConDelivery;
            this.direccion = direccion;
            this.precioFinal = precioFinal;
        }

        public int NroPedido
        {
            get { return this.idPedido; }
            set { this.idPedido = value; }
        }

        public ETipoComida Comida
        {
            get { return this.comida; }
            set { this.comida = value; }
        }

        public ETieneDelivery TieneDelivery
        {
            get { return this.esConDelivery; }
            set { this.esConDelivery = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set 
            {
                if(value == string.Empty)
                {
                    throw new DatosErroneosException("Error, direccion vacia");
                }
                this.direccion = value; 
            }
        }


        public double PrecioFinal
        {
            get { return this.precioFinal; }
            set
            { 
                this.precioFinal = ValidarPrecio(value.ToString()); 
            }
        }
        

        /// <summary>
        /// Override del ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "NºPedido : " + this.NroPedido + " - Comida : " + this.Comida + " - Delivery: " + this.TieneDelivery;
        }

        /// <summary>
        /// Metodo que devuelve un string a ser usado en el guardado del archivo.txt
        /// </summary>
        /// <returns></returns>
        public string InfoTicket()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine("<--------------------------------------->");
            datos.AppendLine($"Ticket Nº {this.NroPedido}");
            datos.AppendLine($"Comida: {this.Comida}");
            datos.AppendLine($"Delivery: {this.TieneDelivery} ");
            datos.AppendLine($"Direccion: {this.Direccion}");

            return datos.ToString();

        }


        /// <summary>
        /// Valida que el precio ingresado sea correcta
        /// </summary>
        /// <param name="auxNumero"></param>
        /// <returns>retorna el numero parseado o lanza una excepcion</returns>
        public static double ValidarPrecio(string auxNumero)
        {
            if (double.TryParse(auxNumero, out double precioParseado) && precioParseado > 0)
            {
                return precioParseado;
            }
            else
            {
                throw new DatosErroneosException("El precio calculado debe ser mayor a 0");
            }
        }



    }
}
