namespace Fault_Code_Search
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.codeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Fault_Code_Search.Database1DataSet();
            this.codeTableAdapter = new Fault_Code_Search.Database1DataSetTableAdapters.CodeTableAdapter();
            this.uniqueControllersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet11 = new Fault_Code_Search.Database1DataSet1();
            this.database1DataSet1 = new Fault_Code_Search.Database1DataSet();
            this.database1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniqueControllersTableAdapter = new Fault_Code_Search.Database1DataSet1TableAdapters.UniqueControllersTableAdapter();
            this.uniqueControllersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new Fault_Code_Search.Database1DataSet2();
            this.uniqueControllersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.uniqueControllersTableAdapter1 = new Fault_Code_Search.Database1DataSet2TableAdapters.UniqueControllersTableAdapter();
            this.uniqueControllersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new Fault_Code_Search.Database1DataSet3();
            this.uniqueControllersTableAdapter2 = new Fault_Code_Search.Database1DataSet3TableAdapters.UniqueControllersTableAdapter();
            this.manufactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet4 = new Fault_Code_Search.Database1DataSet4();
            this.manufactureTableAdapter = new Fault_Code_Search.Database1DataSet4TableAdapters.ManufactureTableAdapter();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet5 = new Fault_Code_Search.Database1DataSet5();
            this.typeTableAdapter = new Fault_Code_Search.Database1DataSet5TableAdapters.TypeTableAdapter();
            this.dataSet1 = new System.Data.DataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchProgress = new System.Windows.Forms.TableLayoutPanel();
            this.SearchControlBox = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Searcbutton = new System.Windows.Forms.Button();
            this.FMItextBox = new System.Windows.Forms.TextBox();
            this.SPNtextBox = new System.Windows.Forms.TextBox();
            this.FMIText = new System.Windows.Forms.Label();
            this.SPNText = new System.Windows.Forms.Label();
            this.EngineText = new System.Windows.Forms.Label();
            this.EngineBox = new System.Windows.Forms.ComboBox();
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codesDataSet = new Fault_Code_Search.CodesDataSet();
            this.TypeText = new System.Windows.Forms.Label();
            this.ManufactureText = new System.Windows.Forms.Label();
            this.ControllerText = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Manufacture = new System.Windows.Forms.ComboBox();
            this.Controllers = new System.Windows.Forms.ComboBox();
            this.Ned = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.engineTableAdapter = new Fault_Code_Search.CodesDataSetTableAdapters.EngineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.codeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SearchProgress.SuspendLayout();
            this.SearchControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // codeBindingSource
            // 
            this.codeBindingSource.DataMember = "Code";
            this.codeBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeTableAdapter
            // 
            this.codeTableAdapter.ClearBeforeFill = true;
            // 
            // uniqueControllersBindingSource
            // 
            this.uniqueControllersBindingSource.DataMember = "UniqueControllers";
            this.uniqueControllersBindingSource.DataSource = this.database1DataSet11;
            // 
            // database1DataSet11
            // 
            this.database1DataSet11.DataSetName = "Database1DataSet1";
            this.database1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSet1BindingSource
            // 
            this.database1DataSet1BindingSource.DataSource = this.database1DataSet1;
            this.database1DataSet1BindingSource.Position = 0;
            // 
            // uniqueControllersTableAdapter
            // 
            this.uniqueControllersTableAdapter.ClearBeforeFill = true;
            // 
            // uniqueControllersBindingSource1
            // 
            this.uniqueControllersBindingSource1.DataMember = "UniqueControllers";
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uniqueControllersBindingSource2
            // 
            this.uniqueControllersBindingSource2.DataMember = "UniqueControllers";
            this.uniqueControllersBindingSource2.DataSource = this.database1DataSet2;
            // 
            // uniqueControllersTableAdapter1
            // 
            this.uniqueControllersTableAdapter1.ClearBeforeFill = true;
            // 
            // uniqueControllersBindingSource3
            // 
            this.uniqueControllersBindingSource3.DataMember = "UniqueControllers";
            this.uniqueControllersBindingSource3.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uniqueControllersTableAdapter2
            // 
            this.uniqueControllersTableAdapter2.ClearBeforeFill = true;
            // 
            // manufactureBindingSource
            // 
            this.manufactureBindingSource.DataMember = "Manufacture";
            this.manufactureBindingSource.DataSource = this.database1DataSet4;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufactureTableAdapter
            // 
            this.manufactureTableAdapter.ClearBeforeFill = true;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.database1DataSet5;
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 506);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1402, 0);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // SearchProgress
            // 
            this.SearchProgress.AutoScroll = true;
            this.SearchProgress.ColumnCount = 1;
            this.SearchProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SearchProgress.Controls.Add(this.SearchControlBox, 0, 1);
            this.SearchProgress.Controls.Add(this.Ned, 0, 0);
            this.SearchProgress.Controls.Add(this.progressBar1, 0, 2);
            this.SearchProgress.Controls.Add(this.SearchResults, 0, 3);
            this.SearchProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchProgress.Location = new System.Drawing.Point(0, 0);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.RowCount = 4;
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.9226F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0774F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SearchProgress.Size = new System.Drawing.Size(1402, 803);
            this.SearchProgress.TabIndex = 17;
            this.SearchProgress.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // SearchControlBox
            // 
            this.SearchControlBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchControlBox.AutoSize = true;
            this.SearchControlBox.Controls.Add(this.Clear);
            this.SearchControlBox.Controls.Add(this.Searcbutton);
            this.SearchControlBox.Controls.Add(this.FMItextBox);
            this.SearchControlBox.Controls.Add(this.SPNtextBox);
            this.SearchControlBox.Controls.Add(this.FMIText);
            this.SearchControlBox.Controls.Add(this.SPNText);
            this.SearchControlBox.Controls.Add(this.EngineText);
            this.SearchControlBox.Controls.Add(this.EngineBox);
            this.SearchControlBox.Controls.Add(this.TypeText);
            this.SearchControlBox.Controls.Add(this.ManufactureText);
            this.SearchControlBox.Controls.Add(this.ControllerText);
            this.SearchControlBox.Controls.Add(this.Type);
            this.SearchControlBox.Controls.Add(this.Manufacture);
            this.SearchControlBox.Controls.Add(this.Controllers);
            this.SearchControlBox.Location = new System.Drawing.Point(441, 245);
            this.SearchControlBox.Name = "SearchControlBox";
            this.SearchControlBox.Size = new System.Drawing.Size(519, 75);
            this.SearchControlBox.TabIndex = 16;
            this.SearchControlBox.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(380, 11);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear ALL";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Searcbutton
            // 
            this.Searcbutton.Location = new System.Drawing.Point(299, 11);
            this.Searcbutton.Name = "Searcbutton";
            this.Searcbutton.Size = new System.Drawing.Size(75, 23);
            this.Searcbutton.TabIndex = 12;
            this.Searcbutton.Text = "Search!";
            this.Searcbutton.UseVisualStyleBackColor = true;
            this.Searcbutton.Click += new System.EventHandler(this.Searcbutton_Click);
            // 
            // FMItextBox
            // 
            this.FMItextBox.Location = new System.Drawing.Point(218, 12);
            this.FMItextBox.Name = "FMItextBox";
            this.FMItextBox.Size = new System.Drawing.Size(75, 20);
            this.FMItextBox.TabIndex = 11;
            this.FMItextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SPNtextBox
            // 
            this.SPNtextBox.Location = new System.Drawing.Point(106, 12);
            this.SPNtextBox.Name = "SPNtextBox";
            this.SPNtextBox.Size = new System.Drawing.Size(75, 20);
            this.SPNtextBox.TabIndex = 10;
            this.SPNtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SPNtextBox.TextChanged += new System.EventHandler(this.SPNtextBox_TextChanged);
            // 
            // FMIText
            // 
            this.FMIText.AutoSize = true;
            this.FMIText.Location = new System.Drawing.Point(187, 16);
            this.FMIText.Name = "FMIText";
            this.FMIText.Size = new System.Drawing.Size(25, 13);
            this.FMIText.TabIndex = 9;
            this.FMIText.Text = "FMI";
            // 
            // SPNText
            // 
            this.SPNText.AutoSize = true;
            this.SPNText.Location = new System.Drawing.Point(71, 16);
            this.SPNText.Name = "SPNText";
            this.SPNText.Size = new System.Drawing.Size(29, 13);
            this.SPNText.TabIndex = 8;
            this.SPNText.Text = "SPN";
            // 
            // EngineText
            // 
            this.EngineText.AutoSize = true;
            this.EngineText.Location = new System.Drawing.Point(306, 36);
            this.EngineText.Name = "EngineText";
            this.EngineText.Size = new System.Drawing.Size(40, 13);
            this.EngineText.TabIndex = 7;
            this.EngineText.Text = "Engine";
            // 
            // EngineBox
            // 
            this.EngineBox.DataSource = this.engineBindingSource;
            this.EngineBox.DisplayMember = "Engine";
            this.EngineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineBox.FormattingEnabled = true;
            this.EngineBox.Location = new System.Drawing.Point(266, 52);
            this.EngineBox.Name = "EngineBox";
            this.EngineBox.Size = new System.Drawing.Size(121, 21);
            this.EngineBox.TabIndex = 6;
            this.EngineBox.ValueMember = "Engine";
            // 
            // engineBindingSource
            // 
            this.engineBindingSource.DataMember = "Engine";
            this.engineBindingSource.DataSource = this.codesDataSet;
            // 
            // codesDataSet
            // 
            this.codesDataSet.DataSetName = "CodesDataSet";
            this.codesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TypeText
            // 
            this.TypeText.AutoSize = true;
            this.TypeText.Location = new System.Drawing.Point(162, 36);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(75, 13);
            this.TypeText.TabIndex = 5;
            this.TypeText.Text = "Machine Type";
            // 
            // ManufactureText
            // 
            this.ManufactureText.AutoSize = true;
            this.ManufactureText.Location = new System.Drawing.Point(41, 36);
            this.ManufactureText.Name = "ManufactureText";
            this.ManufactureText.Size = new System.Drawing.Size(67, 13);
            this.ManufactureText.TabIndex = 4;
            this.ManufactureText.Text = "Manufacture";
            // 
            // ControllerText
            // 
            this.ControllerText.AutoSize = true;
            this.ControllerText.Location = new System.Drawing.Point(427, 36);
            this.ControllerText.Name = "ControllerText";
            this.ControllerText.Size = new System.Drawing.Size(51, 13);
            this.ControllerText.TabIndex = 3;
            this.ControllerText.Text = "Controller";
            // 
            // Type
            // 
            this.Type.DataSource = this.typeBindingSource;
            this.Type.DisplayMember = "Type";
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(139, 52);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 2;
            this.Type.ValueMember = "Type";
            // 
            // Manufacture
            // 
            this.Manufacture.DataSource = this.manufactureBindingSource;
            this.Manufacture.DisplayMember = "Manufacture";
            this.Manufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manufacture.FormattingEnabled = true;
            this.Manufacture.Location = new System.Drawing.Point(14, 52);
            this.Manufacture.Name = "Manufacture";
            this.Manufacture.Size = new System.Drawing.Size(121, 21);
            this.Manufacture.TabIndex = 1;
            this.Manufacture.ValueMember = "Manufacture";
            // 
            // Controllers
            // 
            this.Controllers.DataSource = this.uniqueControllersBindingSource3;
            this.Controllers.DisplayMember = "Controllers";
            this.Controllers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controllers.FormattingEnabled = true;
            this.Controllers.Location = new System.Drawing.Point(392, 52);
            this.Controllers.Name = "Controllers";
            this.Controllers.Size = new System.Drawing.Size(121, 21);
            this.Controllers.TabIndex = 0;
            this.Controllers.ValueMember = "Controllers";
            this.Controllers.SelectedIndexChanged += new System.EventHandler(this.Controllers_SelectedIndexChanged);
            // 
            // Ned
            // 
            this.Ned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ned.Image = ((System.Drawing.Image)(resources.GetObject("Ned.Image")));
            this.Ned.Location = new System.Drawing.Point(3, 3);
            this.Ned.Name = "Ned";
            this.Ned.Size = new System.Drawing.Size(1396, 236);
            this.Ned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ned.TabIndex = 17;
            this.Ned.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 326);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1396, 4);
            this.progressBar1.TabIndex = 18;
            // 
            // SearchResults
            // 
            this.SearchResults.AllowUserToAddRows = false;
            this.SearchResults.AllowUserToDeleteRows = false;
            this.SearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SearchResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchResults.Location = new System.Drawing.Point(3, 336);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.ReadOnly = true;
            this.SearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.SearchResults.Size = new System.Drawing.Size(1396, 464);
            this.SearchResults.TabIndex = 19;
            this.SearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResults_CellContentClick);
            // 
            // engineTableAdapter
            // 
            this.engineTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AcceptButton = this.Searcbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1402, 803);
            this.Controls.Add(this.SearchProgress);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "Fault Code Search";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniqueControllersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.SearchProgress.ResumeLayout(false);
            this.SearchProgress.PerformLayout();
            this.SearchControlBox.ResumeLayout(false);
            this.SearchControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource codeBindingSource;
        private Database1DataSetTableAdapters.CodeTableAdapter codeTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSet1BindingSource;
        private Database1DataSet database1DataSet1;
        private Database1DataSet1 database1DataSet11;
        private System.Windows.Forms.BindingSource uniqueControllersBindingSource;
        private Database1DataSet1TableAdapters.UniqueControllersTableAdapter uniqueControllersTableAdapter;
      
        private System.Windows.Forms.BindingSource uniqueControllersBindingSource1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource uniqueControllersBindingSource2;
        private Database1DataSet2TableAdapters.UniqueControllersTableAdapter uniqueControllersTableAdapter1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource uniqueControllersBindingSource3;
        private Database1DataSet3TableAdapters.UniqueControllersTableAdapter uniqueControllersTableAdapter2;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource manufactureBindingSource;
        private Database1DataSet4TableAdapters.ManufactureTableAdapter manufactureTableAdapter;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private Database1DataSet5TableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel SearchProgress;
        private System.Windows.Forms.GroupBox SearchControlBox;
        private System.Windows.Forms.Button Searcbutton;
        private System.Windows.Forms.TextBox FMItextBox;
        private System.Windows.Forms.TextBox SPNtextBox;
        private System.Windows.Forms.Label FMIText;
        private System.Windows.Forms.Label SPNText;
        private System.Windows.Forms.Label EngineText;
        private System.Windows.Forms.ComboBox EngineBox;
        private System.Windows.Forms.Label TypeText;
        private System.Windows.Forms.Label ManufactureText;
        private System.Windows.Forms.Label ControllerText;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.ComboBox Manufacture;
        private System.Windows.Forms.ComboBox Controllers;
        private System.Windows.Forms.PictureBox Ned;
        private System.Windows.Forms.ProgressBar progressBar1;
        private CodesDataSet codesDataSet;
        private System.Windows.Forms.BindingSource engineBindingSource;
        private CodesDataSetTableAdapters.EngineTableAdapter engineTableAdapter;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView SearchResults;
    }
}

