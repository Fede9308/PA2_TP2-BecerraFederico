using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_TP2_Federico_Becerra
{
    internal class Cliente
    {
        public int DocumentoUnico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        public Cliente(int documento, string nombre, string apellido, int telefono, string correoElectronico)
        {
            DocumentoUnico = documento;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            CorreoElectronico = correoElectronico;
        }
    }
}
