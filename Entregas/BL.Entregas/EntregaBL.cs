using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class EntregaBL
    {
        Contexto _contexto;
        public BindingList<Entrega> ListaEntregas { get; set; }

        public EntregaBL()
        {
            _contexto = new Contexto();
        }

       public  BindingList<Entrega> ObtenerEntregas()
        {
            _contexto.Entrega.Include("EntregaDetalle").Load();
            ListaEntregas = _contexto.Entrega.Local.ToBindingList();

           return ListaEntregas;
        }
        public void AgregarEntrega()
        {
            var nuevaEntrega = new Entrega();
            ListaEntregas.Add(nuevaEntrega);
        }
        public void AgregarEntregaDetalle(Entrega entrega)
        {
            if (entrega != null)
            {
                var nuevoDetalle = new EntregaDetalle();
                entrega.EntregaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverEntregaDetalle(Entrega entrega, EntregaDetalle entregaDetalle)
        {
            if (entrega != null && entregaDetalle != null)
            {
                var nuevoDetalle = new EntregaDetalle();
                entrega.EntregaDetalle.Remove(entregaDetalle);
            }
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        public Resultado GuardarEntrega(Entrega entrega)
        {
            var resultado = Validar(entrega);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();
            resultado.Exitoso = true;

            return resultado;
        }
        private Resultado Validar(Entrega factura)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            return resultado;
        }
        public void CañcularEntrega(Entrega entrega)
        {
            if (entrega != null)
            {
             //   double subtotal = 0;
                foreach (var detalle in entrega.EntregaDetalle)
                {

                }
            }
        }
    }

    public class Entrega
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }
        public BindingList<EntregaDetalle> EntregaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Entrega()
        {
            Fecha = DateTime.Now;
            EntregaDetalle = new BindingList<EntregaDetalle>();
            Activo = true;
        }
    }
    public class EntregaDetalle
    {
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public EntregaDetalle()
        {
            Peso = 1;
        }

    }
}
