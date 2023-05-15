using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Butaca
    {
        public int Numero { get; set; }
        public string Estado { get; set; }

        public Butaca(int numero, string estado)
        {
            Numero = numero;
            Estado = estado;
        }
    }
}
