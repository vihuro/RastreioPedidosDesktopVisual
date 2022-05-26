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
        public bool tem = false;
        public String mensagem = "";
        Npgsql.NpgsqlCommand cmd = new Npgsql.NpgsqlCommand();
        Conexao con = new Conexao();
        Npgsql.NpgsqlDataReader dr;

        DataSet dataSet;
        String pedidos;
        String id;
        String status;
        
        


        public frmPedidos()
        {
            InitializeComponent();
            cmd.CommandText = "select * from tab_Pedidos";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                    
                    ListViewItem list = new ListViewItem("i");



                list.SubItems.Add(dr.10);
                list.SubItems.Add("2");


               listView1.Items.Add(list);


                

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
    }
}
