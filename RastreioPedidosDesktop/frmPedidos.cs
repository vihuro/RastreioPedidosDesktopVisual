using MySql.Data.MySqlClient;
using RastreioPedidosDesktop.DAL;
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
    public partial class frmPedidos : Form
    {
        Conexao con = new Conexao();
        Npgsql.NpgsqlCommand postgreSql = new Npgsql.NpgsqlCommand();
        Npgsql.NpgsqlDataReader lerDados;




        public frmPedidos()
        {
            InitializeComponent();

            postgreSql.CommandText = "select * from tab_Pedidos";

            con.conectar();
            postgreSql.Connection = con.conectar();

            lerDados = postgreSql.ExecuteReader();


            try
            {

                while(lerDados.Read())
                    {
   
                        ListViewItem list = new ListViewItem(); ;

                        list.SubItems[0].Text = lerDados[0].ToString();
                        list.SubItems.Add(lerDados[9].ToString());
                        list.SubItems.Add(lerDados[1].ToString());
                    


                       listView1.Items.Add(list);

                    }

            }
            catch(Npgsql.NpgsqlException)
            {
                
            }

        }

        String carregar;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
 

            
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        private void alteraSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        private void desenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }
    }
}
