
namespace CloudDataSecurity2
{
    partial class btnOpen
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
            this.button1 = new System.Windows.Forms.Button();
            this.txb256 = new System.Windows.Forms.TextBox();
            this.txbKey_decrypt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSHA256 = new System.Windows.Forms.Button();
            this.txb256bit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbKey_encrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPathToEncrypt = new System.Windows.Forms.TextBox();
            this.btnSelectFileToEncrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPathToSaveDecryptedFile = new System.Windows.Forms.TextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1274, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 48;
            this.button1.Text = "Show key after hash";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb256
            // 
            this.txb256.Location = new System.Drawing.Point(874, 226);
            this.txb256.Name = "txb256";
            this.txb256.Size = new System.Drawing.Size(384, 22);
            this.txb256.TabIndex = 47;
            // 
            // txbKey_decrypt
            // 
            this.txbKey_decrypt.Location = new System.Drawing.Point(209, 440);
            this.txbKey_decrypt.Name = "txbKey_decrypt";
            this.txbKey_decrypt.Size = new System.Drawing.Size(384, 22);
            this.txbKey_decrypt.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Key to decrypt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CloudDataSecurity2.Properties.Resources.tải_xuống;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 94);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnSHA256
            // 
            this.btnSHA256.Location = new System.Drawing.Point(1274, 195);
            this.btnSHA256.Name = "btnSHA256";
            this.btnSHA256.Size = new System.Drawing.Size(159, 25);
            this.btnSHA256.TabIndex = 36;
            this.btnSHA256.Text = "Show key (binary)";
            this.btnSHA256.UseVisualStyleBackColor = true;
            this.btnSHA256.Click += new System.EventHandler(this.btnSHA256_Click);
            // 
            // txb256bit
            // 
            this.txb256bit.Location = new System.Drawing.Point(874, 198);
            this.txb256bit.Name = "txb256bit";
            this.txb256bit.Size = new System.Drawing.Size(384, 22);
            this.txb256bit.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(791, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "256 bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "SHA256 make the input key to 256 bit key";
            // 
            // txbKey_encrypt
            // 
            this.txbKey_encrypt.Location = new System.Drawing.Point(209, 162);
            this.txbKey_encrypt.Name = "txbKey_encrypt";
            this.txbKey_encrypt.Size = new System.Drawing.Size(384, 22);
            this.txbKey_encrypt.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Key to encrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "File\'s path for ENCRYPT";
            // 
            // txbPathToEncrypt
            // 
            this.txbPathToEncrypt.Location = new System.Drawing.Point(209, 231);
            this.txbPathToEncrypt.Name = "txbPathToEncrypt";
            this.txbPathToEncrypt.Size = new System.Drawing.Size(384, 22);
            this.txbPathToEncrypt.TabIndex = 29;
            // 
            // btnSelectFileToEncrypt
            // 
            this.btnSelectFileToEncrypt.Location = new System.Drawing.Point(621, 162);
            this.btnSelectFileToEncrypt.Name = "btnSelectFileToEncrypt";
            this.btnSelectFileToEncrypt.Size = new System.Drawing.Size(164, 91);
            this.btnSelectFileToEncrypt.TabIndex = 49;
            this.btnSelectFileToEncrypt.Text = "Select file to encrypt";
            this.btnSelectFileToEncrypt.UseVisualStyleBackColor = true;
            this.btnSelectFileToEncrypt.Click += new System.EventHandler(this.btnSelectFileToEncrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "File\'s path of the output file";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txbPathToSaveDecryptedFile
            // 
            this.txbPathToSaveDecryptedFile.Location = new System.Drawing.Point(209, 390);
            this.txbPathToSaveDecryptedFile.Name = "txbPathToSaveDecryptedFile";
            this.txbPathToSaveDecryptedFile.Size = new System.Drawing.Size(384, 22);
            this.txbPathToSaveDecryptedFile.TabIndex = 52;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(621, 390);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(164, 72);
            this.btnDecrypt.TabIndex = 53;
            this.btnDecrypt.Text = "Select file to decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 607);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txbPathToSaveDecryptedFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectFileToEncrypt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txb256);
            this.Controls.Add(this.txbKey_decrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSHA256);
            this.Controls.Add(this.txb256bit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbKey_encrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPathToEncrypt);
            this.Name = "btnOpen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb256;
        private System.Windows.Forms.TextBox txbKey_decrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSHA256;
        private System.Windows.Forms.TextBox txb256bit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKey_encrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPathToEncrypt;
        private System.Windows.Forms.Button btnSelectFileToEncrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPathToSaveDecryptedFile;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

