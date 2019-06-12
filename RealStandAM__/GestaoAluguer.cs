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
    public partial class GestaoAluguer : Form
    {
        private RealStandAMmodelContainer RealStandAM__;
        public GestaoAluguer()
        {
            InitializeComponent();

            RealStandAM__ = new RealStandAMmodelContainer();

            listBoxClientes.DataSource = RealStandAM__.ClienteSet.ToList();
        }

        //Listar os clientes na listbox
        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;
        }

        //Adcionar o carro ao cliente
        private void buttonRent_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)listBoxClientes.SelectedItem;

            CarroAluguer carroAluguer = new CarroAluguer(combustivelTextBox.Text, kmsTextBox.Text, marcaTextBox.Text, matriculaTextBox.Text, modeloTextBox.Text, numeroChassisTextBox.Text);

            clienteSelecionado.CarroAluguer.Add(carroAluguer);

            RealStandAM__.SaveChanges();

            listBoxAluguer.DataSource = clienteSelecionado.CarroAluguer.ToList();
        }

        //Listar o Aluguer na listbox
        private void listBoxAluguer_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroAluguer carroselecionado = (CarroAluguer)listBoxAluguer.SelectedItem;
        }

        //Apenas é valido inserir numeros    
        private void kmsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(kmsTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                kmsTextBox.Text = kmsTextBox.Text.Remove(kmsTextBox.Text.Length - 1);
            }
        }

        //Apenas é valido inserir numeros    
        private void numeroChassisTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(numeroChassisTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                numeroChassisTextBox.Text = numeroChassisTextBox.Text.Remove(numeroChassisTextBox.Text.Length - 1);
            }
        }

        // A data do inicio de aluguer é a atual
        private void dataInicioTextBox_TextChanged(object sender, EventArgs e)
        {
            dataInicioTextBox.Text = DateTime.Now.ToString();
        }

    }
}
