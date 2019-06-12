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
    public partial class GestaoCliente : Form
    {
        private RealStandAMmodelContainer Standreal;
        public GestaoCliente()
        {
            InitializeComponent();

            Standreal = new RealStandAMmodelContainer();

            (from Cliente in Standreal.ClienteSet
             orderby Cliente.Nome
             select Cliente).Load();
            clienteBindingSource.DataSource = Standreal.ClienteSet.Local.ToBindingList();
        }
      
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                Standreal.Dispose();
                Standreal = new RealStandAMmodelContainer();
                (from cliente in Standreal.ClienteSet
                 where cliente.Nome.ToUpper().Contains(textBoxFilter.Text.ToUpper())
                 orderby cliente.Nome
                 select cliente).ToList();
                clienteBindingSource.DataSource = Standreal.ClienteSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;
                Standreal.Dispose();
                Standreal = new RealStandAMmodelContainer();
                (from cliente in Standreal.ClienteSet
                 orderby cliente.Nome
                 select cliente).Load();
                clienteBindingSource.DataSource = Standreal.ClienteSet.Local.ToBindingList();
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Standreal.SaveChanges();
        }


        private void contactoTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(contactoTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                contactoTextBox.Text = contactoTextBox.Text.Remove(contactoTextBox.Text.Length - 1);
            }
        }

        private void nifTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nifTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor insira números.");
                nifTextBox.Text = nifTextBox.Text.Remove(nifTextBox.Text.Length - 1);
            }
        }
    }
}
