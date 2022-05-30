﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void buscarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidos pedidos = new frmPedidos();
            pedidos.lblUsuario.Text = lblUsuario.Text.ToString();

            pedidos.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void desenvolvimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
