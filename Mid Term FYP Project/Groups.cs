﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Term_FYP_Project
{
    public partial class Groups : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True");

        public Groups()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            string query = string.Format("Select ID,Date=Created_On from [ProjectA].[dbo].[Group]");



            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ArrayList row = new ArrayList();
                row.Add(reader["ID"].ToString());
                row.Add(reader["Date"].ToString());
                
                dataGridView1.Rows.Add(row.ToArray());


            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                conn.Open();
                string query = string.Format("insert into [ProjectA].[dbo].[Group] values('{0}')", DateTime.Now);
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                object OB = null;
                EventArgs er = null;
                this.Groups_Load(OB,er);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ViewGroupStudents sdr = new ViewGroupStudents();
                sdr.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                sdr.Show();
            }
            if(e.ColumnIndex==3)
            {
                GroupEvaluation grp = new GroupEvaluation();
                grp.Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                grp.Show();

            }
            if (e.ColumnIndex == 4)
            {
                GroupProjects prg = new GroupProjects();
                prg.Id= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                prg.Show();
            }
            if (e.ColumnIndex == 5)
            {
                
                    
                    conn.Open();

                    String cm4 = string.Format("Delete from GroupEvaluation where GroupId={0};Delete from GroupStudent where GroupId={0};Delete from GroupProject where GroupId={0};Delete from [Group] where Id={0}", Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    SqlCommand comm4 = new SqlCommand(cm4, conn);
                    comm4.ExecuteNonQuery();
                   
                    conn.Close();


                    MessageBox.Show("Deleted");

                    object sende = null;
                    EventArgs er = null;
                    dataGridView1.Rows.Clear();
                    this.Groups_Load(sende, er);


                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new GroupEvaluation();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new GroupProjects();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new ViewGroupStudents();
            frm.Show();
        }
    }
}
