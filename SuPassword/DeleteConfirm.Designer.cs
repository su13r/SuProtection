namespace SuPassword
{
    partial class DeleteConfirm
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
            this.NoBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.TypePassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NoBtn
            // 
            this.NoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NoBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NoBtn.FlatAppearance.BorderSize = 0;
            this.NoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.NoBtn.Location = new System.Drawing.Point(25, 73);
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Size = new System.Drawing.Size(100, 34);
            this.NoBtn.TabIndex = 5;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.YesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(65)))));
            this.YesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.YesBtn.FlatAppearance.BorderSize = 0;
            this.YesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.YesBtn.Location = new System.Drawing.Point(170, 73);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(100, 34);
            this.YesBtn.TabIndex = 6;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // TypePassword
            // 
            this.TypePassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TypePassword.AutoSize = true;
            this.TypePassword.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypePassword.ForeColor = System.Drawing.SystemColors.Control;
            this.TypePassword.Location = new System.Drawing.Point(21, 30);
            this.TypePassword.Name = "TypePassword";
            this.TypePassword.Size = new System.Drawing.Size(266, 21);
            this.TypePassword.TabIndex = 7;
            this.TypePassword.Text = "Are you sure to delete this account?";
            // 
            // DeleteConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(308, 132);
            this.Controls.Add(this.TypePassword);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.NoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteConfirm";
            this.Opacity = 0.97D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Label TypePassword;
    }
}