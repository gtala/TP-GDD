using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace PagoElectronico.Util
{
    public class Encriptador
    {

        public static string Encriptar(string cadena)
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
