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
     public partial class Form7 : Form
     {
          public Form7()
          {
               InitializeComponent();
          }
          SqlConnection cn7 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\HTA pharmacy\HTA pharmacy\Database1.mdf;Integrated Security=True");
          private void Form7_Load(object sender, EventArgs e)
          {

          }

          private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
          {

          }

          private void button1_Click(object sender, EventArgs e)
          {
               cn7.Open();
               SqlDataAdapter da3 = new SqlDataAdapter("select * from HTA_P", cn7);
               DataTable dt3 = new DataTable();
               da3.Fill(dt3);
               dataGridView1.DataSource = dt3;
               dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
               
               cn7.Close();

          }

          private void fileToolStripMenuItem_Click(object sender, EventArgs e)
          {
               
            //بتن تحديد فتره 15 يوم
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                dt = DateTime.Now;
                com = 15;
                

                
               
                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }

        }

        private void شهرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //تحديد فتره صلاحية 1 شهر
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                dt = DateTime.Now;
                com = 30;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
               
                cn7.Close();
            }
        }

        private void شهرToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             //تحديد فتره صلاحية 2 شهر
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                dt = DateTime.Now;
                com = 60;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }
        }

        private void شهرToolStripMenuItem2_Click(object sender, EventArgs e)
        {
             //تحديد فتره صلاحية 3 شهر
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                dt = DateTime.Now;
                com = 90;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }
        }

        private void شهرToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //تحديد فتره صلاحية 4 شهر
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                dt = DateTime.Now;
                com = 120;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
               MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }
        }

        private void شهرToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //تحديد فتره صلاحية 5 شهر
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
               
                dt = DateTime.Now;
                com = 150;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
               
                cn7.Close();
            }
        }

        private void شهرToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //تحديد فتره صلاحية 6 شهر
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                dt = DateTime.Now;
                com = 180;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }
        }

        private void سنهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //تحديد فتره صلاحية 1 سنه
            int com;
            DateTime dt;
            try
            {
                cn7.Open();
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
               
                dt = DateTime.Now;
                com = 365;




                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now >= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }



                for (int i = 0; i < co; i++)
                {
                    TimeSpan dif = mat_stri[i] - dt;
                    if (dif.Days <= com)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                    }

                }
                cn7.Close();

            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }
        }

        private void showExpiredMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            
            //البتن الي تفتح المواد منتهيه الصلاحيه 
            try
            {

                cn7.Open();
              
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                

                DateTime dt = DateTime.Now;
                DateTime[] mat_stri = new DateTime[1000000];
                SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                SqlDataReader mo = jo.ExecuteReader();
                int co = 0;
                while (mo.Read())
                {
                    mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                    co++;

                }
                mo.Close();

                for (int i = 0; i < co; i++)
                {

                    if (DateTime.Now <= mat_stri[i])
                    {
                        dataGridView1.CurrentCell = null;
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                        currencyManager1.SuspendBinding();
                        dataGridView1.Rows[i].Visible = false;

                    }

                }
                cn7.Close();
            }
            catch
            {
                cn7.Close();
                cn7.Open();
                MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                
                cn7.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Hide();
             Form4 f4 = new Form4();
             f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Form9 f9 = new Form9();
             f9.Show();
             this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
             //بتن تحديد فتره 15 يوم
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 15;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }

        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 30;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        private void monthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 60;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        private void monthToolStripMenuItem2_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 90;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        private void monthToolStripMenuItem3_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 150;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        private void monthToolStripMenuItem4_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 150;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        private void monthToolStripMenuItem5_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 180;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
             int com;
             DateTime dt;
             try
             {
                  cn7.Open();
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  dt = DateTime.Now;
                  com = 360;




                  DateTime[] mat_stri = new DateTime[1000000];
                  SqlCommand jo = new SqlCommand("select * from HTA_P", cn7);
                  SqlDataReader mo = jo.ExecuteReader();
                  int co = 0;
                  while (mo.Read())
                  {
                       mat_stri[co] = DateTime.Parse(mo[2] + "".ToString());
                       co++;

                  }
                  mo.Close();

                  for (int i = 0; i < co; i++)
                  {

                       if (DateTime.Now >= mat_stri[i])
                       {
                            dataGridView1.CurrentCell = null;
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridView1.Rows[i].Visible = false;

                       }

                  }



                  for (int i = 0; i < co; i++)
                  {
                       TimeSpan dif = mat_stri[i] - dt;
                       if (dif.Days <= com)
                       {
                            dataGridView1.Rows[i].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkTurquoise;

                       }

                  }
                  cn7.Close();

             }
             catch
             {
                  cn7.Close();
                  cn7.Open();
                  MessageBox.Show("حصل خطأ ما يرجى اعادة المحاوله");
                  SqlDataAdapter da2 = new SqlDataAdapter("select * from HTA_P", cn7);
                  DataTable dt2 = new DataTable();
                  da2.Fill(dt2);
                  dataGridView1.DataSource = dt2;

                  cn7.Close();
             }
        }

        }

          }

         
     

