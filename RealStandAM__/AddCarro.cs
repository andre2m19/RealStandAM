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
    public partial class AddCarro : Form
    {
        public AddCarro()
        {
            InitializeComponent();
        }

        private void buttonCarro_Click(object sender, EventArgs e)
        {
            if (matriculaTextBox.Text.Length == 0)
                return;

            //Cliente clienteSelecionado = (Cliente)ListBoxClientes.Selec
        }
    }
}
