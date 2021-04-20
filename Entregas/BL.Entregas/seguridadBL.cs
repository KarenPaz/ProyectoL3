using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Entregas
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public BindingList<Usuario> ListaUsuario { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuario = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexto.Usuarios.Load();
            ListaUsuario = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuario;
        }

        public void CancelarCambios()//
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }


        //BOTONES DE GUARDAR 
        public Result GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);
            if (resultado.Exito == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();

            resultado.Exito = true;

            return resultado;
        }
        // Funcion AGREGAMOS UN NUEVO USUARIO
        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            ListaUsuario.Add(nuevoUsuario);
            

        }
        //Funcion Eliminar 
        public bool EliminarUusario(int Id)
        {
            foreach (var usuario in ListaUsuario)
            {
                if (usuario.Id == Id)
                {
                    ListaUsuario.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        private Result Validar(Usuario usuario)
        {
            var resultado = new Result();
            resultado.Exito = true;

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Msj = "Ingrese un nombre valido";
                resultado.Exito = false;
            }
            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Msj = "Ingrese una contarseña";
                resultado.Exito = false;
            }
            if (string.IsNullOrEmpty(usuario.TipoUsuario) == true)
            {
                resultado.Msj = "Ingrese un ntipo de usuario";
                resultado.Exito = false;
            }

            return resultado;
        }


        public Usuario Acceso(string usuario, string contrasena)//regreso un objeto tipo usuario
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                }
            }

            return null;            
        }
        
    }



    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }
    }

    public class Result
    {
        public bool Exito { get; set; }
        public string Msj { get; set; }
    }
}
