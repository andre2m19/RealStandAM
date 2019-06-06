namespace RealStandAM__
{
    partial class GestaoOficina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoOficina));
            System.Windows.Forms.Label combustivelLabel;
            System.Windows.Forms.Label kmsLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label modeloLabel;
            System.Windows.Forms.Label numeroChassisLabel;
            this.listBoxCLientes = new System.Windows.Forms.ListBox();
            this.listBoxOficina = new System.Windows.Forms.ListBox();
            this.listBoxServico = new System.Windows.Forms.ListBox();
            this.listBoxParcela = new System.Windows.Forms.ListBox();
            this.buttonAddCarro = new System.Windows.Forms.Button();
            this.buttonAddServico = new System.Windows.Forms.Button();
            this.buttonaddParcela = new System.Windows.Forms.Button();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelNif = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.carroOficinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carroOficinaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.carroOficinaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.combustivelTextBox = new System.Windows.Forms.TextBox();
            this.kmsTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.matriculaTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.numeroChassisTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.textBoxDescrever = new System.Windows.Forms.TextBox();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            combustivelLabel = new System.Windows.Forms.Label();
            kmsLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            matriculaLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            numeroChassisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingNavigator)).BeginInit();
            this.carroOficinaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCLientes
            // 
            this.listBoxCLientes.FormattingEnabled = true;
            this.listBoxCLientes.Location = new System.Drawing.Point(21, 63);
            this.listBoxCLientes.Name = "listBoxCLientes";
            this.listBoxCLientes.Size = new System.Drawing.Size(160, 355);
            this.listBoxCLientes.TabIndex = 0;
            this.listBoxCLientes.SelectedIndexChanged += new System.EventHandler(this.listBoxCLientes_SelectedIndexChanged);
            // 
            // listBoxOficina
            // 
            this.listBoxOficina.FormattingEnabled = true;
            this.listBoxOficina.Location = new System.Drawing.Point(219, 66);
            this.listBoxOficina.Name = "listBoxOficina";
            this.listBoxOficina.Size = new System.Drawing.Size(180, 303);
            this.listBoxOficina.TabIndex = 1;
            this.listBoxOficina.SelectedIndexChanged += new System.EventHandler(this.listBoxOficina_SelectedIndexChanged);
            // 
            // listBoxServico
            // 
            this.listBoxServico.FormattingEnabled = true;
            this.listBoxServico.Location = new System.Drawing.Point(426, 66);
            this.listBoxServico.Name = "listBoxServico";
            this.listBoxServico.Size = new System.Drawing.Size(180, 303);
            this.listBoxServico.TabIndex = 2;
            this.listBoxServico.SelectedIndexChanged += new System.EventHandler(this.listBoxServico_SelectedIndexChanged);
            // 
            // listBoxParcela
            // 
            this.listBoxParcela.FormattingEnabled = true;
            this.listBoxParcela.Location = new System.Drawing.Point(634, 66);
            this.listBoxParcela.Name = "listBoxParcela";
            this.listBoxParcela.Size = new System.Drawing.Size(154, 251);
            this.listBoxParcela.TabIndex = 3;
            this.listBoxParcela.SelectedIndexChanged += new System.EventHandler(this.listBoxParcela_SelectedIndexChanged);
            // 
            // buttonAddCarro
            // 
            this.buttonAddCarro.Location = new System.Drawing.Point(219, 395);
            this.buttonAddCarro.Name = "buttonAddCarro";
            this.buttonAddCarro.Size = new System.Drawing.Size(180, 23);
            this.buttonAddCarro.TabIndex = 4;
            this.buttonAddCarro.Text = "Adicionar Carro";
            this.buttonAddCarro.UseVisualStyleBackColor = true;
            this.buttonAddCarro.Click += new System.EventHandler(this.buttonAddCarro_Click);
            // 
            // buttonAddServico
            // 
            this.buttonAddServico.Location = new System.Drawing.Point(426, 429);
            this.buttonAddServico.Name = "buttonAddServico";
            this.buttonAddServico.Size = new System.Drawing.Size(180, 23);
            this.buttonAddServico.TabIndex = 5;
            this.buttonAddServico.Text = "Adicionar Serviço";
            this.buttonAddServico.UseVisualStyleBackColor = true;
            this.buttonAddServico.Click += new System.EventHandler(this.buttonAddServico_Click);
            // 
            // buttonaddParcela
            // 
            this.buttonaddParcela.Location = new System.Drawing.Point(634, 395);
            this.buttonaddParcela.Name = "buttonaddParcela";
            this.buttonaddParcela.Size = new System.Drawing.Size(154, 23);
            this.buttonaddParcela.TabIndex = 6;
            this.buttonaddParcela.Text = "Adicionar Parcela";
            this.buttonaddParcela.UseVisualStyleBackColor = true;
            this.buttonaddParcela.Click += new System.EventHandler(this.buttonaddParcela_Click);
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(301, 13);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(35, 13);
            this.labelCliente.TabIndex = 7;
            this.labelCliente.Text = "label1";
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Location = new System.Drawing.Point(363, 23);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(35, 13);
            this.labelNif.TabIndex = 8;
            this.labelNif.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente ";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(441, 22);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(35, 13);
            this.labelTotal.TabIndex = 10;
            this.labelTotal.Text = "label4";
            // 
            // carroOficinaBindingSource
            // 
            this.carroOficinaBindingSource.DataSource = typeof(RealStandAM__.CarroOficina);
            // 
            // carroOficinaBindingNavigator
            // 
            this.carroOficinaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.carroOficinaBindingNavigator.BindingSource = this.carroOficinaBindingSource;
            this.carroOficinaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.carroOficinaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.carroOficinaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.carroOficinaBindingNavigatorSaveItem});
            this.carroOficinaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.carroOficinaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.carroOficinaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.carroOficinaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.carroOficinaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.carroOficinaBindingNavigator.Name = "carroOficinaBindingNavigator";
            this.carroOficinaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.carroOficinaBindingNavigator.Size = new System.Drawing.Size(1238, 25);
            this.carroOficinaBindingNavigator.TabIndex = 11;
            this.carroOficinaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // carroOficinaBindingNavigatorSaveItem
            // 
            this.carroOficinaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.carroOficinaBindingNavigatorSaveItem.Enabled = false;
            this.carroOficinaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("carroOficinaBindingNavigatorSaveItem.Image")));
            this.carroOficinaBindingNavigatorSaveItem.Name = "carroOficinaBindingNavigatorSaveItem";
            this.carroOficinaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.carroOficinaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // combustivelLabel
            // 
            combustivelLabel.AutoSize = true;
            combustivelLabel.Location = new System.Drawing.Point(205, 458);
            combustivelLabel.Name = "combustivelLabel";
            combustivelLabel.Size = new System.Drawing.Size(67, 13);
            combustivelLabel.TabIndex = 14;
            combustivelLabel.Text = "Combustivel:";
            // 
            // combustivelTextBox
            // 
            this.combustivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Combustivel", true));
            this.combustivelTextBox.Location = new System.Drawing.Point(300, 455);
            this.combustivelTextBox.Name = "combustivelTextBox";
            this.combustivelTextBox.Size = new System.Drawing.Size(100, 20);
            this.combustivelTextBox.TabIndex = 15;
            // 
            // kmsLabel
            // 
            kmsLabel.AutoSize = true;
            kmsLabel.Location = new System.Drawing.Point(205, 510);
            kmsLabel.Name = "kmsLabel";
            kmsLabel.Size = new System.Drawing.Size(30, 13);
            kmsLabel.TabIndex = 18;
            kmsLabel.Text = "Kms:";
            // 
            // kmsTextBox
            // 
            this.kmsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Kms", true));
            this.kmsTextBox.Location = new System.Drawing.Point(300, 507);
            this.kmsTextBox.Name = "kmsTextBox";
            this.kmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.kmsTextBox.TabIndex = 19;
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(205, 536);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(40, 13);
            marcaLabel.TabIndex = 20;
            marcaLabel.Text = "Marca:";
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(300, 533);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(100, 20);
            this.marcaTextBox.TabIndex = 21;
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(205, 562);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 22;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaTextBox
            // 
            this.matriculaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Matricula", true));
            this.matriculaTextBox.Location = new System.Drawing.Point(300, 559);
            this.matriculaTextBox.Name = "matriculaTextBox";
            this.matriculaTextBox.Size = new System.Drawing.Size(100, 20);
            this.matriculaTextBox.TabIndex = 23;
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Location = new System.Drawing.Point(205, 588);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(45, 13);
            modeloLabel.TabIndex = 24;
            modeloLabel.Text = "Modelo:";
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "Modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(300, 585);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 25;
            // 
            // numeroChassisLabel
            // 
            numeroChassisLabel.AutoSize = true;
            numeroChassisLabel.Location = new System.Drawing.Point(205, 614);
            numeroChassisLabel.Name = "numeroChassisLabel";
            numeroChassisLabel.Size = new System.Drawing.Size(86, 13);
            numeroChassisLabel.TabIndex = 26;
            numeroChassisLabel.Text = "Numero Chassis:";
            // 
            // numeroChassisTextBox
            // 
            this.numeroChassisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carroOficinaBindingSource, "NumeroChassis", true));
            this.numeroChassisTextBox.Location = new System.Drawing.Point(300, 611);
            this.numeroChassisTextBox.Name = "numeroChassisTextBox";
            this.numeroChassisTextBox.Size = new System.Drawing.Size(100, 20);
            this.numeroChassisTextBox.TabIndex = 27;
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Location = new System.Drawing.Point(426, 395);
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(180, 21);
            this.comboBoxServico.TabIndex = 28;
            // 
            // textBoxDescrever
            // 
            this.textBoxDescrever.Location = new System.Drawing.Point(665, 324);
            this.textBoxDescrever.Name = "textBoxDescrever";
            this.textBoxDescrever.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescrever.TabIndex = 29;
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(665, 348);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 20);
            this.textBoxValor.TabIndex = 30;
            // 
            // GestaoOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 872);
            this.Controls.Add(this.textBoxValor);
            this.Controls.Add(this.textBoxDescrever);
            this.Controls.Add(this.comboBoxServico);
            this.Controls.Add(combustivelLabel);
            this.Controls.Add(this.combustivelTextBox);
            this.Controls.Add(kmsLabel);
            this.Controls.Add(this.kmsTextBox);
            this.Controls.Add(marcaLabel);
            this.Controls.Add(this.marcaTextBox);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaTextBox);
            this.Controls.Add(modeloLabel);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(numeroChassisLabel);
            this.Controls.Add(this.numeroChassisTextBox);
            this.Controls.Add(this.carroOficinaBindingNavigator);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNif);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.buttonaddParcela);
            this.Controls.Add(this.buttonAddServico);
            this.Controls.Add(this.buttonAddCarro);
            this.Controls.Add(this.listBoxParcela);
            this.Controls.Add(this.listBoxServico);
            this.Controls.Add(this.listBoxOficina);
            this.Controls.Add(this.listBoxCLientes);
            this.Name = "GestaoOficina";
            this.Text = "GestorOficina";
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carroOficinaBindingNavigator)).EndInit();
            this.carroOficinaBindingNavigator.ResumeLayout(false);
            this.carroOficinaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCLientes;
        private System.Windows.Forms.ListBox listBoxOficina;
        private System.Windows.Forms.ListBox listBoxServico;
        private System.Windows.Forms.ListBox listBoxParcela;
        private System.Windows.Forms.Button buttonAddCarro;
        private System.Windows.Forms.Button buttonAddServico;
        private System.Windows.Forms.Button buttonaddParcela;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.BindingSource carroOficinaBindingSource;
        private System.Windows.Forms.BindingNavigator carroOficinaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton carroOficinaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox combustivelTextBox;
        private System.Windows.Forms.TextBox kmsTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.TextBox matriculaTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox numeroChassisTextBox;
        private System.Windows.Forms.ComboBox comboBoxServico;
        private System.Windows.Forms.TextBox textBoxDescrever;
        private System.Windows.Forms.TextBox textBoxValor;
    }
}