namespace Sinema
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            filmBox1 = new PictureBox();
            filmBox2 = new PictureBox();
            filmBox3 = new PictureBox();
            button1 = new Button();
            filmLabel1 = new LinkLabel();
            filmLabel2 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();
            adminButton = new Button();
            filmLabel3 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)filmBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBox3).BeginInit();
            SuspendLayout();
            // 
            // filmBox1
            // 
            filmBox1.Image = (Image)resources.GetObject("filmBox1.Image");
            filmBox1.Location = new Point(78, 91);
            filmBox1.Name = "filmBox1";
            filmBox1.Size = new Size(211, 306);
            filmBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            filmBox1.TabIndex = 0;
            filmBox1.TabStop = false;
            // 
            // filmBox2
            // 
            filmBox2.BackgroundImage = (Image)resources.GetObject("filmBox2.BackgroundImage");
            filmBox2.BackgroundImageLayout = ImageLayout.Stretch;
            filmBox2.Location = new Point(347, 91);
            filmBox2.Name = "filmBox2";
            filmBox2.Size = new Size(211, 306);
            filmBox2.TabIndex = 1;
            filmBox2.TabStop = false;
            // 
            // filmBox3
            // 
            filmBox3.BackgroundImage = Properties.Resources.The_Green_Mile;
            filmBox3.BackgroundImageLayout = ImageLayout.Stretch;
            filmBox3.Location = new Point(604, 91);
            filmBox3.Name = "filmBox3";
            filmBox3.Size = new Size(211, 306);
            filmBox3.TabIndex = 2;
            filmBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(82, 422);
            button1.Name = "button1";
            button1.Size = new Size(207, 29);
            button1.TabIndex = 3;
            button1.Text = "Seç";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // filmLabel1
            // 
            filmLabel1.AutoSize = true;
            filmLabel1.BackColor = SystemColors.Control;
            filmLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filmLabel1.LinkColor = Color.Black;
            filmLabel1.Location = new Point(136, 68);
            filmLabel1.Name = "filmLabel1";
            filmLabel1.Size = new Size(94, 20);
            filmLabel1.TabIndex = 4;
            filmLabel1.TabStop = true;
            filmLabel1.Text = "The Batman";
            filmLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // filmLabel2
            // 
            filmLabel2.AutoSize = true;
            filmLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filmLabel2.LinkColor = Color.Black;
            filmLabel2.Location = new Point(410, 68);
            filmLabel2.Name = "filmLabel2";
            filmLabel2.Size = new Size(89, 20);
            filmLabel2.TabIndex = 5;
            filmLabel2.TabStop = true;
            filmLabel2.Text = "Star Wars 3";
            filmLabel2.LinkClicked += filmLabel2_LinkClicked;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(351, 422);
            button2.Name = "button2";
            button2.Size = new Size(207, 29);
            button2.TabIndex = 6;
            button2.Text = "Seç";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(608, 422);
            button3.Name = "button3";
            button3.Size = new Size(207, 29);
            button3.TabIndex = 7;
            button3.Text = "Seç";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // adminButton
            // 
            adminButton.BackColor = SystemColors.Control;
            adminButton.BackgroundImage = Properties.Resources.admin;
            adminButton.BackgroundImageLayout = ImageLayout.Stretch;
            adminButton.ForeColor = SystemColors.Control;
            adminButton.Location = new Point(818, 12);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(94, 56);
            adminButton.TabIndex = 8;
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            // 
            // filmLabel3
            // 
            filmLabel3.AutoSize = true;
            filmLabel3.BackColor = SystemColors.Control;
            filmLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            filmLabel3.LinkColor = Color.Black;
            filmLabel3.Location = new Point(659, 68);
            filmLabel3.Name = "filmLabel3";
            filmLabel3.Size = new Size(115, 20);
            filmLabel3.TabIndex = 9;
            filmLabel3.TabStop = true;
            filmLabel3.Text = "The Green Mile";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 535);
            Controls.Add(filmLabel3);
            Controls.Add(adminButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(filmLabel2);
            Controls.Add(filmLabel1);
            Controls.Add(button1);
            Controls.Add(filmBox3);
            Controls.Add(filmBox2);
            Controls.Add(filmBox1);
            Name = "Form1";
            Text = "Filmler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)filmBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox filmBox1;
        private PictureBox filmBox2;
        private PictureBox filmBox3;
        private Button button1;
        private LinkLabel filmLabel1;
        private LinkLabel filmLabel2;
        private Button button2;
        private Button button3;
        private Button adminButton;
        private LinkLabel filmLabel3;
    }
}