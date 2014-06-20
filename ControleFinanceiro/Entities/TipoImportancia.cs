using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Entities
{
    public enum TipoImportancia
    {
        [Description("Importante")]
        Importante = 1,

        [Description("Importante/Dispensável")]
        ImportanteDispensável = 2,

        [Description("Dispensável")]
        Dispensável = 3
    }
}