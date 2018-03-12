namespace CHMHelpTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button indexOfHelp;
        private System.Windows.Forms.Button showMiscellaneous;

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
            this.components = new System.ComponentModel.Container();
            this.indexOfHelp = new System.Windows.Forms.Button();
            this.showMiscellaneous = new System.Windows.Forms.Button();
            this.showContents = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.showPopUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // indexOfHelp
            // 
            this.indexOfHelp.Location = new System.Drawing.Point(64, 12);
            this.indexOfHelp.Name = "indexOfHelp";
            this.indexOfHelp.Size = new System.Drawing.Size(157, 32);
            this.indexOfHelp.TabIndex = 0;
            this.indexOfHelp.Text = "Show Help Index";
            this.indexOfHelp.Click += new System.EventHandler(this.indexOfHelp_Click);
            // 
            // showMiscellaneous
            // 
            this.showMiscellaneous.Location = new System.Drawing.Point(64, 185);
            this.showMiscellaneous.Name = "showMiscellaneous";
            this.showMiscellaneous.Size = new System.Drawing.Size(157, 32);
            this.showMiscellaneous.TabIndex = 4;
            this.showMiscellaneous.Text = "Show Chapter Miscellaneous";
            this.showMiscellaneous.Click += new System.EventHandler(this.showMiscellaneous_Click);
            // 
            // showContents
            // 
            this.showContents.Location = new System.Drawing.Point(64, 129);
            this.showContents.Name = "showContents";
            this.showContents.Size = new System.Drawing.Size(157, 32);
            this.showContents.TabIndex = 5;
            this.showContents.Text = "Show Chapter Contents";
            this.showContents.Click += new System.EventHandler(this.showContents_Click);
            // 
            // showPopUp
            // 
            this.showPopUp.Location = new System.Drawing.Point(64, 72);
            this.showPopUp.Name = "showPopUp";
            this.showPopUp.Size = new System.Drawing.Size(157, 32);
            this.showPopUp.TabIndex = 6;
            this.showPopUp.Text = "Show PopUp";
            this.showPopUp.Click += new System.EventHandler(this.showPopUp_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(276, 229);
            this.Controls.Add(this.showPopUp);
            this.Controls.Add(this.showContents);
            this.Controls.Add(this.showMiscellaneous);
            this.Controls.Add(this.indexOfHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Test Help App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showContents;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button showPopUp;
    }
}

