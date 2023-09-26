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
    public partial class MemberRegister : Form
    {
        public MemberRegister()
        {
            InitializeComponent();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try { 
            
                String index = indexNum.Text;
                String FullName = FullN.Text;
                String Firstname = Fname.Text;
                String Lastname = Lname.Text;
                Int64 intakeN = Int64.Parse(intake.Text);
                String Department = Dep.Text;
                String DOB = Dob.Text;
                String GENDER = "";
                bool isChecked = radioButtonMale.Checked;
                if (isChecked)
                {
                    GENDER = radioButtonMale.Text;
                }
                else
                {
                    GENDER = radioButtonFemale.Text;
                }
                String ADDRESS = Address.Text;
                String CITY = City.Text;
                String PROVINCE = province.Text;
                Int32 ZIP = Int32.Parse(zip.Text);
                Int64 Pnum = Int64.Parse(ContNum.Text);
                String kduMail = KDUmail.Text;
                String Pemail = Pmail.Text;
                String POS = pos.Text;

             
            SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI; database =AddMemberDetails;integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddMember(RegID,FullName,Fname,Lname,Intake,Dep,Dob,Gender,Addres,City,Province,Zip,Pnum,kduMail,Pemail,POS) values('" + index + "','" + FullName + "','" + Firstname + "','" + Lastname + "','" + intakeN + "','" + Department + "', '" + DOB + "','" + GENDER + "','" + ADDRESS + "','" + CITY + "','" + PROVINCE + "','" + ZIP + "','" + Pnum + "','" + kduMail + "','" + Pemail + "','" + POS + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                con.Close();
                MessageBox.Show("Data Saved.Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (FormatException)
            {
                MessageBox.Show("Invaild Entry or Data", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void reset_Click(object sender, EventArgs e)
        {
            indexNum.Clear();
            FullN.Clear();
            Fname.Clear();
            Lname.Clear();
            intake.Clear();
            Dep.ResetText();
            Dob.ResetText();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            pos.ResetText();
            Address.Clear();
            City.Clear();
            province.ResetText();
            zip.Clear();
            ContNum.Clear();
            KDUmail.Clear();
            Pmail.Clear();

        }

        private void MemberRegister_Load(object sender, EventArgs e)
        {

        }

        private void Dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void indexNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
