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

    public partial class GroupProjects : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OLQ1SQE;Initial Catalog=ProjectA;Integrated Security=True"); public int Id { get; set; }
        public GroupProjects()
        {
            InitializeComponent();
        }

        private void GroupProjects_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();
            conn.Open();
            string query = string.Format("Select Title,AssignmentDate from Project Inner Join ([ProjectA].[dbo].[Group] INNER join GroupProject On [ProjectA].[dbo].[Group].Id=GroupProject.GroupId) On Project.Id=GroupProject.ProjectId where [ProjectA].[dbo].[Group].Id={0}", Id);
           
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<string> list = new List<string>();
            while (reader.Read())
            {
           
                ArrayList row = new ArrayList();
                row.Add(reader["Title"].ToString());
                row.Add(reader["AssignmentDate"].ToString());
                
                list.Add(reader["Title"].ToString());
                

                dataGridView1.Rows.Add(row.ToArray());
            }
            conn.Close();


            conn.Open();
            string query1 = string.Format("Select Title from Project");
           
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            
            while (reader1.Read())
            {
                if (list.Count == 0)
                {
                    comboBox1.Items.Add(reader1["Title"]);
                }

            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                conn.Open();
                string query2 = string.Format("Insert Into GroupProject values((Select Id from Project where Title='{0}'),{1},'{2}')", comboBox1.Text.ToString(), Id, DateTime.Now);
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
                object ob = null;
                EventArgs er = null;
                this.GroupProjects_Load(ob, er);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                
                    conn.Open();
                    string query = string.Format("Delete from GroupProject where GroupId={0} and ProjectId=(Select Id from Project where Title='{1}')", Id, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    object ob = null;
                    EventArgs er = null;
                    this.GroupProjects_Load(ob, er);
                
            }
        }
    }
}
