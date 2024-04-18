namespace SteamAplication
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(114, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(114, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(117, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 21);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(192)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(316, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(95, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "Can\' t sign in";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(425, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Create a Free account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(117, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(479, 30);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Verdana", 15.75F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(117, 206);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(479, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sign In";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.pictureBox2.Location = new System.Drawing.Point(77, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(565, 323);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SteamAplication.Properties.Resources.Header_1;
            this.ClientSize = new System.Drawing.Size(780, 497);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "STEAM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

