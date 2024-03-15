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
    public partial class FormularioFuncionarioForm : Form
    {
        public FormularioFuncionarioForm()
        {
            InitializeComponent();
            CarregaCargosComboBox();
        }

        private void CarregaCargosComboBox()
        {
            // Faz a conexão com o contexto
            using (var contexto = new ControlePontoDbContext())
            {
                // Pega os cargos do banco
                var cargos = contexto.Cargos.ToList();

                // Adiciona os cargos como fonte de dados do combobox
                cmbCargos.DataSource = cargos;

                // Adiciona o ID como valor combobox
                cmbCargos.ValueMember = "Id";
                // Adiciona o nome para ser exibido no combobox
                cmbCargos.DisplayMember = "Nome";
            };
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int cargoId = 0;
            if (cmbCargos.SelectedIndex > -1)
            {
                cargoId = (int)cmbCargos.SelectedValue;
            }

            // Cria um novo objeto de funcionário
            var funcionario = new Funcionario
            {
                Nome = txtNome.Text,
                CPF = mtxtCPF.Text,
                Matricula = txtMatricula.Text,
                DataNascimento = dtDataNascimento.Value,
                Foto = ""
            };

            // Criou uma instancia do contexto do banco
            using (var contexto = new ControlePontoDbContext())
            {
                // Procura no banco de dados o cargo com o cargoID
                var cargo = contexto.Cargos.Find(cargoId);
                // Associa o cargo ao funcionário
                funcionario.Cargo = cargo;

                // Adiciona o usuário no contexto do banco
                contexto.Funcionarios.Add(funcionario);

                // Salva as alterações dentro do banco
                int resultado = contexto.SaveChanges();

                if (resultado > 0)
                {
                    MessageBox.Show("Funcionário inserido com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Houve um problema ao salvar o funcionário!");
                }
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioFuncionarioForm_Load(object sender, EventArgs e)
        {

        }
    }
}
