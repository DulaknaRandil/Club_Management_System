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
    public partial class individual : Form
    {
        public individual()
        {
            InitializeComponent();
        }

        private void individual_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI; database = AddMemberDetails; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from AddMember Where RegID ='" +search.Text  + "'";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            if (DS.Tables[0].Rows.Count != 0)
            {
                Lname.Text = DS.Tables[0].Rows[0][3].ToString();
                Fname.Text = DS.Tables[0].Rows[0][2].ToString();
                Fullname.Text = DS.Tables[0].Rows[0][1].ToString();
                Gender.Text = DS.Tables[0].Rows[0][7].ToString();
                DOB.Text = DS.Tables[0].Rows[0][6].ToString();
                Intake.Text = DS.Tables[0].Rows[0][4].ToString();
                Department.Text = DS.Tables[0].Rows[0][5].ToString();
                Address.Text = DS.Tables[0].Rows[0][8].ToString();
                City.Text = DS.Tables[0].Rows[0][9].ToString();
                Province.Text = DS.Tables[0].Rows[0][10].ToString();
                ZipCode.Text = DS.Tables[0].Rows[0][11].ToString();
                ConNum.Text = DS.Tables[0].Rows[0][12].ToString();
                Kdum.Text = DS.Tables[0].Rows[0][13].ToString();
                Pmail.Text = DS.Tables[0].Rows[0][14].ToString();
                Pos.Text = DS.Tables[0].Rows[0][15].ToString();

            }
            else
            {
                MessageBox.Show("Record Not Found...!", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lname.Text = "________________________";
                Fname.Text = "________________________";
                Fullname.Text = "__________________________________________________________";
                Gender.Text = "____________";
                DOB.Text = "________________________";
                Intake.Text = "____________";
                Department.Text = "_____________________________";
                Address.Text = "__________________________________________________________";
                City.Text = "________________________";
                Province.Text = "________________________";
                ZipCode.Text = "________________";
                ConNum.Text = "________________________";
                Kdum.Text = "_____________________________";
                Pmail.Text = "_____________________________";
                Pos.Text = "_____________________________";
            }

        }

        private void ZipCode_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lname.Text = "________________________";
            Fname.Text = "________________________";
            Fullname.Text = "__________________________________________________________";
            Gender.Text = "____________";
            DOB.Text = "________________________";
            Intake.Text = "____________";
            Department.Text = "_____________________________";
            Address.Text = "__________________________________________________________";
            City.Text = "________________________";
            Province.Text = "________________________";
            ZipCode.Text = "________________";
            ConNum.Text = "________________________";
            Kdum.Text = "_____________________________";
            Pmail.Text = "_____________________________";
            Pos.Text = "_____________________________";
        }

        private void Fname_Click(object sender, EventArgs e)
        {

        }

        private void Province_Click(object sender, EventArgs e)
        {

        }

        private void Fullname_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Department_Click(object sender, EventArgs e)
        {

        }

        private void DOB_Click(object sender, EventArgs e)
        {

        }

        private void Kdum_Click(object sender, EventArgs e)
        {

        }

        private void Pos_Click(object sender, EventArgs e)
        {

        }
    }
    
}
