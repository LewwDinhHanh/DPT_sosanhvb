namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnTinhTuongTu = new Button();
            btnDong = new Button();
            lblResult = new Label();
            txtVbA = new TextBox();
            txtVbB = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(206, 30);
            label1.Name = "label1";
            label1.Size = new Size(417, 31);
            label1.TabIndex = 0;
            label1.Text = "So sánh độ tương tự giữa hai văn bản";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 90);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 1;
            label2.Text = "Văn bản A";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(588, 90);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Văn bản B";
            // 
            // btnTinhTuongTu
            // 
            btnTinhTuongTu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinhTuongTu.Location = new Point(72, 459);
            btnTinhTuongTu.Name = "btnTinhTuongTu";
            btnTinhTuongTu.Size = new Size(182, 52);
            btnTinhTuongTu.TabIndex = 5;
            btnTinhTuongTu.Text = "Tính độ tương tự";
            btnTinhTuongTu.UseVisualStyleBackColor = true;
            btnTinhTuongTu.Click += btnTinhTuongTu_Click;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDong.Location = new Point(625, 459);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(121, 52);
            btnDong.TabIndex = 6;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(283, 471);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(28, 28);
            lblResult.TabIndex = 7;
            lblResult.Text = "%";
            // 
            // txtVbA
            // 
            txtVbA.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVbA.Location = new Point(22, 138);
            txtVbA.Margin = new Padding(3, 4, 3, 4);
            txtVbA.Multiline = true;
            txtVbA.Name = "txtVbA";
            txtVbA.Size = new Size(365, 275);
            txtVbA.TabIndex = 8;
            // 
            // txtVbB
            // 
            txtVbB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVbB.Location = new Point(439, 138);
            txtVbB.Margin = new Padding(3, 4, 3, 4);
            txtVbB.Multiline = true;
            txtVbB.Name = "txtVbB";
            txtVbB.Size = new Size(365, 275);
            txtVbB.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 538);
            Controls.Add(txtVbB);
            Controls.Add(txtVbA);
            Controls.Add(lblResult);
            Controls.Add(btnDong);
            Controls.Add(btnTinhTuongTu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Độ tương tự văn bản";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnTinhTuongTu;
        private Button btnDong;
        private Label lblResult;
        private TextBox txtVbA;
        private TextBox txtVbB;
    }
}
