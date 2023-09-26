using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_managment_system
{
    public partial class Searchmember : Form
    {
        public Searchmember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Searchmember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT AddMember.RegID as Member_ID,AddMember.FullName as Full_Name,AddMember.Fname As First_Name,AddMember.Lname As Last_Name,AddMember.Intake As Intake,AddMember.Dep As Department,AddMember.Dob As Date_of_Birth,AddMember.Gender As Gender,AddMember.Addres As Address ,AddMember.City As City,AddMember.Province As Province,AddMember.POS As Position,AddMember.Pnum As Contact_Number,AddMember.Pemail As E_mail,Fee.Fee As Fee  from AddMember full join Fee on AddMember.RegID = Fee.IID";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from  AddMember where RegID = '" +search.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show( "Please Enter the Index Number Correctly..! ", "Member Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "SELECT AddMember.RegID as Member_ID,AddMember.FullName as Full_Name,AddMember.Fname As First_Name,AddMember.Lname As Last_Name,AddMember.Intake As Intake,AddMember.Dep As Department,AddMember.Dob As Date_of_Birth,AddMember.Gender As Gender,AddMember.Addres As Address ,AddMember.City As City,AddMember.Province As Province,AddMember.POS As Position,AddMember.Pnum As Contact_Number,AddMember.Pemail As E_mail,Fee.Fee As Fee  from AddMember full join Fee on AddMember.RegID = Fee.IID";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);
                dataGridView1.DataSource = DS1.Tables[0];

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT AddMember.RegID as Member_ID,AddMember.FullName as Full_Name,AddMember.Fname As First_Name,AddMember.Lname As Last_Name,AddMember.Intake As Intake,AddMember.Dep As Department,AddMember.Dob As Date_of_Birth,AddMember.Gender As Gender,AddMember.Addres As Address ,AddMember.City As City,AddMember.Province As Province,AddMember.POS As Position,AddMember.Pnum As Contact_Number,AddMember.Pemail As E_mail,Fee.Fee As Fee  from AddMember full join Fee on AddMember.RegID = Fee.IID";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
