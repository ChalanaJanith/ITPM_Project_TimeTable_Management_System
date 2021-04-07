using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ITPM_Project
{
    public partial class Visualizingstatistic : Form
    {

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public Visualizingstatistic()
        {
            InitializeComponent();
        }


        //established the connection
        SqlConnection con = new SqlConnection(@"Data Source = ELECTRA\SQLSERVER; Initial Catalog = LocationDB; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
        String sql;
        SqlDataAdapter da;

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Visualizingstatistic_Load(object sender, EventArgs e)
        {

            LoadProgramme_Std_Group_Chart();
            total_Std_GrpCount();
            LoadSubject_YearChart();

        }

        // Total Subject Count and Chart Part --------------------------------------------------

        private void total_Std_GrpCount()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT count(GenGroupNumber) as grpcount from GenGroupNum_Table";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string grp_count = (string)dr["grpcount"].ToString();
                StudentGroupCount_Label.Text = grp_count;


            }
            con.Close();

        }


        private void LoadProgramme_Std_Group_Chart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select p.ProgrammeName as Programme, count(g.GenGroupNumber) as Grpcount  " +
                "from Programme_Table p, GenGroupNum_Table g where p.id = g.ProgrammeRef group by p.ProgrammeName", con);
            adapt.Fill(ds, "Grpcount");
            Programme_GropCount_Chart.DataSource = ds.Tables["Grpcount"];


            Programme_GropCount_Chart.Series["Programme"].XValueMember = "Programme";
            Programme_GropCount_Chart.Series["Programme"].YValueMembers = "Grpcount";
            Programme_GropCount_Chart.Series["Programme"].ChartType = SeriesChartType.Bar;


            Programme_GropCount_Chart.DataBind();
            con.Close();
        }





        private void LoadSubject_YearChart()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;

            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Year ,COUNT(Code) as subyrcount from Subjects_Table GROUP BY Year", con);
            adapt.Fill(ds, "subyrcount");
            Subject_Year_Chart.DataSource = ds.Tables["subyrcount"];


            Subject_Year_Chart.Series["Academic Year"].XValueMember = "Year";
            Subject_Year_Chart.Series["Academic Year"].YValueMembers = "subyrcount";
            Subject_Year_Chart.Series["Academic Year"].ChartType = SeriesChartType.Bar;


            Subject_Year_Chart.DataBind();
            con.Close();
        }














        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel17_Click(object sender, EventArgs e)
        {

        }
    }
}
