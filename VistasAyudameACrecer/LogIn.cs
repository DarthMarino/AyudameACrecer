using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;

namespace VistasAyudameACrecer
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.User = tbUser.Text;
            usuario.Password = tbPassword.Text;
            DataManager manager = new DataManager();

            usuario = manager.ValidarUsuario(usuario);

            if (usuario.Autenticado)
            {
                MessageBox.Show("Bienvenido!");
                Cuerpo cuerpo = new Cuerpo();
                cuerpo.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                foreach(TextBox t in this.Controls)
                {
                    t.Clear();
                }
            }
            
        }
    }
}
