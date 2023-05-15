using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Pais
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public IList<Provincia> ProvinciaList { get; set; }

        public Pais()
        {
            ProvinciaList = new List<Provincia>();
        }

        public Pais(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            ProvinciaList = new List<Provincia>();
        }

        public void AgregarProvincia(Provincia provincia)
        {
            if (provincia != null && !ProvinciaList.Contains(provincia))
            {
                ProvinciaList.Add(provincia);
            }
        }
    }
}
