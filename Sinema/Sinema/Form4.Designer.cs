namespace Sinema
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
            adLabel = new Label();
            sifreLabel = new Label();
            adTextBox = new TextBox();
            sifreTextBox = new TextBox();
            girisButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            adLabel.Location = new Point(43, 52);
            adLabel.Name = "adLabel";
            adLabel.Size = new Size(100, 20);
            adLabel.TabIndex = 0;
            adLabel.Text = "Kullanıcı Adı:";
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            sifreLabel.Location = new Point(96, 87);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new Size(45, 20);
            sifreLabel.TabIndex = 1;
            sifreLabel.Text = "Şifre:";
            // 
            // adTextBox
            // 
            adTextBox.Location = new Point(144, 49);
            adTextBox.Name = "adTextBox";
            adTextBox.Size = new Size(125, 27);
            adTextBox.TabIndex = 2;
            // 
            // sifreTextBox
            // 
            sifreTextBox.Location = new Point(144, 87);
            sifreTextBox.Name = "sifreTextBox";
            sifreTextBox.Size = new Size(125, 27);
            sifreTextBox.TabIndex = 3;
            sifreTextBox.UseSystemPasswordChar = true;
            // 
            // girisButton
            // 
            girisButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            girisButton.Location = new Point(144, 134);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(94, 29);
            girisButton.TabIndex = 4;
            girisButton.Text = "Giriş Yap";
            girisButton.UseVisualStyleBackColor = true;
            girisButton.Click += girisButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(275, 94);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 5;
            label1.Text = "Şifre: admin";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 205);
            Controls.Add(label1);
            Controls.Add(girisButton);
            Controls.Add(sifreTextBox);
            Controls.Add(adTextBox);
            Controls.Add(sifreLabel);
            Controls.Add(adLabel);
            Name = "Form4";
            Text = "Admin";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adLabel;
        private Label sifreLabel;
        private TextBox adTextBox;
        private TextBox sifreTextBox;
        private Button girisButton;
        private Label label1;
    }
}