using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mid_Term_FYP_Project
{
    public partial class ProjectEvalvation : Form
    {
        public ProjectEvalvation()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True");
        private void DisplayData()
        {

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Name,TotalMarks,TotalWeightage from Evaluation", con);
            adapt.Fill(dt);
          dataGridViewProjectEvalvation.DataSource = dt;
            con.Close();

            

        }
        private void ClearData()
        {
            textBoxName.Text = "";
          textBoxtotalmarks.Text= "";
          textBoxtotalwieghtage.Text = " ";


        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd; 
            cmd = new SqlCommand("insert into  Evaluation  values(@nam,@tmarks,@whtag)", con);
            cmd.Parameters.AddWithValue("@nam", textBoxName.Text);
            cmd.Parameters.AddWithValue("@tmarks", textBoxtotalmarks.Text);
            cmd.Parameters.AddWithValue("@whtag", textBoxtotalwieghtage.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Data Inserted Sucessfully");

            ClearData();
        }

        private void dataGridViewProjectEvalvation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0 &&
                e.RowIndex >= 0)
            {
                textBoxName.Text = dataGridViewProjectEvalvation.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxtotalmarks.Text = dataGridViewProjectEvalvation.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxtotalwieghtage.Text = dataGridViewProjectEvalvation.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1 &&
                e.RowIndex >= 0)
            {

                string name = dataGridViewProjectEvalvation.Rows[e.RowIndex].Cells[2].Value.ToString();
                SqlCommand cmd = new SqlCommand("delete from Evaluation  Where name  = @name", con);
                cmd.Parameters.AddWithValue("@name" , name );
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                DisplayData();
                ClearData();
                MessageBox.Show("Deleted Sucessfully");

            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            if (textBoxtotalmarks.Text != "" && textBoxtotalwieghtage.Text != " ")
            {
                int rowIndex = dataGridViewProjectEvalvation.CurrentCell.RowIndex;
                string name = dataGridViewProjectEvalvation.Rows[rowIndex].Cells[2].Value.ToString();



                SqlCommand cmd = new SqlCommand("update Evaluation set  Name = @nam  ,TotalMarks = @mark,TotalWeightage = @tweit Where Name = @name", con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@nam", textBoxName.Text);
                cmd.Parameters.AddWithValue("@mark", textBoxtotalmarks.Text);
                cmd.Parameters.AddWithValue("@tweit", textBoxtotalwieghtage.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("updated Sucessfully");
            }
            else
            {
                MessageBox.Show("please select data to update");
            }
        }

        private void Project_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ProjectEvalvation_Load(object sender, EventArgs e)
        {
            DisplayData(); 
        }
    }
}
   