namespace LSB
{
    partial class mainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.embedButton = new System.Windows.Forms.Button();
            this.buttonBrowseEmFile = new System.Windows.Forms.Button();
            this.buttonSaveEmImg = new System.Windows.Forms.Button();
            this.embedURLTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowseEmImg = new System.Windows.Forms.Button();
            this.embedPictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.extractNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.extractButton = new System.Windows.Forms.Button();
            this.buttonSaveExFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBrowseExImg = new System.Windows.Forms.Button();
            this.extractPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.embedPictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extractPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 436);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.embedButton);
            this.tabPage1.Controls.Add(this.buttonBrowseEmFile);
            this.tabPage1.Controls.Add(this.buttonSaveEmImg);
            this.tabPage1.Controls.Add(this.embedURLTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonBrowseEmImg);
            this.tabPage1.Controls.Add(this.embedPictureBox);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Embed";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // embedButton
            // 
            this.embedButton.Enabled = false;
            this.embedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embedButton.Location = new System.Drawing.Point(445, 363);
            this.embedButton.Name = "embedButton";
            this.embedButton.Size = new System.Drawing.Size(91, 33);
            this.embedButton.TabIndex = 9;
            this.embedButton.Text = "Embed";
            this.embedButton.UseVisualStyleBackColor = true;
            this.embedButton.Click += new System.EventHandler(this.embedButton_Click);
            // 
            // buttonBrowseEmFile
            // 
            this.buttonBrowseEmFile.Enabled = false;
            this.buttonBrowseEmFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseEmFile.Location = new System.Drawing.Point(149, 363);
            this.buttonBrowseEmFile.Name = "buttonBrowseEmFile";
            this.buttonBrowseEmFile.Size = new System.Drawing.Size(111, 33);
            this.buttonBrowseEmFile.TabIndex = 8;
            this.buttonBrowseEmFile.Text = "Choose File";
            this.buttonBrowseEmFile.UseVisualStyleBackColor = true;
            this.buttonBrowseEmFile.Click += new System.EventHandler(this.buttonBrowseEmFile_Click);
            // 
            // buttonSaveEmImg
            // 
            this.buttonSaveEmImg.Enabled = false;
            this.buttonSaveEmImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveEmImg.Location = new System.Drawing.Point(542, 363);
            this.buttonSaveEmImg.Name = "buttonSaveEmImg";
            this.buttonSaveEmImg.Size = new System.Drawing.Size(70, 33);
            this.buttonSaveEmImg.TabIndex = 7;
            this.buttonSaveEmImg.Text = "Save";
            this.buttonSaveEmImg.UseVisualStyleBackColor = true;
            this.buttonSaveEmImg.Click += new System.EventHandler(this.buttonSaveEmImg_Click);
            // 
            // embedURLTextBox
            // 
            this.embedURLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embedURLTextBox.Location = new System.Drawing.Point(8, 333);
            this.embedURLTextBox.Name = "embedURLTextBox";
            this.embedURLTextBox.ReadOnly = true;
            this.embedURLTextBox.Size = new System.Drawing.Size(604, 24);
            this.embedURLTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "File to embed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Image:";
            // 
            // buttonBrowseEmImg
            // 
            this.buttonBrowseEmImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseEmImg.Location = new System.Drawing.Point(8, 363);
            this.buttonBrowseEmImg.Name = "buttonBrowseEmImg";
            this.buttonBrowseEmImg.Size = new System.Drawing.Size(135, 33);
            this.buttonBrowseEmImg.TabIndex = 2;
            this.buttonBrowseEmImg.Text = "Browse Image";
            this.buttonBrowseEmImg.UseVisualStyleBackColor = true;
            this.buttonBrowseEmImg.Click += new System.EventHandler(this.buttonBrowseEmImg_Click);
            // 
            // embedPictureBox
            // 
            this.embedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.embedPictureBox.Location = new System.Drawing.Point(8, 23);
            this.embedPictureBox.Name = "embedPictureBox";
            this.embedPictureBox.Size = new System.Drawing.Size(604, 287);
            this.embedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.embedPictureBox.TabIndex = 0;
            this.embedPictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.extractNameTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.extractButton);
            this.tabPage2.Controls.Add(this.buttonSaveExFile);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonBrowseExImg);
            this.tabPage2.Controls.Add(this.extractPictureBox);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // extractNameTextBox
            // 
            this.extractNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractNameTextBox.Location = new System.Drawing.Point(8, 333);
            this.extractNameTextBox.Name = "extractNameTextBox";
            this.extractNameTextBox.Size = new System.Drawing.Size(604, 24);
            this.extractNameTextBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Embedded file name:";
            // 
            // extractButton
            // 
            this.extractButton.Enabled = false;
            this.extractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.Location = new System.Drawing.Point(451, 363);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(85, 33);
            this.extractButton.TabIndex = 15;
            this.extractButton.Text = "Extract";
            this.extractButton.UseVisualStyleBackColor = true;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // buttonSaveExFile
            // 
            this.buttonSaveExFile.Enabled = false;
            this.buttonSaveExFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveExFile.Location = new System.Drawing.Point(542, 363);
            this.buttonSaveExFile.Name = "buttonSaveExFile";
            this.buttonSaveExFile.Size = new System.Drawing.Size(70, 33);
            this.buttonSaveExFile.TabIndex = 14;
            this.buttonSaveExFile.Text = "Save";
            this.buttonSaveExFile.UseVisualStyleBackColor = true;
            this.buttonSaveExFile.Click += new System.EventHandler(this.buttonSaveExFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image:";
            // 
            // buttonBrowseExImg
            // 
            this.buttonBrowseExImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowseExImg.Location = new System.Drawing.Point(8, 363);
            this.buttonBrowseExImg.Name = "buttonBrowseExImg";
            this.buttonBrowseExImg.Size = new System.Drawing.Size(137, 33);
            this.buttonBrowseExImg.TabIndex = 10;
            this.buttonBrowseExImg.Text = "Browse Image";
            this.buttonBrowseExImg.UseVisualStyleBackColor = true;
            this.buttonBrowseExImg.Click += new System.EventHandler(this.buttonBrowseExImg_Click);
            // 
            // extractPictureBox
            // 
            this.extractPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extractPictureBox.Location = new System.Drawing.Point(8, 23);
            this.extractPictureBox.Name = "extractPictureBox";
            this.extractPictureBox.Size = new System.Drawing.Size(604, 287);
            this.extractPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extractPictureBox.TabIndex = 9;
            this.extractPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 436);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "LSB";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.embedPictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extractPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowseEmImg;
        private System.Windows.Forms.PictureBox embedPictureBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox embedURLTextBox;
        private System.Windows.Forms.Button embedButton;
        private System.Windows.Forms.Button buttonBrowseEmFile;
        private System.Windows.Forms.Button buttonSaveEmImg;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.Button buttonSaveExFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowseExImg;
        private System.Windows.Forms.PictureBox extractPictureBox;
        private System.Windows.Forms.TextBox extractNameTextBox;
        private System.Windows.Forms.Label label3;
    }
}

