using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Reflection;
using System.Text;
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
            SPNtextBox.Text = "";
            FMItextBox.Text = "";
            Controllers.Text = "ALL";
            EngineBox.Text = "ALL";
            Type.Text = "ALL";
            Manufacture.Text = "ALL";

            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, SearchResults, new object[] { true });

        }

        private void Main_Load(object sender, EventArgs e)
        {
            String Database = @"Data Source = fault.db";

            try

            {
                using (DataTable dt = new DataTable("SearchedCodes"))

                {



                    using (SQLiteConnection cn = new SQLiteConnection(Database))
                    {
                        cn.Open();

                        using (SQLiteConnection destination = new SQLiteConnection("Data Source=:memory:"))
                        {
                            destination.Open();

                            cn.BackupDatabase(destination, "main", "main", -1, null, 0);
                            cn.Close();

                            if (destination.State != ConnectionState.Open)
                            {
                                destination.Close();
                                destination.Open();
                            }
                            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Code", destination);
                            cmd.ExecuteNonQuery();
                            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                            adapter.Fill(dt);
                            SearchResults.DataSource = dt;
                            destination.Close();
                            SearchResults.Columns[0].Width = 100;
                            SearchResults.Columns[1].Width = 100;
                            SearchResults.Columns[2].Width = 100;
                            SearchResults.Columns[3].Width = 100;
                            SearchResults.Columns[4].Width = 100;
                            SearchResults.Columns[5].Width = 100;
                            SearchResults.Columns[6].Width = 725;


                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }





        private void Searcbutton_Click(object sender, EventArgs e)
        {
            String Database = @"Data Source = fault.db";

            if ((SPNtextBox.Text == "")
             && (FMItextBox.Text == "")
             && (Controllers.Text == "ALL")
             && (EngineBox.Text == "ALL")
             && (Type.Text == "ALL")
             && (Manufacture.Text == "ALL"))

            {
                try

                {
                    using (DataTable dt = new DataTable("SearchedCodes"))

                    {



                        using (SQLiteConnection cn = new SQLiteConnection(Database))
                        {
                            cn.Open();

                            using (SQLiteConnection destination = new SQLiteConnection("Data Source=:memory:"))

                            {
                                destination.Open();

                                cn.BackupDatabase(destination, "main", "main", -1, null, 0);
                                cn.Close();

                                if (destination.State != ConnectionState.Open)
                                {
                                    destination.Close();
                                    destination.Open();


                                }
                                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Code", destination);
                                cmd.ExecuteNonQuery();
                                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                                adapter.Fill(dt);
                                SearchResults.DataSource = dt;
                                destination.Close();
                                SearchResults.Columns[0].Width = 100;
                                SearchResults.Columns[1].Width = 100;
                                SearchResults.Columns[2].Width = 100;
                                SearchResults.Columns[3].Width = 100;
                                SearchResults.Columns[4].Width = 100;
                                SearchResults.Columns[5].Width = 100;
                                SearchResults.Columns[6].Width = 725;



                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



                }
            }
            else
            {
                string varSPN = null;
                if (SPNtextBox.Text != "")
                {
                    varSPN = SPNtextBox.Text;
                }
                else
                {
                    varSPN = null;
                }

                string varFMI = null;
                if (FMItextBox.Text != "")
                {
                    varFMI = FMItextBox.Text;
                }
                else
                {
                    varFMI = null;
                }

                string varControllers;
                if (Controllers.Text != "ALL")
                {
                    varControllers = Controllers.Text;
                }
                else
                {
                    varControllers = null;
                }

                string varType;
                if (Type.Text != "ALL")
                {
                    varType = Type.Text;
                }
                else
                {
                    varType = null;
                }

                string varEngine;
                if (EngineBox.Text != "ALL")
                {
                    varEngine = EngineBox.Text;
                }
                else
                {
                    varEngine = null;
                }

                string varManufacture;
                if (Manufacture.Text != "ALL")
                {
                    varManufacture = Manufacture.Text;
                }
                else
                {
                    varManufacture = null;
                }
                try
                {
                    using (DataTable dt = new DataTable("SearchedCodes"))
                    {

                        using (SQLiteConnection cn = new SQLiteConnection(Database))
                        {
                            cn.Open();

                            using (SQLiteConnection destination = new SQLiteConnection("Data Source=:memory:"))

                            {
                                destination.Open();

                                cn.BackupDatabase(destination, "main", "main", -1, null, 0);
                                cn.Close();
                                if (destination.State != ConnectionState.Open)
                                {
                                    destination.Close();
                                    destination.Open();


                                }

                                var parameters = new Dictionary<string, object>();
                                parameters["SPN"] = varSPN;
                                parameters["FMI"] = varFMI;
                                parameters["Controllers"] = varControllers;
                                parameters["Type"] = varType;
                                parameters["Engine"] = varEngine;
                                parameters["Manufacture"] = varManufacture;


                                StringBuilder builder = new StringBuilder("SELECT * FROM Code WHERE 1=1 ");
                                SQLiteCommand cmd = new SQLiteCommand(destination);
                                foreach (var parameter in parameters)
                                {
                                    if (!string.IsNullOrWhiteSpace(parameter.Value?.ToString()))
                                    {
                                        builder.Append(" AND " + parameter.Key + "=@" + parameter.Key);
                                        cmd.Parameters.AddWithValue("@" + parameter.Key, parameter.Value);
                                    }
                                }
                                cmd.CommandText = builder.ToString() + " COLLATE NOCASE";
                                cmd.ExecuteNonQuery();

                                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                                adapter.Fill(dt);
                                SearchResults.DataSource = dt;
                                destination.Close();
                                SearchResults.Columns[0].Width = 100;
                                SearchResults.Columns[1].Width = 100;
                                SearchResults.Columns[2].Width = 100;
                                SearchResults.Columns[3].Width = 100;
                                SearchResults.Columns[4].Width = 100;
                                SearchResults.Columns[5].Width = 100;
                                SearchResults.Columns[6].Width = 725;


                            }
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



                }




            }





        }







        private void Clear_Click(object sender, EventArgs e)
        {

            FMItextBox.Text = null;
            SPNtextBox.Text = null;
            Controllers.Text = "ALL";
            EngineBox.Text = "ALL";
            Type.Text = "ALL";
            Manufacture.Text = "ALL";
            SearchResults.DataSource = null;


        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://github.com/kksimp/NED/releases/latest");
        }



        private void CheckUpdate_Click(object sender, EventArgs e)
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
    }
}