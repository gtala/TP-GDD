﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PagoElectronico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //GDT: Indica cual va a ser el primer formulario que se va a abrir.
            Application.Run(new Login.Login());
           //Application.Run(new ABM_de_Usuario.UsuarioListado());
        }
    }
}
