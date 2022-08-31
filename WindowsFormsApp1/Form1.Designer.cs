namespace WindowsFormsApp1
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
            this.label3 = new System.Windows.Forms.Label();
            this.IPText = new System.Windows.Forms.TextBox();
            this.ScanPorts = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.portsLst = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sportText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eportText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter an IP address to scan";
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(15, 25);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(209, 20);
            this.IPText.TabIndex = 1;
            // 
            // ScanPorts
            // 
            this.ScanPorts.Location = new System.Drawing.Point(16, 276);
            this.ScanPorts.Name = "ScanPorts";
            this.ScanPorts.Size = new System.Drawing.Size(75, 23);
            this.ScanPorts.TabIndex = 2;
            this.ScanPorts.Text = "Scan";
            this.ScanPorts.UseVisualStyleBackColor = true;
            this.ScanPorts.Click += new System.EventHandler(this.ScanPorts_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(150, 276);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // portsLst
            // 
            this.portsLst.FormattingEnabled = true;
            this.portsLst.Location = new System.Drawing.Point(16, 97);
            this.portsLst.Name = "portsLst";
            this.portsLst.Size = new System.Drawing.Size(209, 173);
            this.portsLst.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 305);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(209, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 5;
            // 
            // sportText
            // 
            this.sportText.Location = new System.Drawing.Point(15, 71);
            this.sportText.Name = "sportText";
            this.sportText.Size = new System.Drawing.Size(58, 20);
            this.sportText.TabIndex = 6;
            this.sportText.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Start Port";
            // 
            // eportText
            // 
            this.eportText.Location = new System.Drawing.Point(169, 71);
            this.eportText.Name = "eportText";
            this.eportText.Size = new System.Drawing.Size(55, 20);
            this.eportText.TabIndex = 8;
            this.eportText.Text = "65535";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "End Port";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(237, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eportText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sportText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.portsLst);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ScanPorts);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.Button ScanPorts;
        private System.Windows.Forms.Button ClearBtn;
        public System.Windows.Forms.ListBox portsLst;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox sportText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eportText;
        private System.Windows.Forms.Label label2;
    }
}

