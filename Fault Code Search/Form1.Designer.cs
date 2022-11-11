using System.Reflection;
using System.Windows.Forms;

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
        /// 
        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.engineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faultDB = new Fault_Code_Search.FaultDB();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controllersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VersionNUM = new System.Windows.Forms.Label();
            this.manufactureTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.ManufactureTableAdapter();
            this.typeTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.TypeTableAdapter();
            this.engineTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.EngineTableAdapter();
            this.controllersTableAdapter = new Fault_Code_Search.FaultDBTableAdapters.ControllersTableAdapter();
            this.Ned = new System.Windows.Forms.PictureBox();
            this.SearchProgress = new System.Windows.Forms.TableLayoutPanel();
            this.SearchResults = new System.Windows.Forms.DataGridView();
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
            this.CheckUpdate = new System.Windows.Forms.Button();
            this.InitialLoad = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ned)).BeginInit();
            this.SearchProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).BeginInit();
            this.SearchControlBox.SuspendLayout();
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
            // engineBindingSource
            // 
            this.engineBindingSource.DataMember = "Engine";
            this.engineBindingSource.DataSource = this.faultDB;
            // 
            // faultDB
            // 
            this.faultDB.DataSetName = "FaultDB";
            this.faultDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.faultDB;
            // 
            // manufactureBindingSource
            // 
            this.manufactureBindingSource.DataMember = "Manufacture";
            this.manufactureBindingSource.DataSource = this.faultDB;
            // 
            // controllersBindingSource
            // 
            this.controllersBindingSource.DataMember = "Controllers";
            this.controllersBindingSource.DataSource = this.faultDB;
            // 
            // VersionNUM
            // 
            this.VersionNUM.AutoSize = true;
            this.VersionNUM.Location = new System.Drawing.Point(10, 10);
            this.VersionNUM.Name = "VersionNUM";
            this.VersionNUM.Size = new System.Drawing.Size(35, 13);
            this.VersionNUM.TabIndex = 20;
            this.VersionNUM.Text = "label1";
            // 
            // manufactureTableAdapter
            // 
            this.manufactureTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // engineTableAdapter
            // 
            this.engineTableAdapter.ClearBeforeFill = true;
            // 
            // controllersTableAdapter
            // 
            this.controllersTableAdapter.ClearBeforeFill = true;
            // 
            // Ned
            // 
            this.Ned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ned.Image = ((System.Drawing.Image)(resources.GetObject("Ned.Image")));
            this.Ned.Location = new System.Drawing.Point(3, 33);
            this.Ned.Name = "Ned";
            this.Ned.Size = new System.Drawing.Size(1396, 268);
            this.Ned.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ned.TabIndex = 17;
            this.Ned.TabStop = false;
            // 
            // SearchProgress
            // 
            this.SearchProgress.AutoScroll = true;
            this.SearchProgress.ColumnCount = 1;
            this.SearchProgress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchProgress.Controls.Add(this.Ned, 0, 1);
            this.SearchProgress.Controls.Add(this.SearchResults, 0, 3);
            this.SearchProgress.Controls.Add(this.SearchControlBox, 0, 2);
            this.SearchProgress.Controls.Add(this.CheckUpdate, 0, 0);
            this.SearchProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchProgress.Location = new System.Drawing.Point(0, 0);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.RowCount = 4;
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.73599F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.12204F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.83064F));
            this.SearchProgress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.1868F));
            this.SearchProgress.Size = new System.Drawing.Size(1402, 803);
            this.SearchProgress.TabIndex = 17;
            // 
            // SearchResults
            // 
            this.SearchResults.AllowUserToAddRows = false;
            this.SearchResults.AllowUserToDeleteRows = false;
            this.SearchResults.AllowUserToResizeColumns = false;
            this.SearchResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchResults.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SearchResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SearchResults.ColumnHeadersHeight = 35;
            this.SearchResults.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.SearchResults.Location = new System.Drawing.Point(10, 409);
            this.SearchResults.Margin = new System.Windows.Forms.Padding(10);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.ReadOnly = true;
            this.SearchResults.RowTemplate.Height = 42;
            this.SearchResults.RowTemplate.ReadOnly = true;
            this.SearchResults.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchResults.Size = new System.Drawing.Size(1382, 384);
            this.SearchResults.TabIndex = 19;
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
            this.SearchControlBox.Location = new System.Drawing.Point(441, 307);
            this.SearchControlBox.Name = "SearchControlBox";
            this.SearchControlBox.Size = new System.Drawing.Size(519, 89);
            this.SearchControlBox.TabIndex = 16;
            this.SearchControlBox.TabStop = false;
            this.SearchControlBox.Enter += new System.EventHandler(this.SearchControlBox_Enter);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(395, 11);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear ALL";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Searcbutton
            // 
            this.Searcbutton.Location = new System.Drawing.Point(312, 11);
            this.Searcbutton.Name = "Searcbutton";
            this.Searcbutton.Size = new System.Drawing.Size(75, 23);
            this.Searcbutton.TabIndex = 12;
            this.Searcbutton.Text = "Search!";
            this.Searcbutton.UseVisualStyleBackColor = true;
            this.Searcbutton.Click += new System.EventHandler(this.Searcbutton_Click);
            // 
            // FMItextBox
            // 
            this.FMItextBox.Location = new System.Drawing.Point(229, 12);
            this.FMItextBox.Name = "FMItextBox";
            this.FMItextBox.Size = new System.Drawing.Size(75, 20);
            this.FMItextBox.TabIndex = 11;
            this.FMItextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SPNtextBox
            // 
            this.SPNtextBox.Location = new System.Drawing.Point(113, 12);
            this.SPNtextBox.Name = "SPNtextBox";
            this.SPNtextBox.Size = new System.Drawing.Size(75, 20);
            this.SPNtextBox.TabIndex = 10;
            this.SPNtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FMIText
            // 
            this.FMIText.AutoSize = true;
            this.FMIText.Location = new System.Drawing.Point(196, 16);
            this.FMIText.Name = "FMIText";
            this.FMIText.Size = new System.Drawing.Size(25, 13);
            this.FMIText.TabIndex = 9;
            this.FMIText.Text = "FMI";
            // 
            // SPNText
            // 
            this.SPNText.AutoSize = true;
            this.SPNText.Location = new System.Drawing.Point(48, 16);
            this.SPNText.Name = "SPNText";
            this.SPNText.Size = new System.Drawing.Size(57, 13);
            this.SPNText.TabIndex = 8;
            this.SPNText.Text = "Fault/SPN";
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
            this.EngineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EngineBox.FormattingEnabled = true;
            this.EngineBox.Items.AddRange(new object[] {
            "ALL",
            "CAT",
            "Cummins",
            "Cummins/Mercedes",
            "Deutz",
            "Kubota",
            "Mitsubishi",
            "Perkins",
            "Scania",
            "Yanmar"});
            this.EngineBox.Location = new System.Drawing.Point(266, 52);
            this.EngineBox.Name = "EngineBox";
            this.EngineBox.Size = new System.Drawing.Size(121, 21);
            this.EngineBox.TabIndex = 6;
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
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "ALL",
            "Deutz",
            "Dump/Track Truck",
            "Excavator",
            "Forklift",
            "Loader",
            "Trench Roller"});
            this.Type.Location = new System.Drawing.Point(139, 52);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 2;
            // 
            // Manufacture
            // 
            this.Manufacture.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.manufactureBindingSource, "Manufacture", true));
            this.Manufacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Manufacture.FormattingEnabled = true;
            this.Manufacture.Items.AddRange(new object[] {
            "ALL",
            "Bell",
            "Bomag",
            "CAT",
            "Cummins",
            "Deutz",
            "Hyundai"});
            this.Manufacture.Location = new System.Drawing.Point(14, 52);
            this.Manufacture.Name = "Manufacture";
            this.Manufacture.Size = new System.Drawing.Size(121, 21);
            this.Manufacture.TabIndex = 1;
            this.Manufacture.SelectedIndexChanged += new System.EventHandler(this.Manufacture_SelectedIndexChanged);
            // 
            // Controllers
            // 
            this.Controllers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.controllersBindingSource, "Controllers", true));
            this.Controllers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Controllers.FormattingEnabled = true;
            this.Controllers.Items.AddRange(new object[] {
            "ALL",
            "BLM",
            "CCU/OEU",
            "ECM",
            "ECU",
            "EHCU",
            "MCU",
            "MDU",
            "MMU",
            "SSM",
            "TCU"});
            this.Controllers.Location = new System.Drawing.Point(392, 52);
            this.Controllers.Name = "Controllers";
            this.Controllers.Size = new System.Drawing.Size(121, 21);
            this.Controllers.TabIndex = 0;
            // 
            // CheckUpdate
            // 
            this.CheckUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckUpdate.AutoSize = true;
            this.CheckUpdate.Location = new System.Drawing.Point(1290, 3);
            this.CheckUpdate.Name = "CheckUpdate";
            this.CheckUpdate.Size = new System.Drawing.Size(109, 23);
            this.CheckUpdate.TabIndex = 21;
            this.CheckUpdate.Text = "Check For Update";
            this.CheckUpdate.UseVisualStyleBackColor = true;
            this.CheckUpdate.Click += new System.EventHandler(this.CheckUpdate_Click);
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
            this.Controls.Add(this.VersionNUM);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.SearchProgress);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(3840, 2160);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Text = "Fault Code Search";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.engineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controllersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ned)).EndInit();
            this.SearchProgress.ResumeLayout(false);
            this.SearchProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchResults)).EndInit();
            this.SearchControlBox.ResumeLayout(false);
            this.SearchControlBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
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
        private System.Windows.Forms.PictureBox Ned;
        private System.Windows.Forms.TableLayoutPanel SearchProgress;
        private System.Windows.Forms.GroupBox SearchControlBox;
        private System.Windows.Forms.Button Clear;
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
        private System.Windows.Forms.DataGridView SearchResults;
        private System.Windows.Forms.Button CheckUpdate;
        private System.ComponentModel.BackgroundWorker InitialLoad;
    }
}

