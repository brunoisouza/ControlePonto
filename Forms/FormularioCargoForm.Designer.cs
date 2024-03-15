namespace ControlePonto.Forms
{
    partial class FormularioCargoForm
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
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            numCargaHoraria = new NumericUpDown();
            label3 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(335, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 94);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(335, 107);
            txtDescricao.TabIndex = 2;
            // 
            // numCargaHoraria
            // 
            numCargaHoraria.Location = new Point(227, 219);
            numCargaHoraria.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numCargaHoraria.Name = "numCargaHoraria";
            numCargaHoraria.Size = new Size(120, 23);
            numCargaHoraria.TabIndex = 4;
            numCargaHoraria.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 221);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Carga Horária";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(253, 258);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 35);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(144, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 35);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormularioCargoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 303);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(label3);
            Controls.Add(numCargaHoraria);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "FormularioCargoForm";
            Text = "FormularioCargoForm";
            ((System.ComponentModel.ISupportInitialize)numCargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private NumericUpDown numCargaHoraria;
        private Label label3;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}