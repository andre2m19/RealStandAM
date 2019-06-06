using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealStandAM__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormGestao_Click(object sender, EventArgs e)
        {
            GestaoCliente gestaocliente = new GestaoCliente();
            gestaocliente.ShowDialog();
        }

        private void GestorOficina_Click(object sender, EventArgs e)
        {
            GestaoOficina gestaooficina = new GestaoOficina();
            gestaooficina.ShowDialog();
        }
    }
}
