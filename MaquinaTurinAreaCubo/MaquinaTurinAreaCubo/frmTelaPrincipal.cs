using MaquinaTurinAreaCubo.MaquinaTuring;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaTurinAreaCubo
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void visualizarFitaOriginalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region --- Botoes ---

        private void btnTamanhoArestas_Click(object sender, EventArgs e)
        {

         
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region --- CONFIGURACAO INICIAL MAQUINA E LOAD DO FORM ---

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            tabelamaquina.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
          //  this.dataGridView1.Rows.Add(">", "", "", "", "", "");
            tabelamaquina.Rows.Add("0",  "D,>,0", "D,X,0",      "D,A,1",    "",         "");
            tabelamaquina.Rows.Add("1",  "",       "D,B,2",     "",         "",         "");
            tabelamaquina.Rows.Add("2",  "",       "D,X,2",     "D,A,3",    "",         "");
            tabelamaquina.Rows.Add("3",  "",       "",          "E,B,4",    "",         "");
            tabelamaquina.Rows.Add("4",  "",       "E,X,4",     "",         "E,A,4",    "D,B,5");
            tabelamaquina.Rows.Add("5",  "",       "D,B,6",     "",         "E,A,8",    "");
            tabelamaquina.Rows.Add("6",  "",       "D,X,6",     "",         "D,A,7",    "");
            tabelamaquina.Rows.Add("7",  "",       "",          "E,B,8",    "",         "D,B,7");
            tabelamaquina.Rows.Add("8",  "",       "",          "",         "E,A,9",    "E,B,8");
            tabelamaquina.Rows.Add("9",  "D,>,10", "E,X,9",     "D,_,10",   "",         "D,B,5");
            tabelamaquina.Rows.Add("10", "D,>,11", "E,X,10",    "E,_,10",   "D,_,10",   "D,X,10");
            tabelamaquina.Rows.Add("11", "",       "D,X,11",    "D,_,12",   "D,_,10",   "");
            tabelamaquina.Rows.Add("12", "",       "D,B,13",    "D,_,20",   "",         "");
            tabelamaquina.Rows.Add("13", "",       "D,X,13",    "D,_,14",   "",         "");
            tabelamaquina.Rows.Add("14", "",       "D,A,15",    "E,_,18",   "",         "");
            tabelamaquina.Rows.Add("15", "",       "D,X,15",    "D,_,16",   "",         "");
            tabelamaquina.Rows.Add("16", "",       "D,X,16",    "E,X,17",   "",         "");
            tabelamaquina.Rows.Add("17", "",       "E,X,17",    "E,_,17",   "D,A,14",   "");
            tabelamaquina.Rows.Add("18", "",       "",          "E,_,19",   "E,X,18",   "");
            tabelamaquina.Rows.Add("19", "",       "E,X,19",    "D,_,12",   "",         "D,B,12");
            tabelamaquina.Rows.Add("20", "",       "D,_,20",    "E,_,20",   "",         "E,_,21");
            tabelamaquina.Rows.Add("21", "",       "",          "D,A,22",   "",         "E,_,21");
            tabelamaquina.Rows.Add("22", "",       "D,X,23",    "D,_,22",   "",         "");
            tabelamaquina.Rows.Add("23", "",       "D,X,23",    "E,B,24",   "",         "");
            tabelamaquina.Rows.Add("24", "",       "E,X,24",    "E,_,25",   "",         "");
            tabelamaquina.Rows.Add("25", "",       "",          "E,_,25",   "D,A,26",   "");
            tabelamaquina.Rows.Add("26", "",       "",          "D,X,27",   "",         "");
            tabelamaquina.Rows.Add("27", "",       "E,_,28",    "D,_,27",   "",         "E,_,29");
            tabelamaquina.Rows.Add("28", "",       "D,X,26",    "E,_,28",   "",         "");
            tabelamaquina.Rows.Add("29", "",       "E,_,30",    "E,_,29",   "",         "");
            tabelamaquina.Rows.Add("30", "D,>,31", "E,X,30",    "",         "E,_,30",   "");
            tabelamaquina.Rows.Add("31", "",       "D,_,32",    "D,_,39",   "",         "");
            tabelamaquina.Rows.Add("32", "",       "D,X,32",    "D,_,33",   "",         "");
            tabelamaquina.Rows.Add("33", "",       "D,A,34",    "E,_,37",   "",         "");
            tabelamaquina.Rows.Add("34", "",       "D,X,34",    "D,_,35",   "",         "");
            tabelamaquina.Rows.Add("35", "",       "D,X,35",    "E,X,36",   "",         "");
            tabelamaquina.Rows.Add("36", "",       "E,X,36",    "E,_,36",   "D,A,33",   "");
            tabelamaquina.Rows.Add("37", "",       "",          "E,_,38",   "E,X,37",   "");
            tabelamaquina.Rows.Add("38", "",       "E,X,38",    "D,_,31",    "",         "");
            tabelamaquina.Rows.Add("39", "",       "D,_,39",    "0,0,0",    "",         "");
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox1.Text.Equals(0))
            {
                MessageBox.Show("Digite um numero válido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (Convert.ToInt32(textBox1.Text) <= 1)
            {

                MessageBox.Show("Digite um numero maior que 1", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            RodarMaquina();

        }

        #region --- RODAR MAQUINA DIRETO SEM PAUSAS ---

        private void RodarMaquina()
        {

            string valor = ">XXXXXX_";
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                valor = valor + "X";
            }

            txtfita.Text = valor + "_";
            String linhaatual = "0"; // referente aos estados
            Int32 colunaatual = 1;
            Int32 posicao = 0;
            String fita = txtfita.Text;
            String dadoatual = "";
 
            tabelamaquina.CurrentCell = tabelamaquina[colunaatual, Convert.ToInt32(linhaatual)];    // seleciona celula

            while (dadoatual != "0,0,0")
            {

                dadoatual = Convert.ToString(tabelamaquina.CurrentCell.Value);

                if (Convert.ToString(dadoatual) == "")
                {
                    MessageBox.Show("Maquina de turing com problema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Convert.ToString(dadoatual[2]) == ">")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = '>';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;

                }
                else if (Convert.ToString(dadoatual[2]) == "A")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = 'A';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }
                else if (Convert.ToString(dadoatual[2]) == "B")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = 'B';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }
                else if (Convert.ToString(dadoatual[2]) == "_")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = '_';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }
                else if (Convert.ToString(dadoatual[2]) == "X")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = 'X';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }

                if (Convert.ToString(dadoatual[0]) == "D")
                {
                    posicao = posicao + 1;
                }
                else if (Convert.ToString(dadoatual[0]) == "E")
                {
                    posicao = posicao - 1;
                }

                linhaatual = Convert.ToString(dadoatual[4]);
                if (Convert.ToInt32(dadoatual.Length) > 5)
                {
                    linhaatual = linhaatual + Convert.ToString(dadoatual[5]);
                }

                try
                {
                    if (Convert.ToString(fita[posicao]) == ">")
                    {
                        colunaatual = 1;
                    }
                    else if (Convert.ToString(fita[posicao]) == "X")
                    {
                        colunaatual = 2;
                    }
                    else if (Convert.ToString(fita[posicao]) == "_")
                    {
                        colunaatual = 3;
                    }
                    else if (Convert.ToString(fita[posicao]) == "A")
                    {
                        colunaatual = 4;
                    }
                    else if (Convert.ToString(fita[posicao]) == "B")
                    {
                        colunaatual = 5;
                    }
                }
                catch
                {
                    fita = fita + "_";
                    colunaatual = 3;
                }

                tabelamaquina.CurrentCell = tabelamaquina[colunaatual, Convert.ToInt32(linhaatual)];

            }
            int contar = 0;
            for (int i = 0; i < fita.Length; i++)
            {
                if (Convert.ToString(fita[i]) == "X")
                {
                    contar = contar + 1;
                }
            }
            txtArea.Text = "Area: " + Convert.ToString(contar);
        }

        #endregion

        #region --- RODAR MAQUINA COM PAUSAS ---

        private void RodarMaquinaComPausa()
        {

            string valor = ">XXXXXX_";
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                valor = valor + "X";
            }

            txtfita.Text = valor + "_";
            String linhaatual = "0"; //estado
            Int32 colunaatual = 1;
            Int32 posicao = 0;
            String fita = txtfita.Text;
            String dadoatual = "";

            tabelamaquina.CurrentCell = tabelamaquina[colunaatual, Convert.ToInt32(linhaatual)];

            while (dadoatual != "0,0,0")
            {

                dadoatual = Convert.ToString(tabelamaquina.CurrentCell.Value);

                txtfita.Select(0, fita.Length);
                txtfita.SelectionColor = Color.Black;
         
                if (Convert.ToString(dadoatual) == "")
                {
                    frmProximo frmProximo = new frmProximo();
                    frmProximo.ShowDialog();
                    MessageBox.Show("Maquina de turing com problema", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Convert.ToString(dadoatual[2]) == ">")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = '>';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;

                }
                else if (Convert.ToString(dadoatual[2]) == "A")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = 'A';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }
                else if (Convert.ToString(dadoatual[2]) == "B")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = 'B';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }
                else if (Convert.ToString(dadoatual[2]) == "_")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = '_';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }
                else if (Convert.ToString(dadoatual[2]) == "X")
                {

                    StringBuilder editarfita = new StringBuilder(fita);
                    editarfita[posicao] = 'X';
                    fita = Convert.ToString(editarfita);
                    txtfita.Text = fita;
                }

                txtfita.Select(posicao, posicao);
                txtfita.SelectionColor = Color.Blue;

                txtfita.Select(posicao +1, posicao);
                txtfita.SelectionColor = Color.Black;

                if (Convert.ToString(dadoatual[0]) == "D")
                {
                    posicao = posicao + 1;
                }
                else if (Convert.ToString(dadoatual[0]) == "E")
                {
                    posicao = posicao - 1;
                }


                linhaatual = Convert.ToString(dadoatual[4]);
                if (Convert.ToInt32(dadoatual.Length) > 5)
                {
                    linhaatual = linhaatual + Convert.ToString(dadoatual[5]);
                }

                try
                {
                    if (Convert.ToString(fita[posicao]) == ">")
                    {
                        colunaatual = 1;
                    }
                    else if (Convert.ToString(fita[posicao]) == "X")
                    {
                        colunaatual = 2;
                    }
                    else if (Convert.ToString(fita[posicao]) == "_")
                    {
                        colunaatual = 3;
                    }
                    else if (Convert.ToString(fita[posicao]) == "A")
                    {
                        colunaatual = 4;
                    }
                    else if (Convert.ToString(fita[posicao]) == "B")
                    {
                        colunaatual = 5;
                    }
                }
                catch
                {
                    fita = fita + "_";
                    colunaatual = 3;
                }
                if (dadoatual == "0,0,0")
                {
                    frmProximo frmProximo = new frmProximo();
                    frmProximo.ShowDialog();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Linha Atual= " + linhaatual, "Proximo", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                tabelamaquina.CurrentCell = tabelamaquina[colunaatual, Convert.ToInt32(linhaatual)];

            }
            int contar = 0;
            for (int i = 0; i < fita.Length; i++)
            {
                if (Convert.ToString(fita[i]) == "X")
                {
                    contar = contar + 1;
                }
            }
            txtArea.Text = "Area: " + Convert.ToString(contar);
        }

        #endregion

        #region --- BOTOES E OUTROS ---

        private void permitirEdiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtfita.ReadOnly = false;
            tabelamaquina.ReadOnly = false;
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void executarMaquinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(0) || textBox1.Text.Equals(""))
            {
                MessageBox.Show("É preciso informar um valor valido para calcular!");
            }
            else
            {
                RodarMaquinaComPausa();
            }
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.ShowDialog();
        }

        #endregion

    }
}
