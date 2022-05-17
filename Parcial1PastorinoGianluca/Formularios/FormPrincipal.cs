using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormPrincipal : Form
    {
        Usuario usuarioLogueado;

        private FormPrincipal()
        {
            InitializeComponent();
        }

        public FormPrincipal(Usuario user) : this()
        {
            usuarioLogueado = user;
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
