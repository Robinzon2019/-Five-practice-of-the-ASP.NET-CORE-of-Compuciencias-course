using five_practice.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace five_practice.data
{
    public class ProductInMemory : IProductRepository
    {
        List<Producto> productos;
        List<Categoria> categorias;

        public ProductInMemory()
        {
            productos = new List<Producto>()
            {
                new Producto(){ Id = 1, Nombre = "Tablet 10 pulg", CategoriaId = 2, Marca = "Samsung", Modelo = "K6", Precio = 3500 },
                new Producto(){ Id = 2, Nombre = "Lavadora 20 libras", CategoriaId = 1, Marca = "Daewo", Modelo = "l700", Precio = 5500 },
                new Producto(){ Id = 3, Nombre = "Televisor 30 pulg", CategoriaId = 1, Marca = "Sony", Modelo = "e432", Precio = 25000 },
                new Producto(){ Id = 4, Nombre = "Celular", CategoriaId = 3, Marca = "Alcatel", Modelo = "K20 plus", Precio = 5000 },
                new Producto(){ Id = 5, Nombre = "Licuadora", CategoriaId = 1, Marca = "Oster", Modelo = "4tr4", Precio = 4000 },
                new Producto(){ Id = 6, Nombre = "laptop 15 pulg", CategoriaId = 1, Marca = "lenovo", Modelo = "sw33", Precio = 22000 },
                new Producto(){ Id = 7, Nombre = "Automovil", CategoriaId = 4, Marca = "Toyota", Modelo = "Corolla", Precio = 90000 },
                new Producto(){ Id = 8, Nombre = "Camion", CategoriaId = 4, Marca = "Daihatsu", Modelo = "Delta", Precio = 1200000 },
                new Producto(){ Id = 9, Nombre = "Camioneta 4x4", CategoriaId = 4, Marca = "Nissan", Modelo = "Frontier", Precio = 800000 },
                new Producto(){ Id = 10, Nombre = "Colchón Sommier", CategoriaId = 5, Marca = "Simmons", Modelo = "Backcare", Precio = 2700 }
            };

            categorias = new List<Categoria>() 
            {
                new Categoria(){ Id = 1, Nombre = "Electrodomesticos" },
                new Categoria(){ Id = 2, Nombre = "Tables" },
                new Categoria(){ Id = 3, Nombre = "Celulares" },
                new Categoria(){ Id = 4, Nombre = "Vehiculos" },
                new Categoria(){ Id = 5, Nombre = "Colchones" },
                new Categoria(){ Id = 6, Nombre = "Comestibles" },
                new Categoria(){ Id = 7, Nombre = "Detergentes" },
                new Categoria(){ Id = 8, Nombre = "Deportes" }
            };

        }


        public IEnumerable<Producto> getProductsByCategory()
        {
            var listaProductos = from producto in productos
                                 join categoria in categorias
                                 on producto.CategoriaId equals categoria.Id
                                 select producto;

            return listaProductos;
        }

        public IEnumerable<Producto> getProductshigher3000AndLess5000()
        {
            var listaProductos = from producto in productos
                                 where producto.Precio > 3000 && producto.Precio < 5000
                                 orderby producto.Precio descending
                                 select producto;

            return listaProductos;
        }
        public IEnumerable<Categoria> getCategoryName()
        {
            var listaCategorias = from categoria in categorias
                                 join producto in productos
                                 on categoria.Id equals producto.CategoriaId
                                 select categoria;

            return listaCategorias;
        }
    }
}
