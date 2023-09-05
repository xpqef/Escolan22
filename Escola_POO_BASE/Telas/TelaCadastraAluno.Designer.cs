namespace Escola_POO_BASE.Telas
{
    partial class TelaCadastraAluno
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CkbAtivo = new System.Windows.Forms.CheckBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DtpDtMatricula = new System.Windows.Forms.DateTimePicker();
            this.DtpDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.LblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CkbAtivo);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DtpDtNascimento);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Aluno";
            // 
            // CkbAtivo
            // 
            this.CkbAtivo.AutoSize = true;
            this.CkbAtivo.Checked = true;
            this.CkbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbAtivo.Enabled = false;
            this.CkbAtivo.Location = new System.Drawing.Point(388, 30);
            this.CkbAtivo.Name = "CkbAtivo";
            this.CkbAtivo.Size = new System.Drawing.Size(79, 29);
            this.CkbAtivo.TabIndex = 10;
            this.CkbAtivo.Text = "Ativo";
            this.CkbAtivo.UseVisualStyleBackColor = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(19, 136);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(448, 31);
            this.TxtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data da Matrícula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data de Nascimento:";
            // 
            // DtpDtMatricula
            // 
            this.DtpDtMatricula.Location = new System.Drawing.Point(751, 464);
            this.DtpDtMatricula.Name = "DtpDtMatricula";
            this.DtpDtMatricula.Size = new System.Drawing.Size(448, 31);
            this.DtpDtMatricula.TabIndex = 5;
            // 
            // DtpDtNascimento
            // 
            this.DtpDtNascimento.Location = new System.Drawing.Point(490, 65);
            this.DtpDtNascimento.Name = "DtpDtNascimento";
            this.DtpDtNascimento.Size = new System.Drawing.Size(448, 31);
            this.DtpDtNascimento.TabIndex = 4;
            // 
            // LblId
            // 
            this.LblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblId.Location = new System.Drawing.Point(19, 65);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(116, 31);
            this.LblId.TabIndex = 3;
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matrícula:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(146, 65);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(321, 31);
            this.TxtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(1026, 239);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(220, 47);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(1026, 130);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(220, 47);
            this.BtnCadastrar.TabIndex = 11;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.AllowUserToAddRows = false;
            this.DgvUsuarios.AllowUserToDeleteRows = false;
            this.DgvUsuarios.AllowUserToResizeRows = false;
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 292);
            this.DgvUsuarios.MultiSelect = false;
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.ReadOnly = true;
            this.DgvUsuarios.RowHeadersVisible = false;
            this.DgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvUsuarios.Size = new System.Drawing.Size(1233, 344);
            this.DgvUsuarios.TabIndex = 1;
            this.DgvUsuarios.SelectionChanged += new System.EventHandler(this.DgvUsuarios_SelectionChanged);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(1026, 24);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(220, 47);
            this.BtnNovo.TabIndex = 13;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(1026, 77);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(220, 47);
            this.BtnAlterar.TabIndex = 14;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // TelaCadastraAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 648);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.DtpDtMatricula);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TelaCadastraAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.TelaCadastraAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpDtMatricula;
        private System.Windows.Forms.DateTimePicker DtpDtNascimento;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CkbAtivo;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnAlterar;
    }
}