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
using System.Text.RegularExpressions;

namespace Mid_Term_FYP_Project
{
    public partial class Student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True");
        
        public Student()
        {
            InitializeComponent();
        }
        private void ClearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = " ";
            textBoxMobileNo.Text = " ";
            textBoxRegNo.Text = " ";
            textBoxEmailAddress.Text = " ";
        }

        private void DisplayData()
        {
            
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select [RegistrationNo] ,[FirstName],[LastName],[Contact],[Email],[DateOfBirth],[Gender] from Person inner join Student on Person.id = Student.id", con);
            adapt.Fill(dt);
            dataGridViewstudentdetail.DataSource = dt;
            con.Close();
            


        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd,cmd2; 
             

            

             
            string qr = @"insert into Person values(@fname , @lname , @phoneno , @Emailaddress , @birthdat ,  @gender ) SELECT SCOPE_IDENTITY()";

            cmd = new SqlCommand(qr, con);           
            
            cmd.Parameters.AddWithValue("@fname" , textBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
            int gender;
            if(comboBoxGender.Text == "Male")
            {
                gender = 1;
            }
            else
            {
                gender = 2;
            }
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@phoneno" , textBoxMobileNo.Text);
            
            cmd.Parameters.AddWithValue("@Emailaddress" , textBoxEmailAddress.Text);
             cmd.Parameters.AddWithValue("@birthdat" , DateTime.Parse(dateTimePicker1.Text));
            
            con.Open();
            cmd.ExecuteNonQuery();
            SqlCommand get_id_cmd = new SqlCommand("select @@identity", con);
            string query = @" insert into Student values(@id,@regno)";

            cmd2 = new SqlCommand(query, con);
            int id = Convert.ToInt32(get_id_cmd.ExecuteScalar());
            cmd2.Parameters.AddWithValue("@id", id);
            cmd2.Parameters.AddWithValue("@regno", textBoxRegNo.Text);

           
            
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            DisplayData();
            ClearData();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxRegNo_TextChanged(object sender, EventArgs e)
        {

        }

        private String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyy-MM-dd HH:mm:ss");
            //return value.ToString("yyyyMMddHHmmss");


        }

       
        private void dataGridViewstudentdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex ==0 &&
                e.RowIndex >= 0)
            {

                textBoxFirstName.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxLastName.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxMobileNo.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxRegNo.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEmailAddress.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                comboBoxGender.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[8].Value.ToString();

                


                
              //ateTimePicker1.Value = Convert.ToDateTime(dataGridViewstudentdetail.Rows[e.RowIndex].Cells[8].Value.ToString());


                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewstudentdetail.Rows[e.RowIndex].Cells[7].Value);


            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex ==1 &&
                e.RowIndex >= 0)
            {


                

                
                SqlCommand cmd;


                int rowIndex = dataGridViewstudentdetail.CurrentCell.RowIndex;

                string emal = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                //string Emal = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
                string reg = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                // string query = @"(delete from student Where RegistrationNo =" +reg+")"; 
                string query = $" delete from student Where RegistrationNo = @reg ;delete from person Where Email= @emal";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@reg", reg);
                cmd.Parameters.AddWithValue("@emal", emal);
                con.Open();


                cmd.ExecuteNonQuery();

                con.Close();
                dataGridViewstudentdetail.Rows.RemoveAt(rowIndex);
                DisplayData();
                MessageBox.Show("deleted scucessfully");

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
           /*ataGridViewButtonColumn btnnew = new DataGridViewButtonColumn();
            btnnew.HeaderText = "Update";
            btnnew.Text = "Update";
            btnnew.UseColumnTextForButtonValue = true;
            dataGridViewstudentdetail.Columns.Add(btnnew);
            DataGridViewButtonColumn btnne1= new DataGridViewButtonColumn();
            btnne1.HeaderText = "Delete";
            btnne1.Text = "Delete";
            btnne1.UseColumnTextForButtonValue = true;
            dataGridViewstudentdetail.Columns.Add(btnne1);*/
        }

        private void Update_Click(object sender, EventArgs e)
        {

            if (textBoxFirstName.Text != "" &&
            textBoxLastName.Text != " " &&
            textBoxMobileNo.Text != " " &&
            textBoxRegNo.Text != " " &&
            textBoxEmailAddress.Text != " ")
            {
                SqlCommand cmd, cmd2;
                int rowIndex = dataGridViewstudentdetail.CurrentCell.RowIndex;
                string emal = dataGridViewstudentdetail.Rows[rowIndex].Cells[6].Value.ToString();
                //string Emal = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
                string reg = dataGridViewstudentdetail.Rows[rowIndex].Cells[2].Value.ToString();

                
                string qr = @"Update  Person set firstname = @fname ,lastname = @lname ,contact = @phoneno ,Email = @Emailaddress , dateofBirth = @birthdat ,gender = @gender "+ "where Email = @emal";

              cmd = new SqlCommand(qr, con);
                cmd.Parameters.AddWithValue("@emal", emal);
                cmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
                int gender;
                if (comboBoxGender.Text == "Male")
                {
                    gender = 1;
                }
                else
                {
                    gender = 2;
                }
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@phoneno", textBoxMobileNo.Text);

                cmd.Parameters.AddWithValue("@Emailaddress", textBoxEmailAddress.Text);
                cmd.Parameters.AddWithValue("@birthdat", DateTime.Parse(dateTimePicker1.Text));
                


                con.Open();
                cmd.ExecuteNonQuery();
                string query = @" update Student set RegistrationNo = @regno "+ "where   RegistrationNo = @reg";
               
                cmd2 = new SqlCommand(query, con);
                cmd2.Parameters.AddWithValue("@reg", reg);
                cmd2.Parameters.AddWithValue("@regno", textBoxRegNo.Text);

                
                

                cmd2.ExecuteNonQuery();
                con.Close();

               
                DisplayData();
                MessageBox.Show("updated scucessfully");
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select the data to Delete");
            }

        }
    }
}
