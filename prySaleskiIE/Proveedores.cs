using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prySaleskiIE
{
    public class Proveedores
    {
        public string rutaArchivo;
        public void Grabar(string linea)
        {
            StreamWriter sw = new StreamWriter(rutaArchivo + ".csv", true);
            sw.WriteLine(linea);
            sw.Close();
            sw.Dispose();
        }

    }
}
