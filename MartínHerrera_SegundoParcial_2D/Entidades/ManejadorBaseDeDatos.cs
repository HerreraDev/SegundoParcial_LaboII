using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ManejadorBaseDeDatos
    {
        static SqlConnection conexionALaBase;

        static ManejadorBaseDeDatos()
        {
            conexionALaBase = new SqlConnection();
            conexionALaBase.ConnectionString = "Data Source=.\\sqlexpress; Initial Catalog=SegundoParcial; Integrated Security=True;";

        }

        public static bool InsertarProducto(Pedido auxPedido)
        {
            SqlCommand comandoAEjecutar;
            comandoAEjecutar = new SqlCommand();
            bool exito = false;
            try
            {
                comandoAEjecutar.Connection = conexionALaBase;
                comandoAEjecutar.CommandType = CommandType.Text;

                comandoAEjecutar.CommandText = "Insert into Pedido(tipoComida,esDelivery, direccion, precioFinal)" +
                "values(@auxTipoComida,@auxEsDelivery, @auxDireccion, @auxPrecioFinal)"; ;

                comandoAEjecutar.Parameters.Clear();
                comandoAEjecutar.Parameters.Add(new SqlParameter("@auxTipoComida", auxPedido.Comida.ToString()));
                comandoAEjecutar.Parameters.Add(new SqlParameter("@auxEsDelivery", auxPedido.TieneDelivery.ToString()));
                comandoAEjecutar.Parameters.Add(new SqlParameter("@auxDireccion", auxPedido.Direccion));
                comandoAEjecutar.Parameters.Add(new SqlParameter("@auxPrecioFinal", auxPedido.PrecioFinal));

                if (conexionALaBase.State != ConnectionState.Open)
                {
                    conexionALaBase.Open();
                }

                comandoAEjecutar.ExecuteNonQuery();
                exito = true;
            }
            catch (Exception e)
            {
                exito = false;
                throw e;
            }
            finally
            {
                if (conexionALaBase.State != ConnectionState.Closed)
                {
                    conexionALaBase.Close();
                }
            }

            return exito;
        }
    }
}
