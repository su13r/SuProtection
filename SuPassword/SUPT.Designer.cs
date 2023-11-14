namespace SuPassword
{
    partial class SUPT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUPT));
            this.infoLabel = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.TypePassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loading = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoLabel.Location = new System.Drawing.Point(95, 190);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 15);
            this.infoLabel.TabIndex = 1;
            // 
            // Encrypt
            // 
            this.Encrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Encrypt.FlatAppearance.BorderSize = 0;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Encrypt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.Encrypt.Location = new System.Drawing.Point(175, 286);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(106, 34);
            this.Encrypt.TabIndex = 2;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Decrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Decrypt.FlatAppearance.BorderSize = 0;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrypt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.Decrypt.Location = new System.Drawing.Point(334, 286);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(106, 34);
            this.Decrypt.TabIndex = 3;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // TypePassword
            // 
            this.TypePassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TypePassword.AutoSize = true;
            this.TypePassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.TypePassword.Location = new System.Drawing.Point(114, 211);
            this.TypePassword.Name = "TypePassword";
            this.TypePassword.Size = new System.Drawing.Size(41, 18);
            this.TypePassword.TabIndex = 5;
            this.TypePassword.Text = "Key  :";
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Password.Location = new System.Drawing.Point(117, 241);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(390, 30);
            this.Password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(238, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "File encryption";
            // 
            // loading
            // 
            this.loading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loading.Image = global::SuPassword.Properties.Resources.loading;
            this.loading.Location = new System.Drawing.Point(243, 346);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(145, 57);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loading.TabIndex = 7;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // OpenFile
            // 
            this.OpenFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(70)))), ((int)(((byte)(125)))));
            this.OpenFile.FlatAppearance.BorderSize = 0;
            this.OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenFile.Image = global::SuPassword.Properties.Resources.file;
            this.OpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenFile.Location = new System.Drawing.Point(92, 101);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(442, 79);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Pick File";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SUPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(612, 451);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.OpenFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SUPT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUPT";
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label TypePassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox loading;
    }
}