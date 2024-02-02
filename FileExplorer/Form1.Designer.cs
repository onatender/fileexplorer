namespace FileExplorer
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.strpthexp = new System.Windows.Forms.Button();
            this.wholepccb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(25, 43);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(289, 20);
            this.txtQuery.TabIndex = 0;
            // 
            // lstFile
            // 
            this.lstFile.FormattingEnabled = true;
            this.lstFile.Location = new System.Drawing.Point(25, 88);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(451, 277);
            this.lstFile.TabIndex = 1;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.lstFile_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(320, 43);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // strpthexp
            // 
            this.strpthexp.Enabled = false;
            this.strpthexp.Location = new System.Drawing.Point(401, 43);
            this.strpthexp.Name = "strpthexp";
            this.strpthexp.Size = new System.Drawing.Size(75, 23);
            this.strpthexp.TabIndex = 3;
            this.strpthexp.Text = "LOOK IN";
            this.strpthexp.UseVisualStyleBackColor = true;
            this.strpthexp.Click += new System.EventHandler(this.strpthexp_Click);
            // 
            // wholepccb
            // 
            this.wholepccb.AutoSize = true;
            this.wholepccb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wholepccb.Location = new System.Drawing.Point(401, 20);
            this.wholepccb.Name = "wholepccb";
            this.wholepccb.Size = new System.Drawing.Size(77, 17);
            this.wholepccb.TabIndex = 4;
            this.wholepccb.Text = "All Memory";
            this.wholepccb.UseVisualStyleBackColor = true;
            this.wholepccb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(505, 389);
            this.Controls.Add(this.wholepccb);
            this.Controls.Add(this.strpthexp);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.lstFile);
            this.Controls.Add(this.txtQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button strpthexp;
        private System.Windows.Forms.CheckBox wholepccb;
    }
}

