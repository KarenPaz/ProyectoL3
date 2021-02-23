using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class ClienteBL
    {
        public BindingList<Clientes> ListadeClientes { get; set; }

        public ClienteBL() // Constructor
        {
            ListadeClientes = new BindingList<Clientes>();

            var cliente1 = new Clientes();
            //cliente1.CodigoCliente = "SPS001";
            cliente1.CodigoCliente = "1";
            cliente1.RTN = "0908999636134";
            cliente1.NombredeEmpresa = "Repuestos y Mas";
            cliente1.Direccion = "Barrio Suyapa, 9 clle, 10 Ave";
            cliente1.Telefono = "2554-0630";
            cliente1.Contacto = "Javier Martinez";
            cliente1.Activo = true;

            ListadeClientes.Add(cliente1);

            var cliente2 = new Clientes();
            //cliente2.CodigoCliente = "SPS002";
            cliente2.CodigoCliente = "2";
            cliente2.RTN = "08015269471313";
            cliente2.NombredeEmpresa = "Comercializadora de Productos";
            cliente2.Direccion = "Colonia Las Mercedes, casa 20";
            cliente2.Telefono = "9865-2424";
            cliente2.Contacto = "Laura Perez";
            cliente2.Activo = true;

            ListadeClientes.Add(cliente2);

        }

        public BindingList<Clientes> ObtenerClientes()
        {
            return ListadeClientes;
        }

        public Resultado GuardarCliente(Clientes cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false )
            {
                return resultado;
            }

            if(cliente.CodigoCliente == "0")
            {
                cliente.CodigoCliente = ListadeClientes.Max(item => item.CodigoCliente) + 1;
            }

            resultado.Exitoso = true;
            return resultado;
        }
        public void AgregarCliente()
        {
            var nuevoCliente = new Clientes();
            ListadeClientes.Add(nuevoCliente);
        }
        public bool EliminarCliente(string id)
        {
            foreach (var cliente in ListadeClientes)
            {
                if (cliente.CodigoCliente == id)
                {
                    ListadeClientes.Remove(cliente);
                    return true;
                }
                    
            }
            return false;
        }

        private Resultado Validar(Clientes Cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if (string.IsNullOrEmpty(Cliente.CodigoCliente) == true)
            {
                resultado.Mensaje = "Ingrese un codigo";
                resultado.Exitoso = false;
            }
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
        public string CodigoCliente { get; set; }
        public string RTN { get; set; }
        public string NombredeEmpresa { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }
        public bool Activo { get; set; }

    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
