namespace HTA_pharmacy
{
     partial class Form9
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
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(463, 358);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(119, 58);
               this.button1.TabIndex = 0;
               this.button1.Text = "CLOSE";
               this.button1.UseVisualStyleBackColor = true;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::HTA_pharmacy.Properties.Resources.photo_2021_05_18_20_16_44;
               this.pictureBox1.Location = new System.Drawing.Point(354, 95);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(334, 139);
               this.pictureBox1.TabIndex = 1;
               this.pictureBox1.TabStop = false;
               // 
               // Form9
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = global::HTA_pharmacy.Properties.Resources.photo_2021_05_23_19_53_221;
               this.ClientSize = new System.Drawing.Size(771, 563);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.button1);
               this.Name = "Form9";
               this.Text = "Form9";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.PictureBox pictureBox1;
     }
}