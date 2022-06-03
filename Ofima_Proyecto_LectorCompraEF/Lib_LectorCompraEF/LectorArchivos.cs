using Lib_LectorCompraEF.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_LectorCompraEF
{
    public class LectorArchivos
    {
        public List<Directorio> Archivos(string Ruta)
        {
            
            List<Directorio> ListArchivos = new List<Directorio>();

            string[] files = Directory.GetFiles(Ruta,"*.xml");

            foreach(string file in files)
            {
                ListArchivos.Add(new Directorio
                {
                    Nombre = file,
                });
            }  

            return ListArchivos;
            
        } 
    }
}
