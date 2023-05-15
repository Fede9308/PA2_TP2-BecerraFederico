using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Prestador
    {
        public int Codigo { get; set; }
        public string RazonSocial { get; set; }

        public Prestador(int codigo, string razonSocial)
        {
            Codigo = codigo;
            RazonSocial = razonSocial;
        }
    }
}
