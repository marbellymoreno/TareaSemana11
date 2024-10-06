using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Desserts
    {
        public int IdPostre { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Estado { get; set; }
        public int Stock { get; set; }
        public int Calorias { get; set; }

    }
}
