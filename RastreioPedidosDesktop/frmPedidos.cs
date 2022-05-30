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


        public void loadListView()
        {
            postgreSql.CommandText = "select * from tab_Pedidos order by numero_Pedido asc";

            con.conectar();
            postgreSql.Connection = con.conectar();

            lerDados = postgreSql.ExecuteReader();


            try
            {

                while (lerDados.Read())
                {

                    ListViewItem list = new ListViewItem(lerDados[0].ToString());

                    list.SubItems.Add(lerDados[9].ToString());
                    list.SubItems.Add(lerDados[1].ToString());


                    listView1.Items.Add(list);

                }

                con.desconectar();
                postgreSql.Connection.Close();


            }
            catch (Npgsql.NpgsqlException)
            {

            }
        }


        public frmPedidos()
        {
            InitializeComponent();

            loadListView();


        }

        public Npgsql.NpgsqlDataReader GetLerDados()
        {
            return lerDados;
        }

        private void obterDados(object sender, EventArgs e)
        {

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

        private void obter()
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dtpDataEntrega_ValueChanged(object sender, EventArgs e)
        {
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtPedido.Text = listView1.SelectedItems[0].SubItems[1].Text;


            if (listView1.SelectedIndices.Count > 0)
            {

                postgreSql.CommandText = "select * from tab_Pedidos where numero_Pedido = @Pedido";
                postgreSql.Parameters.AddWithValue("@Pedido", txtPedido.Text);

                con.conectar();
                postgreSql.Connection = con.conectar();
                lerDados = postgreSql.ExecuteReader();

                    while (lerDados.Read())
                    {
                    if (lerDados["numero_Pedido"].ToString() != txtPedido.Text)
                    {
                        con.desconectar();
                        postgreSql.Connection.Close();

                        postgreSql.CommandText = "select * from tab_Pedidos where numero_Pedido = @Pedido";
                        postgreSql.Parameters.Clear();
                        postgreSql.Parameters.AddWithValue("@Pedido", txtPedido.Text);


                        con.conectar();
                        postgreSql.Connection = con.conectar();
                        lerDados = postgreSql.ExecuteReader();


                    }
                    else
                    {
                        if (lerDados["data_entrega"] != DBNull.Value)
                        {
                            String dataEntrega = Convert.ToDateTime(lerDados["data_Entrega"]).ToString("dd/MM/yyyy");

                            dtpDataEntrega.Value = Convert.ToDateTime(dataEntrega);
                        }
                        else
                        {
                            dtpDataEntrega.Value = Convert.ToDateTime("01/01/1991");


                        }

                        txtPedido.Text = lerDados["numero_Pedido"].ToString();

                        ListViewItem list = new ListViewItem();

                        if (lerDados["data_ini_prod"] != DBNull.Value)
                        { 

                            String dataIniProd = Convert.ToDateTime(lerDados["data_ini_Prod"]).ToString("dd/MM/yyyy  hh:mm:ss");

                            dtpDataEntrega.Value = Convert.ToDateTime(dataIniProd);


                            ListViewItem listItem = new ListViewItem();

                            listItem.SubItems.Add(dataIniProd);


                            listViewApontamento.Items[1].SubItems.Add(dataIniProd);

                        }
                        else
                        {
                            ListViewItem listItem = new ListViewItem();

                            String dataValue = "00/00/0000 00:00:00";

                            listItem.SubItems.Add("00/00/0000 00:00:00");


                            listViewApontamento.Items[1].SubItems.Add(dataValue);

                            date();



                        }
                    }

                    }
                con.desconectar();
                postgreSql.Connection.Close();

            }
        }

        private void date()
        {
            dtpDataEntrega.Value = Convert.ToDateTime("01/01/1991");
        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
 

            String dateTime = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy HH:mm:ss");

            listViewApontamento.SelectedItems[0].SubItems.Add(dateTime);
            listViewApontamento.SelectedItems[0].SubItems.Add(lblUsuario.Text);


        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }


    }
}
