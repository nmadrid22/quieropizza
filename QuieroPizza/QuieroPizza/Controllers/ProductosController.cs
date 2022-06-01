using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            var producto1 = new Models.ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "pizza 6 quesos";

            var producto2 = new Models.ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "pizza 4 Estaciones";

            var producto3 = new Models.ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "pizza Jamon y Queso";


            var listadeProducto = new List<Models.ProductoModel>();
            listadeProducto.Add(producto1);
            listadeProducto.Add(producto2);
            listadeProducto.Add(producto3);



            return View(listadeProducto);
            
        }
    }
}