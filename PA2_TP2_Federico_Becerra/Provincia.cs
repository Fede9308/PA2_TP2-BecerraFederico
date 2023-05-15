using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Provincia
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public IList<Ciudad> CiudadList { get; set; }

        public Provincia()
        {
            CiudadList = new List<Ciudad>();
        }

        public Provincia(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
            CiudadList = new List<Ciudad>();
        }
        public void AgregarCiudad(Ciudad ciudad)
        {
            if (ciudad != null && !CiudadList.Contains(ciudad))
            {
                CiudadList.Add(ciudad);
            }
        }
    }
}
