using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace Test_Unitario
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Se testea que funcione la creacion de un pedido
        /// </summary>
        [TestMethod]
        public void TestGenerarPedido()
        {
            Pedido pedido = new Pedido(1,Pedido.ETipoComida.Empanada,Pedido.ETieneDelivery.no,"asd", (double)Pedido.ETipoComida.Empanada);
            Assert.IsNotNull(pedido);
        }

    }
}
