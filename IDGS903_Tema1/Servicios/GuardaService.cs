using IDGS903_TEMA1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace IDGS903_TEMA1.Servicios
{
    public class GuardaService
    {
        public void GuardarActivo(Maestros maes)
        {
        var mat = maes.Matricula;
        var nom = maes.Nombre;
        var apa = maes.Apaterno;
        var ama = maes.Amaterno;
        var email = maes.Email;
        var datos = mat + "," + nom + "," + apa + "," + ama + "," + email + Environment.NewLine;

        var archivo = HttpContext.Current.Server.MapPath("~/App_Data/datos.txt");
        File.AppendAllText(archivo, datos);
        }
        
    }
}