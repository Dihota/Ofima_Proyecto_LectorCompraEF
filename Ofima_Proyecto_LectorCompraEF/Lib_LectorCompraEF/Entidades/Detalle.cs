using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_LectorCompraEF.Entidades
{
    public class Detalle
    {
        public int Item { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public double Cantidad { get; set; }
        public string UND { get; set; }
        public double IVA { get; set; }
        public double VlrIVA { get; set; }
        public double VlrUnit { get; set; }
        public double VlrTotal { get; set; }

    }
}
