using Desarrollo_web_ASP.NET_Core_Practica_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desarrollo_web_ASP.NET_Core_Practica_5.Repositoty
{
    public class ProductoRepository
    {
        private readonly List<Producto> productos;
        private readonly List<Categoría> categorías;
        public ProductoRepository()
        {
            categorías = new List<Categoría> {
                new Categoría { Id = 1, Nombre = "Categoria 1" },
                new Categoría { Id = 2, Nombre = "Categoria 2" },
                new Categoría { Id = 3, Nombre = "Categoria 3" },
                new Categoría { Id = 4, Nombre = "Categoria 4" },
                new Categoría { Id = 5, Nombre = "Categoria 5" },
            };

            productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Producto 1", CategoriaId = 1, Marca = "Marca 1", Modelo = "Modelo 1", Precio = 3000},
                new Producto { Id = 2, Nombre = "Producto 2", CategoriaId = 2, Marca = "Marca 2", Modelo = "Modelo 2", Precio = 20000},
                new Producto { Id = 3, Nombre = "Producto 3", CategoriaId = 3, Marca = "Marca 3", Modelo = "Modelo 3", Precio = 3500},
                new Producto { Id = 4, Nombre = "Producto 4", CategoriaId = 4, Marca = "Marca 4", Modelo = "Modelo 4", Precio = 3100},
                new Producto { Id = 5, Nombre = "Producto 5", CategoriaId = 5, Marca = "Marca 5", Modelo = "Modelo 5", Precio = 4500},
                new Producto { Id = 6, Nombre = "Producto 6", CategoriaId = 1, Marca = "Marca 6", Modelo = "Modelo 6", Precio = 5000},
                new Producto { Id = 7, Nombre = "Producto 7", CategoriaId = 2, Marca = "Marca 7", Modelo = "Modelo 7", Precio = 4300},
                new Producto { Id = 8, Nombre = "Producto 8", CategoriaId = 3, Marca = "Marca 8", Modelo = "Modelo 8", Precio = 6500},
                new Producto { Id = 9, Nombre = "Producto 9", CategoriaId = 4, Marca = "Marca 9", Modelo = "Modelo 9", Precio = 7000},
                new Producto { Id = 10, Nombre = "Producto 10", CategoriaId = 5, Marca = "Marca 10", Modelo = "Modelo 10", Precio = 2100},
            };
        }

        public List<Producto> GetProductosByCategoriaId(int id)
        {
            var result = (from p in productos
                          where p.CategoriaId == id
                          select p).ToList();

            return result;

        }

        public List<Producto> GetProductsSortedByDescendingPrice()
        {
            var result = (from p in productos
                          where p.Precio > 3000 && p.Precio < 5000
                          orderby p.Precio descending
                          select p).ToList();
            return result;
        }

        public List<string> GetNameCategories()
        {
            var result = (from p in productos
                          join c in categorías on p.CategoriaId equals c.Id
                          orderby p.Precio descending
                          group c by c.Nombre into nombre
                          select nombre.Key).ToList();
            return result;
        }

    }
}

