namespace iData
{
    partial class Form1
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxGender = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.Label();
            this.inputGender = new System.Windows.Forms.Label();
            this.lblNewEntry = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.refreshFormOne = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataName,
            this.dataAge,
            this.dataGender});
            this.dataView.Location = new System.Drawing.Point(12, 28);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(344, 399);
            this.dataView.TabIndex = 0;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(94, 499);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(182, 20);
            this.tbxName.TabIndex = 1;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(94, 556);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(182, 20);
            this.tbxAge.TabIndex = 2;
            // 
            // tbxGender
            // 
            this.tbxGender.Location = new System.Drawing.Point(94, 612);
            this.tbxGender.Name = "tbxGender";
            this.tbxGender.Size = new System.Drawing.Size(182, 20);
            this.tbxGender.TabIndex = 4;
            // 
            // inputName
            // 
            this.inputName.AutoSize = true;
            this.inputName.Location = new System.Drawing.Point(166, 483);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(38, 13);
            this.inputName.TabIndex = 5;
            this.inputName.Text = "Name:";
            // 
            // inputAge
            // 
            this.inputAge.AutoSize = true;
            this.inputAge.Location = new System.Drawing.Point(169, 540);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(29, 13);
            this.inputAge.TabIndex = 6;
            this.inputAge.Text = "Age:";
            // 
            // inputGender
            // 
            this.inputGender.AutoSize = true;
            this.inputGender.Location = new System.Drawing.Point(163, 596);
            this.inputGender.Name = "inputGender";
            this.inputGender.Size = new System.Drawing.Size(45, 13);
            this.inputGender.TabIndex = 7;
            this.inputGender.Text = "Gender:";
            // 
            // lblNewEntry
            // 
            this.lblNewEntry.AutoSize = true;
            this.lblNewEntry.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblNewEntry.Location = new System.Drawing.Point(78, 441);
            this.lblNewEntry.Name = "lblNewEntry";
            this.lblNewEntry.Size = new System.Drawing.Size(207, 37);
            this.lblNewEntry.TabIndex = 8;
            this.lblNewEntry.Text = "Create Entry";
            this.lblNewEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewEntry.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 650);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataName
            // 
            this.dataName.HeaderText = "Name";
            this.dataName.Name = "dataName";
            this.dataName.ReadOnly = true;
            // 
            // dataAge
            // 
            this.dataAge.HeaderText = "Age";
            this.dataAge.Name = "dataAge";
            this.dataAge.ReadOnly = true;
            // 
            // dataGender
            // 
            this.dataGender.HeaderText = "Gender";
            this.dataGender.Name = "dataGender";
            this.dataGender.ReadOnly = true;
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Red;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshFormOne});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(369, 25);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "Main Menu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 690);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNewEntry);
            this.Controls.Add(this.inputGender);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.tbxGender);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.dataView);
            this.Name = "Form1";
            this.Text = "iData";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxGender;
        private System.Windows.Forms.Label inputName;
        private System.Windows.Forms.Label inputAge;
        private System.Windows.Forms.Label inputGender;
        private System.Windows.Forms.Label lblNewEntry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGender;
        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripLabel refreshFormOne;
    }
}

