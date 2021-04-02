﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ITPM_Project.Properties;

namespace ITPM_Project
{
    public partial class AddandManageLocations : Form
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


        public AddandManageLocations()
        {
            InitializeComponent();
            RoomAutono();
            editroom_cmb_DropDown();


        }

        //established the connection
        SqlConnection con = new SqlConnection(@"Data Source = ELECTRA\SQLSERVER; Initial Catalog = LocationDB; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
        String sql;
        SqlDataAdapter da;
        //String buildingID;
        String roomID;


        //create Auto increment number for building table............

        public void RoomAutono()
        {

            sql = "select Room_ID from RoomTable order by Room_ID desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                roomID = id.ToString("0001");

            }
            else if(Convert.IsDBNull(dr))
            {
                roomID = ("0001");
            }
            else
            {
                roomID = ("0001");
            }

            Room_ID_textbox.Text = roomID.ToString();
            con.Close();


        }


        //create auto-increment number for room table...................

        private void AddandManageLocations_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Save_Location_Button_Click(object sender, EventArgs e)
        {

            String addbuild = Building_Combo_Box.SelectedItem.ToString();
            String addroom = Room_Combo_Box.SelectedItem.ToString();
            String addroomty = AddRoomType_cmb.SelectedItem.ToString();
            String addcapacity = AddCapacity_cmb.Text;


            if((Building_Combo_Box.SelectedItem.ToString() != string.Empty) && (Room_Combo_Box.SelectedItem.ToString() != string.Empty) && (AddRoomType_cmb.SelectedItem.ToString() != string.Empty) 
                && (AddCapacity_cmb.Text != string.Empty) )

            {
                sql = "insert into LocationTable (BuildingName,RoomName,RoomType,Capacity)values(@addbuild,@addroom,@addroomty,@addcapacity)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@addbuild", addbuild);
                cmd.Parameters.AddWithValue("@addroom", addroom);
                cmd.Parameters.AddWithValue("@addroomty", addroomty);
                cmd.Parameters.AddWithValue("@addcapacity", addcapacity);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added");
                con.Close();
            }


        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Insert Building Name to the Building Table.....

