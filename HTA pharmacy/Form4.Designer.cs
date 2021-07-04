namespace HTA_pharmacy
{
     partial class Form4
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
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(247, 196);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(171, 44);
               this.button1.TabIndex = 4;
               this.button1.Text = "Add medicine";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(247, 283);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(174, 44);
               this.button2.TabIndex = 5;
               this.button2.Text = "Selling a medicine";
               this.button2.UseVisualStyleBackColor = true;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // button3
               // 
               this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button3.Location = new System.Drawing.Point(212, 372);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(232, 44);
               this.button3.TabIndex = 6;
               this.button3.Text = "The expiry date of the medicine";
               this.button3.UseVisualStyleBackColor = true;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::HTA_pharmacy.Properties.Resources.photo_2021_05_18_20_16_44;
               this.pictureBox1.Location = new System.Drawing.Point(176, 12);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(316, 160);
               this.pictureBox1.TabIndex = 7;
               this.pictureBox1.TabStop = false;
               // 
               // Form4
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.LightBlue;
               this.ClientSize = new System.Drawing.Size(696, 457);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.Name = "Form4";
               this.Text = "Form4";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.PictureBox pictureBox1;
     }
}