using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIRest.Models
{
    public class BaseDeDatos : DbContext 
    {
        public BaseDeDatos()
            :base("Conexion")
        {

        }
        public DbSet<Producto> Productos { get; set; }

    }
}