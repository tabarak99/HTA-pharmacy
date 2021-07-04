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
     public partial class Form5 : Form
     {
          public Form5()
          {
               InitializeComponent();
          }
          
          SqlConnection cn5 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alnaseem\documents\visual studio 2012\Projects\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");
          private void Form5_Load(object sender, EventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               if (textBox1.Text == "HTA99" && textBox2.Text == "1234")
               {
                    Form8 f8 = new Form8();
                    f8.Show();
                    this.Hide();
               }
               else
               {
                    MessageBox.Show("You enter your username or password wrong ?! ");
               }

               }
          }
     }

