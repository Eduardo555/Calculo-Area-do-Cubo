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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.visualizarFitaOriginalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.executarMaquinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitaDeExecuçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarFitaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeEstadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 711);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Informar Tamanho das Aresta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ESTADOS,
            this.SIMBOLO_INICIAL,
            this.SIMBOLO_X,
            this.SIMBOLO_VAZIO,
            this.VARIAVEL_A,
            this.VARIAVEL_B});
            this.dataGridView1.Location = new System.Drawing.Point(206, 444);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1136, 261);
            this.dataGridView1.TabIndex = 1;
            // 
            // ESTADOS
            // 
            this.ESTADOS.HeaderText = "Estados";
            this.ESTADOS.Name = "ESTADOS";
            // 
            // SIMBOLO_INICIAL
            // 
            this.SIMBOLO_INICIAL.HeaderText = "->";
            this.SIMBOLO_INICIAL.Name = "SIMBOLO_INICIAL";
            // 
            // SIMBOLO_X
            // 
            this.SIMBOLO_X.HeaderText = "X";
            this.SIMBOLO_X.Name = "SIMBOLO_X";
            // 
            // SIMBOLO_VAZIO
            // 
            this.SIMBOLO_VAZIO.HeaderText = "-";
            this.SIMBOLO_VAZIO.Name = "SIMBOLO_VAZIO";
            // 
            // VARIAVEL_A
            // 
            this.VARIAVEL_A.HeaderText = "A";
            this.VARIAVEL_A.Name = "VARIAVEL_A";
            // 
            // VARIAVEL_B
            // 
            this.VARIAVEL_B.HeaderText = "B";
            this.VARIAVEL_B.Name = "VARIAVEL_B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visualização Tabela de Estados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.máquinaToolStripMenuItem,
            this.fitaDeExecuçãoToolStripMenuItem,
            this.tabelaDeEstadosToolStripMenuItem,
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
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // máquinaToolStripMenuItem
            // 
            this.máquinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarFitaOriginalToolStripMenuItem,
            this.toolStripSeparator1,
            this.executarMaquinaToolStripMenuItem,
            this.pararToolStripMenuItem,
            this.reiniciarToolStripMenuItem});
            this.máquinaToolStripMenuItem.Name = "máquinaToolStripMenuItem";
            this.máquinaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.máquinaToolStripMenuItem.Text = "Máquina";
            // 
            // visualizarFitaOriginalToolStripMenuItem
            // 
            this.visualizarFitaOriginalToolStripMenuItem.Name = "visualizarFitaOriginalToolStripMenuItem";
            this.visualizarFitaOriginalToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.visualizarFitaOriginalToolStripMenuItem.Text = "Informar Tamanho das Aresta";
            this.visualizarFitaOriginalToolStripMenuItem.Click += new System.EventHandler(this.visualizarFitaOriginalToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // executarMaquinaToolStripMenuItem
            // 
            this.executarMaquinaToolStripMenuItem.Name = "executarMaquinaToolStripMenuItem";
            this.executarMaquinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.executarMaquinaToolStripMenuItem.Text = "Executar";
            // 
            // pararToolStripMenuItem
            // 
            this.pararToolStripMenuItem.Name = "pararToolStripMenuItem";
            this.pararToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pararToolStripMenuItem.Text = "Parar";
            // 
            // fitaDeExecuçãoToolStripMenuItem
            // 
            this.fitaDeExecuçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.visualizarFitaInicialToolStripMenuItem});
            this.fitaDeExecuçãoToolStripMenuItem.Name = "fitaDeExecuçãoToolStripMenuItem";
            this.fitaDeExecuçãoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.fitaDeExecuçãoToolStripMenuItem.Text = "Fita de Execução";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            // 
            // visualizarFitaInicialToolStripMenuItem
            // 
            this.visualizarFitaInicialToolStripMenuItem.Name = "visualizarFitaInicialToolStripMenuItem";
            this.visualizarFitaInicialToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.visualizarFitaInicialToolStripMenuItem.Text = "Visualizar Fita Inicial";
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
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // tabelaDeEstadosToolStripMenuItem
            // 
            this.tabelaDeEstadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
            this.tabelaDeEstadosToolStripMenuItem.Name = "tabelaDeEstadosToolStripMenuItem";
            this.tabelaDeEstadosToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.tabelaDeEstadosToolStripMenuItem.Text = "Tabela de Estados";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Executar Máquina";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(206, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1136, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualização | Execução da Maquina";
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maquina de Turing - Area Cubo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO_INICIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIMBOLO_VAZIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VARIAVEL_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn VARIAVEL_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem máquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarFitaOriginalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem executarMaquinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pararToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitaDeExecuçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarFitaInicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeEstadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

