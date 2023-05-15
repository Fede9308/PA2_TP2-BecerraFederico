using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Reserva
    {
        public int CantidadPersonas { get; set; }
        public string Codigo { get; set; }

        public Cliente Cliente { get; set; }

        public IList<Butaca> ButacaList { get; set; }

        public Reserva(List<Butaca> butaca, int cantidadPersonas, string codigo, Cliente cliente)
        {
            ButacaList = butaca;
            CantidadPersonas = cantidadPersonas;
            Codigo = codigo;
            Cliente = cliente;
        }

        public void AgregarCantidadPersonas(int cantidadPersonas)
        {
            CantidadPersonas = cantidadPersonas;
        }
        public double ObtenerPrecioTotal(Paquete paquete)
        {
            Paquete paquete1 = paquete;
            double precioUnitarioPaquete1 = paquete1.PrecioBase.PrecioUnitario;
            double descuentoPaquete1 = paquete1.PrecioBase.Descuento;
            double precioTotal = (precioUnitarioPaquete1 * CantidadPersonas) - (descuentoPaquete1 * CantidadPersonas);

            return precioTotal;
        }


    }
}
