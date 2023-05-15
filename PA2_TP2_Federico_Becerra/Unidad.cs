using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Unidad
    {
        public int Numero { get; set; }
        public string Dominio { get; set; }
        public int CantidadAsientos { get; set; }

        public IList<Butaca> ButacaList { get; set; }

        public Unidad(int numero, string dominio, int cantidadAsientos)
        {
            Numero = numero;
            Dominio = dominio;
            CantidadAsientos = cantidadAsientos;
            ButacaList = new List<Butaca>();

        }
    }
}
