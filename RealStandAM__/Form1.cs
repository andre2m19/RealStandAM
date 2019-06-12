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

        //Botao de acesso ao Gestor de Clientes
        private void FormGestao_Click(object sender, EventArgs e)
        {
            GestaoCliente gestaocliente = new GestaoCliente();
            gestaocliente.Show();
        }

        //Botao de acesso ao Gestor de Oficina
        private void GestorOficina_Click(object sender, EventArgs e)
        {
            GestaoOficina gestaooficina = new GestaoOficina();
            gestaooficina.Show();
        }

        //Botao de acesso ao Gestor de Vendas
        private void buttonGestaoVenda_Click(object sender, EventArgs e)
        {
            GestaoVenda gestaoVenda = new GestaoVenda();
            gestaoVenda.Show();
        }

        //Botao de acesso ao Gestor de Aluguer
        private void buttonGestaoAluguer_Click(object sender, EventArgs e)
        {
            GestaoAluguer gestaoAluguer = new GestaoAluguer();
            gestaoAluguer.Show();
        }
    }
}
