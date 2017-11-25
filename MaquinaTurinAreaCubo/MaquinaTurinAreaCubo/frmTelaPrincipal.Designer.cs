namespace MaquinaTurinAreaCubo
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabelamaquina = new System.Windows.Forms.DataGridView();
            this.ESTADOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIMBOLO_INICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIMBOLO_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIMBOLO_VAZIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VARIAVEL_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VARIAVEL_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.máquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executarMaquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.permitirEdiçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfita = new System.Windows.Forms.RichTextBox();
            this.lbResposta = new System.Windows.Forms.Label();
            this.lbCalculando = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelamaquina)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lbCalculando);
            this.panel1.Controls.Add(this.lbResposta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 711);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Execução pausada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtArea
            // 
            this.txtArea.AutoSize = true;
            this.txtArea.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.ForeColor = System.Drawing.Color.Red;
            this.txtArea.Location = new System.Drawing.Point(15, 257);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(149, 33);
            this.txtArea.TabIndex = 1;
            this.txtArea.Text = "Area Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tamanho: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Execução sem pausa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabelamaquina
            // 
            this.tabelamaquina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelamaquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelamaquina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTADOS,
            this.SIMBOLO_INICIAL,
            this.SIMBOLO_X,
            this.SIMBOLO_VAZIO,
            this.VARIAVEL_A,
            this.VARIAVEL_B});
            this.tabelamaquina.Location = new System.Drawing.Point(206, 444);
            this.tabelamaquina.Name = "tabelamaquina";
            this.tabelamaquina.ReadOnly = true;
            this.tabelamaquina.Size = new System.Drawing.Size(1136, 261);
            this.tabelamaquina.TabIndex = 1;
            this.tabelamaquina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ESTADOS
            // 
            this.ESTADOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ESTADOS.HeaderText = "Estados";
            this.ESTADOS.Name = "ESTADOS";
            this.ESTADOS.ReadOnly = true;
            // 
            // SIMBOLO_INICIAL
            // 
            this.SIMBOLO_INICIAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SIMBOLO_INICIAL.HeaderText = "->";
            this.SIMBOLO_INICIAL.Name = "SIMBOLO_INICIAL";
            this.SIMBOLO_INICIAL.ReadOnly = true;
            // 
            // SIMBOLO_X
            // 
            this.SIMBOLO_X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SIMBOLO_X.HeaderText = "X";
            this.SIMBOLO_X.Name = "SIMBOLO_X";
            this.SIMBOLO_X.ReadOnly = true;
            // 
            // SIMBOLO_VAZIO
            // 
            this.SIMBOLO_VAZIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SIMBOLO_VAZIO.HeaderText = "-";
            this.SIMBOLO_VAZIO.Name = "SIMBOLO_VAZIO";
            this.SIMBOLO_VAZIO.ReadOnly = true;
            // 
            // VARIAVEL_A
            // 
            this.VARIAVEL_A.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VARIAVEL_A.HeaderText = "A";
            this.VARIAVEL_A.Name = "VARIAVEL_A";
            this.VARIAVEL_A.ReadOnly = true;
            // 
            // VARIAVEL_B
            // 
            this.VARIAVEL_B.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VARIAVEL_B.HeaderText = "B";
            this.VARIAVEL_B.Name = "VARIAVEL_B";
            this.VARIAVEL_B.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualização | Tabela de Estados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.máquinaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // máquinaToolStripMenuItem
            // 
            this.máquinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarMaquinaToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.toolStripSeparator1,
            this.permitirEdiçõesToolStripMenuItem});
            this.máquinaToolStripMenuItem.Name = "máquinaToolStripMenuItem";
            this.máquinaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.máquinaToolStripMenuItem.Text = "Máquina";
            // 
            // executarMaquinaToolStripMenuItem
            // 
            this.executarMaquinaToolStripMenuItem.Name = "executarMaquinaToolStripMenuItem";
            this.executarMaquinaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.executarMaquinaToolStripMenuItem.Text = "Executar";
            this.executarMaquinaToolStripMenuItem.Click += new System.EventHandler(this.executarMaquinaToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // permitirEdiçõesToolStripMenuItem
            // 
            this.permitirEdiçõesToolStripMenuItem.Name = "permitirEdiçõesToolStripMenuItem";
            this.permitirEdiçõesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.permitirEdiçõesToolStripMenuItem.Text = "Permitir Edições";
            this.permitirEdiçõesToolStripMenuItem.Click += new System.EventHandler(this.permitirEdiçõesToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtfita);
            this.groupBox1.Location = new System.Drawing.Point(206, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização | Execução da Maquina";
            // 
            // txtfita
            // 
            this.txtfita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfita.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfita.Location = new System.Drawing.Point(6, 19);
            this.txtfita.MaxLength = 999999999;
            this.txtfita.Name = "txtfita";
            this.txtfita.ReadOnly = true;
            this.txtfita.Size = new System.Drawing.Size(1124, 347);
            this.txtfita.TabIndex = 0;
            this.txtfita.Text = ">XXXXXX_?";
            // 
            // lbResposta
            // 
            this.lbResposta.AutoSize = true;
            this.lbResposta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResposta.ForeColor = System.Drawing.Color.Red;
            this.lbResposta.Location = new System.Drawing.Point(72, 290);
            this.lbResposta.Name = "lbResposta";
            this.lbResposta.Size = new System.Drawing.Size(20, 24);
            this.lbResposta.TabIndex = 5;
            this.lbResposta.Text = "0";
            // 
            // lbCalculando
            // 
            this.lbCalculando.AutoSize = true;
            this.lbCalculando.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbCalculando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculando.ForeColor = System.Drawing.Color.White;
            this.lbCalculando.Location = new System.Drawing.Point(20, 656);
            this.lbCalculando.Name = "lbCalculando";
            this.lbCalculando.Size = new System.Drawing.Size(144, 25);
            this.lbCalculando.TabIndex = 6;
            this.lbCalculando.Text = "Calculando ...";
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabelamaquina);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquina de Turing - Area Cubo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelamaquina)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tabelamaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem executarMaquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtfita;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtArea;
        private System.Windows.Forms.ToolStripMenuItem permitirEdiçõesToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO_INICIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO_VAZIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VARIAVEL_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn VARIAVEL_B;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbResposta;
        private System.Windows.Forms.Label lbCalculando;
    }
}

