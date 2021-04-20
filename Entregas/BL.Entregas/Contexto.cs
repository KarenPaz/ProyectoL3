using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Delivery")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());//AGREGA DATOS DE INICIO A AL BASE DE DATOS DESPUES DE ELIMINARLA
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Tipo> Tipos { get; set; }//
        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<TiposPaquete> TiposPaquetes { get; set; }
        public DbSet<FormasPago> FormasdePago { get; set; }
        public DbSet<Estado> EstadoDePagos { get; set; }
        public DbSet<Estatus> EstatusPaquete { get; set; }

    }

}
