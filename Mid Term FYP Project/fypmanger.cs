using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Term_FYP_Project
{
    public partial class fypmanger : Form
    {
        public fypmanger()
        {
            InitializeComponent();
        }

        private void buttonstudent_Click(object sender, EventArgs e)
        {
            Form frmo = new Student();
            frmo.Show();
        }

        private void buttonadvisorinfo_Click(object sender, EventArgs e)
        {
            Form frm = new Advisor();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new ProjectEvalvation();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonproject_Click(object sender, EventArgs e)
        {
            Form frm = new Project();
            frm.Show();
        }
    }
}
