using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
   public  class TiposBL
    {
        Contexto _contexto;

        public BindingList<Tipo> ListaTipos { get; set; }
        public BindingList<TiposPaquete> ListaPaquetes { get; set; }
        public BindingList<FormasPago> ListaPagos { get; set; }
        public BindingList<Estado> ListaDeEstadoDePago { get; set; }
        public BindingList<Estatus> ListaStatus { get; set; }

        public TiposBL()
        {
            _contexto = new Contexto();
            ListaTipos = new BindingList<Tipo>();
            ListaPaquetes = new BindingList<TiposPaquete>();
            ListaPagos = new BindingList<FormasPago>();
            ListaDeEstadoDePago = new BindingList<Estado>();
            ListaStatus = new BindingList<Estatus>();

        }


        public BindingList<Tipo> ObtenerTipo()
        {
            _contexto.Tipos.Load();
            ListaTipos = _contexto.Tipos.Local.ToBindingList();

            return ListaTipos;
        }

        public BindingList<TiposPaquete> ObtenerPaquete()
        {
            _contexto.TiposPaquetes.Load();
            ListaPaquetes = _contexto.TiposPaquetes.Local.ToBindingList();

            return ListaPaquetes;
        }

        public BindingList<FormasPago> ObtenerFormasPago()
        {
            _contexto.FormasdePago.Load();
            ListaPagos = _contexto.FormasdePago.Local.ToBindingList();

            return ListaPagos;
        }

        public BindingList<Estado> ObtenerEstadoDePago()
        {
            _contexto.EstadoDePagos.Load();
            ListaDeEstadoDePago = _contexto.EstadoDePagos.Local.ToBindingList();
            return ListaDeEstadoDePago;
        }

        public BindingList<Estatus> ObtenerStatus()
        {
            _contexto.EstatusPaquete.Load();
            ListaStatus = _contexto.EstatusPaquete.Local.ToBindingList();

           return ListaStatus;
        }

    }

    public class Tipo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

    public class TiposPaquete
    {
        public int ID { get; set; }
        public string Paquetes { get; set; }
    }

    public class FormasPago
    {
        public int Id { get; set; }
        public string Pagos { get; set; }
    }

    public class Estado
    {
        public int Id { get; set; }
        public string EstadodePago { get; set; }
    }

    public  class Estatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }

}

