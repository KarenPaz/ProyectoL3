using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class FacturaBL
    {
        Contexto _contexto;

        public BindingList<Factura> ListaFacturas { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();
        }

        public  BindingList<Factura> ObtenerFacturas()
        {
            _contexto.Facturas.Include("FacturaDetalle").Load();
            ListaFacturas = _contexto.Facturas.Local.ToBindingList();

            return ListaFacturas;
        }
        

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();
            _contexto.Facturas.Add(nuevaFactura);
        }

        public void AgregarFacturaDetalle(Factura factura)
        {
            if (factura != null )
            {
                var nuevoDetalle = new FacturaDetalle();
                factura.FacturaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverFacturaDetalle(Factura factura, FacturaDetalle facturaDetalle)
        {
            if (factura != null && facturaDetalle != null)
            {
                factura.FacturaDetalle.Remove(facturaDetalle);
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

        public Comprobar GuardarFactura(Factura factura)
        {
            var resultado = Validar(factura);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }            
            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }


        private Comprobar Validar(Factura factura)
        {
            var resultado = new Comprobar();
            resultado.Exitoso = true;

            if (factura == null)
            {
                resultado.Mensaje = "Agregue una factura para poder crearla";
                resultado.Exitoso = false;
                return resultado;
            }

            if (factura.Id !=0 && factura.Activo == true)
            {
                resultado.Mensaje = "La factura ya fue emitida y no se pueden realizar cambios, genere una nueva factura";
                resultado.Exitoso = false;
            }
            if (factura.Activo == false)
            {
                resultado.Mensaje = "La factura está anulada y no es posible realizar cambios";
                resultado.Exitoso = false;
            }
            if (factura.ClienteId == 0)
            {
                resultado.Mensaje = "Seleccione un cliente";
                resultado.Exitoso = false;
            }
            if (factura.FacturaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue una entrega a la factura";
                resultado.Exitoso = false;
            }
            foreach (var detalle in factura.FacturaDetalle)
            {
                if (detalle.EntregaId == 0)
                {
                    resultado.Mensaje = "Seleccione entregas correctas";
                    resultado.Exitoso = false;
                }
            }

            return resultado;
        }

        public void CalcularFactura(Factura factura)
        {
            if (factura != null)
            {
                double subtotal = 0;
                foreach (var detalle in factura.FacturaDetalle)
                {
                    var entrega = _contexto.Entregas.Find(detalle.EntregaId);
                    if (entrega != null)
                    {
                        detalle.Costo = entrega.Costo;
                        detalle.CostoAdicional = entrega.CostoAdicional;
                        detalle.Total = detalle.Costo + detalle.CostoAdicional;

                        subtotal += detalle.Total;
                    }
                }

                factura.Subtotal = subtotal;
                factura.Impuesto = subtotal * 0.15;
                factura.Total = subtotal + factura.Impuesto;
            }

            
        }
        public bool AnularFactura(int id)
        {
            foreach (var factura in ListaFacturas)
            {
                if (factura.Id == id)
                {
                    factura.Activo = false;

                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }



    }

    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            Activo = true;
            FacturaDetalle = new BindingList<FacturaDetalle>();
        }
    }


    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int EntregaId { get; set; }
        public Entrega Delivery { get; set; }
        public double Costo { get; set; }
        public double CostoAdicional { get; set; }
        public double Total { get; set; }//se coloca para que sume el total si son varias entregas para un mismo cliente

        

    }

    public class Comprobar
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
