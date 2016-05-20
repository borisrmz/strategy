using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    /// <summary>
    /// Esta clase es la encargada de establecer la conexión entre el cliente y 
    /// las clases que implementan la estrategia, sustituyendo la clase que la 
    /// implementa dependiendo del comportamiento deseado.
    /// </summary>
    /// <remarks></remarks>
    public class Contexto
    {
        private ITipoFecha tipoFecha;

        /// <summary>
        /// Gets or sets .
        /// </summary>
        /// <value></value>
        /// <remarks></remarks>
        public ITipoFecha TipoFecha
        {
            get { return tipoFecha; }
            set { this.tipoFecha = value; }
        }

        /// <summary>
        /// invoca al método implementado en la estrategia dependiendo del tipo de contexto 
        /// </summary>
        /// <param name="dd">dia</param>
        /// <param name="mm">mes</param>
        /// <param name="yy">año</param>
        /// <returns>retorna el formato de fecha dependiendo del contexto</returns>
        /// <remarks></remarks>
        public string ObtenerFormatoFecha(int dd, int mm, int yy)
        {
            return tipoFecha.obtenerFormatoFecha(dd, mm, yy);

        }
    }
}
