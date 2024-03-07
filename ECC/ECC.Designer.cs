namespace ECC
{
    partial class ECC
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
            this.encrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.pr = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.TextBox();
            this.generateK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encrypt
            // 
            this.encrypt.Location = new System.Drawing.Point(804, 78);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(84, 26);
            this.encrypt.TabIndex = 0;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(804, 145);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(84, 26);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(60, 80);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(686, 24);
            this.input.TabIndex = 2;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(60, 147);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(686, 88);
            this.output.TabIndex = 3;
            // 
            // pr
            // 
            this.pr.Location = new System.Drawing.Point(60, 388);
            this.pr.Name = "pr";
            this.pr.Size = new System.Drawing.Size(686, 24);
            this.pr.TabIndex = 4;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(60, 465);
            this.pb.Multiline = true;
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(686, 72);
            this.pb.TabIndex = 5;
            // 
            // generateK
            // 
            this.generateK.Location = new System.Drawing.Point(756, 406);
            this.generateK.Name = "generateK";
            this.generateK.Size = new System.Drawing.Size(132, 67);
            this.generateK.TabIndex = 6;
            this.generateK.Text = "Generate key(s)";
            this.generateK.UseVisualStyleBackColor = true;
            this.generateK.Click += new System.EventHandler(this.generateK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "64 bytes hex format AES key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ciphertext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Private Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Public Key";
            // 
            // plain
            // 
            this.plain.Location = new System.Drawing.Point(60, 286);
            this.plain.Name = "plain";
            this.plain.Size = new System.Drawing.Size(686, 24);
            this.plain.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Plaintext = AES key";
            // 
            // ECC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.plain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateK);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pr);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.encrypt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ECC";
            this.Text = "ECC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox pr;
        private System.Windows.Forms.TextBox pb;
        private System.Windows.Forms.Button generateK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox plain;
        private System.Windows.Forms.Label label5;
    }
}

