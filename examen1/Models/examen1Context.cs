using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace examen1.Models
{
    public class examen1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public examen1Context() : base("name=examen1Context")
        {
        }

        public System.Data.Entity.DbSet<examen1.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<examen1.Models.Carros> Carros { get; set; }

        public System.Data.Entity.DbSet<examen1.Models.Accesorios> Accesorios { get; set; }

        public System.Data.Entity.DbSet<examen1.Models.Vendedor> Vendedors { get; set; }

        public System.Data.Entity.DbSet<examen1.Models.Transaccion> Transaccions { get; set; }

        public System.Data.Entity.DbSet<examen1.Models.Lacalizador> Lacalizadors { get; set; }
    }
}
