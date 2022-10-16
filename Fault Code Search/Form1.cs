using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Fault_Code_Search
{

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            try
            {
                VersionNUM.Text = "V" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch (Exception)
            {
                VersionNUM.Text = "V" + Assembly.GetExecutingAssembly().GetName().Version;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'codesDataSet.Engine' table. You can move, or remove it, as needed.
            this.engineTableAdapter.Fill(this.codesDataSet.Engine);
            // TODO: This line of code loads data into the 'database1DataSet5.Type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.database1DataSet5.Type);
            // TODO: This line of code loads data into the 'database1DataSet4.Manufacture' table. You can move, or remove it, as needed.
            this.manufactureTableAdapter.Fill(this.database1DataSet4.Manufacture);
            // TODO: This line of code loads data into the 'database1DataSet3.UniqueControllers' table. You can move, or remove it, as needed.
            this.uniqueControllersTableAdapter2.Fill(this.database1DataSet3.UniqueControllers);
            // TODO: This line of code loads data into the 'database1DataSet2.UniqueControllers' table. You can move, or remove it, as needed.
            this.uniqueControllersTableAdapter1.Fill(this.database1DataSet2.UniqueControllers);

        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Controller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fillByControllerToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.codeTableAdapter.FillByController(this.database1DataSet.Code);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByControllerToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.codeTableAdapter.FillByController(this.database1DataSet.Code);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByControllerToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void FMIText_Click(object sender, EventArgs e)
        {

        }

        private void NedPicture_Click(object sender, EventArgs e)
        {

        }

        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Searcbutton_Click(object sender, EventArgs e)
        {

            try
            {

                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Fault_Code_Search.Properties.Settings.Manufactures"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("SearchedCodes"))

                    {
                        string varFMI = null;
                        string varEngine = null;
                        string varControllers = null;
                        string varType = null;
                        string varManufacture = null;

                        if (FMItextBox.Text == "")
                        {
                            varFMI = null;
                        }
                        else
                        {
                            varFMI = " and FMI=@FMI";
                        }

                        if (Controllers.Text == "ALL       ")
                        {
                            varControllers = null;
                        }
                        else
                        {
                            varControllers = " and Controllers=@Controllers";
                        }

                        if (EngineBox.Text == "ALL       ")
                        {
                            varEngine = null;
                        }
                        else
                        {
                            varEngine = " and Engine=@Engine";
                        }

                        if (Type.Text == "ALL")
                        {
                            varType = null;
                        }
                        else
                        {
                            varType = " and Type=@Type";
                        }
                        if (Manufacture.Text == "ALL       ")
                        {
                            varManufacture = null;
                        }
                        else
                        {
                            varManufacture = " and Manufacture=@Manufacture";
                        }

                        using (SqlCommand cmd = new SqlCommand("select *from Code Where SPN=@SPN" + varFMI + varControllers + varType + varEngine + varManufacture, cn))
                        {
                            cmd.Parameters.AddWithValue("SPN", SPNtextBox.Text);
                            cmd.Parameters.AddWithValue("FMI", FMItextBox.Text);
                            if (varFMI != null)
                            {
                                cmd.Parameters.AddWithValue("FMI", FMItextBox.Text);
                            }
                            if (varControllers != null)
                            {
                                cmd.Parameters.AddWithValue("Controllers", Controllers.Text);
                            }
                            if (varType != null)
                            {
                                cmd.Parameters.AddWithValue("Type", Type.Text);
                            }
                            if (varEngine != null)
                            {
                                cmd.Parameters.AddWithValue("Engine", EngineBox.Text);
                            }
                            if (varManufacture != null)
                            {
                                cmd.Parameters.AddWithValue("Manufacture", Manufacture.Text);
                            }
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            SearchResults.DataSource = dt;
                        }

                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


        private void SPNtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodesTetBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

            FMItextBox.Text = null;
            SPNtextBox.Text = null;
            Controllers.Text = "ALL       ";
            EngineBox.Text = "ALL       ";
            Type.Text = "ALL";
            Manufacture.Text = "ALL       ";
            SearchResults.DataSource = null;


        }



        private void Controllers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void SearchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateCheck_Click(object sender, EventArgs e)
        {






        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://github.com/kksimp/NED/releases/latest");
        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }
    }
}