namespace asansor
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_hpsyolla = new System.Windows.Forms.Button();
            this.btn_yolla = new System.Windows.Forms.Button();
            this.btn_gerial = new System.Windows.Forms.Button();
            this.btn_hpsgerial = new System.Windows.Forms.Button();
            this.btn_sayıat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(405, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Turquoise;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(46, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(106, 251);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Turquoise;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(274, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(106, 251);
            this.listBox2.TabIndex = 2;
            // 
            // btn_hpsyolla
            // 
            this.btn_hpsyolla.BackColor = System.Drawing.Color.LightCoral;
            this.btn_hpsyolla.Location = new System.Drawing.Point(172, 73);
            this.btn_hpsyolla.Name = "btn_hpsyolla";
            this.btn_hpsyolla.Size = new System.Drawing.Size(75, 23);
            this.btn_hpsyolla.TabIndex = 3;
            this.btn_hpsyolla.Text = ">>";
            this.btn_hpsyolla.UseVisualStyleBackColor = false;
            this.btn_hpsyolla.Click += new System.EventHandler(this.btn_hpsyolla_Click);
            // 
            // btn_yolla
            // 
            this.btn_yolla.BackColor = System.Drawing.Color.LightCoral;
            this.btn_yolla.Location = new System.Drawing.Point(172, 116);
            this.btn_yolla.Name = "btn_yolla";
            this.btn_yolla.Size = new System.Drawing.Size(75, 23);
            this.btn_yolla.TabIndex = 4;
            this.btn_yolla.Text = ">";
            this.btn_yolla.UseVisualStyleBackColor = false;
            this.btn_yolla.Click += new System.EventHandler(this.btn_yolla_Click);
            // 
            // btn_gerial
            // 
            this.btn_gerial.BackColor = System.Drawing.Color.LightCoral;
            this.btn_gerial.Location = new System.Drawing.Point(172, 159);
            this.btn_gerial.Name = "btn_gerial";
            this.btn_gerial.Size = new System.Drawing.Size(75, 23);
            this.btn_gerial.TabIndex = 5;
            this.btn_gerial.Text = "<";
            this.btn_gerial.UseVisualStyleBackColor = false;
            this.btn_gerial.Click += new System.EventHandler(this.btn_gerial_Click);
            // 
            // btn_hpsgerial
            // 
            this.btn_hpsgerial.BackColor = System.Drawing.Color.LightCoral;
            this.btn_hpsgerial.Location = new System.Drawing.Point(172, 213);
            this.btn_hpsgerial.Name = "btn_hpsgerial";
            this.btn_hpsgerial.Size = new System.Drawing.Size(75, 23);
            this.btn_hpsgerial.TabIndex = 6;
            this.btn_hpsgerial.Text = "<<";
            this.btn_hpsgerial.UseVisualStyleBackColor = false;
            this.btn_hpsgerial.Click += new System.EventHandler(this.btn_hpsgerial_Click);
            // 
            // btn_sayıat
            // 
            this.btn_sayıat.BackColor = System.Drawing.Color.LightCyan;
            this.btn_sayıat.Location = new System.Drawing.Point(172, 296);
            this.btn_sayıat.Name = "btn_sayıat";
            this.btn_sayıat.Size = new System.Drawing.Size(75, 23);
            this.btn_sayıat.TabIndex = 7;
            this.btn_sayıat.Text = "Oluştur";
            this.btn_sayıat.UseVisualStyleBackColor = false;
            this.btn_sayıat.Click += new System.EventHandler(this.btn_sayıat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.btn_sayıat);
            this.Controls.Add(this.btn_hpsgerial);
            this.Controls.Add(this.btn_gerial);
            this.Controls.Add(this.btn_yolla);
            this.Controls.Add(this.btn_hpsyolla);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_hpsyolla;
        private System.Windows.Forms.Button btn_yolla;
        private System.Windows.Forms.Button btn_gerial;
        private System.Windows.Forms.Button btn_hpsgerial;
        private System.Windows.Forms.Button btn_sayıat;
    }
}