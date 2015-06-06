using System;
using PagoElectronico.Entidades.Clases;
using System.Security.Cryptography;
using System.Text;
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

        public static string encriptar(string cadena)
        {

            var proveedor = new SHA256Managed();

            byte[] inputBytes = Encoding.UTF8.GetBytes(cadena);
            byte[] hashedBytes = proveedor.ComputeHash(inputBytes);

            StringBuilder salida = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                salida.Append(hashedBytes[i].ToString("x2").ToLower());

            return salida.ToString();
        }
    }
}
