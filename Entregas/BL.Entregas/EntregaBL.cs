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
        private Resultado Validar(Entrega entrega)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if (entrega == null)
            {
                resultado.Mensaje = "Agregue una factura para poderla salvar";
                resultado.Exitoso = false;

                return resultado;
            }
            if (entrega.Activo == false)
            {
                resultado.Mensaje = "La factura esta anulada y no se puede realizar cambios en ella.";
                resultado.Exitoso = false;
            }
            if (entrega.ClienteId == 0)
            {
                resultado.Mensaje = "Seleccione un cliente";
                resultado.Exitoso = false;
            }
            if (entrega.EntregaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue ecomiendas a la factura";
                resultado.Exitoso = false;
            }
            foreach (var detalle in entrega.EntregaDetalle)
            {
                if (detalle.Peso == 0)
                {
                    resultado.Mensaje = "Agregue peso valido";
                    resultado.Exitoso = false;
                }
            }

            return resultado;    
        }

        public void CalcularEntrega(Entrega entrega)
        {
            if (entrega != null)
            {
                double subtotal = 0;
                foreach (var detalle in entrega.EntregaDetalle)
                {
                   // detalle.Costo = 20;
                    detalle.Total = detalle.Peso * detalle.Costo;

                    subtotal += detalle.Total;
                }
                entrega.Subtotal = subtotal;
                entrega.Impuesto = subtotal * 0.15;
                entrega.Total = subtotal + entrega.Impuesto;
            }
        }
        public bool AnularEntrega(int id)
        {
            foreach (var entrega in ListaEntregas)
            {
                if (entrega.Id == id)
                {
                    entrega.Activo = false;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
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
            Costo = 20;
          
        }

    }
}
