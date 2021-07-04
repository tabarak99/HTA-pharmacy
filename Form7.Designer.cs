namespace HTA_pharmacy
{
     partial class Form7
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
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.dayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.monthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.monthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
               this.monthToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
               this.monthToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
               this.monthToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
               this.monthToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
               this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.menuStrip2 = new System.Windows.Forms.MenuStrip();
               this.showExpiredMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.menuStrip1.SuspendLayout();
               this.menuStrip2.SuspendLayout();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Location = new System.Drawing.Point(68, 125);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowTemplate.Height = 26;
               this.dataGridView1.Size = new System.Drawing.Size(400, 302);
               this.dataGridView1.TabIndex = 0;
               // 
               // menuStrip1
               // 
               this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 31);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
               this.menuStrip1.Size = new System.Drawing.Size(858, 31);
               this.menuStrip1.TabIndex = 1;
               this.menuStrip1.Text = "menuStrip1";
               this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dayToolStripMenuItem,
            this.monthToolStripMenuItem,
            this.monthToolStripMenuItem1,
            this.monthToolStripMenuItem2,
            this.monthToolStripMenuItem3,
            this.monthToolStripMenuItem4,
            this.monthToolStripMenuItem5,
            this.yearToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(452, 27);
               this.fileToolStripMenuItem.Text = "Determine a specific period of expired of medicines";
               this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
               // 
               // dayToolStripMenuItem
               // 
               this.dayToolStripMenuItem.Name = "dayToolStripMenuItem";
               this.dayToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
               this.dayToolStripMenuItem.Text = "15 day";
               this.dayToolStripMenuItem.Click += new System.EventHandler(this.dayToolStripMenuItem_Click);
               // 
               // monthToolStripMenuItem
               // 
               this.monthToolStripMenuItem.Name = "monthToolStripMenuItem";
               this.monthToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
               this.monthToolStripMenuItem.Text = "1 month";
               this.monthToolStripMenuItem.Click += new System.EventHandler(this.monthToolStripMenuItem_Click);
               // 
               // monthToolStripMenuItem1
               // 
               this.monthToolStripMenuItem1.Name = "monthToolStripMenuItem1";
               this.monthToolStripMenuItem1.Size = new System.Drawing.Size(152, 28);
               this.monthToolStripMenuItem1.Text = "2 month";
               this.monthToolStripMenuItem1.Click += new System.EventHandler(this.monthToolStripMenuItem1_Click);
               // 
               // monthToolStripMenuItem2
               // 
               this.monthToolStripMenuItem2.Name = "monthToolStripMenuItem2";
               this.monthToolStripMenuItem2.Size = new System.Drawing.Size(152, 28);
               this.monthToolStripMenuItem2.Text = "3 month";
               this.monthToolStripMenuItem2.Click += new System.EventHandler(this.monthToolStripMenuItem2_Click);
               // 
               // monthToolStripMenuItem3
               // 
               this.monthToolStripMenuItem3.Name = "monthToolStripMenuItem3";
               this.monthToolStripMenuItem3.Size = new System.Drawing.Size(152, 28);
               this.monthToolStripMenuItem3.Text = "4 month";
               this.monthToolStripMenuItem3.Click += new System.EventHandler(this.monthToolStripMenuItem3_Click);
               // 
               // monthToolStripMenuItem4
               // 
               this.monthToolStripMenuItem4.Name = "monthToolStripMenuItem4";
               this.monthToolStripMenuItem4.Size = new System.Drawing.Size(152, 28);
               this.monthToolStripMenuItem4.Text = "5 month";
               this.monthToolStripMenuItem4.Click += new System.EventHandler(this.monthToolStripMenuItem4_Click);
               // 
               // monthToolStripMenuItem5
               // 
               this.monthToolStripMenuItem5.Name = "monthToolStripMenuItem5";
               this.monthToolStripMenuItem5.Size = new System.Drawing.Size(152, 28);
               this.monthToolStripMenuItem5.Text = "6 month";
               this.monthToolStripMenuItem5.Click += new System.EventHandler(this.monthToolStripMenuItem5_Click);
               // 
               // yearToolStripMenuItem
               // 
               this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
               this.yearToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
               this.yearToolStripMenuItem.Text = "1 year";
               this.yearToolStripMenuItem.Click += new System.EventHandler(this.yearToolStripMenuItem_Click);
               // 
               // menuStrip2
               // 
               this.menuStrip2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showExpiredMedicineToolStripMenuItem});
               this.menuStrip2.Location = new System.Drawing.Point(0, 0);
               this.menuStrip2.Name = "menuStrip2";
               this.menuStrip2.Size = new System.Drawing.Size(858, 31);
               this.menuStrip2.TabIndex = 2;
               this.menuStrip2.Text = "menuStrip2";
               this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
               // 
               // showExpiredMedicineToolStripMenuItem
               // 
               this.showExpiredMedicineToolStripMenuItem.Name = "showExpiredMedicineToolStripMenuItem";
               this.showExpiredMedicineToolStripMenuItem.Size = new System.Drawing.Size(216, 27);
               this.showExpiredMedicineToolStripMenuItem.Text = "Show expired medicine";
               this.showExpiredMedicineToolStripMenuItem.Click += new System.EventHandler(this.showExpiredMedicineToolStripMenuItem_Click);
               // 
               // button1
               // 
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(570, 235);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(102, 38);
               this.button1.TabIndex = 3;
               this.button1.Text = "Display";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(570, 484);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(102, 38);
               this.button2.TabIndex = 4;
               this.button2.Text = "Back";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(718, 416);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(102, 38);
               this.button3.TabIndex = 5;
               this.button3.Text = "Next";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // Form7
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::HTA_pharmacy.Properties.Resources.photo_2021_05_23_19_53_221;
               this.ClientSize = new System.Drawing.Size(858, 566);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Controls.Add(this.dataGridView1);
               this.Controls.Add(this.menuStrip1);
               this.Controls.Add(this.menuStrip2);
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "Form7";
               this.Text = "Form7";
               this.Load += new System.EventHandler(this.Form7_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.menuStrip2.ResumeLayout(false);
               this.menuStrip2.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.MenuStrip menuStrip1;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem dayToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem1;
          private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem2;
          private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem3;
          private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem4;
          private System.Windows.Forms.ToolStripMenuItem monthToolStripMenuItem5;
          private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
          private System.Windows.Forms.MenuStrip menuStrip2;
          private System.Windows.Forms.ToolStripMenuItem showExpiredMedicineToolStripMenuItem;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;

     }
}