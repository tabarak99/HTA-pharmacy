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
namespace HTA_pharmacy
{
     public partial class Form6 : Form
     {
         public int z;
         
          public Form6()
          {
               InitializeComponent();
               cn6.Open();
               SqlDataAdapter da3 = new SqlDataAdapter("select * from HTA_P", cn6);
               DataTable dt3 = new DataTable();
               da3.Fill(dt3);
               dataGridView1.DataSource = dt3;
              
               
          }
          SqlConnection cn6 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");
          private void button1_Click(object sender, EventArgs e)
          {


              if (textBox1.Text == "")
              {
                   MessageBox.Show("Choose a drug from the table");
              }
              else { 


              string name = textBox1.Text;
              string value = textBox2.Text;
                
              SqlCommand mx = new SqlCommand("select Que from HTA_P where Name='" + textBox1.Text + "'", cn6);
              string get = mx.ExecuteScalar().ToString();
              int x = int.Parse(get);
              string get2 = textBox2.Text;
              int y = int.Parse(get2);
              if (x > y && y>0)  { 
               z = x-y;
               SqlCommand cmd = new SqlCommand("update HTA_P set Que =" + z + " where  Name='" + textBox1.Text + "'  ", cn6);
               cmd.ExecuteNonQuery();
               textBox3.Text = name + "        " + value;
               SqlDataAdapter da3 = new SqlDataAdapter("select * from HTA_P", cn6);
               DataTable dt3 = new DataTable();
               da3.Fill(dt3);
               dataGridView1.DataSource = dt3;
               textBox1.Text = "";
               textBox2.Text = "";
              }
              else if(x<y)
              {
                   MessageBox.Show("You do not have enough medication");
              }
              else
              {
                   MessageBox.Show(" Wrong number entered");
              }
           

              }
          }

          private void button2_Click(object sender, EventArgs e)
          {

               this.Hide();
               Form7 f7 = new Form7();
               f7.Show();
          }

          private void Form6_Load(object sender, EventArgs e)
          {

          }

          private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
          {
              if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
              {
                  dataGridView1.CurrentRow.Selected = true;
                  textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
              }
          }

          private void label3_Click(object sender, EventArgs e)
          {

          }

          private void button3_Click(object sender, EventArgs e)
          {
               this.Hide();
               Form4 f4 = new Form4();
               f4.Show();
          
          }

        
          
     }
}
