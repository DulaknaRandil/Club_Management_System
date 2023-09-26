using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Club_managment_system
{
    public partial class Editmem : Form
    {
        public Editmem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from AddMember Where RegID ='" + search.Text + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count != 0)
            {
              /*  MessageBox.Show("Valid Member.You can edit data.", "Valid Member", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Select * from AddMember Where RegID ='" + search.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                if (DS.Tables[0].Rows.Count != 0)
                { */
                    indexNum.Text = DS.Tables[0].Rows[0][0].ToString();
                     Lname.Text = DS.Tables[0].Rows[0][3].ToString();
                    Fname.Text = DS.Tables[0].Rows[0][2].ToString();
                    FullN.Text = DS.Tables[0].Rows[0][1].ToString();
                    Gender.Text = DS.Tables[0].Rows[0][7].ToString();
                    Dob.Text = DS.Tables[0].Rows[0][6].ToString();
                    intake.Text = Convert.ToString(DS.Tables[0].Rows[0][4]);
                    Dep.Text = DS.Tables[0].Rows[0][5].ToString();
                    Address.Text = DS.Tables[0].Rows[0][8].ToString();
                    City.Text = DS.Tables[0].Rows[0][9].ToString();
                    province.Text = DS.Tables[0].Rows[0][10].ToString();
                    zip.Text = Convert.ToString(DS.Tables[0].Rows[0][11]);
                    ContNum.Text = Convert.ToString(DS.Tables[0].Rows[0][12]);
                    KDUmail.Text = DS.Tables[0].Rows[0][13].ToString();
                    Pmail.Text = DS.Tables[0].Rows[0][14].ToString();
                    pos.Text = DS.Tables[0].Rows[0][15].ToString();

                
               
            }
            else
            {
                MessageBox.Show("Invalid Member..!You can't edit data.", "Invalid Member", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                String index = indexNum.Text;
                String FullName = FullN.Text;
                String Firstname = Fname.Text;
                String Lastname = Lname.Text;
                Int64 intakeN = Int64.Parse(intake.Text);
                String Department = Dep.Text;
                String DOB = Dob.Text;
                String GENDER = Gender.Text;

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
                // cmd.CommandText = "update AddMember set FullName = " + FullName + " where RegID ='" + search.Text + "' ";
                cmd.CommandText = "update AddMember  set RegID = '" + index + "',FullName ='" + FullName + "',Fname = '" + Firstname + "' ,Lname = '" + Lastname + "',Intake = " + intakeN + ",Dep = '" + Department + "',Dob =  '" + DOB + "',Gender = '" + GENDER + "',Addres = '" + ADDRESS + "',City = '" + CITY + "',Province = '" + PROVINCE + "', Zip = " + ZIP + " ,Pnum = " + Pnum + ",kduMail = '" + kduMail + "',Pemail = '" + Pemail + "',POS = '" + POS + "' where RegID = '" + search.Text + "' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);




                MessageBox.Show("Data Upadated Sucessfully", "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invaild Entry or Data", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void Editmem_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            search.Clear();
            indexNum.Clear();
            FullN.Clear();
            Fname.Clear();
            Lname.Clear();
            intake.Clear();
            Dep.ResetText();
            Dob.ResetText();
           
            
            pos.ResetText();
            Address.Clear();
            City.Clear();
            province.ResetText();
            zip.Clear();
            ContNum.Clear();
            KDUmail.Clear();
            Pmail.Clear();
        }

        private void pos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
