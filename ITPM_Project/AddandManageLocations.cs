using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            BuildingAutono();
            RoomAutono();
        }

        //established the connection
        SqlConnection con = new SqlConnection(@"Data Source = ELECTRA\SQLSERVER; Initial Catalog = LocationDB; Integrated Security = True");
        SqlCommand cmd;
        SqlDataReader dr;
        String sql;
        String buildingID;
        String roomID;


        //create Auto increment number for building table............

        public void BuildingAutono()
        {

            sql = "select BuildingID from BuildingTable order by BuildingID desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                buildingID = id.ToString("0001");

            }
            else if(Convert.IsDBNull(dr))
            {
                buildingID = ("0001");
            }
            else
            {
                buildingID = ("0001");
            }

            Building_ID_textbox.Text = buildingID.ToString();
            con.Close();


        }


        //create auto-increment number for room table...................

        public void RoomAutono()
        {

            sql = "select Room_ID from RoomTable order by Room_ID desc";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                roomID = id.ToString("0001");

            }
            else if (Convert.IsDBNull(dr))
            {
                roomID = ("0001");
            }
            else
            {
                roomID = ("0001");
            }

            Room_id_textbox.Text = roomID.ToString();
            con.Close();


        }

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

            String addbuild = AddBuilding_TextBox.Text;
            String addroom = AddRoom_TextBox.Text;
            String addroomty = AddRoomType_cmb.SelectedItem.ToString();
            String addcapacity = AddCapacity_cmb.Text;


            if((AddBuilding_TextBox.Text != string.Empty) && (AddRoom_TextBox.Text != string.Empty) && (AddRoomType_cmb.SelectedItem.ToString() != string.Empty) 
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
            String addbuildingid = Building_ID_textbox.Text;

            if ((Add_Building_Name.Text != string.Empty))
            {
                sql = "insert into BuildingTable (BuildingID,Building_Name)values(@addbuildingid,@addbuildingname)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@addbuildingname", addbuildingname);
                cmd.Parameters.AddWithValue("@addbuildingid", addbuildingid);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Building successfuly Added!");
                con.Close();

            }

        }

        private void SaveRoom_Name_Click(object sender, EventArgs e)
        {

            String addroomname = Room_NametextBox.Text;
            String addroomid = Room_id_textbox.Text;

            if ((Room_NametextBox.Text != string.Empty))
            {
                sql = "insert into RoomTable (Room_ID,Room_Name)values(@addroomid,@addroomname)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@addroomname", addroomname);
                cmd.Parameters.AddWithValue("@addroomid", addroomid);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room successfuly Added!");
                con.Close();

            }

        }
    }
}
