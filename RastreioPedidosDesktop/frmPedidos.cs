using MySql.Data.MySqlClient;
using RastreioPedidosDesktop.DAL;
using RastreioPedidosDesktop.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ListViewItem = System.Windows.Forms.ListViewItem;

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

                    String dataGeracao = Convert.ToDateTime(lerDados["data_geracao"]).ToString("dd/MM/yyyy  HH:mm:ss");

                    dtpDataEntrega.Value = Convert.ToDateTime(dataGeracao);

                    ListViewItem list = new ListViewItem(lerDados["numero_Pedido"].ToString());

                    list.SubItems.Add(lerDados["status"].ToString());
                    list.SubItems.Add(dataGeracao);
                    list.SubItems.Add(lerDados["data_geracao_usuario"].ToString());

                    listView1.Items.Add(list);

                }

                con.desconectar();
                postgreSql.Connection.Close();


            }
            catch (Npgsql.NpgsqlException)
            {

            }
            con.desconectar();
            postgreSql.Connection.Close();
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

        public void carregarItems()
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
                    if (lerDados["data_prevista_entrega"] != DBNull.Value)
                    {

                        String dataEntrega = Convert.ToDateTime(lerDados["data_prevista_entrega"]).ToString("dd/MM/yyyy");
                        dtpDataEntrega.CustomFormat = dataEntrega;


                    }
                    else
                    {

                        dtpDataEntrega.CustomFormat = "00/00/0000";


                    }

                    cboStatus.Text = lerDados["status"].ToString();
                    txtPedido.Text = lerDados["numero_Pedido"].ToString();



                    if (lerDados["data_geracao"] != DBNull.Value)
                    {

                        String dataGeracao = Convert.ToDateTime(lerDados["data_geracao"]).ToString("dd/MM/yyyy  HH:mm:ss");

                        dtpDataEntrega.Value = Convert.ToDateTime(dataGeracao);


                        ListViewItem listItem = new ListViewItem();

                        listItem.SubItems.Add(dataGeracao);

                        listViewApontamento.Items[0].SubItems[1].Text = dataGeracao.ToString();


                    }
                    else
                    {
                        ListViewItem listItem = new ListViewItem();

                        String dataValue = "00/00/0000 00:00:00";

                        listItem.SubItems.Add("00/00/0000 00:00:00");


                        listViewApontamento.Items[0].SubItems[1].Text = dataValue.ToString();

                    }
                    if (lerDados["data_geracao_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[0].SubItems[2].Text = lerDados["data_geracao_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[0].SubItems[2].Text = string.Empty;
                    }

                    if (lerDados["data_ini_Prod"] == DBNull.Value || Convert.ToDateTime(lerDados["data_ini_Prod"].ToString()) == DateTime.MinValue)
                    {

                        ListViewItem listItem = new ListViewItem();

                        String dataValue = "00/00/0000 00:00:00";

                        listItem.SubItems.Add("00/00/0000 00:00:00");

                        listViewApontamento.Items[1].SubItems[1].Text = dataValue.ToString();


                    }
                    else
                    {
                        String dataIniProd = Convert.ToDateTime(lerDados["data_ini_Prod"]).ToString("dd/MM/yyyy  HH:mm:ss");

                        dtpDataEntrega.Value = Convert.ToDateTime(dataIniProd);


                        ListViewItem listItem = new ListViewItem();

                        listItem.SubItems.Add(dataIniProd);


                        listViewApontamento.Items[1].SubItems[1].Text = dataIniProd.ToString();


                    }
                    if (lerDados["data_ini_prod_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[1].SubItems[2].Text = lerDados["data_ini_prod_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[1].SubItems[2].Text = string.Empty;
                    }

                    if (lerDados["data_ini_prod"] == DBNull.Value || Convert.ToDateTime(lerDados["data_fin_prod"].ToString()) == DateTime.MinValue)
                    {

                        ListViewItem listItem = new ListViewItem();

                        String dataValue = "00/00/0000 00:00:00";

                        listItem.SubItems.Add("00/00/0000 00:00:00");


                        listViewApontamento.Items[2].SubItems[1].Text = dataValue.ToString();



                    }
                    else
                    {
                        String datafinProd = Convert.ToDateTime(lerDados["data_fin_prod"]).ToString("dd/MM/yyyy  HH:mm:ss");

                        dtpDataEntrega.Value = Convert.ToDateTime(datafinProd);


                        ListViewItem listItem = new ListViewItem();

                        listItem.SubItems.Add(datafinProd);


                        listViewApontamento.Items[2].SubItems[1].Text = datafinProd.ToString();

                    }
                    if (lerDados["data_fin_prod_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[2].SubItems[2].Text = lerDados["data_fin_prod_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[2].SubItems[2].Text = string.Empty;
                    }
                    if (lerDados["data_separa"] == DBNull.Value || Convert.ToDateTime(lerDados["data_separa"].ToString()) == DateTime.MinValue)
                    {
                        ListViewItem listItem = new ListViewItem();

                        String dataValue = "00/00/0000 00:00:00";

                        listItem.SubItems.Add("00/00/0000 00:00:00");
                        listViewApontamento.Items[3].SubItems[1].Text = dataValue.ToString();

                    }
                    else
                    {

                        String dataSapara = Convert.ToDateTime(lerDados["data_separa"]).ToString("dd/MM/yyyy  HH:mm:ss");

                        dtpDataEntrega.Value = Convert.ToDateTime(dataSapara);

                        ListViewItem listItem = new ListViewItem();

                        listItem.SubItems.Add(dataSapara);


                        listViewApontamento.Items[3].SubItems[1].Text = dataSapara.ToString();

                    }
                    if (lerDados["data_separa_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[3].SubItems[2].Text = lerDados["data_separa_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[3].SubItems[2].Text = string.Empty;
                    }
                    if (lerDados["data_transito_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[4].SubItems[2].Text = lerDados["data_transito_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[4].SubItems[2].Text = string.Empty;
                    }
                    if (lerDados["data_transito"] == DBNull.Value || Convert.ToDateTime(lerDados["data_transito"].ToString()) == DateTime.MinValue)
                    {

                        ListViewItem listItem = new ListViewItem();

                        String dataValue = "00/00/0000 00:00:00";

                        listItem.SubItems.Add("00/00/0000 00:00:00");


                        listViewApontamento.Items[4].SubItems[1].Text = dataValue.ToString();


                    }
                    else
                    {

                        String dataTransito = Convert.ToDateTime(lerDados["data_transito"]).ToString("dd/MM/yyyy  HH:mm:ss");

                        dtpDataEntrega.Value = Convert.ToDateTime(dataTransito);


                        ListViewItem listItem = new ListViewItem();

                        listItem.SubItems.Add(dataTransito);


                        listViewApontamento.Items[4].SubItems[1].Text = dataTransito.ToString();

                    }
                    if (lerDados["data_transito_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[4].SubItems[2].Text = lerDados["data_transito_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[4].SubItems[2].Text = string.Empty;
                    }
                    if (lerDados["data_entrega"] != DBNull.Value)
                    {

                        String dataEntrega = Convert.ToDateTime(lerDados["data_entrega"]).ToString("dd/MM/yyyy  HH:mm:ss");

                        dtpDataEntrega.Value = Convert.ToDateTime(dataEntrega);


                        ListViewItem listItem = new ListViewItem();

                        listItem.SubItems.Add(dataEntrega);


                        listViewApontamento.Items[5].SubItems[1].Text = dataEntrega.ToString();

                    }
                    else
                    {
                        ListViewItem listItem = new ListViewItem();

                        String dataValue = "00/00/0000 00:00:00";

                        listItem.SubItems.Add("00/00/0000 00:00:00");


                        listViewApontamento.Items[5].SubItems[1].Text = dataValue.ToString();

                    }
                    if (lerDados["data_entrega_usuario"] != DBNull.Value)
                    {
                        listViewApontamento.Items[5].SubItems[2].Text = lerDados["data_entrega_usuario"].ToString();
                    }
                    else
                    {
                        listViewApontamento.Items[5].SubItems[2].Text = string.Empty;
                    }

                }

            }
            con.desconectar();
            postgreSql.Connection.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtPedido.Text = listView1.SelectedItems[0].SubItems[0].Text;
            
            listViewApontamento.Items[0].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[1].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[2].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[3].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[4].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[5].SubItems[2].Text = string.Empty.ToString();

            if (listView1.SelectedIndices.Count > 0)
            {
                carregarItems();


            }
        }
        String numeroPedido;
        DateTime? dataHoraGeracao;
        DateTime? dataHoraFinProd;
        DateTime? dataHoraIniProd;
        DateTime dataPrevistaEntrega;
        DateTime? dataHoraSeparacao;
        DateTime? dataHoraTransito;
        String dataHoraEntregaUsuario;
        String dataHoraFinProdUsuario;
        String dataHoraGeracaoUsuario;
        String dataHoraIniProdUsuario;
        String dataHoraSeparaUsuario;
        String dataHoraTransitoUsuario;
        String usuario;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Modelo.PedidoController pedidoController = new Modelo.PedidoController();
            pedidoController.verificarSeTemPedido(txtPedido.Text);
            if(pedidoController.have)
            {
                updatePedidoController updateController = new updatePedidoController();

                if (listViewApontamento.Items[0].SubItems[1].Text == "00/00/0000 00:00:00")
                {
                    dataHoraGeracao = DateTime.MinValue;

                }
                else
                {
                    DateTime value = (DateTime)Convert.ToDateTime(listViewApontamento.Items[0].SubItems[1].Text);

                    dataHoraGeracao = value;
                }
                if (listViewApontamento.Items[2].SubItems[1].Text == "00/00/0000 00:00:00")
                {
                    dataHoraFinProd = DateTime.MinValue;
                }
                else
                {
                    DateTime value = (DateTime)Convert.ToDateTime(listViewApontamento.Items[2].SubItems[1].Text);

                    dataHoraFinProd = value;

                }
                if (listViewApontamento.Items[3].SubItems[1].Text == "00/00/0000 00:00:00")
                {
                    dataHoraSeparacao = DateTime.MinValue;
                }
                else
                {
                    DateTime value = (DateTime)Convert.ToDateTime(listViewApontamento.Items[3].SubItems[1].Text);

                    dataHoraSeparacao = value;
                }

                if (listViewApontamento.Items[4].SubItems[1].Text == "00/00/0000 00:00:00")
                {
                    dataHoraTransito = DateTime.MinValue;
                }
                else
                {
                    DateTime value = (DateTime)Convert.ToDateTime(listViewApontamento.Items[4].SubItems[1].Text);

                    dataHoraTransito = value;

                }

                if (listViewApontamento.Items[1].SubItems[1].Text == "00/00/0000 00:00:00")
                {
                    dataHoraIniProd = DateTime.MinValue;
                }
                else
                {
                    DateTime value = Convert.ToDateTime(listViewApontamento.Items[1].SubItems[1].Text);

                    dataHoraIniProd = value;

                }

                if (listViewApontamento.Items[5].SubItems[2].Text != string.Empty)
                {
                    dataHoraEntregaUsuario = listViewApontamento.Items[5].SubItems[2].Text;
                }
                else
                {
                    dataHoraEntregaUsuario = string.Empty;
                }

                if (listViewApontamento.Items[2].SubItems[2].Text != string.Empty)
                {
                    dataHoraFinProdUsuario = listViewApontamento.Items[2].SubItems[2].Text;
                }
                else
                {
                    dataHoraFinProdUsuario = string.Empty;
                }
                if (listViewApontamento.Items[0].SubItems[2].Text != string.Empty)
                {
                    dataHoraGeracaoUsuario = listViewApontamento.Items[0].SubItems[2].Text;
                }
                else
                {
                    dataHoraGeracaoUsuario = string.Empty;
                }

                if (listViewApontamento.Items[1].SubItems[2].Text != string.Empty)
                {
                    dataHoraIniProdUsuario = listViewApontamento.Items[1].SubItems[2].Text;
                }
                else
                {
                    dataHoraIniProdUsuario = string.Empty;
                }
                if (listViewApontamento.Items[3].SubItems[2].Text != string.Empty)
                {
                    dataHoraSeparaUsuario = listViewApontamento.Items[3].SubItems[2].Text;

                }
                else
                {
                    dataHoraSeparaUsuario = string.Empty;
                }
                if (listViewApontamento.Items[4].SubItems[2].Text != string.Empty)
                {
                    dataHoraTransitoUsuario = listViewApontamento.Items[4].SubItems[2].Text;
                }
                else
                {
                    dataHoraTransitoUsuario = string.Empty;
                }

                DateTime dataEntrega = Convert.ToDateTime(dtpDataEntrega.Value);



                updateController.UpdatePedidoController(txtPedido.Text, cboStatus.Text, dataEntrega, dataHoraFinProd, dataHoraIniProd, dataPrevistaEntrega, dataHoraSeparacao, dataHoraTransito, dataHoraEntregaUsuario, dataHoraFinProdUsuario, dataHoraGeracaoUsuario, dataHoraGeracao, dataHoraIniProdUsuario, dataHoraSeparaUsuario, dataHoraTransitoUsuario);
       
                loadListView();
                limpar();

            }
            else
            {
                pedidoController.adicionarPedido(txtPedido.Text, DateTime.Now, lblUsuario.Text);

                MessageBox.Show("Pedido adicionado com sucesso");
                limpar();
                loadListView();

            }

        }

        private void btnApontar_Click_1(object sender, EventArgs e)
        {

            String dateTime = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy HH:mm:ss");


            listViewApontamento.SelectedItems[0].SubItems[1].Text = dateTime.ToString();
            listViewApontamento.SelectedItems[0].SubItems[2].Text = lblUsuario.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();

        }
        private void limpar()
        {
            txtPedido.Text = string.Empty;
            cboStatus.Text = string.Empty;
            listView1.SelectedItems.Clear();
            listViewApontamento.Items[0].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[1].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[2].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[3].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[4].SubItems[2].Text = string.Empty.ToString();
            listViewApontamento.Items[5].SubItems[2].Text = string.Empty.ToString();

            listViewApontamento.Items[0].SubItems[1].Text = "00/00/0000 00:00:00";
            listViewApontamento.Items[1].SubItems[1].Text = "00/00/0000 00:00:00";
            listViewApontamento.Items[2].SubItems[1].Text = "00/00/0000 00:00:00";
            listViewApontamento.Items[3].SubItems[1].Text = "00/00/0000 00:00:00";
            listViewApontamento.Items[4].SubItems[1].Text = "00/00/0000 00:00:00";
            listViewApontamento.Items[5].SubItems[1].Text = "00/00/0000 00:00:00";
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                carregarItems();

                listView1.SelectedItems.Clear();
                foreach(ListViewItem item in listView1.Items)
                {

                    if(txtPedido.Text == item.SubItems[0].Text)
                    {
                        listView1.Focus();
                        item.Selected = true;
                        break;


                    }
                }


            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtMskPedido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMskPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                carregarItems();

                listView1.SelectedItems.Clear();
                foreach (ListViewItem item in listView1.Items)
                {

                    if (txtMskPedido.Text == item.SubItems[0].Text)
                    {
                        listView1.Focus();
                        item.Selected = true;
                        break;


                    }
                }


            }

        }
    }
}
