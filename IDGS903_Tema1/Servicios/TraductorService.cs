using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS903_TEMA1.Servicios
{
    public class TraductorService
    {
        public void GuardarTraduccion(Palabras pal)
        {
            var ing = pal.ing;
            var esp = pal.esp;
            var palabras = ing + "=" + esp + Environment.NewLine;

            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");
            File.AppendAllText(archivo, palabras);
            ing = "";
            esp = "";
        }
        public Array LeerPalabras()
        {
            Array palData = null;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/palabras.txt");

            if (File.Exists(archivo))
            {
                palData = File.ReadAllLines(archivo);
            }

            return palData;
        }
        
    }
}