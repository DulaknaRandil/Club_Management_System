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

namespace Club_managment_system
{
    public partial class CheckList : Form
    {
        public CheckList()
        {
            InitializeComponent();
        }

        private void CheckList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Fee.IID as Member_ID,Addmember.FullName as Full_Name,Fee.YEARS as Year,Fee.Fee As Fee from AddMember inner join Fee on AddMember.RegID = Fee.IID";
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
            cmd.CommandText = "select  Fee.IID as Member_ID,Addmember.FullName as Full_Name,Fee.YEARS as Year,Fee.Fee As Fee from Addmember inner join Fee on Fee.IID = AddMember.RegID AND Fee.IID = '" + Se.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count != 0)
           {
                dataGridView1.DataSource = DS.Tables[0];
            }
           else
            {
                MessageBox.Show("Record not found", "Not Paid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;
                cmd1.CommandText = "SELECT Fee.IID as Member_ID,Addmember.FullName as Full_Name,Fee.YEARS as Year,Fee.Fee As Fee from AddMember inner join Fee on AddMember.RegID = Fee.IID";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);
                dataGridView1.DataSource = DS1.Tables[0];
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Fee.IID as Member_ID,Addmember.FullName as Full_Name,Fee.YEARS as Year,Fee.Fee As Fee from AddMember inner join Fee on AddMember.RegID = Fee.IID";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
