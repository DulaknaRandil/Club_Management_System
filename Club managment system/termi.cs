using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_managment_system
{
    public partial class termi : Form
    {
        public termi()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {



           // try
            //{



                if (MessageBox.Show("Your Data will be delete ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {


                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;


                cmd1.CommandText = "select * from AddMember Where RegID = '" + del.Text + "'";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);





                SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;


                    cmd.CommandText = "Delete from AddMember Where RegID = '" + del.Text + "'";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    Disp_data();
                       if (DS1.Tables[0].Rows.Count != 0)
                     {
                    MessageBox.Show("Record removed Sucessfully", "Done...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // dataGridView1.DataSource = DS.Tables[0];




                    }

                     else
                      {
                     MessageBox.Show("Record not found", "Invaild Member ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                     }
                      // }
         //   catch (IndexOutOfRangeException)
         //   {
               // MessageBox.Show("Record not found1", "Invaild Member ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   }

        



        }

        private void termi_Load(object sender, EventArgs e)
        {
            Disp_data();
        }
        public void Disp_data()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from AddMember ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void del_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from AddMember ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
