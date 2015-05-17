using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace clases
{
    public class Usuario
    {
        string username { get; set; }
        string pass { get; set; }
        int rol { get; set; }
        DateTime fechacrea { get; set; }
        DateTime fechaultmod { get; set; }
        string preguntasecreta { get; set; }
        string respuestasecreta { get; set; }
        public int estado { get; set; }

        public void setusername(string usr) 
        {
            this.username = usr;
        }
        public string getusername()
        {
            return this.username;
        }

        public void setpass(string pass)
        {
            this.pass = pass;
        }
        public string getpass()
        {
            return this.pass;
        }

        public void setfechacrea(DateTime fec)
        {
            this.fechacrea = fec;
        }
        public DateTime getfechacrea()
        {
            return this.fechacrea;
        }

        public void setfechaultmod(DateTime fec)
        {
            this.fechaultmod = fec;
        }
        public DateTime getfechaultmod()
        {
            return this.fechaultmod;
        }

        public void setpreguntasecreta(string preg)
        {
            this.preguntasecreta = preg;
        }
        public string getpreguntasecreta()
        {
            return this.preguntasecreta;
        }

        public void setrespuestasecreta(string resp)
        {
            this.respuestasecreta = resp;
        }
        public string getrespuestasecreta()
        {
            return this.respuestasecreta;
        }

        public void setrol(int rol)
        {
            this.rol = rol;
        }
        public int getrol()
        {
            return this.rol;
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
