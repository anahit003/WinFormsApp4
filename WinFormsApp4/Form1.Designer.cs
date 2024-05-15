namespace WinFormsApp4
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
            buttonEncrypt = new Button();
            buttonDecipher = new Button();
            bt_ToDisk = new Button();
            Bt_NewPrimeNumbers = new Button();
            bt_CalculateKey = new Button();
            textBox_p = new TextBox();
            textBox_q = new TextBox();
            textBox_n = new TextBox();
            textBox_d = new TextBox();
            textBox_Decrypted = new TextBox();
            textBox_Encrypted = new TextBox();
            textBox_ToEncrypt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            bt_FromDisk = new Button();
            SuspendLayout();
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Location = new Point(12, 389);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new Size(169, 29);
            buttonEncrypt.TabIndex = 0;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // buttonDecipher
            // 
            buttonDecipher.Location = new Point(763, 389);
            buttonDecipher.Name = "buttonDecipher";
            buttonDecipher.Size = new Size(191, 29);
            buttonDecipher.TabIndex = 1;
            buttonDecipher.Text = "Decipher";
            buttonDecipher.UseVisualStyleBackColor = true;
            buttonDecipher.Click += buttonDecipher_Click;
            // 
            // bt_ToDisk
            // 
            bt_ToDisk.Location = new Point(542, 389);
            bt_ToDisk.Name = "bt_ToDisk";
            bt_ToDisk.Size = new Size(94, 29);
            bt_ToDisk.TabIndex = 3;
            bt_ToDisk.Text = "To File";
            bt_ToDisk.UseVisualStyleBackColor = true;
            bt_ToDisk.Click += bt_ToDisk_Click;
            // 
            // Bt_NewPrimeNumbers
            // 
            Bt_NewPrimeNumbers.Location = new Point(29, 72);
            Bt_NewPrimeNumbers.Name = "Bt_NewPrimeNumbers";
            Bt_NewPrimeNumbers.Size = new Size(196, 29);
            Bt_NewPrimeNumbers.TabIndex = 4;
            Bt_NewPrimeNumbers.Text = "New prime numbers";
            Bt_NewPrimeNumbers.UseVisualStyleBackColor = true;
            Bt_NewPrimeNumbers.Click += Bt_NewPrimeNumbers_Click;
            // 
            // bt_CalculateKey
            // 
            bt_CalculateKey.Location = new Point(635, 72);
            bt_CalculateKey.Name = "bt_CalculateKey";
            bt_CalculateKey.Size = new Size(94, 29);
            bt_CalculateKey.TabIndex = 5;
            bt_CalculateKey.Text = "Calculate";
            bt_CalculateKey.UseVisualStyleBackColor = true;
            bt_CalculateKey.Click += bt_CalculateKey_Click;
            // 
            // textBox_p
            // 
            textBox_p.Location = new Point(45, 29);
            textBox_p.Name = "textBox_p";
            textBox_p.Size = new Size(71, 27);
            textBox_p.TabIndex = 6;
            // 
            // textBox_q
            // 
            textBox_q.Location = new Point(170, 29);
            textBox_q.Name = "textBox_q";
            textBox_q.Size = new Size(69, 27);
            textBox_q.TabIndex = 7;
            // 
            // textBox_n
            // 
            textBox_n.Location = new Point(709, 29);
            textBox_n.Name = "textBox_n";
            textBox_n.Size = new Size(69, 27);
            textBox_n.TabIndex = 8;
            // 
            // textBox_d
            // 
            textBox_d.Location = new Point(593, 29);
            textBox_d.Name = "textBox_d";
            textBox_d.Size = new Size(71, 27);
            textBox_d.TabIndex = 9;
            // 
            // textBox_Decrypted
            // 
            textBox_Decrypted.BackColor = SystemColors.InactiveBorder;
            textBox_Decrypted.Location = new Point(681, 178);
            textBox_Decrypted.Multiline = true;
            textBox_Decrypted.Name = "textBox_Decrypted";
            textBox_Decrypted.Size = new Size(274, 194);
            textBox_Decrypted.TabIndex = 10;
            // 
            // textBox_Encrypted
            // 
            textBox_Encrypted.BackColor = SystemColors.InactiveBorder;
            textBox_Encrypted.Location = new Point(337, 178);
            textBox_Encrypted.Multiline = true;
            textBox_Encrypted.Name = "textBox_Encrypted";
            textBox_Encrypted.Size = new Size(299, 194);
            textBox_Encrypted.TabIndex = 11;
            textBox_Encrypted.TextChanged += textBox_Encrypted_TextChanged;
            // 
            // textBox_ToEncrypt
            // 
            textBox_ToEncrypt.BackColor = SystemColors.Control;
            textBox_ToEncrypt.ForeColor = SystemColors.ControlText;
            textBox_ToEncrypt.Location = new Point(12, 178);
            textBox_ToEncrypt.Multiline = true;
            textBox_ToEncrypt.Name = "textBox_ToEncrypt";
            textBox_ToEncrypt.Size = new Size(291, 194);
            textBox_ToEncrypt.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 13;
            label1.Text = "Pime numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(34, 18);
            label2.TabIndex = 14;
            label2.Text = " p =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(140, 32);
            label3.Name = "label3";
            label3.Size = new Size(30, 18);
            label3.TabIndex = 15;
            label3.Text = "q =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(635, 6);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 16;
            label4.Text = "The secret key";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(559, 32);
            label5.Name = "label5";
            label5.Size = new Size(30, 18);
            label5.TabIndex = 17;
            label5.Text = "d =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(681, 32);
            label6.Name = "label6";
            label6.Size = new Size(30, 18);
            label6.TabIndex = 18;
            label6.Text = "n =";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ButtonFace;
            label7.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(78, 137);
            label7.Name = "label7";
            label7.Size = new Size(184, 28);
            label7.TabIndex = 19;
            label7.Text = "   Text to encrypt      ";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(404, 137);
            label8.Name = "label8";
            label8.Size = new Size(174, 28);
            label8.TabIndex = 20;
            label8.Text = "  Encrypted text";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ButtonFace;
            label9.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(752, 137);
            label9.Name = "label9";
            label9.Size = new Size(173, 25);
            label9.TabIndex = 21;
            label9.Text = "  Decrypted text";
            label9.Click += label9_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // bt_FromDisk
            // 
            bt_FromDisk.Location = new Point(288, 389);
            bt_FromDisk.Name = "bt_FromDisk";
            bt_FromDisk.Size = new Size(94, 29);
            bt_FromDisk.TabIndex = 22;
            bt_FromDisk.Text = "From File";
            bt_FromDisk.UseVisualStyleBackColor = true;
            bt_FromDisk.Click += bt_FromDisk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(966, 467);
            Controls.Add(bt_FromDisk);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_ToEncrypt);
            Controls.Add(textBox_Encrypted);
            Controls.Add(textBox_Decrypted);
            Controls.Add(textBox_d);
            Controls.Add(textBox_n);
            Controls.Add(textBox_q);
            Controls.Add(textBox_p);
            Controls.Add(bt_CalculateKey);
            Controls.Add(Bt_NewPrimeNumbers);
            Controls.Add(bt_ToDisk);
            Controls.Add(buttonDecipher);
            Controls.Add(buttonEncrypt);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "RSA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEncrypt;
        private Button buttonDecipher;
        private Button bt_ToDisk;
        private Button Bt_NewPrimeNumbers;
        private Button bt_CalculateKey;
        private TextBox textBox_p;
        private TextBox textBox_q;
        private TextBox textBox_n;
        private TextBox textBox_d;
        private TextBox textBox_Decrypted;
        private TextBox textBox_Encrypted;
        private TextBox textBox_ToEncrypt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Button bt_FromDisk;
    }
}