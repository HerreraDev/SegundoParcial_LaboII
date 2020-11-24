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
using System.Xml;
using System.Xml.Serialization;
using System.Threading;
using Excepciones;

namespace Formularios
{

    public partial class FormPedidos : Form
    {
        Thread hiloEntregas;
        Random tiempoRandom;

        public FormPedidos()
        {
            InitializeComponent();
            tiempoRandom = new Random();

        }

        private void btn_Atender_Click(object sender, EventArgs e)
        {

            if (hiloEntregas is null || !(hiloEntregas.IsAlive))
            {
                this.hiloEntregas = new Thread(EntregarPedidos);
                hiloEntregas.Start();
            }

        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            if (hiloEntregas.IsAlive)
            {
                hiloEntregas.Abort();
            }

        }

        /// <summary>
        /// Metodo lanzado en el hilo llamado hiloEntregas
        /// </summary>
        public void EntregarPedidos()
        {
            while (true)
            {
                if(Stock.Pendientes.Count > 0)
                {
                    if (this.rtb_Entregados.InvokeRequired || this.rtb_Pendientes.InvokeRequired)
                    {
                        this.rtb_Entregados.BeginInvoke((MethodInvoker)delegate ()
                        {
                            Stock.Entregados.Enqueue(Stock.Pendientes.Dequeue());

                            rtb_Entregados.Text = Stock.Entregados.ToStringRichBoxQueue();

                            rtb_Pendientes.Text = Stock.Pendientes.ToStringRichBoxQueue();
                        });
                    }
                    else
                    {

                        Stock.Entregados.Enqueue(Stock.Pendientes.Dequeue());

                        rtb_Entregados.Text = Stock.Entregados.ToStringRichBoxQueue();

                        rtb_Pendientes.Text = Stock.Pendientes.ToStringRichBoxQueue();
                    }
                    Thread.Sleep(tiempoRandom.Next(2000, 4000));
                    EntregarPedidos();
                }
            }
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {
            try
            { 
                //Construyo el richtextbox
                rtb_Pendientes.Text = Stock.Pendientes.ToStringRichBoxQueue();

            }
            catch (ArchivosException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void FormPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hiloEntregas != null)
            {
                this.hiloEntregas.Abort();
            }
        }

        private void btn_PedidoNuevo_Click(object sender, EventArgs e)
        {
            FormAñadirPedido formAñadirPedido = new FormAñadirPedido();
            formAñadirPedido.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

