using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    
    public class FormatearFecha
    {
        private Contexto contexto;

        public FormatearFecha()
        {
            contexto = new Contexto();
        }

        /// <summary>
        /// implementa la interfaz dependiendo el tipo que se requiera
        /// </summary>
        /// <remarks></remarks>
        public void FormatoEuropeo()
        {
            ITipoFecha formatoEuropeo = new FormatoEuropeo();
            contexto.TipoFecha = formatoEuropeo;
        }

        public void FormatoISO()
        {
            ITipoFecha formatoISO = new FormatoISO(); 
            contexto.TipoFecha = formatoISO;
        }

        public void FormatoUSA()
        {
            ITipoFecha formatoAmericano = new FormatoUSA();
            contexto.TipoFecha = formatoAmericano;
        }

        /// <summary>
        /// metodo que invoca la funcionalidad implementada de la interfaz
        /// </summary>
        /// <param name="dd">dia</param>
        /// <param name="mm">mes</param>
        /// <param name="yyyy">anio</param>
        /// <returns>fecha formateada</returns>
        /// <remarks></remarks>
        public string Convertir(int dd, int mm, int yyyy)
        {
            string fecha = contexto.ObtenerFormatoFecha(dd, mm, yyyy);
            return fecha;
        }


    }
}
