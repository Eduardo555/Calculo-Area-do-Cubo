using MaquinaTurinAreaCubo.Arestas;
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
            frmTamanhoArestas frTamanhoArestas = new frmTamanhoArestas();
            frTamanhoArestas.ShowDialog();
        }

        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Rows.Add(">", "D,>,0", "", "", "", "");
            this.dataGridView1.Rows.Add("0","", "D,X,0","D,A,1","","");
            this.dataGridView1.Rows.Add("1","", "D,B,2", "", "", "");
            this.dataGridView1.Rows.Add("2", "", "D,X,2", "E,B,3", "", "D,B,2");
            this.dataGridView1.Rows.Add("3", "", "E,X,3", "", "", "D,B,4");
            this.dataGridView1.Rows.Add("4", "", "D,B,5", "", "", "");
            this.dataGridView1.Rows.Add("5", "", "D,X,5", "E,B,6", "", "D,B,5");
            this.dataGridView1.Rows.Add("6", "", "E,X,3", "", "D,A,7", "E,B,6");
            this.dataGridView1.Rows.Add("7", "D,>,8", "", "E,X,7", "E,A,7", "D,X,7");
            this.dataGridView1.Rows.Add("8", "", "D,_,9", "D,_,16", "", "");
            this.dataGridView1.Rows.Add("9", "", "D,X,9", "D,_,10", "", "");
            this.dataGridView1.Rows.Add("10", "", "D,A,11", "E,_,14", "", "");
            this.dataGridView1.Rows.Add("11", "", "D,X,11", "D,_,12", "", "");
            this.dataGridView1.Rows.Add("12", "", "D,X,12", "E,X,13", "", "");
            this.dataGridView1.Rows.Add("13", "", "E,X,13", "E,_,13", "D,A,10", "");
            this.dataGridView1.Rows.Add("14", "", "", "E,_,15", "E,X,14", "");
            this.dataGridView1.Rows.Add("15", "", "E,X,15", "D,_,8", "", "");
            this.dataGridView1.Rows.Add("16", "", "D,_,16", "FIM", "", "");
        }
    }
}
