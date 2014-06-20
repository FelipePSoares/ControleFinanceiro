using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transacao
    {
        public int Id { get; set; }

        public TipoOpcao Opcao { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public TipoImportancia Importancia { get; set; }

        public Boolean DeduzDoImpostoDeRenda { get; set; }

        public String CpfCnpj { get; set; }
    }
}
