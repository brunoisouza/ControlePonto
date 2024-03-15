using ControlePonto.Data;
using ControlePonto.Modelos;
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
    public partial class FormularioCargoForm : Form
    {
        public FormularioCargoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Criando o objeto de cargo que vai ser salvo
            var cargo = new Cargo
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                CargaHoraria = numCargaHoraria.Value
            };

            //Diretiva para liberar recursos após o uso
            using (var contexto = new ControlePontoDbContext())
            {
                contexto.Cargos.Add(cargo);
                contexto.SaveChanges();
            }

            MessageBox.Show("Cargo inserido com sucesso!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
