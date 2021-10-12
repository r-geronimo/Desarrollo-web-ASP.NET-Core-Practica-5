using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desarrollo_web_ASP.NET_Core_Practica_5.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int CategoriaId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
    }
}
