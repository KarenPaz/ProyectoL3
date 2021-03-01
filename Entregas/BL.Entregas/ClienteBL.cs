using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class ClienteBL
    {
        Contexto _contexto;
        public BindingList<Clientes> ListadeClientes { get; set; }

        public ClienteBL() // Constructor
        {
            _contexto = new Contexto();
            ListadeClientes = new BindingList<Clientes>();
        }

        public BindingList<Clientes> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListadeClientes = _contexto.Clientes.Local.ToBindingList();
            return ListadeClientes;
        }

        //BOTONES DE GUARDAR 
        public Resultado GuardarCliente(Clientes cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false )
            {
                return resultado;
            }
            _contexto.SaveChanges();
          
            resultado.Exitoso = true;
            
            return resultado;
        }
        // Funcion AGREGAMOS UN NUEVO CLIENTE
        public void AgregarCliente()
        {
            var nuevoCliente = new Clientes();
            ListadeClientes.Add(nuevoCliente);
        }
        //Funcion Eliminar 
        public bool EliminarCliente(int Id)
        {
            foreach (var cliente in ListadeClientes)
            {
                if (cliente.Id == Id)
                {
                    ListadeClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
                    
            }
            return false;
        }

        //VALIDACIONES DE DATOS DE CLIENTE 
        private Resultado Validar(Clientes Cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(Cliente.Contacto) == true)
            {
                resultado.Mensaje = "Ingrese un contacto";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(Cliente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(Cliente.RTN) == true)
            {
                resultado.Mensaje = "Ingrese el RTN del Cliente";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(Cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un numero telefonico";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(Cliente.NombredeEmpresa) == true)
            {
                resultado.Mensaje = "Ingrese un nombre de la empresa";
                resultado.Exitoso = false;
            }
            
            return resultado;
        }
    }

    public class Clientes //CLASE Y DEFINICION DE PROPIEDADES
    {
        public int Id { get; set; }
        //public int CodigoCliente { get; set; }
        public string RTN { get; set; }
        public string NombredeEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }
        public bool Activo { get; set; }

    }

    //Funciones para Validar
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
