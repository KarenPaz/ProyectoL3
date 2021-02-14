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
            cliente1.CodigoCliente = "SPS001";
            cliente1.RTN = "0908999636134";
            cliente1.NombredeEmpresa = "Repuestos y Mas";
            cliente1.Direccion = "Barrio Suyapa, 9 clle, 10 Ave";
            cliente1.Telefono = "2554-0630";
            cliente1.Contacto = "Javier Martinez";
            cliente1.Activo = true;

            ListadeClientes.Add(cliente1);

            var cliente2 = new Clientes();
            cliente2.CodigoCliente = "SPS002";
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
}
