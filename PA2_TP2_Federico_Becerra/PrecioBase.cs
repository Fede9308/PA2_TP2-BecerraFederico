using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class PrecioBase
    {
        public int Codigo { get; set; }
        public double PrecioUnitario { get; set; }
        public double Descuento { get; set; }

        public PrecioBase(int codigo, double precioUnitario, double descuento)
        {
            Codigo = codigo;
            PrecioUnitario = precioUnitario;
            Descuento = descuento;
        }
        public void AgregarPrecioUnitario(double precioUnitario)
        {
            PrecioUnitario = precioUnitario;
        }
        public void AgregarDescuento(double descuento)
        {
            Descuento = descuento;
        }

    }
}
