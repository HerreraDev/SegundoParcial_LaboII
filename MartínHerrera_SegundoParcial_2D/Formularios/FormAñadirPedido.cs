using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using Excepciones;

namespace Formularios
{
    public delegate bool DelegadoPedidos(Pedido auxPedido);

    public partial class FormAñadirPedido : Form
    {
        public event DelegadoPedidos insertarYAñadirPedido;
        public FormAñadirPedido()
        {
            InitializeComponent();
            insertarYAñadirPedido += ManejadorBaseDeDatos.InsertarProducto;
            insertarYAñadirPedido += GenerarTicket;
        }

        private void FormAñadirPedido_Load(object sender, EventArgs e)
        {
            this.cmb_TipoProducto.DataSource = Enum.GetValues(typeof(Pedido.ETipoComida));
            this.cmb_Delivery.DataSource = Enum.GetValues(typeof(Pedido.ETieneDelivery));
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if((Pedido.ETieneDelivery)this.cmb_Delivery.SelectedItem == Pedido.ETieneDelivery.no)
                {
                    //constuyo un pedido
                    Pedido auxPedido = new Pedido(Stock.GetId(),
                        (Pedido.ETipoComida)this.cmb_TipoProducto.SelectedItem,
                        (Pedido.ETieneDelivery)this.cmb_Delivery.SelectedItem,
                        this.txt_Direccion.Text,
                        (double)((Pedido.ETipoComida)this.cmb_TipoProducto.SelectedItem));

                    //lo inserto en la base de datos
                    if (ManejadorBaseDeDatos.InsertarProducto(auxPedido))
                        MessageBox.Show("Pedido agregado a la base de datos");

                    Stock.Pendientes.Enqueue(auxPedido);
                }
                else
                {
                    //si tiene delivery hago el txt
                    //constuyo un pedido
                    Pedido auxPedido = new Pedido(Stock.GetId(),
                        (Pedido.ETipoComida)this.cmb_TipoProducto.SelectedItem,
                        (Pedido.ETieneDelivery)this.cmb_Delivery.SelectedItem,
                        this.txt_Direccion.Text,
                        (double)((Pedido.ETipoComida)this.cmb_TipoProducto.SelectedItem));


                    insertarYAñadirPedido?.Invoke(auxPedido);
                    MessageBox.Show("Pedido agregado a la base de datos y ticket generado");

                    Stock.Pendientes.Enqueue(auxPedido);

                }
            }
            catch(ArchivosException errorArchivo)
            {
                MessageBox.Show(errorArchivo.Message);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Genera un ticket
        /// </summary>
        /// <param name="auxPedido"></param>
        /// <returns></returns>
        public bool GenerarTicket(Pedido auxPedido)
        {

            string auxNombreArchivo = "Pedido"+ " " + "Horario= " + DateTime.Now.ToString("hh, mm, ss") + ".txt";
            string ubicacionArchivo = String.Concat(AppDomain.CurrentDomain.BaseDirectory, auxNombreArchivo);
            Texto serializarTxt = new Texto();
            if(serializarTxt.Guardar(ubicacionArchivo, auxPedido.InfoTicket()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
