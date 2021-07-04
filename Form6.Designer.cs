namespace HTA_pharmacy
{
     partial class Form6
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.button1 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(24, 62);
               this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowTemplate.Height = 26;
               this.dataGridView1.Size = new System.Drawing.Size(407, 450);
               this.dataGridView1.TabIndex = 0;
               this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(511, 74);
               this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(164, 24);
               this.textBox1.TabIndex = 1;
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(511, 148);
               this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(164, 24);
               this.textBox2.TabIndex = 2;
               // 
               // button1
               // 
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(526, 214);
               this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(314, 54);
               this.button1.TabIndex = 3;
               this.button1.Text = "Extract the quantity from the list";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(723, 74);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(51, 20);
               this.label1.TabIndex = 4;
               this.label1.Text = "Name";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(686, 148);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(250, 23);
               this.label2.TabIndex = 5;
               this.label2.Text = "Quantity needs to be reduced";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(599, 299);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(164, 23);
               this.label3.TabIndex = 6;
               this.label3.Text = "Quantity extracted";
               this.label3.Click += new System.EventHandler(this.label3_Click);
               // 
               // textBox3
               // 
               this.textBox3.Location = new System.Drawing.Point(588, 337);
               this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.textBox3.Multiline = true;
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(205, 146);
               this.textBox3.TabIndex = 7;
               // 
               // button2
               // 
               this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(816, 522);
               this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(91, 34);
               this.button2.TabIndex = 8;
               this.button2.Text = "Next";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(588, 522);
               this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(91, 34);
               this.button3.TabIndex = 9;
               this.button3.Text = "Back";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // Form6
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::HTA_pharmacy.Properties.Resources.photo_2021_05_23_19_53_221;
               this.ClientSize = new System.Drawing.Size(948, 601);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.dataGridView1);
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "Form6";
               this.Text = "Form6";
               this.Load += new System.EventHandler(this.Form6_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.TextBox textBox2;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox textBox3;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
     }
}