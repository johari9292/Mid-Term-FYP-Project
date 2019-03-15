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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True");
        private void DisplayData()
        {

            con.Open();
            DataTable dt = new DataTable(); 
            SqlDataAdapter adapt = new SqlDataAdapter("select Title, Description From Project", con);
            adapt.Fill(dt);
          dataGridViewProject.DataSource = dt;
            con.Close();



        }
        private void ClearData()
        {
          textBoxdescription.Text = "";
          textBoxtitle.Text = " ";
            
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Project values(@Description,@title)", con);
            cmd.Parameters.AddWithValue("@Description", textBoxdescription.Text);
            cmd.Parameters.AddWithValue("@title", textBoxtitle.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            MessageBox.Show("Data Inserted Sucessfully");
           
            ClearData();
        }

        private void dataGridViewProject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0 &&
                e.RowIndex >= 0)
            {
                textBoxdescription.Text = dataGridViewProject.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxtitle.Text = dataGridViewProject.Rows[e.RowIndex].Cells[2].Value.ToString();


            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1 &&
                e.RowIndex >= 0)
            {
                
                string title = dataGridViewProject.Rows[e.RowIndex].Cells[2].Value.ToString();
                SqlCommand cmd = new SqlCommand("delete from Project Where title = @title", con);
                cmd.Parameters.AddWithValue("@title", title);
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
            if (textBoxdescription.Text!= "" && textBoxtitle.Text!= " ")
            {
                int rowIndex = dataGridViewProject.CurrentCell.RowIndex;
                string title = dataGridViewProject.Rows[rowIndex].Cells[3].Value.ToString();
                
                SqlCommand cmd = new SqlCommand("update Project set description = @descp, Title = @titl Where  title = @title", con);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@titl", textBoxtitle.Text);
                cmd.Parameters.AddWithValue("@descp", textBoxdescription.Text);
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
    }
}
