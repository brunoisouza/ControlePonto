using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePonto.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCargoForm formularioCargoForm = new FormularioCargoForm();

            formularioCargoForm.Show();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormularioFuncionarioForm formularioFuncionarioForm = new FormularioFuncionarioForm();

            formularioFuncionarioForm.Show();
        }
    }
}
