namespace wf_xu_ly_anh_002
{
    partial class MainForm
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMergeIMG = new System.Windows.Forms.Button();
            this.prbMergeIMG = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbResultImg = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYpos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXpos = new System.Windows.Forms.TextBox();
            this.txtResultIMG = new System.Windows.Forms.TextBox();
            this.btnResultIMG = new System.Windows.Forms.Button();
            this.grbSubImg = new System.Windows.Forms.GroupBox();
            this.txtSubIMG = new System.Windows.Forms.TextBox();
            this.btnSubIMG = new System.Windows.Forms.Button();
            this.grbMainImg = new System.Windows.Forms.GroupBox();
            this.txtMainIMG = new System.Windows.Forms.TextBox();
            this.btnMainIMG = new System.Windows.Forms.Button();
            this.backgroundWorkerIMG = new System.ComponentModel.BackgroundWorker();
            this.pnTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbResultImg.SuspendLayout();
            this.grbSubImg.SuspendLayout();
            this.grbMainImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(391, 34);
            this.pnTitle.TabIndex = 1;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tool-xu-ly-anh-002";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMergeIMG);
            this.panel1.Controls.Add(this.prbMergeIMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 82);
            this.panel1.TabIndex = 2;
            // 
            // btnMergeIMG
            // 
            this.btnMergeIMG.Location = new System.Drawing.Point(12, 47);
            this.btnMergeIMG.Name = "btnMergeIMG";
            this.btnMergeIMG.Size = new System.Drawing.Size(75, 23);
            this.btnMergeIMG.TabIndex = 1;
            this.btnMergeIMG.Text = "MergeIMG";
            this.btnMergeIMG.UseVisualStyleBackColor = true;
            this.btnMergeIMG.Click += new System.EventHandler(this.btnMergeIMG_Click);
            // 
            // prbMergeIMG
            // 
            this.prbMergeIMG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.prbMergeIMG.Location = new System.Drawing.Point(12, 18);
            this.prbMergeIMG.Name = "prbMergeIMG";
            this.prbMergeIMG.Size = new System.Drawing.Size(367, 23);
            this.prbMergeIMG.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grbResultImg, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grbSubImg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbMainImg, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 275);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // grbResultImg
            // 
            this.grbResultImg.Controls.Add(this.label4);
            this.grbResultImg.Controls.Add(this.cbType);
            this.grbResultImg.Controls.Add(this.label3);
            this.grbResultImg.Controls.Add(this.txtYpos);
            this.grbResultImg.Controls.Add(this.label2);
            this.grbResultImg.Controls.Add(this.txtXpos);
            this.grbResultImg.Controls.Add(this.txtResultIMG);
            this.grbResultImg.Controls.Add(this.btnResultIMG);
            this.grbResultImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbResultImg.Location = new System.Drawing.Point(3, 167);
            this.grbResultImg.Name = "grbResultImg";
            this.grbResultImg.Size = new System.Drawing.Size(385, 105);
            this.grbResultImg.TabIndex = 2;
            this.grbResultImg.TabStop = false;
            this.grbResultImg.Text = "RESULT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TYPE";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "PNG",
            "JPEG"});
            this.cbType.Location = new System.Drawing.Point(255, 44);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 10;
            this.cbType.SelectedItem = "PNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Y";
            // 
            // txtYpos
            // 
            this.txtYpos.Location = new System.Drawing.Point(87, 71);
            this.txtYpos.Name = "txtYpos";
            this.txtYpos.Size = new System.Drawing.Size(100, 20);
            this.txtYpos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // txtXpos
            // 
            this.txtXpos.Location = new System.Drawing.Point(87, 45);
            this.txtXpos.Name = "txtXpos";
            this.txtXpos.Size = new System.Drawing.Size(100, 20);
            this.txtXpos.TabIndex = 6;
            // 
            // txtResultIMG
            // 
            this.txtResultIMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultIMG.Location = new System.Drawing.Point(87, 19);
            this.txtResultIMG.Name = "txtResultIMG";
            this.txtResultIMG.Size = new System.Drawing.Size(289, 20);
            this.txtResultIMG.TabIndex = 5;
            // 
            // btnResultIMG
            // 
            this.btnResultIMG.Location = new System.Drawing.Point(6, 16);
            this.btnResultIMG.Name = "btnResultIMG";
            this.btnResultIMG.Size = new System.Drawing.Size(75, 23);
            this.btnResultIMG.TabIndex = 4;
            this.btnResultIMG.Text = "Chọn Folder";
            this.btnResultIMG.UseVisualStyleBackColor = true;
            this.btnResultIMG.Click += new System.EventHandler(this.btnResultIMG_Click);
            // 
            // grbSubImg
            // 
            this.grbSubImg.Controls.Add(this.txtSubIMG);
            this.grbSubImg.Controls.Add(this.btnSubIMG);
            this.grbSubImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbSubImg.Location = new System.Drawing.Point(3, 85);
            this.grbSubImg.Name = "grbSubImg";
            this.grbSubImg.Size = new System.Drawing.Size(385, 76);
            this.grbSubImg.TabIndex = 1;
            this.grbSubImg.TabStop = false;
            this.grbSubImg.Text = "SUB IMG";
            // 
            // txtSubIMG
            // 
            this.txtSubIMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubIMG.Location = new System.Drawing.Point(87, 19);
            this.txtSubIMG.Name = "txtSubIMG";
            this.txtSubIMG.Size = new System.Drawing.Size(289, 20);
            this.txtSubIMG.TabIndex = 3;
            // 
            // btnSubIMG
            // 
            this.btnSubIMG.Location = new System.Drawing.Point(6, 16);
            this.btnSubIMG.Name = "btnSubIMG";
            this.btnSubIMG.Size = new System.Drawing.Size(75, 23);
            this.btnSubIMG.TabIndex = 2;
            this.btnSubIMG.Text = "Chọn Folder";
            this.btnSubIMG.UseVisualStyleBackColor = true;
            this.btnSubIMG.Click += new System.EventHandler(this.btnSubIMG_Click);
            // 
            // grbMainImg
            // 
            this.grbMainImg.Controls.Add(this.txtMainIMG);
            this.grbMainImg.Controls.Add(this.btnMainIMG);
            this.grbMainImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMainImg.Location = new System.Drawing.Point(3, 3);
            this.grbMainImg.Name = "grbMainImg";
            this.grbMainImg.Size = new System.Drawing.Size(385, 76);
            this.grbMainImg.TabIndex = 0;
            this.grbMainImg.TabStop = false;
            this.grbMainImg.Text = "MAIN IMG";
            // 
            // txtMainIMG
            // 
            this.txtMainIMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMainIMG.Location = new System.Drawing.Point(87, 22);
            this.txtMainIMG.Name = "txtMainIMG";
            this.txtMainIMG.Size = new System.Drawing.Size(289, 20);
            this.txtMainIMG.TabIndex = 1;
            // 
            // btnMainIMG
            // 
            this.btnMainIMG.Location = new System.Drawing.Point(6, 19);
            this.btnMainIMG.Name = "btnMainIMG";
            this.btnMainIMG.Size = new System.Drawing.Size(75, 23);
            this.btnMainIMG.TabIndex = 0;
            this.btnMainIMG.Text = "Chọn Folder";
            this.btnMainIMG.UseVisualStyleBackColor = true;
            this.btnMainIMG.Click += new System.EventHandler(this.btnMainIMG_Click);
            // 
            // backgroundWorkerIMG
            // 
            this.backgroundWorkerIMG.WorkerReportsProgress = true;
            this.backgroundWorkerIMG.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerIMG_DoWork);
            this.backgroundWorkerIMG.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerIMG_ProgressChanged);
            this.backgroundWorkerIMG.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerIMG_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 391);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnTitle);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbResultImg.ResumeLayout(false);
            this.grbResultImg.PerformLayout();
            this.grbSubImg.ResumeLayout(false);
            this.grbSubImg.PerformLayout();
            this.grbMainImg.ResumeLayout(false);
            this.grbMainImg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbResultImg;
        private System.Windows.Forms.GroupBox grbSubImg;
        private System.Windows.Forms.GroupBox grbMainImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYpos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXpos;
        private System.Windows.Forms.TextBox txtResultIMG;
        private System.Windows.Forms.Button btnResultIMG;
        private System.Windows.Forms.TextBox txtSubIMG;
        private System.Windows.Forms.Button btnSubIMG;
        private System.Windows.Forms.TextBox txtMainIMG;
        private System.Windows.Forms.Button btnMainIMG;
        private System.ComponentModel.BackgroundWorker backgroundWorkerIMG;
        private System.Windows.Forms.Button btnMergeIMG;
        private System.Windows.Forms.ProgressBar prbMergeIMG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType;
    }
}

