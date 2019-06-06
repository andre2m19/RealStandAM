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

            RealStandAM__ = new RealStandAMmodelContainer();
        }

        private void listBoxCLientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente clienteSelecionado = (Cliente)listBoxCLientes.SelectedItem;

            labelCliente.Text = clienteSelecionado.Nome;
            labelNif.Text = clienteSelecionado.Nif;
            

        }

        private void buttonAddCarro_Click(object sender, EventArgs e)
        {
            if (listBoxCLientes.SelectedIndex == -1)
                return;

            Cliente clienteSelecionado = (Cliente)listBoxCLientes.SelectedItem;

            CarroOficina carroOficina = new CarroOficina(combustivelTextBox.Text, kmsTextBox.Text, marcaTextBox.Text, matriculaTextBox.Text, modeloTextBox.Text, numeroChassisTextBox.Text);

            clienteSelecionado.CarroOficina.Add(carroOficina);

            listBoxOficina.DataSource = null;

            listBoxOficina.DataSource = clienteSelecionado.CarroOficina;

            listBoxServico.SelectedItem = carroOficina;

            marcaTextBox.Text = "";
            modeloTextBox.Text = "";
        }

        private void listBoxOficina_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxOficina.SelectedItem;


            listBoxServico.DataSource = carroSelecionado.Servico.ToList();
        }

        private void buttonAddServico_Click(object sender, EventArgs e)
        {
            CarroOficina carroSelecionado = (CarroOficina)listBoxOficina.SelectedItem;

            Servico servico = new Servico(comboBoxServico.SelectedItem.ToString());

            carroSelecionado.Servico.Add(servico);

            RealStandAM__.SaveChanges();
        }

        private void listBoxServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;

            listBoxParcela.DataSource = servicoSelecionado.Parcela.ToList();
        }

        private void buttonaddParcela_Click(object sender, EventArgs e)
        {          
            Servico servicoSelecionado = (Servico)listBoxServico.SelectedItem;

            Parcela parcela = new Parcela(textBoxDescrever.Text, textBoxValor.Text);

            servicoSelecionado.Parcela.Add(parcela);

            RealStandAM__.SaveChanges();
            listBoxParcela.DataSource = servicoSelecionado.Parcela.ToList();
        }

        private void listBoxParcela_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parcela parcelaSelecionado = (Parcela)listBoxParcela.SelectedItem;
        }
    }
}
