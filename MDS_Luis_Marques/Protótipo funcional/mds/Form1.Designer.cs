namespace mds
{
    partial class Form1
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label bICCLabel;
            System.Windows.Forms.Label dataNascimentoLabel;
            System.Windows.Forms.Label nSNSLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label estCivilLabel;
            System.Windows.Forms.Label contactoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.hospitalDataSet1 = new mds.hospitalDataSet1();
            this.pacienteSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteSetTableAdapter = new mds.hospitalDataSet1TableAdapters.PacienteSetTableAdapter();
            this.tableAdapterManager = new mds.hospitalDataSet1TableAdapters.TableAdapterManager();
            this.pacienteSetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pacienteSetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pacienteSetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.bICCTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimentoTextBox = new System.Windows.Forms.TextBox();
            this.nSNSTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.estCivilTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            nomeLabel = new System.Windows.Forms.Label();
            bICCLabel = new System.Windows.Forms.Label();
            dataNascimentoLabel = new System.Windows.Forms.Label();
            nSNSLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            estCivilLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteSetBindingNavigator)).BeginInit();
            this.pacienteSetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteSetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 352);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 31;
            nomeLabel.Text = "Nome:";
            // 
            // bICCLabel
            // 
            bICCLabel.AutoSize = true;
            bICCLabel.Location = new System.Drawing.Point(218, 352);
            bICCLabel.Name = "bICCLabel";
            bICCLabel.Size = new System.Drawing.Size(34, 13);
            bICCLabel.TabIndex = 33;
            bICCLabel.Text = "BICC:";
            // 
            // dataNascimentoLabel
            // 
            dataNascimentoLabel.AutoSize = true;
            dataNascimentoLabel.Location = new System.Drawing.Point(12, 375);
            dataNascimentoLabel.Name = "dataNascimentoLabel";
            dataNascimentoLabel.Size = new System.Drawing.Size(92, 13);
            dataNascimentoLabel.TabIndex = 35;
            dataNascimentoLabel.Text = "Data Nascimento:";
            // 
            // nSNSLabel
            // 
            nSNSLabel.AutoSize = true;
            nSNSLabel.Location = new System.Drawing.Point(218, 378);
            nSNSLabel.Name = "nSNSLabel";
            nSNSLabel.Size = new System.Drawing.Size(40, 13);
            nSNSLabel.TabIndex = 37;
            nSNSLabel.Text = "NSNS:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(12, 404);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 39;
            moradaLabel.Text = "Morada:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(218, 404);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(27, 13);
            nIFLabel.TabIndex = 41;
            nIFLabel.Text = "NIF:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(428, 352);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 43;
            sexoLabel.Text = "Sexo:";
            // 
            // estCivilLabel
            // 
            estCivilLabel.AutoSize = true;
            estCivilLabel.Location = new System.Drawing.Point(428, 378);
            estCivilLabel.Name = "estCivilLabel";
            estCivilLabel.Size = new System.Drawing.Size(47, 13);
            estCivilLabel.TabIndex = 45;
            estCivilLabel.Text = "Est Civil:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(428, 404);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 47;
            contactoLabel.Text = "Contacto:";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::mds.Properties.Resources.ambulance;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Albert Einstein Hospital";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Secretária";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(642, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            // 
            // hospitalDataSet1
            // 
            this.hospitalDataSet1.DataSetName = "hospitalDataSet1";
            this.hospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteSetBindingSource
            // 
            this.pacienteSetBindingSource.DataMember = "PacienteSet";
            this.pacienteSetBindingSource.DataSource = this.hospitalDataSet1;
            // 
            // pacienteSetTableAdapter
            // 
            this.pacienteSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PacienteSetTableAdapter = this.pacienteSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = mds.hospitalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteSetBindingNavigator
            // 
            this.pacienteSetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteSetBindingNavigator.AutoSize = false;
            this.pacienteSetBindingNavigator.BindingSource = this.pacienteSetBindingSource;
            this.pacienteSetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteSetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteSetBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.pacienteSetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacienteSetBindingNavigatorSaveItem});
            this.pacienteSetBindingNavigator.Location = new System.Drawing.Point(15, 70);
            this.pacienteSetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteSetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteSetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteSetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteSetBindingNavigator.Name = "pacienteSetBindingNavigator";
            this.pacienteSetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteSetBindingNavigator.Size = new System.Drawing.Size(663, 25);
            this.pacienteSetBindingNavigator.TabIndex = 29;
            this.pacienteSetBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pacienteSetBindingNavigatorSaveItem
            // 
            this.pacienteSetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteSetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteSetBindingNavigatorSaveItem.Image")));
            this.pacienteSetBindingNavigatorSaveItem.Name = "pacienteSetBindingNavigatorSaveItem";
            this.pacienteSetBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteSetBindingNavigatorSaveItem.Text = "Save Data";
            this.pacienteSetBindingNavigatorSaveItem.Click += new System.EventHandler(this.pacienteSetBindingNavigatorSaveItem_Click_1);
            // 
            // pacienteSetDataGridView
            // 
            this.pacienteSetDataGridView.AutoGenerateColumns = false;
            this.pacienteSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacienteSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pacienteSetDataGridView.DataSource = this.pacienteSetBindingSource;
            this.pacienteSetDataGridView.Location = new System.Drawing.Point(12, 113);
            this.pacienteSetDataGridView.Name = "pacienteSetDataGridView";
            this.pacienteSetDataGridView.Size = new System.Drawing.Size(672, 220);
            this.pacienteSetDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BICC";
            this.dataGridViewTextBoxColumn3.HeaderText = "BICC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DataNascimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "DataNascimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NSNS";
            this.dataGridViewTextBoxColumn5.HeaderText = "NSNS";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Morada";
            this.dataGridViewTextBoxColumn6.HeaderText = "Morada";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NIF";
            this.dataGridViewTextBoxColumn7.HeaderText = "NIF";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EstCivil";
            this.dataGridViewTextBoxColumn9.HeaderText = "EstCivil";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn10.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(110, 349);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 32;
            // 
            // bICCTextBox
            // 
            this.bICCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "BICC", true));
            this.bICCTextBox.Location = new System.Drawing.Point(316, 349);
            this.bICCTextBox.Name = "bICCTextBox";
            this.bICCTextBox.Size = new System.Drawing.Size(100, 20);
            this.bICCTextBox.TabIndex = 34;
            // 
            // dataNascimentoTextBox
            // 
            this.dataNascimentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "DataNascimento", true));
            this.dataNascimentoTextBox.Location = new System.Drawing.Point(110, 375);
            this.dataNascimentoTextBox.Name = "dataNascimentoTextBox";
            this.dataNascimentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.dataNascimentoTextBox.TabIndex = 36;
            // 
            // nSNSTextBox
            // 
            this.nSNSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "NSNS", true));
            this.nSNSTextBox.Location = new System.Drawing.Point(316, 375);
            this.nSNSTextBox.Name = "nSNSTextBox";
            this.nSNSTextBox.Size = new System.Drawing.Size(100, 20);
            this.nSNSTextBox.TabIndex = 38;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(110, 401);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moradaTextBox.TabIndex = 40;
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "NIF", true));
            this.nIFTextBox.Location = new System.Drawing.Point(316, 401);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(100, 20);
            this.nIFTextBox.TabIndex = 42;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(526, 349);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sexoTextBox.TabIndex = 44;
            // 
            // estCivilTextBox
            // 
            this.estCivilTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "EstCivil", true));
            this.estCivilTextBox.Location = new System.Drawing.Point(526, 375);
            this.estCivilTextBox.Name = "estCivilTextBox";
            this.estCivilTextBox.Size = new System.Drawing.Size(100, 20);
            this.estCivilTextBox.TabIndex = 46;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteSetBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(526, 404);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 48;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(609, 444);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 53;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "Registar Consulta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 476);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pacienteSetBindingNavigator);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(bICCLabel);
            this.Controls.Add(this.bICCTextBox);
            this.Controls.Add(dataNascimentoLabel);
            this.Controls.Add(this.dataNascimentoTextBox);
            this.Controls.Add(nSNSLabel);
            this.Controls.Add(this.nSNSTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nIFLabel);
            this.Controls.Add(this.nIFTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(estCivilLabel);
            this.Controls.Add(this.estCivilTextBox);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(this.pacienteSetDataGridView);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Procurar Paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteSetBindingNavigator)).EndInit();
            this.pacienteSetBindingNavigator.ResumeLayout(false);
            this.pacienteSetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteSetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private hospitalDataSet1 hospitalDataSet1;
        private System.Windows.Forms.BindingSource pacienteSetBindingSource;
        private hospitalDataSet1TableAdapters.PacienteSetTableAdapter pacienteSetTableAdapter;
        private hospitalDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteSetBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacienteSetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pacienteSetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox bICCTextBox;
        private System.Windows.Forms.TextBox dataNascimentoTextBox;
        private System.Windows.Forms.TextBox nSNSTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox estCivilTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
    }
}

