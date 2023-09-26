using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible= false;
            menuStrip2.Visible = false;
            panel2.Visible = false;
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void memberInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            
            if (username == "" && password == "")
            {
                MessageBox.Show("Enter both Username and Password for Logging.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == "")
            {
                MessageBox.Show("Enter Username for Logging.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == "")
            {
                MessageBox.Show("Enter Password for Logging.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == "student" && password == "student")
            {
                menuStrip1.Visible = true;
                menuStrip2.Visible = true;
                panel1.Visible = false;
                panel2.Visible = true;
                button1.Visible = false;

            }
            else
            {
                MessageBox.Show("Invaild Username or Password.","Login Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberRegister NR = new MemberRegister();
            NR.Show();

        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void membershipFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fee NEWfee = new Fee();
            NEWfee.Show();
        }

        private void searchMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchmember sh = new Searchmember();
            sh.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            individual sh = new individual();
            sh.Show();
        }

        private void checkListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckList sh = new CheckList();
            sh.Show();
        }

        private void terminatedMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            termi sh = new termi();
            sh.Show();
        }

        private void editMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editmem sh= new Editmem();
            sh.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About sh = new About();
            sh.Show();
        }

        private void rulesAndRegulationsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Rules sh = new Rules();
            sh.Show();
        }

        private void exitSystemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure? This will Delete your unsaved data.", "Exit Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();

            }
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/kdusc.rotaract/");
        }
    }
}
