
namespace ControlePonto.Forms
{
    partial class FormularioFuncionarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioFuncionarioForm));
            label1 = new Label();
            txtNome = new TextBox();
            txtCPF = new Label();
            dtDataNascimento = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            txtMatricula = new TextBox();
            label4 = new Label();
            txtFoto = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            btnSalvar = new Button();
            pictureBox1 = new PictureBox();
            mtxtCPF = new MaskedTextBox();
            cmbCargos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(341, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.AutoSize = true;
            txtCPF.Location = new Point(12, 73);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(28, 15);
            txtCPF.TabIndex = 5;
            txtCPF.Text = "CPF";
            // 
            // dtDataNascimento
            // 
            dtDataNascimento.Format = DateTimePickerFormat.Short;
            dtDataNascimento.Location = new Point(239, 268);
            dtDataNascimento.Name = "dtDataNascimento";
            dtDataNascimento.Size = new Size(114, 23);
            dtDataNascimento.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 250);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 8;
            label2.Text = "Data de Nascimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(12, 145);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(199, 23);
            txtMatricula.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 12;
            label4.Text = "Foto";
            // 
            // txtFoto
            // 
            txtFoto.Location = new Point(12, 208);
            txtFoto.Name = "txtFoto";
            txtFoto.Size = new Size(341, 23);
            txtFoto.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 14;
            label5.Text = "Cargo";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(152, 306);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(261, 306);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 35);
            btnSalvar.TabIndex = 15;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(239, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 120);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // mtxtCPF
            // 
            mtxtCPF.Location = new Point(13, 95);
            mtxtCPF.Mask = "000.000.000-00";
            mtxtCPF.Name = "mtxtCPF";
            mtxtCPF.Size = new Size(198, 23);
            mtxtCPF.TabIndex = 18;
            mtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // cmbCargos
            // 
            cmbCargos.FormattingEnabled = true;
            cmbCargos.Location = new Point(13, 268);
            cmbCargos.Name = "cmbCargos";
            cmbCargos.Size = new Size(220, 23);
            cmbCargos.TabIndex = 19;
            // 
            // FormularioFuncionarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 353);
            Controls.Add(cmbCargos);
            Controls.Add(mtxtCPF);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtFoto);
            Controls.Add(label3);
            Controls.Add(txtMatricula);
            Controls.Add(label2);
            Controls.Add(dtDataNascimento);
            Controls.Add(txtCPF);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "FormularioFuncionarioForm";
            Text = "FormularioFuncionarioForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Label txtCPF;
        private DateTimePicker dtDataNascimento;
        private Label label2;
        private Label label3;
        private TextBox txtMatricula;
        private Label label4;
        private TextBox txtFoto;
        private Label label5;
        private Button btnCancelar;
        private Button btnSalvar;
        private PictureBox pictureBox1;
        private MaskedTextBox mtxtCPF;
        private ComboBox cmbCargos;
    }
}