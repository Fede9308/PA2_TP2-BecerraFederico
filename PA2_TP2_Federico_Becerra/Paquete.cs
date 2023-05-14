using System;

namespace PA2_TP2_Federico_Becerra
{
    public class Paquete
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int TotalDias { get; set; }
        public int TotalNoches { get; set; }
        public string CondicionComercial { get; set; }

        public IList<Ciudad> CiudadList { get; }

        public Paquete()
        {
            CiudadList = new List<Ciudad>();
        }
        public Paquete(int codigo, string nombre, int totalDias, int totalNoches, string condicionComercial)
        {
            Codigo = codigo;
            Nombre = nombre;
            TotalDias = totalDias;
            TotalNoches = totalNoches;
            CondicionComercial = condicionComercial;
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