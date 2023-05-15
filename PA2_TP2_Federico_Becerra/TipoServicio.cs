using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class TipoServicio
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Rubro Rubro { get; set; }

        public TipoServicio(int codigo, string nombre, Rubro rubro)
        {
            Codigo = codigo;
            Nombre = nombre;
            Rubro = rubro;
        }
    }
}
