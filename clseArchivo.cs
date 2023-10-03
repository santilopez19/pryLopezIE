using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLopezSP1
{
    internal class clseArchivo
    {
        internal class clsArchivo
        {
            public void Grabar(string datosConcatenados)
            {
                StreamWriter AD = new StreamWriter("../../Resources/Carpetas de Proveedores/Datos Proveedores/datosProveedorConPuntoComa.txt", true); //Abrir AdeD
                AD.WriteLine(datosConcatenados); //Leer AdeD
                AD.Close(); //Cerrar AdeD
            }


        }
    }
}
