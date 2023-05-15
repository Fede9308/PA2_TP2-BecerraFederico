using System;

namespace PA2_TP2_Federico_Becerra
{
    internal class Paquete
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int TotalDias { get; set; }
        public int TotalNoches { get; set; }
        public string CondicionComercial { get; set; }

        public PrecioBase PrecioBase { get; set; }

        public IList<Servicio> ServicioList { get; set; }

        public IList<Ciudad> CiudadList { get; set; }

        public Paquete(int codigo, string nombre, int totalDias, int totalNoches, string condicionComercial, PrecioBase preciobase, List<Ciudad> ciudadList1)
        {
            PrecioBase = preciobase;
            Codigo = codigo;
            Nombre = nombre;
            TotalDias = totalDias;
            TotalNoches = totalNoches;
            CondicionComercial = condicionComercial;
            CiudadList = ciudadList1;
            ServicioList = new List<Servicio>();
        }

        public void AgregarServicio(Servicio servicio)
        {
            if (servicio != null && !ServicioList.Contains(servicio))
            {
                ServicioList.Add(servicio);
            }
        }

    }
}