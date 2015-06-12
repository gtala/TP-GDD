using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PagoElectronico.Entidades.Clases;

namespace PagoElectronico.FormulariosBase
{
    public partial class FormBase : Form
    {
        private Usuario usuarioLogueado;
        public Usuario UsuarioLogueado
        {
            get
            {
                return usuarioLogueado;
            }
            set
            {
                usuarioLogueado = value;
            }
        }

        private Cliente clienteSesion;
        public Cliente ClienteSesion
        {
            get
            {
                return clienteSesion;
            }
            set
            {
                clienteSesion = value;
            }
        }

        public FormBase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
