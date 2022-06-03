namespace RastreioPedidosDesktop
{
    partial class frmPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data/Hora Geração",
            "00/00/0000 00:00:00",
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.InactiveBorder, null);
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data/Hora Ini. Prod.",
            "00/00/0000 00:00:00",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem27 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data/Hora Fin. Prod.",
            "00/00/0000 00:00:00",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem28 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data/Hora Separação",
            "00/00/0000 00:00:00",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data/Hora Transito",
            "00/00/0000 00:00:00",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "Data/Hora Entrega",
            "00/00/0000 00:00:00",
            ""}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desenvolvimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listViewApontamento = new System.Windows.Forms.ListView();
            this.clSituacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataHotaApont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clNumeroPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDataHoraGeracao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUsuarioGeracao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApontar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alteraSenhaToolStripMenuItem,
            this.buscarPedidosToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // alteraSenhaToolStripMenuItem
            // 
            this.alteraSenhaToolStripMenuItem.Name = "alteraSenhaToolStripMenuItem";
            this.alteraSenhaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alteraSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alteraSenhaToolStripMenuItem.Click += new System.EventHandler(this.alteraSenhaToolStripMenuItem_Click);
            // 
            // buscarPedidosToolStripMenuItem
            // 
            this.buscarPedidosToolStripMenuItem.Name = "buscarPedidosToolStripMenuItem";
            this.buscarPedidosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.buscarPedidosToolStripMenuItem.Text = "Buscar Pedidos";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.desenvolvimentoToolStripMenuItem});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // desenvolvimentoToolStripMenuItem
            // 
            this.desenvolvimentoToolStripMenuItem.Name = "desenvolvimentoToolStripMenuItem";
            this.desenvolvimentoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.desenvolvimentoToolStripMenuItem.Text = "Desenvolvimento";
            this.desenvolvimentoToolStripMenuItem.Click += new System.EventHandler(this.desenvolvimentoToolStripMenuItem_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(890, 597);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Gravar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(971, 597);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1052, 597);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listViewApontamento
            // 
            this.listViewApontamento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSituacao,
            this.clDataHotaApont,
            this.clUsuario});
            this.listViewApontamento.FullRowSelect = true;
            this.listViewApontamento.HideSelection = false;
            this.listViewApontamento.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem25,
            listViewItem26,
            listViewItem27,
            listViewItem28,
            listViewItem29,
            listViewItem30});
            this.listViewApontamento.Location = new System.Drawing.Point(25, 368);
            this.listViewApontamento.Name = "listViewApontamento";
            this.listViewApontamento.Size = new System.Drawing.Size(1021, 178);
            this.listViewApontamento.TabIndex = 11;
            this.listViewApontamento.UseCompatibleStateImageBehavior = false;
            this.listViewApontamento.View = System.Windows.Forms.View.Details;
            // 
            // clSituacao
            // 
            this.clSituacao.Text = "Situação";
            this.clSituacao.Width = 203;
            // 
            // clDataHotaApont
            // 
            this.clDataHotaApont.Text = "Data/Hora Apontamento";
            this.clDataHotaApont.Width = 266;
            // 
            // clUsuario
            // 
            this.clUsuario.Text = "Usuario do Apontamento";
            this.clUsuario.Width = 255;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1144, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNumeroPedido,
            this.clStatus,
            this.clDataHoraGeracao,
            this.clUsuarioGeracao});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1115, 80);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // clNumeroPedido
            // 
            this.clNumeroPedido.Text = "N° do Pedido";
            this.clNumeroPedido.Width = 180;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.Width = 120;
            // 
            // clDataHoraGeracao
            // 
            this.clDataHoraGeracao.Text = "Data/Hora Geração";
            this.clDataHoraGeracao.Width = 179;
            // 
            // clUsuarioGeracao
            // 
            this.clUsuarioGeracao.Text = "Usuario Geração";
            this.clUsuarioGeracao.Width = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pedido:";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(74, 120);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 15;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "AGUARDANDO AUTORIZAÇÃO",
            "EM PRODUÇÃO",
            "EM SEPARAÇÃO",
            "EM ROTA",
            "ENTREGUE"});
            this.cboStatus.Location = new System.Drawing.Point(452, 119);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(211, 21);
            this.cboStatus.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status";
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.CustomFormat = "00/00/0000";
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrega.Location = new System.Drawing.Point(948, 121);
            this.dtpDataEntrega.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(98, 20);
            this.dtpDataEntrega.TabIndex = 17;
            this.dtpDataEntrega.Value = new System.DateTime(2022, 6, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data prevista D.E";
            // 
            // btnApontar
            // 
            this.btnApontar.Location = new System.Drawing.Point(1052, 523);
            this.btnApontar.Name = "btnApontar";
            this.btnApontar.Size = new System.Drawing.Size(75, 23);
            this.btnApontar.TabIndex = 19;
            this.btnApontar.Text = "Apontar";
            this.btnApontar.UseVisualStyleBackColor = true;
            this.btnApontar.Click += new System.EventHandler(this.btnApontar_Click_1);
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 645);
            this.Controls.Add(this.btnApontar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataEntrega);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewApontamento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desenvolvimentoToolStripMenuItem;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ListView listViewApontamento;
        private System.Windows.Forms.ColumnHeader clSituacao;
        private System.Windows.Forms.ColumnHeader clDataHotaApont;
        private System.Windows.Forms.ColumnHeader clUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clNumeroPedido;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.ColumnHeader clDataHoraGeracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApontar;
        private System.Windows.Forms.ColumnHeader clUsuarioGeracao;
    }
}