using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grading_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Total # of Items";
            dataGridView1.Columns[2].Name = "Score";
            dataGridView1.Columns[3].Name = "Status";
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt_name = txtbox_name.Text;
            string txt_items = txtbox_item.Text;
            string txt_score = txtbox_score.Text;
            string status;

            if (txt_name.Length == 0 && txt_items.Length == 0 && txt_score.Length == 0)
            {
                MessageBox.Show("Please enter something first!");
            }
            else {
                int item = int.Parse(txt_items);
                int score = int.Parse(txt_score);

                double average = (double)score/(double)item;
                double final = (double)average * 100;

                if (final <= 75)
                {
                    status="Failed";
                }
                else
                {

                    status="Passed";
                }
                string[] student_row = new string[] { txt_name, txt_items, txt_score, status };
                dataGridView1.Rows.Add(student_row);

                txtbox_name.Text = "";
                txtbox_item.Text = "";
                txtbox_score.Text = "";
            }
        }
    }
}
