using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Club_managment_system
{
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
        }

        private void Fee_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Index_TextChanged(object sender, EventArgs e)
        {
            if (Index.Text !="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source= MSI;database = AddMemberDetails;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select FullName,Intake,Dep from  AddMember where RegID = '" + Index.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count != 0)
                {
                    Fullname.Text = DS.Tables[0].Rows[0][0].ToString();
                    intake.Text = DS.Tables[0].Rows[0][1].ToString();
                    Department.Text = DS.Tables[0].Rows[0][2].ToString();
                    // MessageBox.Show("ok");
                }
            }
            else
            {
                Fullname.Text = "________________________________";
                intake.Text = "________________________________";
                Department.Text = "________________________________";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source= MSI;database = AddMemberDetails;integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from  Fee where IID = ' " + Index.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            try
            {
                if (DS.Tables[0].Rows.Count == 0)
            {

              



                    SqlConnection con1 = new SqlConnection();
                    con1.ConnectionString = "data source= MSI;database = AddMemberDetails;integrated security = True";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.Connection = con1;
                    cmd1.CommandText = "insert  into Fee(YEARS,IID,Fee) values (" + Year.Text + ",'" + Index.Text + "'," + Fees.Text + ")";


                    SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                    DataSet DS1 = new DataSet();

                    DA1.Fill(DS1);









                    if (MessageBox.Show("Fees Submission Sucessfull", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        Index.Text = "";
                        Fees.Text = "";
                        Fullname.Text = "________________________________";
                        intake.Text = "________________________________";
                        Department.Text = "________________________________";
                        Year.Text = "";

                    }




                    else
                    {
                        MessageBox.Show("Fees already Submitted");
                        Index.Text = "";
                        Fees.Text = "";
                        Fullname.Text = "________________________________";
                        intake.Text = "________________________________";
                        Department.Text = "________________________________";
                        Year.Text = "";

                    }
                }

                else if (DS.Tables[0].Rows.Count != 0)
                {
                        MessageBox.Show("Fees already Submitted");
                        Index.Text = "";
                        Fees.Text = "";
                        Fullname.Text = "________________________________";
                        intake.Text = "________________________________";
                        Department.Text = "________________________________";
                        Year.Text = "";

                    }
                }
                catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Invaild Entery...!","Warning...!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Index.Text = "";
                Fees.Text = "";
                Fullname.Text = "________________________________";
                intake.Text = "________________________________";
                Department.Text = "________________________________";
                Year.Text = ""; 
           }
        }
    }
}