        private void SaveBuilding_Name_Click(object sender, EventArgs e)
        {


          String addbuildingname = Add_Building_Name.Text;
            

            if ((Add_Building_Name.Text != string.Empty))
            {
                sql = "insert into BuildingsNameTable (Buildingnames)values(@addbuildingname)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@addbuildingname", addbuildingname);
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Building successfuly Added!");
                con.Close();

            }

        }


        //Insert operation to Add Room for Room table.................

        private void SaveRoom_Name_Click(object sender, EventArgs e)
        {

            String addroomname = Room_NametextBox.Text;
            String addroomid = Room_ID_textbox.Text;
            String addBuildName= BuildingNameComboBox.Text;
            

            if ((Room_NametextBox.Text != string.Empty) &&(BuildingNameComboBox.Text != string.Empty))
            {
                sql = "insert into RoomTable (Room_ID,Room_Name,BuildingName)values(@addroomid,@addroomname,@addBuildName)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@addroomname", addroomname);
                cmd.Parameters.AddWithValue("@addroomid", addroomid);
                cmd.Parameters.AddWithValue("@addBuildName", addBuildName);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Room successfuly Added!");
                con.Close();

            }

        }

        private void BuildingNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        public void cmbdisp()
        {
            /*  con.Open();
               sql = "SELECT Buildingnames FROM BuildingsNameTable";
               SqlCommand cmd = new SqlCommand(sql, con);
               SqlDataReader dr = cmd.ExecuteReader();
               DataTable dt = new DataTable();
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               da.Fill(dt);*/

            /*   BuildingNameComboBox.Items.Clear();
               con.Open();
               SqlCommand cmd = con.CreateCommand();
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "SELECT Buildingnames FROM BuildingsNameTable";
               cmd.ExecuteNonQuery();
               DataTable dt = new DataTable();
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               da.Fill(dt); 


               /*  while (dr.Read())
                 {
                BuildingNameComboBox.Items.Add(dr["Buildingnames"]. ToString());
                BuildingNameComboBox.DisplayMember = (dr["Buildingnames"].ToString());
                BuildingNameComboBox.ValueMember = (dr["Buildingnames"].ToString());
                } */

            /*foreach (DataRow dr in dt.Rows)
            {
                BuildingNameComboBox.Items.Add(dr["Buildingnames"].ToString());
            }

            con.Close();*/

          BuildingNameComboBox.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Buildingnames FROM BuildingsNameTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                BuildingNameComboBox.Items.Add(dr["Buildingnames"].ToString());
            }

            con.Close(); 
        }


        public void Select_Building_ComboBox()
        {


            Building_Combo_Box.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT BuildingName FROM RoomTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                Building_Combo_Box.Items.Add(dr["BuildingName"].ToString());
            }

            con.Close(); 

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {
           cmbdisp();
           Select_Building_ComboBox();
            LoadLocations();

        }

        private void Refresh_Combo_Box_Click(object sender, EventArgs e)
        {
            sql = "select * from BuildingsNameTable";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            BuildingNameComboBox.Items.Clear();

            while (dr.Read())
            {
                BuildingNameComboBox.Items.Add(dr[0]);

            }

            con.Close();
        }



        private void Building_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Refresh_Select_Building_Combo_Click(object sender, EventArgs e)
        {
            sql = "select DISTINCT BuildingName from RoomTable";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            Building_Combo_Box.Items.Clear();

            while (dr.Read())
            {
                Building_Combo_Box.Items.Add(dr[0]);

            }

            con.Close();
        }

        private void Room_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Refresh_Room_Btn_Click(object sender, EventArgs e)
        {
            sql = "SELECT DISTINCT Room_Name from RoomTable where BuildingName ='" + Building_Combo_Box.Text + "'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            Room_Combo_Box.Items.Clear();

            while (dr.Read())
            {
                Room_Combo_Box.Items.Add(dr[0]);

            }

            con.Close();
        }

        private void Location_Grid_View_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from LocationTable", con);
            DataTable dt = new DataTable();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);


            Location_Grid_View_Table.AutoGenerateColumns = true;
            Location_Grid_View_Table.DataSource = dt;
            con.Close();


        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }


        private void LoadLocations()
        {
            /*con.Open();
            SqlCommand cmd = new SqlCommand("Select * from LocationTable", con);
            DataTable dt = new DataTable();



            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);


            Location_Grid_View_Table.AutoGenerateColumns = true;
            Location_Grid_View_Table.DataSource = dt;
            con.Close();*/
        }


        private void Load_Location_Page_Click(object sender, EventArgs e)
        {

            LoadLocations();

        }



        //Edit Locations...................

        private void editroom_cmb_DropDown()
        {
            editRoomcombo_box.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT RoomName FROM LocationTable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


            foreach (DataRow dr in dt.Rows)
            {
                editRoomcombo_box.Items.Add(dr["RoomName"].ToString());
            }

            con.Close();


        }
        private void editRoomcombo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM LocationTable WHERE RoomName = '" + editRoomcombo_box.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string r_building = (string)dr["BuildingName"].ToString();
                editBuilding_name_text_Box.Text = r_building;
                //editbuil_cmb.Text= r_building;

                string r_capacity = (string)dr["Capacity"].ToString();
                editCapacity.Text = r_capacity;

                string r_type = (string)dr["RoomType"].ToString();
                editRoomType_cmb.Text = r_type;
                //editbuil_cmb.Text = r_type;
            }
            con.Close();

        }

        //update Button code............

        private void metroTile4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE LocationTable SET Capacity ='" + editCapacity.Text + "',RoomType = '" + editRoomType_cmb.Text + "' WHERE RoomName ='" + editRoomcombo_box.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Location Updated!");
            con.Close();

            //LoadLocations();
            // ClearUpdateLocDetails();
            Loc_TabControl.SelectedTab = Load_Location_Page;


        }

        private void DeleteLocation_Btn_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM LocationTable WHERE RoomName = '" + editRoomcombo_box.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Location Deleted!");
            con.Close();



            
        }
    }
}
