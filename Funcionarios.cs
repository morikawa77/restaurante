using System;
namespace Restaurante
{
    public class Funcionarios
    {
        public Funcionarios()
        {
        }

		public int idFuncionario { get; set; }
		public string nomeFuncionario { get; set; }
        public string cargo { get; set; }
		public string rua { get; set; }
		public int num { get; set; }
		public string bairro { get; set; }
		public string referencia { get; set; }
		public string cidade { get; set; }
		public int cep { get; set; }
		public string email { get; set; }
        public DateTime dataAdmissao { get; set; }
        public DateTime dataDemissao { get; set; }
        public Mesas regiaoMesa { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSaida { get; set; }

    }
}
