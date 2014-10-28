using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Transacao
    {
        public int Id { get; set; }

        [DisplayName("Opção")]
        public TipoOpcao Opcao { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Valor")]
        public decimal Valor { get; set; }

        [DisplayName("Data")]
        public DateTime Data { get; set; }

        [DisplayName("Importância")]
        public TipoImportancia Importancia { get; set; }

        [DisplayName("Deduz do imposto de renda")]
        public Boolean DeduzDoImpostoDeRenda { get; set; }

        [DisplayName("Cpf/Cnpj")]
        public String CpfCnpj { get; set; }
    }
}
