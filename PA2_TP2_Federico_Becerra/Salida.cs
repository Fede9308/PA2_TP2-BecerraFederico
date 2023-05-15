using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Salida
    {
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public int Cupo { get; set; }
        public Unidad Unidad { get; set; }
        public IList<Paquete> PaqueteList { get; set; }

        public Salida(DateTime fecha, string estado, int cupo, Unidad unidad, List<Paquete> paquete)
        {
            Fecha = fecha;
            Estado = estado;
            Cupo = cupo;
            Unidad = unidad;
            PaqueteList = paquete;
        }




    }
}
