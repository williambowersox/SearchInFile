
namespace FileInFiles
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbox_FileTypes = new System.Windows.Forms.CheckedListBox();
            this.lstbox_Files = new System.Windows.Forms.ListBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.txt_Dir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatslkj = new System.Windows.Forms.Label();
            this.lblStatInfo = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search String";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(16, 81);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(341, 20);
            this.txt_Search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File Types";
            // 
            // clbox_FileTypes
            // 
            this.clbox_FileTypes.FormattingEnabled = true;
            this.clbox_FileTypes.Location = new System.Drawing.Point(659, 30);
            this.clbox_FileTypes.Name = "clbox_FileTypes";
            this.clbox_FileTypes.Size = new System.Drawing.Size(129, 409);
            this.clbox_FileTypes.TabIndex = 3;
            // 
            // lstbox_Files
            // 
            this.lstbox_Files.FormattingEnabled = true;
            this.lstbox_Files.Location = new System.Drawing.Point(16, 107);
            this.lstbox_Files.Name = "lstbox_Files";
            this.lstbox_Files.Size = new System.Drawing.Size(618, 329);
            this.lstbox_Files.TabIndex = 4;
            this.lstbox_Files.SelectedIndexChanged += new System.EventHandler(this.lstbox_Files_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(376, 78);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(258, 23);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.Location = new System.Drawing.Point(376, 35);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(258, 23);
            this.btn_SelectFolder.TabIndex = 6;
            this.btn_SelectFolder.Text = "Select Folder";
            this.btn_SelectFolder.UseVisualStyleBackColor = true;
            this.btn_SelectFolder.Click += new System.EventHandler(this.btn_SelectFolder_Click);
            // 
            // txt_Dir
            // 
            this.txt_Dir.Location = new System.Drawing.Point(16, 35);
            this.txt_Dir.Name = "txt_Dir";
            this.txt_Dir.Size = new System.Drawing.Size(341, 20);
            this.txt_Dir.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Directory";
            // 
            // lblStatslkj
            // 
            this.lblStatslkj.AutoSize = true;
            this.lblStatslkj.Location = new System.Drawing.Point(12, 465);
            this.lblStatslkj.Name = "lblStatslkj";
            this.lblStatslkj.Size = new System.Drawing.Size(31, 13);
            this.lblStatslkj.TabIndex = 9;
            this.lblStatslkj.Text = "Stats";
            // 
            // lblStatInfo
            // 
            this.lblStatInfo.AutoSize = true;
            this.lblStatInfo.Location = new System.Drawing.Point(16, 465);
            this.lblStatInfo.Name = "lblStatInfo";
            this.lblStatInfo.Size = new System.Drawing.Size(0, 13);
            this.lblStatInfo.TabIndex = 10;
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(19, 443);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(615, 23);
            this.btn_open.TabIndex = 11;
            this.btn_open.Text = "Open File";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lblStatInfo);
            this.Controls.Add(this.lblStatslkj);
            this.Controls.Add(this.txt_Dir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SelectFolder);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lstbox_Files);
            this.Controls.Add(this.clbox_FileTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbox_FileTypes;
        private System.Windows.Forms.ListBox lstbox_Files;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_SelectFolder;
        private System.Windows.Forms.TextBox txt_Dir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatslkj;
        private System.Windows.Forms.Label lblStatInfo;
        private System.Windows.Forms.Button btn_open;
    }
}

