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
     public partial class Form2 : Form
     {
          public Form2()
          {
               InitializeComponent();
          }
          SqlConnection cn2 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alnaseem\documents\visual studio 2012\Projects\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");
          private void Form2_Load(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               //تسجيل الدخول الاسم والرمز موجود بجدول البيانات 
               {
                    cn2.Open();
                    SqlDataReader r;
                    SqlCommand red = new SqlCommand("select * from HTA  where username='" + textBox1.Text + "'and password=" + textBox2.Text + " ", cn2);
                    r = red.ExecuteReader();
                    if (r.HasRows)
                    {
                         Form4 f4 = new Form4();
                         f4.Show();
                         this.Hide();
                    }
                    else if (r.HasRows == false)
                    {
                         MessageBox.Show("You enter your username or password wrong ?! ");
                    }
                    r.Close();
                    cn2.Close();


               }
          }

          private void button2_Click(object sender, EventArgs e)
          {
               //this.Hide();
               //Form4 f4 = new Form4();
               //f4.Show();

               
          }

          private void button2_Click_1(object sender, EventArgs e)
          {

               this.Hide();
               Form5 f5 = new Form5();
               f5.Show();
          }
     }
     
}
