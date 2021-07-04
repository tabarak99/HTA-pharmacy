using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HTA_pharmacy
{
     public partial class Form3 : Form
     {
          public Form3()
          {
               InitializeComponent();
          }
          SqlConnection cn3 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");

          private void toolStripLabel2_Click(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               cn3.Open();
               dataGridView1.Show();
               SqlDataAdapter da = new SqlDataAdapter("select * from HTA_P", cn3);
               DataTable dt = new DataTable();
               da.Fill(dt);
               dataGridView1.DataSource = dt;
               cn3.Close();
          }

          private void button2_Click(object sender, EventArgs e)
          {

               cn3.Open();
               if (textBox1.Text == "")
               {
                    MessageBox.Show("Fill in the field first");
               }
               else
               {
                    SqlCommand add = new SqlCommand("insert into HTA_P values('" + textBox1.Text + "'," + textBox2.Text + ",'" + dateTimePicker1.Text + "')", cn3);
                    add.ExecuteNonQuery();
                    MessageBox.Show("You add a new value correctly .");
                    cn3.Close();
               }
          }

          private void button3_Click(object sender, EventArgs e)
          {
               cn3.Open();
               if (textBox1.Text == "")
               {
                    MessageBox.Show("Fill in the field first");
               }
               else{

                    SqlCommand update = new SqlCommand("update HTA_P set Exe_Date='" + dateTimePicker1.Text + "', Que =" + textBox2.Text + "where name ='" + textBox1.Text + "'", cn3);
               update.ExecuteNonQuery();
               MessageBox.Show("You update a new value corrctly .");
               cn3.Close();
          }
     }

          private void button4_Click(object sender, EventArgs e)
          {
               if (textBox1.Text == "")
               {
                    MessageBox.Show("Fill in the field first");
               }
               else
               {
                    cn3.Open();
                    SqlCommand delete = new SqlCommand("delete from HTA_P where name ='" + textBox1.Text + "'", cn3);
                    delete.ExecuteNonQuery();
                    MessageBox.Show("You delete a value from table corrctly .");
                    cn3.Close();

               }
          }

          private void Form3_Load(object sender, EventArgs e)
          {
               dataGridView1.Hide();
          }

          private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
          {

          }

          private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
          {

          }

          private void button5_Click(object sender, EventArgs e)
          {

               this.Hide();
               Form6 f6 = new Form6();
               f6.Show();

          }

          private void button6_Click(object sender, EventArgs e)
          {
               this.Hide();
               Form4 f4 = new Form4();
               f4.Show();
          }

          
     }
}
