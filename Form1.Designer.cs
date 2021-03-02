
namespace RekenMachineUI
{
    partial class frmHoofdscherm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoofdscherm));
            this.txbGetal1 = new System.Windows.Forms.TextBox();
            this.txbGetal2 = new System.Windows.Forms.TextBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDeel = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnKeer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultText = new System.Windows.Forms.Label();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBTW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbGetal1
            // 
            this.txbGetal1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbGetal1.Location = new System.Drawing.Point(353, 235);
            this.txbGetal1.Name = "txbGetal1";
            this.txbGetal1.Size = new System.Drawing.Size(250, 26);
            this.txbGetal1.TabIndex = 0;
            // 
            // txbGetal2
            // 
            this.txbGetal2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbGetal2.Location = new System.Drawing.Point(353, 282);
            this.txbGetal2.Name = "txbGetal2";
            this.txbGetal2.Size = new System.Drawing.Size(250, 26);
            this.txbGetal2.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMin.Location = new System.Drawing.Point(353, 332);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDeel
            // 
            this.btnDeel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeel.Location = new System.Drawing.Point(449, 332);
            this.btnDeel.Name = "btnDeel";
            this.btnDeel.Size = new System.Drawing.Size(30, 30);
            this.btnDeel.TabIndex = 4;
            this.btnDeel.Text = "/";
            this.btnDeel.UseVisualStyleBackColor = true;
            this.btnDeel.Click += new System.EventHandler(this.btnDeel_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(400, 332);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 30);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnKeer
            // 
            this.btnKeer.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKeer.Location = new System.Drawing.Point(498, 333);
            this.btnKeer.Name = "btnKeer";
            this.btnKeer.Size = new System.Drawing.Size(30, 30);
            this.btnKeer.TabIndex = 5;
            this.btnKeer.Text = "*";
            this.btnKeer.UseVisualStyleBackColor = true;
            this.btnKeer.Click += new System.EventHandler(this.btnKeer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Geef hier het bedrag in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Geef hier het btw percentage in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Klik op de berekening";
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Location = new System.Drawing.Point(219, 390);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(88, 15);
            this.lblResultText.TabIndex = 9;
            this.lblResultText.Text = "Het resultaat is:";
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(353, 390);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(55, 15);
            this.lblResultaat.TabIndex = 10;
            this.lblResultaat.Text = "Resultaat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnBTW
            // 
            this.btnBTW.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBTW.Location = new System.Drawing.Point(556, 333);
            this.btnBTW.Name = "btnBTW";
            this.btnBTW.Size = new System.Drawing.Size(47, 30);
            this.btnBTW.TabIndex = 12;
            this.btnBTW.Text = "btw";
            this.btnBTW.UseVisualStyleBackColor = true;
            this.btnBTW.Click += new System.EventHandler(this.btnBTW_Click);
            // 
            // frmHoofdscherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBTW);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.lblResultText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeer);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDeel);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.txbGetal2);
            this.Controls.Add(this.txbGetal1);
            this.Name = "frmHoofdscherm";
            this.Text = "Rekenmachine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbGetal1;
        private System.Windows.Forms.TextBox txbGetal2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnDeel;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnKeer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBTW;
    }
}

