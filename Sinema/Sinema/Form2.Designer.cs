namespace Sinema
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
            tarihLabel = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            devamEtButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tarihLabel.Location = new Point(57, 49);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new Size(59, 28);
            tarihLabel.TabIndex = 0;
            tarihLabel.Text = "Tarih";
            tarihLabel.Click += label1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(72, 112);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 27);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "13.00";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(170, 112);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 27);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "15.00";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(265, 114);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(76, 27);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "17.00";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // devamEtButton
            // 
            devamEtButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            devamEtButton.Location = new Point(155, 205);
            devamEtButton.Name = "devamEtButton";
            devamEtButton.Size = new Size(190, 63);
            devamEtButton.TabIndex = 5;
            devamEtButton.Text = "Devam Et";
            devamEtButton.UseVisualStyleBackColor = true;
            devamEtButton.Click += devamEtButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(122, 51);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(399, 299);
            Controls.Add(dateTimePicker1);
            Controls.Add(devamEtButton);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(tarihLabel);
            Name = "Form2";
            Text = "Tarih ve Saat";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tarihLabel;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button devamEtButton;
        private DateTimePicker dateTimePicker1;
    }
}