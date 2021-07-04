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
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }
          SqlConnection cn1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\alnaseem\documents\visual studio 2012\Projects\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");

          private void button1_Click(object sender, EventArgs e)
          {
               //بتن الانتقال الى الواجهة الثانية 
               this.Hide();
               Form2 f2 = new Form2();
               f2.Show();
          }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
