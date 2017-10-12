using System;
using System.Collections.Generic;

namespace Restaurante
{
    public class Pedidos
    {
        public Pedidos()
        {
        }

        public int idPedido { get; set; }
        public Funcionarios idFuncionario { get; set; }
        public Funcionarios cargo { get; set; }
        public Clientes idCliente { get; set; }
        public bool entrega { get; set; }
        public DateTime dataEntrega { get; set; }
        public Mesas idMesa { get; set; }
        public IList<string> idItemPedido { get; set; }
        public IList<string> idItemDevolvido { get; set; }

    }
}
