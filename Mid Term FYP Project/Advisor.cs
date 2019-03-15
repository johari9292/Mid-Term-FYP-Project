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
    public partial class Advisor : Form
    {
        public Advisor()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True");
        SqlCommand cmd, cmd2;
        private void ClearData()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = " ";
            textBoxMobileNo.Text = " ";
            comboBoxdesignation.Text = " ";
            textBoxEmailAddress.Text = " ";
            textBoxsalary.Text = "";
        }
        private void DisplayData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select [Designation] ,[FirstName],[LastName],[Contact],[Email],[DateOfBirth],[Gender],[Salary] from Person inner join Advisor on Person.id = Advisor.id", con);
          //string Query = "Select Id=seo.Id,FirstName=seo.FirstName,LastName=seo.LastName,Contact=seo.Contact,Email=seo.Email,DateOfBirth=seo.DateOfBirth,Gender=one.Gender,Designation=seo.DValue,Salary=seo.Salary" + "from(Select Id = Person.Id, FirstName = Person.FirstName, LastName = Person.LastName, Contact = Person.Contact, Email = Person.Email, DateOfBirth = Person.DateOfBirth, Gender = Person.Gender, Designation = Advisor.Designation, DValue = Lookup.Value, Salary = Advisor.Salary  from Person INNER Join(Advisor INNER Join Lookup ON Lookup.Id = Advisor.Designation) ON Advisor.Id = Person.Id) as seo INNer join (Select Id = Person.Id, FirstName= Person.FirstName, LastName= Person.LastName, Contact= Person.Contact, Email = Person.Email, DateOfBirth= Person.DateOfBirth, Gender= Lookup.Value, Designation= Advisor.Designation, DValue= Advisor.Designation, Salary= Advisor.Salary from Advisor INNER Join (Person INNER Join Lookup ON Lookup.Id= Person.Gender) ON Person.Id = Advisor.Id) as one On one.Id = seo.id;";


          //SqlDataAdapter adapt = new SqlDataAdapter(Query, con);
            
            adapt.Fill(dt);
            dataGridViewstudentdetail.DataSource = dt;
            con.Close();
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           





            string qr = @"insert into Person values(@fname , @lname , @phoneno , @Emailaddress , @birthdat , @gender ) SELECT SCOPE_IDENTITY()";

            cmd = new SqlCommand(qr, con);
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
            SqlCommand get_id_cmd = new SqlCommand("select @@identity", con);
            string query = @" insert into Advisor values(@id,@designation,@salery)";

            cmd2 = new SqlCommand(query, con);
            int id = Convert.ToInt32(get_id_cmd.ExecuteScalar());
            cmd2.Parameters.AddWithValue("@id", id);
            int desg;
            if (comboBoxdesignation.Text == "Proffessor")
            {
                desg = 6;
            }
            else if (comboBoxdesignation.Text == "Associate Proffessor")
            {
                desg = 7;
            }
            else if(comboBoxdesignation.Text == "Associate Proffessor")
            {
                desg = 8;
            }
            else if(comboBoxdesignation.Text == "Lecturar")
            {
                desg = 9;
            }
            else
            {
                desg = 10;
}
      

            


            cmd2.Parameters.AddWithValue("@designation", desg);
            Decimal salery = Decimal.Parse(textBoxsalary.Text);
         cmd2.Parameters.AddWithValue(parameterName: "@salery", value: salery);



            cmd2.ExecuteNonQuery();
            con.Close();
            
            DisplayData();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Advisor_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {

            if (textBoxFirstName.Text != "" &&
            textBoxLastName.Text != " " && textBoxsalary.Text!= "" &&
           
            textBoxMobileNo.Text != " " && 
            textBoxEmailAddress.Text != " ")


            {
                SqlCommand cmd, cmd2;
                int rowIndex = dataGridViewstudentdetail.CurrentCell.RowIndex;
                string emal = dataGridViewstudentdetail.Rows[rowIndex].Cells[6].Value.ToString();
                //string Emal = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
              


                string qr = @"Update  Person set firstname = @fname ,lastname = @lname ,contact = @phoneno ,Email = @Emailaddress , dateofBirth = @birthdat ,gender = @gender " + "where Email = @emal";

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
                string query = @" update Advisor set [Designation] = @desgnation, [Salary] = @salray From Person Inner join Advisor on Person.id=Advisor.id  " + "Where Email=@emal";

                cmd2 = new SqlCommand(query, con);
                int desg;
                if (comboBoxdesignation.Text == "Proffessor")
                {
                    desg = 6;
                }
                else if (comboBoxdesignation.Text == "Associate Proffessor")
                {
                    desg = 7;
                }
                else if (comboBoxdesignation.Text == "Associate Proffessor")
                {
                    desg = 8;
                }
                else if (comboBoxdesignation.Text == "Lecturar")
                {
                    desg = 9;
                }
                else
                {
                    desg = 10;
                }



               cmd2.Parameters.AddWithValue("@emal", emal);

                cmd2.Parameters.AddWithValue("@desgnation", desg);
                Decimal salery = Decimal.Parse(textBoxsalary.Text);
                cmd2.Parameters.AddWithValue(parameterName: "@salray", value: salery);






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

        private void dataGridViewstudentdetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 0 &&
                e.RowIndex >= 0)
            {

                textBoxFirstName.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxLastName.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxMobileNo.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBoxdesignation.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxEmailAddress.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                comboBoxGender.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[8].Value.ToString();
                textBoxsalary.Text = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[9].Value.ToString();





                //ateTimePicker1.Value = Convert.ToDateTime(dataGridViewstudentdetail.Rows[e.RowIndex].Cells[8].Value.ToString());


                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewstudentdetail.Rows[e.RowIndex].Cells[7].Value);


            }
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == 1 &&
                e.RowIndex >= 0)
            {





                SqlCommand cmd;


                int rowIndex = dataGridViewstudentdetail.CurrentCell.RowIndex;

                string emal = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[6].Value.ToString();
                //string Emal = dataGridViewstudentdetail.Rows[e.RowIndex].Cells[7].Value.ToString();
               
                
                // string query = @"(delete from student Where RegistrationNo =" +reg+")"; 
                string query = $" delete  Advisor from Advisor join Person on Advisor.id= Person.id Where Person.Email = @emal ; delete from person Where Email= @emal";
               
                cmd = new SqlCommand(query, con);
                
                cmd.Parameters.AddWithValue("@emal", emal);
                con.Open();


                cmd.ExecuteNonQuery();

                con.Close();
                dataGridViewstudentdetail.Rows.RemoveAt(rowIndex);
                DisplayData();
                MessageBox.Show("deleted scucessfully");

            }
        }
    }
}
