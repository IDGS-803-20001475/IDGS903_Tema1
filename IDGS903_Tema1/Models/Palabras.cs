using IDGS903_TEMA1.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS903_TEMA1.Models
{
    public class Palabras
    {
        public string esp { get; set; }
        public string ing { get; set; }
        public string busqueda { get; set; }
        public string buscar(string idioma)
        {
            var ts = new TraductorService();
            Array traducciones = ts.LeerPalabras();
            string resultado = "No se encontró la traducción";

            if (idioma == "ing")
            {
                foreach (string item in traducciones)
                {
                    if (this.busqueda.ToUpper() == item.Split('=')[1].ToUpper())
                    {
                        resultado = item.Split('=')[0].ToUpper();
                    }
                }
            }
            else if (idioma == "esp")
            {
                foreach (string item in traducciones)
                {
                    if (this.busqueda.ToUpper() == item.Split('=')[0].ToUpper())
                    {
                        resultado = item.Split('=')[1].ToUpper();
                    }
                }
            }

            return resultado;
        }
    }
    
}