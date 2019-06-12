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
    public partial class GestaoVenda : Form
    {
        private RealStandAMmodelContainer RealStandAM__;
        public GestaoVenda()
        {
            InitializeComponent();

            RealStandAM__ = new RealStandAMmodelContainer();

            listBoxClientes.DataSource = RealStandAM__.ClienteSet.ToList();
        }

        //Listar os Clientes na listbox
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
        }

        //Colocar o carro como vendido
        private void buttonBuyCar_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
                return;

           Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            CarroVenda carrovenda = new CarroVenda(combustivelTextBox.Text, marcaTextBox.Text, modeloTextBox.Text, numeroChassisTextBox.Text);

            clienteSelecionado.Venda.Add(carrovenda);


            RealStandAM__.SaveChanges();

            listBoxVenda.DataSource = clienteSelecionado.carrovenda.ToList();
        }

        //Listar a venda na listbox
        private void listBoxVenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroVenda carroSelecionado = (CarroVenda)listBoxVenda.SelectedItem;

        }

        //Apenas é valido inserir numeros    
        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(valorTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                valorTextBox.Text = valorTextBox.Text.Remove(valorTextBox.Text.Length - 1);
            }
        }

        //Apenas é valido inserir numeros    
        private void numeroChassisTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(valorTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                valorTextBox.Text = valorTextBox.Text.Remove(valorTextBox.Text.Length - 1);
            }
        }

        //A data da compra é a actual
        private void dataTextBox_TextChanged(object sender, EventArgs e)
        {
            dataTextBox.Text = DateTime.Now.ToString();
        }

    }
}
