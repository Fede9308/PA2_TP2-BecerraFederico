using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Rubro
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public Rubro(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
    }
}
