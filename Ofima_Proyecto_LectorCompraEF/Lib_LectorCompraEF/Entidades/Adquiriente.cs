using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_LectorCompraEF.Entidades
{
    public class Adquiriente
    {
        public string FechaFact { get; set; }
        public string HoraFact { get; set; }
        public string NomAdquiriente { get; set; }
        public string Nit { get; set; }
        public string CUFE { get; set; }
        public string Direccion { get; set; }
        public int CodPostal { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public int MedioDePago { get; set; }
        public int FormaPago { get; set; }
        public int Plazo { get; set; }
    }
}
