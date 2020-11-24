using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Entidades
{
    public static class Stock
    {
        static Queue<Pedido> pendientes;
        static Queue<Pedido> entregados;
        static string ubicacionArchivo = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "Pedidos.xml");
        static int idInicial;

        static Stock()
        {
            pendientes = Deserealizar();
            entregados = new Queue<Pedido>();
            idInicial = Pendientes.Count + 1;
        }

        public static Queue<Pedido> Pendientes
        {
            get { return pendientes; }
            set { pendientes = value; }
        }

        public static Queue<Pedido> Entregados
        {
            get { return entregados; }
            set { entregados = value; }
        }

        public static int IdInicial
        {
            get { return idInicial; }
            set { idInicial = value; }
        }


        /// <summary>
        /// Deserealiza un archivo xml con pedidos, los carga en una lista y luego los pasa a una cola
        /// </summary>
        /// <returns></returns>
        public static Queue<Pedido> Deserealizar()
        {
            List<Pedido> auxLista = new List<Pedido>();

            Queue<Pedido> auxQueue = new Queue<Pedido>();

            Xml<List<Pedido>> Leer = new Xml<List<Pedido>>();

            if (Leer.Leer(ubicacionArchivo, out auxLista))
            {
                foreach (Pedido item in auxLista)
                {
                    auxQueue.Enqueue(item);
                }
            }

            return auxQueue;
        }

        /// <summary>
        /// Aumenta el id en 1 y lo devuelve
        /// </summary>
        /// <returns></returns>
        public static int GetId()
        {
            return IdInicial++;
        }
    }
}


    /*List<Pedido> pedidos = new List<Pedido>();

Pedido p1 = new Pedido(1, Pedido.ETipoComida.Empanada, Pedido.ETieneDelivery.si, "Mitre 1200", (double)Pedido.ETipoComida.Empanada);
Pedido p2 = new Pedido(2, Pedido.ETipoComida.Hamburguesa, Pedido.ETieneDelivery.no, "Mitre 1200", (double)Pedido.ETipoComida.Hamburguesa);
Pedido p3 = new Pedido(3, Pedido.ETipoComida.Pizza, Pedido.ETieneDelivery.si, "Mitre 1200", (double)Pedido.ETipoComida.Pizza);
Pedido p4 = new Pedido(4, Pedido.ETipoComida.Gaseosa, Pedido.ETieneDelivery.si, "Mitre 1200", (double)Pedido.ETipoComida.Gaseosa);
Pedido p5 = new Pedido(5, Pedido.ETipoComida.Pizza, Pedido.ETieneDelivery.si, "Mitre 1200", (double)Pedido.ETipoComida.Pizza);
Pedido p6 = new Pedido(6, Pedido.ETipoComida.Gaseosa, Pedido.ETieneDelivery.si, "Mitre 1200", (double)Pedido.ETipoComida.Gaseosa);

pedidos.Add(p1);
pedidos.Add(p2);
pedidos.Add(p3);
pedidos.Add(p4);
pedidos.Add(p5);
pedidos.Add(p6);


Xml<List<Pedido>> auxXmlUniversidad = new Xml<List<Pedido>>();
auxXmlUniversidad.Guardar(ubicacionArchivo, pedidos);*/