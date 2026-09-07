namespace Bai5
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
            lblNhapTen = new Label();
            txtNhapTen = new TextBox();
            radRed = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            chkUnderLine = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            lblFont = new Label();
            label1 = new Label();
            lblLapTrinh = new Label();
            btnThoat = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNhapTen
            // 
            lblNhapTen.AutoSize = true;
            lblNhapTen.BackColor = SystemColors.ActiveCaptionText;
            lblNhapTen.ForeColor = Color.FromArgb(0, 192, 0);
            lblNhapTen.Location = new Point(66, 54);
            lblNhapTen.Name = "lblNhapTen";
            lblNhapTen.Size = new Size(89, 25);
            lblNhapTen.TabIndex = 2;
            lblNhapTen.Text = "Nhập tên:";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(161, 54);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(406, 31);
            txtNhapTen.TabIndex = 0;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Checked = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(34, 46);
            radRed.Name = "radRed";
            radRed.Size = new Size(70, 29);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.BackColor = SystemColors.Control;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(31, 81);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(88, 29);
            radGreen.TabIndex = 3;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = false;
            radGreen.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(31, 116);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(75, 29);
            radBlue.TabIndex = 4;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(31, 151);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(83, 29);
            radBlack.TabIndex = 5;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(radRed);
            panel1.Controls.Add(radBlack);
            panel1.Controls.Add(radGreen);
            panel1.Controls.Add(radBlue);
            panel1.Location = new Point(66, 131);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 201);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 6;
            label2.Text = "Color";
            // 
            // panel2
            // 
            panel2.Controls.Add(chkUnderLine);
            panel2.Controls.Add(chkItalic);
            panel2.Controls.Add(chkBold);
            panel2.Controls.Add(lblFont);
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            panel2.Location = new Point(355, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 201);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // chkUnderLine
            // 
            chkUnderLine.AutoSize = true;
            chkUnderLine.ForeColor = SystemColors.MenuHighlight;
            chkUnderLine.Location = new Point(30, 132);
            chkUnderLine.Name = "chkUnderLine";
            chkUnderLine.Size = new Size(127, 29);
            chkUnderLine.TabIndex = 6;
            chkUnderLine.Text = "Gạch chân";
            chkUnderLine.UseVisualStyleBackColor = true;
            chkUnderLine.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = SystemColors.MenuHighlight;
            chkItalic.Location = new Point(30, 86);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(160, 29);
            chkItalic.TabIndex = 5;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = SystemColors.MenuHighlight;
            chkBold.Location = new Point(30, 39);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(158, 41);
            chkBold.TabIndex = 4;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(15, 0);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(50, 25);
            lblFont.TabIndex = 0;
            lblFont.Text = "Font";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(66, 374);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 8;
            label1.Text = "Lập Trình Bởi:";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BorderStyle = BorderStyle.Fixed3D;
            lblLapTrinh.Location = new Point(201, 358);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(159, 52);
            lblLapTrinh.TabIndex = 9;
            lblLapTrinh.TextAlign = ContentAlignment.MiddleCenter;
            lblLapTrinh.Click += label3_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(412, 357);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 53);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNhapTen);
            Controls.Add(lblNhapTen);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhapTen;
        private TextBox txtNhapTen;
        private RadioButton radRed;
        private RadioButton radGreen;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label lblFont;
        private CheckBox chkUnderLine;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label1;
        private Label lblLapTrinh;
        private Button btnThoat;
    }
}
