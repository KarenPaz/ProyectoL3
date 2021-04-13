using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class EntregasBL
    {
        Contexto _contexto;
        public BindingList<Entrega> ListaEntregas { get; set; }

        public EntregasBL()
        {
            _contexto = new Contexto();
            ListaEntregas = new BindingList<Entrega>();

        }

        public BindingList<Entrega> ObtenerEntregas()
        {
            _contexto.Entregas.Load();
            ListaEntregas = _contexto.Entregas.Local.ToBindingList();

            return ListaEntregas;
        }

        public void CancelarCambios()//
        {
            foreach (var item in _contexto.ChangeTracker.Entries())//
            {
                item.State = EntityState.Unchanged;//
                item.Reload();//
            }

        }

        //BOTONES DE GUARDAR 
        public Comprobacion GuardarEntrega(Entrega entrega)
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


        

        // Funcion AGREGAMOS UN NUEVA ENTREGA
        public void AgregarEntrega()
        {
            var nuevaEntrega = new Entrega();
            ListaEntregas.Add(nuevaEntrega);
        }


        //BOTONES DE Eliminar
        public bool EliminarEntrega(int Id)
        {
            foreach (var entrega in ListaEntregas)
            {
                if (entrega.Id == Id)
                {
                    ListaEntregas.Remove(entrega);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Comprobacion Validar(Entrega entrega)
        {
            var resultado = new Comprobacion();
            resultado.Exitoso = true;

            if (entrega == null)
            {
                resultado.Mensaje = "Agregue una entrega válida";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(entrega.NombreDest) == true)
            {
                resultado.Mensaje = "Ingrese el nombre de la persona que recibe el paquete";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(entrega.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese el número de contacto de la persona que recibe el paquete";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(entrega.Direccion)==true)
            {
                resultado.Mensaje = "Ingrese la direcci[on a la cual se enviar[a el paquete";
                resultado.Exitoso = false;
            }
            if (entrega.TipoId == 0)
            {
                resultado.Mensaje = "Especifique el tipo de paquete que se envía";
                resultado.Exitoso = false;
            }
            if (entrega.PagoId == 0)
            {
                resultado.Mensaje = "Especifique el tipo de pago";
                resultado.Exitoso = false;
            }
            if (entrega.EstadoId == 0)
            {
                resultado.Mensaje = "Especifique el estado de pago";
                resultado.Exitoso = false;
            }
            

            //if (string.IsNullOrEmpty(entrega.Cliente.NombredeEmpresa) == true)
            //{
            //resultado.Mensaje = "Ingrese el nombre del remitente";
            //resultado.Exitoso = false;
            //}

            //if (string.IsNullOrEmpty(entrega.Cliente.Direccion) == true)
            //{
            //resultado.Mensaje = "Ingrese una direccion de entrega";
            //resultado.Exitoso = false;
            //}
            //if (string.IsNullOrEmpty(entrega.TipoPaquete) == true)
            //{
            //resultado.Mensaje = "Especifique que paquete se envía";
            //resultado.Exitoso = false;
            //}
            //if (string.IsNullOrEmpty(entrega.EstadodePago) == true)
            //{
            //resultado.Mensaje = "Especifique el estado del pago sobre el envio";
            //resultado.Exitoso = false;
            //}
            //if (string.IsNullOrEmpty(entrega.EstadodePago) == true)
            //{
            //resultado.Mensaje = "Especifique la forma de pago";
            //resultado.Exitoso = false;
            //}
            //if (entrega.Status != true)
            //{
            //resultado.Mensaje = "Indique el status del envio";
            //resultado.Exitoso = false;
            //}

            return resultado;
        }

    }

    public class Entrega: EntregaDetalles
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Clientes Cliente { get; set; }
        public int TipoId { get; set; }
        public TiposPaquete Paquete { get; set; }
        public int PagoId { get; set; }
        public FormasPago TipoDePago { get; set; }
        public int EstadoId { get; set; }
        public Estado EstadoDePago { get; set; }
        public int StatusId { get; set; }
        public Estatus EstadoPaquete { get; set; }
        


        public Entrega()
        {
            Fecha = DateTime.Now;
        }
        
    }

    public class EntregaDetalles
    {
        public string NombreDest { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public double Peso { get; set; }
        public double Costo { get; set; }
        public double CostoAdicional { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public string Observaciones { get; set; }
    }

    public class Comprobacion
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
