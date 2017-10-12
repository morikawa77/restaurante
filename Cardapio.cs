using System;
namespace Restaurante
{
    public class Cardapio
    {
        public Cardapio()
        {
        }

        public int idItem { get; set; }
        public string tipoItem { get; set; }
        public String nomeItem { get; set; }
        public String descricaoItem { get; set; }
        public Decimal preco { get; set;  }
        public String diaSemanaDisponivel { get; set; }
    }
}
