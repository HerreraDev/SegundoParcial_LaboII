using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace System.Collections.Generic
{
    public static class ListExtension
    {
        /// <summary>
        /// Genera un string con todo los datos que poseen los pedidos dentro de la cola que llega por parametro
        /// </summary>
        /// <param name="listaPedidos"></param>
        /// <returns></returns>
        public static string ToStringRichBoxQueue(this Queue<Pedido> listaPedidos)
        {
            StringBuilder datos = new StringBuilder();
            foreach (Pedido item in listaPedidos)
            {
                datos.Append(item.ToString());
                datos.AppendLine();
            }

            return datos.ToString();
        }
    }
}
