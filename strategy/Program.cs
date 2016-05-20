using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    class Program
    {
        /// <summary>
        /// Cliente
        /// </summary>
        /// <param name="args"></param>
        /// <remarks></remarks>
        static void Main(string[] args)
        {
           FormatearFecha date = new FormatearFecha();
           date.FormatoEuropeo(); //define el tipo de formato 
           Console.WriteLine("Fecha del sistema, formato Europeo: " + date.Convertir(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
           date.FormatoUSA();//define el tipo de formato 
           Console.WriteLine("Fecha del sistema, formato USA: " + date.Convertir(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
           date.FormatoISO();//define el tipo de formato 
           Console.WriteLine("Fecha del sistema, formato ISO: " + date.Convertir(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year));
           Console.Read();
        }
    }
}

