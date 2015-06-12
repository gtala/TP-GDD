using System;
using System.Collections.Generic;

namespace PagoElectronico.Entidades.Clases
{
    public class Usuario
    {
        public Usuario()
        {
            //this.Pais = new Pais();
        }

        private string username;
        private string password;
        private List<Rol> roles;
        private Rol rolActivo;
        private DateTime fechaCreacion;
        private DateTime fechaUltimaModificacion;
        private string preguntaSecreta;
        private string respuestaSecreta;
        private int cantidadIntentosFallidos;
        private bool inhabilitado;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public List<Rol> Roles
        {
            get
            {
                return roles;
            }
            set
            {
                roles = value;
            }
        }

        public Rol RolActivo
        {
            get
            {
                return rolActivo;
            }
            set
            {
                rolActivo = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }
            set
            {
                fechaCreacion = value;
            }
        }

        public DateTime FechaUltimaModificacion
        {
            get
            {
                return fechaUltimaModificacion;
            }
            set
            {
                fechaUltimaModificacion = value;
            }
        }

        public string PreguntaSecreta
        {
            get
            {
                return preguntaSecreta;
            }
            set
            {
                preguntaSecreta = value;
            }
        }

        public string RespuestaSecreta
        {
            get
            {
                return respuestaSecreta;
            }
            set
            {
                respuestaSecreta = value;
            }
        }

        public bool Inhabilitado
        {
            get
            {
                return inhabilitado;
            }
            set
            {
                inhabilitado = value;
            }
        }

        public string InhabilitadoString
        {
            get
            {
                return inhabilitado ? "Sí" : "No";
            }
        }

        public int CantidadIntentosFallidos
        {
            get
            {
                return cantidadIntentosFallidos;
            }
            set
            {
                cantidadIntentosFallidos = value;
            }
        }

        
    }
}
