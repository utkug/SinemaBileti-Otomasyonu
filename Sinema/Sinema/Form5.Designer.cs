namespace Sinema
{
    partial class Form5
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            idTextBox = new TextBox();
            idLabel = new Label();
            ucretTextBox = new TextBox();
            ucretLabel = new Label();
            guncelleButton = new Button();
            silButton = new Button();
            ekleButton = new Button();
            koltuk4TextBox = new TextBox();
            koltuk3TextBox = new TextBox();
            koltuk2TextBox = new TextBox();
            koltuk1TextBox = new TextBox();
            koltuk4Label = new Label();
            koltuk3Label = new Label();
            koltuk2Label = new Label();
            koltuk1Label = new Label();
            saatTextBox = new TextBox();
            tarihTextBox = new TextBox();
            filmTextBox = new TextBox();
            isimTextBox = new TextBox();
            isimLabel = new Label();
            tarihLabel = new Label();
            saatLabel = new Label();
            filmLabel = new Label();
            biletlerDataGridView = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)biletlerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(878, 609);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(idTextBox);
            tabPage1.Controls.Add(idLabel);
            tabPage1.Controls.Add(ucretTextBox);
            tabPage1.Controls.Add(ucretLabel);
            tabPage1.Controls.Add(guncelleButton);
            tabPage1.Controls.Add(silButton);
            tabPage1.Controls.Add(ekleButton);
            tabPage1.Controls.Add(koltuk4TextBox);
            tabPage1.Controls.Add(koltuk3TextBox);
            tabPage1.Controls.Add(koltuk2TextBox);
            tabPage1.Controls.Add(koltuk1TextBox);
            tabPage1.Controls.Add(koltuk4Label);
            tabPage1.Controls.Add(koltuk3Label);
            tabPage1.Controls.Add(koltuk2Label);
            tabPage1.Controls.Add(koltuk1Label);
            tabPage1.Controls.Add(saatTextBox);
            tabPage1.Controls.Add(tarihTextBox);
            tabPage1.Controls.Add(filmTextBox);
            tabPage1.Controls.Add(isimTextBox);
            tabPage1.Controls.Add(isimLabel);
            tabPage1.Controls.Add(tarihLabel);
            tabPage1.Controls.Add(saatLabel);
            tabPage1.Controls.Add(filmLabel);
            tabPage1.Controls.Add(biletlerDataGridView);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(870, 576);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Biletler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(127, 263);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 24;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.Location = new Point(90, 267);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(31, 23);
            idLabel.TabIndex = 23;
            idLabel.Text = "id:";
            // 
            // ucretTextBox
            // 
            ucretTextBox.Location = new Point(127, 474);
            ucretTextBox.Name = "ucretTextBox";
            ucretTextBox.Size = new Size(125, 27);
            ucretTextBox.TabIndex = 22;
            // 
            // ucretLabel
            // 
            ucretLabel.AutoSize = true;
            ucretLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ucretLabel.Location = new Point(39, 475);
            ucretLabel.Name = "ucretLabel";
            ucretLabel.Size = new Size(82, 23);
            ucretLabel.TabIndex = 21;
            ucretLabel.Text = "Ücret TL:";
            // 
            // guncelleButton
            // 
            guncelleButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guncelleButton.Location = new Point(482, 513);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(120, 55);
            guncelleButton.TabIndex = 19;
            guncelleButton.Text = "Güncelle";
            guncelleButton.UseVisualStyleBackColor = true;
            guncelleButton.Click += guncelleButton_Click;
            // 
            // silButton
            // 
            silButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            silButton.Location = new Point(340, 513);
            silButton.Name = "silButton";
            silButton.Size = new Size(120, 55);
            silButton.TabIndex = 18;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = true;
            silButton.Click += silButton_Click;
            // 
            // ekleButton
            // 
            ekleButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ekleButton.Location = new Point(191, 512);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(120, 55);
            ekleButton.TabIndex = 17;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += ekleButton_Click;
            // 
            // koltuk4TextBox
            // 
            koltuk4TextBox.Location = new Point(526, 442);
            koltuk4TextBox.Name = "koltuk4TextBox";
            koltuk4TextBox.Size = new Size(125, 27);
            koltuk4TextBox.TabIndex = 16;
            // 
            // koltuk3TextBox
            // 
            koltuk3TextBox.Location = new Point(526, 394);
            koltuk3TextBox.Name = "koltuk3TextBox";
            koltuk3TextBox.Size = new Size(125, 27);
            koltuk3TextBox.TabIndex = 15;
            // 
            // koltuk2TextBox
            // 
            koltuk2TextBox.Location = new Point(526, 348);
            koltuk2TextBox.Name = "koltuk2TextBox";
            koltuk2TextBox.Size = new Size(125, 27);
            koltuk2TextBox.TabIndex = 14;
            // 
            // koltuk1TextBox
            // 
            koltuk1TextBox.Location = new Point(526, 306);
            koltuk1TextBox.Name = "koltuk1TextBox";
            koltuk1TextBox.Size = new Size(125, 27);
            koltuk1TextBox.TabIndex = 13;
            // 
            // koltuk4Label
            // 
            koltuk4Label.AutoSize = true;
            koltuk4Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            koltuk4Label.Location = new Point(437, 442);
            koltuk4Label.Name = "koltuk4Label";
            koltuk4Label.Size = new Size(83, 23);
            koltuk4Label.TabIndex = 12;
            koltuk4Label.Text = "Koltuk 4:";
            // 
            // koltuk3Label
            // 
            koltuk3Label.AutoSize = true;
            koltuk3Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            koltuk3Label.Location = new Point(437, 398);
            koltuk3Label.Name = "koltuk3Label";
            koltuk3Label.Size = new Size(83, 23);
            koltuk3Label.TabIndex = 11;
            koltuk3Label.Text = "Koltuk 3:";
            // 
            // koltuk2Label
            // 
            koltuk2Label.AutoSize = true;
            koltuk2Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            koltuk2Label.Location = new Point(437, 352);
            koltuk2Label.Name = "koltuk2Label";
            koltuk2Label.Size = new Size(83, 23);
            koltuk2Label.TabIndex = 10;
            koltuk2Label.Text = "Koltuk 2:";
            // 
            // koltuk1Label
            // 
            koltuk1Label.AutoSize = true;
            koltuk1Label.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            koltuk1Label.Location = new Point(437, 306);
            koltuk1Label.Name = "koltuk1Label";
            koltuk1Label.Size = new Size(83, 23);
            koltuk1Label.TabIndex = 9;
            koltuk1Label.Text = "Koltuk 1:";
            // 
            // saatTextBox
            // 
            saatTextBox.Location = new Point(127, 435);
            saatTextBox.Name = "saatTextBox";
            saatTextBox.Size = new Size(125, 27);
            saatTextBox.TabIndex = 8;
            // 
            // tarihTextBox
            // 
            tarihTextBox.Location = new Point(127, 393);
            tarihTextBox.Name = "tarihTextBox";
            tarihTextBox.Size = new Size(125, 27);
            tarihTextBox.TabIndex = 7;
            // 
            // filmTextBox
            // 
            filmTextBox.Location = new Point(127, 348);
            filmTextBox.Name = "filmTextBox";
            filmTextBox.Size = new Size(125, 27);
            filmTextBox.TabIndex = 6;
            // 
            // isimTextBox
            // 
            isimTextBox.Location = new Point(127, 296);
            isimTextBox.Name = "isimTextBox";
            isimTextBox.Size = new Size(125, 27);
            isimTextBox.TabIndex = 5;
            // 
            // isimLabel
            // 
            isimLabel.AutoSize = true;
            isimLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            isimLabel.Location = new Point(6, 297);
            isimLabel.Name = "isimLabel";
            isimLabel.Size = new Size(115, 23);
            isimLabel.TabIndex = 4;
            isimLabel.Text = "İsim Soyisim:";
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tarihLabel.Location = new Point(66, 393);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new Size(55, 23);
            tarihLabel.TabIndex = 3;
            tarihLabel.Text = "Tarih:";
            // 
            // saatLabel
            // 
            saatLabel.AutoSize = true;
            saatLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            saatLabel.Location = new Point(71, 436);
            saatLabel.Name = "saatLabel";
            saatLabel.Size = new Size(50, 23);
            saatLabel.TabIndex = 2;
            saatLabel.Text = "Saat:";
            // 
            // filmLabel
            // 
            filmLabel.AutoSize = true;
            filmLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            filmLabel.Location = new Point(33, 352);
            filmLabel.Name = "filmLabel";
            filmLabel.Size = new Size(88, 23);
            filmLabel.TabIndex = 1;
            filmLabel.Text = "Film İsmi:";
            // 
            // biletlerDataGridView
            // 
            biletlerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            biletlerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            biletlerDataGridView.Location = new Point(3, 6);
            biletlerDataGridView.Name = "biletlerDataGridView";
            biletlerDataGridView.RowHeadersWidth = 51;
            biletlerDataGridView.RowTemplate.Height = 29;
            biletlerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            biletlerDataGridView.Size = new Size(852, 244);
            biletlerDataGridView.TabIndex = 0;
            biletlerDataGridView.CellEnter += biletlerDataGridView_CellEnter;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 611);
            Controls.Add(tabControl1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)biletlerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox koltuk4TextBox;
        private TextBox koltuk3TextBox;
        private TextBox koltuk2TextBox;
        private TextBox koltuk1TextBox;
        private Label koltuk4Label;
        private Label koltuk3Label;
        private Label koltuk2Label;
        private Label koltuk1Label;
        private TextBox saatTextBox;
        private TextBox tarihTextBox;
        private TextBox filmTextBox;
        private TextBox isimTextBox;
        private Label isimLabel;
        private Label tarihLabel;
        private Label saatLabel;
        private Label filmLabel;
        private DataGridView biletlerDataGridView;
        private Button guncelleButton;
        private Button silButton;
        private Button ekleButton;
        private TextBox ucretTextBox;
        private Label ucretLabel;
        private TextBox idTextBox;
        private Label idLabel;
    }
}