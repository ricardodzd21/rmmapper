namespace BemMapperApp
{
	partial class frmPrincipal
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
			this.components = new System.ComponentModel.Container();
			this.cbTabelas = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtServidor = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dgTabela = new System.Windows.Forms.DataGridView();
			this.btnConectar = new System.Windows.Forms.Button();
			this.txtCatalogo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnGerar = new System.Windows.Forms.Button();
			this.txtNomeDominio = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNameSpace = new System.Windows.Forms.TextBox();
			this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDominioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeDtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipoDominioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colunaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colunaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cbTabelas
			// 
			this.cbTabelas.DisplayMember = "Nome";
			this.cbTabelas.FormattingEnabled = true;
			this.cbTabelas.Location = new System.Drawing.Point(21, 79);
			this.cbTabelas.Name = "cbTabelas";
			this.cbTabelas.Size = new System.Drawing.Size(879, 21);
			this.cbTabelas.TabIndex = 5;
			this.cbTabelas.ValueMember = "Nome";
			this.cbTabelas.SelectedIndexChanged += new System.EventHandler(this.cbTabelas_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Servidor";
			// 
			// txtServidor
			// 
			this.txtServidor.Location = new System.Drawing.Point(21, 30);
			this.txtServidor.Name = "txtServidor";
			this.txtServidor.Size = new System.Drawing.Size(188, 20);
			this.txtServidor.TabIndex = 0;
			this.txtServidor.Text = "10.90.7.11";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(215, 30);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(206, 20);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.Text = "sis_dbc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(212, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Usuário";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(427, 30);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(187, 20);
			this.txtSenha.TabIndex = 2;
			this.txtSenha.Text = "BemPromotora@199$";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(424, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Senha";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 63);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tabela";
			// 
			// dgTabela
			// 
			this.dgTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgTabela.AutoGenerateColumns = false;
			this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.nuloDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.nomeDominioDataGridViewTextBoxColumn,
            this.nomeDtoDataGridViewTextBoxColumn,
            this.tipoDominioDataGridViewTextBoxColumn});
			this.dgTabela.DataSource = this.colunaBindingSource;
			this.dgTabela.Location = new System.Drawing.Point(21, 121);
			this.dgTabela.Name = "dgTabela";
			this.dgTabela.Size = new System.Drawing.Size(879, 273);
			this.dgTabela.TabIndex = 8;
			// 
			// btnConectar
			// 
			this.btnConectar.Location = new System.Drawing.Point(825, 28);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(75, 23);
			this.btnConectar.TabIndex = 4;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// txtCatalogo
			// 
			this.txtCatalogo.Location = new System.Drawing.Point(620, 30);
			this.txtCatalogo.Name = "txtCatalogo";
			this.txtCatalogo.Size = new System.Drawing.Size(187, 20);
			this.txtCatalogo.TabIndex = 3;
			this.txtCatalogo.Text = "DB_TIPIFICACAO";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(617, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Catalogo";
			// 
			// btnGerar
			// 
			this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGerar.Location = new System.Drawing.Point(825, 428);
			this.btnGerar.Name = "btnGerar";
			this.btnGerar.Size = new System.Drawing.Size(75, 23);
			this.btnGerar.TabIndex = 8;
			this.btnGerar.Text = "Gerar";
			this.btnGerar.UseVisualStyleBackColor = true;
			this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
			// 
			// txtNomeDominio
			// 
			this.txtNomeDominio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtNomeDominio.Location = new System.Drawing.Point(302, 430);
			this.txtNomeDominio.Name = "txtNomeDominio";
			this.txtNomeDominio.Size = new System.Drawing.Size(268, 20);
			this.txtNomeDominio.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(302, 413);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Nome Dominio";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 413);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(69, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Name Space";
			// 
			// txtNameSpace
			// 
			this.txtNameSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtNameSpace.Location = new System.Drawing.Point(21, 430);
			this.txtNameSpace.Name = "txtNameSpace";
			this.txtNameSpace.Size = new System.Drawing.Size(268, 20);
			this.txtNameSpace.TabIndex = 6;
			// 
			// nomeDataGridViewTextBoxColumn
			// 
			this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
			this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
			this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
			this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tipoDataGridViewTextBoxColumn
			// 
			this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
			this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
			this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
			this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nuloDataGridViewTextBoxColumn
			// 
			this.nuloDataGridViewTextBoxColumn.DataPropertyName = "Nulo";
			this.nuloDataGridViewTextBoxColumn.HeaderText = "Nulo";
			this.nuloDataGridViewTextBoxColumn.Name = "nuloDataGridViewTextBoxColumn";
			this.nuloDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tamanhoDataGridViewTextBoxColumn
			// 
			this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
			this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
			this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
			this.tamanhoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nomeDominioDataGridViewTextBoxColumn
			// 
			this.nomeDominioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeDominioDataGridViewTextBoxColumn.DataPropertyName = "NomeDominio";
			this.nomeDominioDataGridViewTextBoxColumn.HeaderText = "NomeDominio";
			this.nomeDominioDataGridViewTextBoxColumn.Name = "nomeDominioDataGridViewTextBoxColumn";
			// 
			// nomeDtoDataGridViewTextBoxColumn
			// 
			this.nomeDtoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.nomeDtoDataGridViewTextBoxColumn.DataPropertyName = "NomeDto";
			this.nomeDtoDataGridViewTextBoxColumn.HeaderText = "NomeDto";
			this.nomeDtoDataGridViewTextBoxColumn.Name = "nomeDtoDataGridViewTextBoxColumn";
			this.nomeDtoDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tipoDominioDataGridViewTextBoxColumn
			// 
			this.tipoDominioDataGridViewTextBoxColumn.DataPropertyName = "TipoDominio";
			this.tipoDominioDataGridViewTextBoxColumn.HeaderText = "TipoDominio";
			this.tipoDominioDataGridViewTextBoxColumn.Name = "tipoDominioDataGridViewTextBoxColumn";
			this.tipoDominioDataGridViewTextBoxColumn.ReadOnly = true;
			this.tipoDominioDataGridViewTextBoxColumn.Width = 141;
			// 
			// colunaBindingSource
			// 
			this.colunaBindingSource.DataSource = typeof(RMMapperApp.Dominio.Coluna);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(926, 465);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtNameSpace);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtNomeDominio);
			this.Controls.Add(this.btnGerar);
			this.Controls.Add(this.txtCatalogo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnConectar);
			this.Controls.Add(this.dgTabela);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtServidor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbTabelas);
			this.Name = "frmPrincipal";
			this.Text = "Mapper";
			((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colunaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbTabelas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtServidor;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgTabela;
		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.TextBox txtCatalogo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnGerar;
		private System.Windows.Forms.TextBox txtNomeDominio;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNameSpace;
		private System.Windows.Forms.BindingSource colunaBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nuloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDominioDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeDtoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipoDominioDataGridViewTextBoxColumn;
	}
}

