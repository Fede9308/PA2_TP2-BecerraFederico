using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Servicio
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<Prestador> PrestadorList { get; set; }
        public TipoServicio Tipo { get; set; }

        public Servicio(int codigo, string descriptcion, DateTime fechaInicio, DateTime fechaFin, List<Prestador> prestador, TipoServicio tipo)
        {
            Codigo = codigo;
            Descripcion = descriptcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            PrestadorList = prestador;
            Tipo = tipo;
        }

        public void AgregarPrestador(Prestador prestador)
        {
            if (prestador != null && !PrestadorList.Contains(prestador))
            {
                PrestadorList.Add(prestador);
            }
        }

    }
}
