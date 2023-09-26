using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_managment_system
{
    partial class About : Form
    {
        public About()
        {
           InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            About sh= new About();
          this.Close();
        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
