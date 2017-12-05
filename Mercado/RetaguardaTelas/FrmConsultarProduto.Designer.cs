namespace RetaguardaTelas
{
    partial class FrmConsultarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarProduto));
            this.dataGridViewConsultaProduto = new System.Windows.Forms.DataGridView();
            this.txtCodigoDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.cadprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoCompletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdEmbalagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDsectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custoVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDfamiliaProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMercadoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSetorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSituacao = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterarLote = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadprodutoBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewConsultaProduto
            // 
            this.dataGridViewConsultaProduto.AllowUserToAddRows = false;
            this.dataGridViewConsultaProduto.AllowUserToDeleteRows = false;
            this.dataGridViewConsultaProduto.AutoGenerateColumns = false;
            this.dataGridViewConsultaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codigoBarraDataGridViewTextBoxColumn,
            this.descricaoCompletaDataGridViewTextBoxColumn,
            this.qtdEmbalagemDataGridViewTextBoxColumn,
            this.iDsectorDataGridViewTextBoxColumn,
            this.custoVendaDataGridViewTextBoxColumn,
            this.iDfamiliaProdutoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.tipoMercadoriaDataGridViewTextBoxColumn,
            this.tipoSetorDataGridViewTextBoxColumn,
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn});
            this.dataGridViewConsultaProduto.DataSource = this.cadprodutoBindingSource;
            this.dataGridViewConsultaProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewConsultaProduto.Location = new System.Drawing.Point(0, 106);
            this.dataGridViewConsultaProduto.Name = "dataGridViewConsultaProduto";
            this.dataGridViewConsultaProduto.ReadOnly = true;
            this.dataGridViewConsultaProduto.Size = new System.Drawing.Size(1163, 378);
            this.dataGridViewConsultaProduto.TabIndex = 0;
            // 
            // txtCodigoDescricao
            // 
            this.txtCodigoDescricao.Location = new System.Drawing.Point(172, 47);
            this.txtCodigoDescricao.Name = "txtCodigoDescricao";
            this.txtCodigoDescricao.Size = new System.Drawing.Size(300, 20);
            this.txtCodigoDescricao.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo/Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "data Fim:";
            // 
            // dateTimePickerDataInicial
            // 
            this.dateTimePickerDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataInicial.Location = new System.Drawing.Point(578, 47);
            this.dateTimePickerDataInicial.Name = "dateTimePickerDataInicial";
            this.dateTimePickerDataInicial.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataInicial.TabIndex = 9;
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(738, 47);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerDataFinal.TabIndex = 10;
            // 
            // cadprodutoBindingSource
            // 
            this.cadprodutoBindingSource.DataSource = typeof(CamadaDados.Cadproduto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idDataGridViewTextBoxColumn.HeaderText = "Code";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // codigoBarraDataGridViewTextBoxColumn
            // 
            this.codigoBarraDataGridViewTextBoxColumn.DataPropertyName = "codigoBarra";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigoBarraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigoBarraDataGridViewTextBoxColumn.HeaderText = "Codigo Barra";
            this.codigoBarraDataGridViewTextBoxColumn.Name = "codigoBarraDataGridViewTextBoxColumn";
            this.codigoBarraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoCompletaDataGridViewTextBoxColumn
            // 
            this.descricaoCompletaDataGridViewTextBoxColumn.DataPropertyName = "descricaoCompleta";
            this.descricaoCompletaDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoCompletaDataGridViewTextBoxColumn.Name = "descricaoCompletaDataGridViewTextBoxColumn";
            this.descricaoCompletaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoCompletaDataGridViewTextBoxColumn.Width = 200;
            // 
            // qtdEmbalagemDataGridViewTextBoxColumn
            // 
            this.qtdEmbalagemDataGridViewTextBoxColumn.DataPropertyName = "qtdEmbalagem";
            this.qtdEmbalagemDataGridViewTextBoxColumn.HeaderText = "Qnt.Embalagem";
            this.qtdEmbalagemDataGridViewTextBoxColumn.Name = "qtdEmbalagemDataGridViewTextBoxColumn";
            this.qtdEmbalagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDsectorDataGridViewTextBoxColumn
            // 
            this.iDsectorDataGridViewTextBoxColumn.DataPropertyName = "ID_sector";
            this.iDsectorDataGridViewTextBoxColumn.HeaderText = "ID_sector";
            this.iDsectorDataGridViewTextBoxColumn.Name = "iDsectorDataGridViewTextBoxColumn";
            this.iDsectorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custoVendaDataGridViewTextBoxColumn
            // 
            this.custoVendaDataGridViewTextBoxColumn.DataPropertyName = "custoVenda";
            this.custoVendaDataGridViewTextBoxColumn.HeaderText = "Valor Venda";
            this.custoVendaDataGridViewTextBoxColumn.Name = "custoVendaDataGridViewTextBoxColumn";
            this.custoVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDfamiliaProdutoDataGridViewTextBoxColumn
            // 
            this.iDfamiliaProdutoDataGridViewTextBoxColumn.DataPropertyName = "ID_familiaProduto";
            this.iDfamiliaProdutoDataGridViewTextBoxColumn.HeaderText = "ID_familiaProduto";
            this.iDfamiliaProdutoDataGridViewTextBoxColumn.Name = "iDfamiliaProdutoDataGridViewTextBoxColumn";
            this.iDfamiliaProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "dataCadastro";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataCadastroDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "dataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            this.dataCadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoMercadoriaDataGridViewTextBoxColumn
            // 
            this.tipoMercadoriaDataGridViewTextBoxColumn.DataPropertyName = "tipoMercadoria";
            this.tipoMercadoriaDataGridViewTextBoxColumn.HeaderText = "tipoMercadoria";
            this.tipoMercadoriaDataGridViewTextBoxColumn.Name = "tipoMercadoriaDataGridViewTextBoxColumn";
            this.tipoMercadoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoSetorDataGridViewTextBoxColumn
            // 
            this.tipoSetorDataGridViewTextBoxColumn.DataPropertyName = "tipoSetor";
            this.tipoSetorDataGridViewTextBoxColumn.HeaderText = "tipoSetor";
            this.tipoSetorDataGridViewTextBoxColumn.Name = "tipoSetorDataGridViewTextBoxColumn";
            this.tipoSetorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoUnidadeMedidaDataGridViewTextBoxColumn
            // 
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn.DataPropertyName = "tipoUnidadeMedida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn.HeaderText = "Medida";
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn.Name = "tipoUnidadeMedidaDataGridViewTextBoxColumn";
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoUnidadeMedidaDataGridViewTextBoxColumn.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(907, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Situação:";
            // 
            // comboBoxSituacao
            // 
            this.comboBoxSituacao.FormattingEnabled = true;
            this.comboBoxSituacao.Location = new System.Drawing.Point(961, 46);
            this.comboBoxSituacao.Name = "comboBoxSituacao";
            this.comboBoxSituacao.Size = new System.Drawing.Size(99, 21);
            this.comboBoxSituacao.TabIndex = 12;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEditar,
            this.btnAlterarLote});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1163, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Adicionar Produto";
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Alterar Produto";
            // 
            // btnAlterarLote
            // 
            this.btnAlterarLote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterarLote.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarLote.Image")));
            this.btnAlterarLote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterarLote.Name = "btnAlterarLote";
            this.btnAlterarLote.Size = new System.Drawing.Size(23, 22);
            this.btnAlterarLote.Text = "Alteração em Lote";
            // 
            // FrmConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 484);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.comboBoxSituacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDataFinal);
            this.Controls.Add(this.dateTimePickerDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoDescricao);
            this.Controls.Add(this.dataGridViewConsultaProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadprodutoBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewConsultaProduto;
        private System.Windows.Forms.BindingSource cadprodutoBindingSource;
        private System.Windows.Forms.TextBox txtCodigoDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoCompletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdEmbalagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custoVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfamiliaProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMercadoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSetorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUnidadeMedidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSituacao;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnAlterarLote;
    }
}