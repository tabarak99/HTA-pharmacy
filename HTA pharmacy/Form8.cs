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
     public partial class Form8 : Form
     {
          public Form8()
          {
               InitializeComponent();
          }
          SqlConnection cn8 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alnaseem\documents\visual studio 2012\Projects\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");
          private void button1_Click(object sender, EventArgs e)
          {

               cn8.Open();


               SqlCommand add = new SqlCommand("insert into HTA values("+ textBox3.Text +" ,'" + textBox1.Text + "'," + textBox2.Text + " )", cn8);
               add.ExecuteNonQuery();
              
                Form4 f4= new Form4();
               f4.Show();
               this.Hide();
               cn8.Close();
          }
          }
     }
