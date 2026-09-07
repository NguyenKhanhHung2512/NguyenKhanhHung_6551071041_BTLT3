namespace Bai3
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
            lblHoTen = new Label();
            txtHo = new TextBox();
            txtTen = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = Color.DodgerBlue;
            lblHoTen.Location = new Point(-1, -2);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(802, 94);
            lblHoTen.TabIndex = 0;
            lblHoTen.TextAlign = ContentAlignment.MiddleCenter;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // txtHo
            // 
            txtHo.BorderStyle = BorderStyle.FixedSingle;
            txtHo.Location = new Point(194, 148);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(501, 31);
            txtHo.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(194, 207);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(501, 31);
            txtTen.TabIndex = 2;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 148);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 3;
            label2.Text = "Họ lót:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 210);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 4;
            label3.Text = "Tên:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(194, 291);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 5;
            button1.Text = "Họ lót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(372, 291);
            button2.Name = "button2";
            button2.Size = new Size(112, 45);
            button2.TabIndex = 6;
            button2.Text = "Tên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(542, 291);
            button3.Name = "button3";
            button3.Size = new Size(112, 45);
            button3.TabIndex = 7;
            button3.Text = "Họ và tên";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(328, 369);
            button4.Name = "button4";
            button4.Size = new Size(193, 49);
            button4.TabIndex = 8;
            button4.Text = "Thoát chương trình";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(lblHoTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHo;
        private TextBox txtTen;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
