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

namespace MaquinaTurinAreaCubo.Arestas
{
    public partial class frmTamanhoArestas : Form
    {
        public frmTamanhoArestas()
        {
            InitializeComponent();
        }

        #region --- Instanciadores ---

        clnFita clFita = new clnFita();

        #endregion

        #region --- Botoes ---

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampo() == true)
            {
                clFita.iTamArestas = Convert.ToInt32(txtTamanhoAresta.Text);
                this.Close();
            }
        }

        #endregion


        private Boolean validaCampo()
        {
            if (txtTamanhoAresta.Text.Equals(string.Empty))
            {
                MessageBox.Show("É preciso prhencer o campo antes de salvar!");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
