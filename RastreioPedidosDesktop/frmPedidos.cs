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

            postgreSql.CommandText = "select * from tab_Pedidos order by numero_Pedido asc";

            con.conectar();
            postgreSql.Connection = con.conectar();

            lerDados = postgreSql.ExecuteReader();


            try
            {

                while(lerDados.Read())
                    {
   
                        ListViewItem list = new ListViewItem(lerDados[0].ToString());

                    String Date = DateTime.Now.ToString("dd-MM-");

                    list.SubItems.Add(lerDados[9].ToString());
                        list.SubItems.Add(lerDados[1].ToString());
                    


                       listView1.Items.Add(list);

                    }

                con.desconectar();
                postgreSql.Connection.Close();


            }
            catch(Npgsql.NpgsqlException)
            {
                
            }

        }

        public static object ListView1 { get; internal set; }

        public Npgsql.NpgsqlDataReader GetLerDados()
        {
            return lerDados;
        }

        private void obterDados(object sender, EventArgs e)
        {

        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e, Npgsql.NpgsqlDataReader lerDados)
        {

            MessageBox.Show(listView1.SelectedIndices[0].ToString());

        }


        public void frmPedidos_Load(object sender, EventArgs e)
        {

        }

        public void alteraSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        public void desenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {
                MessageBox.Show(listView1.SelectedItems[0].SubItems[1].Text);
                txtPedido.Text = listView1.SelectedItems[0].SubItems[1].Text;

                postgreSql.CommandText = "select * from tab_Pedidos where numero_Pedido = @Pedido";
                postgreSql.Parameters.AddWithValue("Pedido", listView1.SelectedItems[0].SubItems[1].Text);

            

                con.conectar();
                postgreSql.Connection = con.conectar();

                lerDados = postgreSql.ExecuteReader();

                MessageBox.Show(lerDados[0].ToString());

                if (lerDados.NextResult())
                {

                    cboStatus = (ComboBox)lerDados[0];

                }

                con.desconectar();

            }

        }
    }
}
