namespace obs
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            maskedTextBoxOgrenciNo = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSifre = new TextBox();
            label5 = new Label();
            txtCaptcha = new TextBox();
            label6 = new Label();
            button1 = new Button();
            lblCaptcha = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDurum = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(654, 186);
            label1.Margin = new Padding(9, 0, 9, 0);
            label1.Name = "label1";
            label1.Size = new Size(380, 46);
            label1.TabIndex = 0;
            label1.Text = "Bitlis Eren Üniversitesi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(726, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // maskedTextBoxOgrenciNo
            // 
            maskedTextBoxOgrenciNo.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            maskedTextBoxOgrenciNo.Location = new Point(527, 334);
            maskedTextBoxOgrenciNo.Mask = "00000000000";
            maskedTextBoxOgrenciNo.Name = "maskedTextBoxOgrenciNo";
            maskedTextBoxOgrenciNo.Size = new Size(192, 40);
            maskedTextBoxOgrenciNo.TabIndex = 2;
            maskedTextBoxOgrenciNo.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(726, 343);
            label2.Name = "label2";
            label2.Size = new Size(140, 31);
            label2.TabIndex = 3;
            label2.Text = "@beu.edu.tr";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(527, 287);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 4;
            label3.Text = "Öğrenci No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(527, 406);
            label4.Name = "label4";
            label4.Size = new Size(59, 31);
            label4.TabIndex = 5;
            label4.Text = "Şifre";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(527, 440);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(192, 40);
            txtSifre.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(527, 232);
            label5.Name = "label5";
            label5.Size = new Size(608, 31);
            label5.TabIndex = 7;
            label5.Text = "----------------------------Öğrenci-----------------------------";
            // 
            // txtCaptcha
            // 
            txtCaptcha.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            txtCaptcha.Location = new Point(751, 535);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(186, 40);
            txtCaptcha.TabIndex = 8;
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(521, 495);
            label6.Name = "label6";
            label6.Size = new Size(187, 31);
            label6.TabIndex = 9;
            label6.Text = "Sayıların Toplamı";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(943, 535);
            button1.Name = "button1";
            button1.Size = new Size(224, 38);
            button1.TabIndex = 10;
            button1.Text = "→]Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblCaptcha
            // 
            lblCaptcha.AutoSize = true;
            lblCaptcha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCaptcha.Location = new Point(521, 544);
            lblCaptcha.Name = "lblCaptcha";
            lblCaptcha.Size = new Size(224, 31);
            lblCaptcha.TabIndex = 11;
            lblCaptcha.Text = "RANDOM TOPLAMA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(726, 592);
            label8.Name = "label8";
            label8.Size = new Size(267, 28);
            label8.TabIndex = 12;
            label8.Text = "Şifremi Unuttum / Şifre Sıfırla";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(739, 644);
            label9.Name = "label9";
            label9.Size = new Size(229, 38);
            label9.TabIndex = 13;
            label9.Text = "E- Devlet İle Giriş";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Font = new Font("Segoe Script", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDurum.Location = new Point(959, 440);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(130, 44);
            lblDurum.TabIndex = 14;
            lblDurum.Text = "label10";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(23F, 55F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1924, 1055);
            Controls.Add(lblDurum);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblCaptcha);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txtCaptcha);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maskedTextBoxOgrenciNo);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(9, 8, 9, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBoxOgrenciNo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSifre;
        private Label label5;
        private TextBox txtCaptcha;
        private Label label6;
        private Button button1;
        private Label lblCaptcha;
        private Label label8;
        private Label label9;
        private Label lblDurum;
    }
}
