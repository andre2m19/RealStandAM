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

        //Iniciar o Gestor
        private void GestaoOficina_Load(object sender, EventArgs e)
        {
            RealStandAM__ = new RealStandAMmodelContainer();
            LerDados();
        }

        //Ler os dados dos Clientes
        private void LerDados()
        {
            listBoxCLientes.DataSource = RealStandAM__.ClienteSet.ToList<Cliente>();
        }

        //Listar os clientes na LisBox
        private void listBoxCLientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxCLientes.SelectedItem;

            labelClientes.Text = clienteSelecionado.Nome;
            labelNif.Text = clienteSelecionado.Nif;
            

        }

        //Adicionar o carro ao Cliente
        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            if(listBoxCLientes.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)listBoxCLientes.SelectedItem;

            CarroOficina carroOficina = new CarroOficina(combustivelTextBox.Text, kmsTextBox.Text, marcaTextBox.Text, matriculaTextBox.Text, modeloTextBox.Text, numeroChassisTextBox.Text);

            clienteSelecionado.CarroOficina.Add(carroOficina);

            RealStandAM__.SaveChanges();

            listBoxOficina.DataSource = clienteSelecionado.CarroOficina.ToList();
        }

        //Listar o carro na listbox
        private void listBoxOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxOficina.SelectedItem;


            listBoxServico.DataSource = carroSelecionado.Servico.ToList();
        }

        //Remover o carro
        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Carro carroSelecionado = (Carro)listBoxOficina.SelectedItem;

            RealStandAM__.CarroSet.Remove(carroSelecionado);

            RealStandAM__.SaveChanges();

            listBoxCLientes.DataSource = RealStandAM__.ClienteSet.ToList();
        }

        //Adicionar o serviço ao carro
        private void buttonAddServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxOficina.SelectedItem;
            Servico servico = new Servico(comboBoxServico.SelectedItem.ToString());

            carroSelecionado.Servico.Add(servico);

            RealStandAM__.SaveChanges();
            listBoxServico.DataSource = carroSelecionado.Servico.ToList();
        }

        //Listar o serviço
        private void listBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;

            listBoxParcela.DataSource = servicoSelecionado.Parcela.ToList();
        }

        //Adicionar a parcela ao serviço
        private void buttonaddParcela_Click(object sender, EventArgs e)
        {          
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;

            Parcela parcela = new Parcela(textBoxDescrever.Text, textBoxValor.Text);

            servicoSelecionado.Parcela.Add(parcela);

            RealStandAM__.SaveChanges();
            listBoxParcela.DataSource = servicoSelecionado.Parcela.ToList();
        }

        //Listar a parcela
        private void listBoxParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parcela parcelaSelecionado = (Parcela)listBoxParcela.SelectedItem;
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
        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxValor.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                textBoxValor.Text = textBoxValor.Text.Remove(textBoxValor.Text.Length - 1);
            }
        }

        
    }
}
