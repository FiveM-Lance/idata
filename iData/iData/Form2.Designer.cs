namespace iData
{
    partial class Form2
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
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.menuCE = new System.Windows.Forms.ToolStripLabel();
            this.menuVE = new System.Windows.Forms.ToolStripLabel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Red;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCE,
            this.menuVE});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 25);
            this.mainMenu.TabIndex = 11;
            this.mainMenu.Text = "Main Menu";
            // 
            // menuCE
            // 
            this.menuCE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuCE.Name = "menuCE";
            this.menuCE.Size = new System.Drawing.Size(76, 22);
            this.menuCE.Text = "Create Entry";
            // 
            // menuVE
            // 
            this.menuVE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuVE.Name = "menuVE";
            this.menuVE.Size = new System.Drawing.Size(76, 22);
            this.menuVE.Text = "View Entries";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripLabel menuCE;
        private System.Windows.Forms.ToolStripLabel menuVE;
    }
}