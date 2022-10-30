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
            this.TypeText = new System.Windows.Forms.Label();
            this.ManufactureText = new System.Windows.Forms.Label();
            this.ControllerText = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Manufacture = new System.Windows.Forms.ComboBox();
            this.Controllers = new System.Windows.Forms.ComboBox();
            this.Ned = new System.Windows.Forms.PictureBox();
            this.SearchResults = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Version = new System.Windows.Forms.LinkLabel();
            this.VersionNUM = new System.Windows.Forms.Label();
            this.faultDB = new Fault_Code_Search.FaultDB();
            this.manufactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactureTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.ManufactureTableAdapter();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.TypeTableAdapter();
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.engineTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.EngineTableAdapter();
            this.controllersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controllersTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.ControllersTableAdapter();
            this.SearchProgress.SuspendLayout();
            this.SearchControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faultDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllersBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.SearchProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchProgress.Controls.Add(this.SearchControlBox, 0, 1);
            this.SearchProgress.Controls.Add(this.Ned, 0, 0);
            this.SearchProgress.Controls.Add(this.SearchResults, 0, 2);
            this.SearchProgress.Controls.Add(this.toolStripContainer1, 0, 3);
            this.SearchProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchProgress.Location = new System.Drawing.Point(0, 0);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.RowCount = 4;
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.47561F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.52439F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 463F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.SearchControlBox.Location = new System.Drawing.Point(441, 238);
            this.SearchControlBox.Name = "SearchControlBox";
            this.SearchControlBox.Size = new System.Drawing.Size(519, 78);
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
            this.EngineBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.engineBindingSource, "Engine", true));
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
            this.Type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeBindingSource, "Type", true));
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
            this.Manufacture.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manufactureBindingSource, "Manufacture", true));
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
            this.Controllers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.controllersBindingSource, "Controllers", true));
            this.Controllers.DataSource = this.controllersBindingSource;
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
            this.Ned.Size = new System.Drawing.Size(1396, 229);
            this.Ned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ned.TabIndex = 17;
            this.Ned.TabStop = false;
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
            this.SearchResults.Location = new System.Drawing.Point(3, 322);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.ReadOnly = true;
            this.SearchResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.SearchResults.Size = new System.Drawing.Size(1396, 457);
            this.SearchResults.TabIndex = 19;
            this.SearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResults_CellContentClick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1396, 0);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripContainer1.Location = new System.Drawing.Point(3, 785);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1396, 15);
            this.toolStripContainer1.TabIndex = 20;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Version.AutoSize = true;
            this.Version.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Version.LinkColor = System.Drawing.Color.Black;
            this.Version.Location = new System.Drawing.Point(1300, 5);
            this.Version.Name = "Version";
            this.Version.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Version.Size = new System.Drawing.Size(94, 13);
            this.Version.TabIndex = 19;
            this.Version.TabStop = true;
            this.Version.Text = "Check For Update";
            this.Version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Version.VisitedLinkColor = System.Drawing.Color.Black;
            this.Version.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // VersionNUM
            // 
            this.VersionNUM.AutoSize = true;
            this.VersionNUM.Location = new System.Drawing.Point(10, 5);
            this.VersionNUM.Name = "VersionNUM";
            this.VersionNUM.Size = new System.Drawing.Size(35, 13);
            this.VersionNUM.TabIndex = 20;
            this.VersionNUM.Text = "label1";
            this.VersionNUM.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // faultDB
            // 
            this.faultDB.DataSetName = "FaultDB";
            this.faultDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // manufactureBindingSource
            // 
            this.manufactureBindingSource.DataMember = "Manufacture";
            this.manufactureBindingSource.DataSource = this.faultDB;
            // 
            // manufactureTableAdapter
            // 
            this.manufactureTableAdapter.ClearBeforeFill = true;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.faultDB;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // engineBindingSource
            // 
            this.engineBindingSource.DataMember = "Engine";
            this.engineBindingSource.DataSource = this.faultDB;
            // 
            // engineTableAdapter
            // 
            this.engineTableAdapter.ClearBeforeFill = true;
            // 
            // controllersBindingSource
            // 
            this.controllersBindingSource.DataMember = "Controllers";
            this.controllersBindingSource.DataSource = this.faultDB;
            // 
            // controllersTableAdapter
            // 
            this.controllersTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.VersionNUM);
            this.Controls.Add(this.Version);
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
            this.SearchProgress.ResumeLayout(false);
            this.SearchProgress.PerformLayout();
            this.SearchControlBox.ResumeLayout(false);
            this.SearchControlBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faultDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
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
       
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.LinkLabel Version;
        private System.Windows.Forms.Label VersionNUM;
        private FaultDB faultDB;
        private System.Windows.Forms.BindingSource manufactureBindingSource;
        private FaultDBTableAdapters.ManufactureTableAdapter manufactureTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private FaultDBTableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource engineBindingSource;
        private FaultDBTableAdapters.EngineTableAdapter engineTableAdapter;
        private System.Windows.Forms.BindingSource controllersBindingSource;
        private FaultDBTableAdapters.ControllersTableAdapter controllersTableAdapter;
    }
}

