using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RastreioPedidosDesktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            
            
                if (controle.tem)
                {
                 
                    frmMenu menu = new frmMenu();

                    menu.lblUsuario.Text = txtUsuario.Text.ToString();
                    
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("Nome ou senha invalidos!");
                }
            }
            
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
