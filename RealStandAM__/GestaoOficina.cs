using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStandAM__
{
    public partial class GestaoOficina : Form
    {
        private RealStandAMmodelContainer RealStandAM__;
        public GestaoOficina()
        {
            InitializeComponent();

            RealStandAM__ = new RealStandAMmodelContainer();

            listBoxCLientes.DataSource = RealStandAM__.ClienteSet.ToList();
        }

        private void listBoxCLientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxCLientes.SelectedItem;

            labelCliente.Text = clienteSelecionado.Nome;
            labelNif.Text = clienteSelecionado.Nif;
            //labelTotal.Text = clienteSelecionado.total.ToStrin("0.00");

        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {

        }
    }
}
