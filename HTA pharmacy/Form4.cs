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
     public partial class Form4 : Form
     {
          public Form4()
          {
               InitializeComponent();
          }
          SqlConnection cn4 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alnaseem\documents\visual studio 2012\Projects\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");
          private void button1_Click(object sender, EventArgs e)
          {
               Form3 f3= new Form3();
               f3.Show();
               this.Hide();
               
               }

          private void button2_Click(object sender, EventArgs e)
          {

               Form6 f6 = new Form6();
               f6.Show();
               this.Hide();

          }

          private void button3_Click(object sender, EventArgs e)
          {
               Form7 f7 = new Form7();
               f7.Show();
               this.Hide();
          }
          }
     }

