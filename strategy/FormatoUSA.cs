using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class FormatoUSA : ITipoFecha
    {

        /// <summary>
        /// Implementacion de los metodos de la interfaz (estrategia 1)
        /// </summary>
        /// <param name="dd">dia</param>
        /// <param name="mm">mes</param>
        /// <param name="yyyy">año</param>
        /// <returns>fecha formateada</returns>
        /// <remarks></remarks>
        public string obtenerFormatoFecha(int dd, int mm, int yyyy)
        {
            string dia = dd.ToString(), mes = mm.ToString(), anio = yyyy.ToString();

            dia = Convert.ToInt16(dia) > 9 ? dia : "0" + dia;
            mes = Convert.ToInt16(mm) > 9 ? dia : "0" + mm;

            return string.Format("{0}/{1}/{2}", mes, dia, anio);
        }
    }
}
