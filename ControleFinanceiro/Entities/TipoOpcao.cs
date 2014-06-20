using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Entities
{
    public enum TipoOpcao
    {
        [Description("Entrada")]
        Entrada = 1,

        [Description("Saída")]
        Saída = 2
    }
}