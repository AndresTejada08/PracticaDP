using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Practica
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod(Description = "Suma de 2 numeros")]
        public double Suma(double nro1, double nro2)
        {
            double suma = nro1 + nro2;
            return suma;
        }

        [WebMethod(Description = "Resta de 2 numeros")]
        public double Resta(double nro1, double nro2)
        {
            double resta = nro1 - nro2;
            return resta;
        }

        [WebMethod(Description = "Multiplicación de 2 numeros")]
        public double Multiplicacion(double nro1, double nro2)
        {
            double multiplicacion = nro1 * nro2;
            return multiplicacion;
        }

        [WebMethod(Description = "División de 2 numeros")]
        public string Division(double nro1, double nro2)
        {
            if (nro2 == 0) {
                return "No se puede dividir entre 0";
            } else {
                double division = nro1 / nro2;
                return ""+division;
            }
            
        }

        [WebMethod(Description = "Inverso de un numero")]
        public double Inverso(double nro)
        {
            return 1 / nro;
        }

        private double factorial(int nro)
        {
            if (nro == 0) return 1;
            else return nro * factorial(nro - 1);
        }

        [WebMethod(Description = "Factorial de un numero")]
        public double Factorial(int nro)
        {
            return factorial(nro);
        }

        [WebMethod(Description = "Potencia de un numeros")]
        public double Potencia(double nro1, double nro2)
        {
            return Math.Pow(nro1, nro2);
        }

        [WebMethod(Description = "Seno de un numero")]
        public double Seno(double nro)
        {
            return Math.Sin(nro);
        }

        [WebMethod(Description = "Coseno de un numero")]
        public double Coseno(double nro)
        {
            return Math.Cos(nro);
        }

        [WebMethod(Description = "Tangente de un numero")]
        public double Tangente(double nro)
        {
            return Math.Tan(nro);
        }
    }
}
