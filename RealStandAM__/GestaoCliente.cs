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
        }
      
        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length > 0)
            {
                bindingNavigatorAddNewItem.Enabled = false;
                Standreal.Dispose();
                Standreal = new RealStandAMmodelContainer();
                (from pessoa in Standreal.ClienteSet
                 where pessoa.Nome.ToUpper().Contains(textBoxFilter.Text.ToUpper())
                 orderby pessoa.Nome
                 select pessoa).ToList();
                clienteBindingSource.DataSource = Standreal.ClienteSet.Local.ToBindingList();
            }
            else
            {
                bindingNavigatorAddNewItem.Enabled = true;
                Standreal.Dispose();
                Standreal = new RealStandAMmodelContainer();
                (from pessoa in Standreal.ClienteSet
                 orderby pessoa.Nome
                 select pessoa).Load();
                clienteBindingSource.DataSource = Standreal.ClienteSet.Local.ToBindingList();
            }
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Standreal.SaveChanges();
        }
    }
}
