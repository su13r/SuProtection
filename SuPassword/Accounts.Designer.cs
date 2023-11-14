namespace SuPassword
{
    partial class Accounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AccountsLiv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountsLiv
            // 
            this.AccountsLiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.AccountsLiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountsLiv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.AccountsLiv.ContextMenuStrip = this.AccountsMenu;
            this.AccountsLiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsLiv.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountsLiv.ForeColor = System.Drawing.SystemColors.Menu;
            this.AccountsLiv.FullRowSelect = true;
            this.AccountsLiv.HideSelection = false;
            this.AccountsLiv.Location = new System.Drawing.Point(0, 0);
            this.AccountsLiv.MultiSelect = false;
            this.AccountsLiv.Name = "AccountsLiv";
            this.AccountsLiv.Size = new System.Drawing.Size(677, 573);
            this.AccountsLiv.TabIndex = 0;
            this.AccountsLiv.UseCompatibleStateImageBehavior = false;
            this.AccountsLiv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 29;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "URL";
            this.columnHeader5.Width = 211;
            // 
            // AccountsMenu
            // 
            this.AccountsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyEmailToolStripMenuItem,
            this.copyPasswordToolStripMenuItem,
            this.newAccountToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.AccountsMenu.Name = "AccountsMenu";
            this.AccountsMenu.Size = new System.Drawing.Size(156, 92);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy password";
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            // 
            // copyEmailToolStripMenuItem
            // 
            this.copyEmailToolStripMenuItem.Name = "copyEmailToolStripMenuItem";
            this.copyEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyEmailToolStripMenuItem.Text = "Copy email";
            this.copyEmailToolStripMenuItem.Click += new System.EventHandler(this.copyEmailToolStripMenuItem_Click);
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newAccountToolStripMenuItem.Text = "New account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(36)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.AccountsLiv);
            this.Name = "Accounts";
            this.Size = new System.Drawing.Size(677, 573);
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.AccountsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView AccountsLiv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip AccountsMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
