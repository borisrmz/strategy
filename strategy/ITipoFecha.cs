using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    /// <summary>
    /// interfaz de la estrategia
    /// </summary>
    /// <remarks></remarks>
    public interface ITipoFecha
    {
        string obtenerFormatoFecha(int dd, int mm, int yyyy);
    }

}
