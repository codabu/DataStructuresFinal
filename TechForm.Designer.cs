
namespace FinalProject
{
    partial class TechForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.assigneeBox = new System.Windows.Forms.ComboBox();
            this.assigneeLabel = new System.Windows.Forms.Label();
            this.reporterLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.infoTb = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.exitBtn);
            this.groupBox.Controls.Add(this.infoTb);
            this.groupBox.Controls.Add(this.filterCombo);
            this.groupBox.Controls.Add(this.filterLabel);
            this.groupBox.Controls.Add(this.prevBtn);
            this.groupBox.Controls.Add(this.nextBtn);
            this.groupBox.Controls.Add(this.assigneeBox);
            this.groupBox.Controls.Add(this.assigneeLabel);
            this.groupBox.Controls.Add(this.reporterLabel);
            this.groupBox.Controls.Add(this.priorityLabel);
            this.groupBox.Controls.Add(this.numberLabel);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(499, 354);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ticket Number:";
            // 
            // filterCombo
            // 
            this.filterCombo.FormattingEnabled = true;
            this.filterCombo.Items.AddRange(new object[] {
            "Ticket Number",
            "Priority"});
            this.filterCombo.Location = new System.Drawing.Point(330, 19);
            this.filterCombo.Name = "filterCombo";
            this.filterCombo.Size = new System.Drawing.Size(156, 23);
            this.filterCombo.TabIndex = 14;
            this.filterCombo.SelectedIndexChanged += new System.EventHandler(this.filterCombo_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(267, 22);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(64, 15);
            this.filterLabel.TabIndex = 13;
            this.filterLabel.Text = "Filter by:";
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(70, 317);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(74, 31);
            this.prevBtn.TabIndex = 12;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(150, 317);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(74, 31);
            this.nextBtn.TabIndex = 11;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // assigneeBox
            // 
            this.assigneeBox.FormattingEnabled = true;
            this.assigneeBox.Items.AddRange(new object[] {
            "Unassigned",
            "Jarrod",
            "Corry",
            "Alexis"});
            this.assigneeBox.Location = new System.Drawing.Point(17, 276);
            this.assigneeBox.Name = "assigneeBox";
            this.assigneeBox.Size = new System.Drawing.Size(207, 23);
            this.assigneeBox.TabIndex = 10;
            this.assigneeBox.SelectedIndexChanged += new System.EventHandler(this.assigneeBox_SelectedIndexChanged);
            // 
            // assigneeLabel
            // 
            this.assigneeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assigneeLabel.Location = new System.Drawing.Point(16, 240);
            this.assigneeLabel.Name = "assigneeLabel";
            this.assigneeLabel.Size = new System.Drawing.Size(208, 23);
            this.assigneeLabel.TabIndex = 9;
            // 
            // reporterLabel
            // 
            this.reporterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporterLabel.Location = new System.Drawing.Point(16, 207);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(208, 23);
            this.reporterLabel.TabIndex = 7;
            // 
            // priorityLabel
            // 
            this.priorityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityLabel.Location = new System.Drawing.Point(16, 174);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(208, 23);
            this.priorityLabel.TabIndex = 6;
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.SystemColors.Info;
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Location = new System.Drawing.Point(6, 17);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(66, 23);
            this.numberLabel.TabIndex = 4;
            // 
            // infoTb
            // 
            this.infoTb.Location = new System.Drawing.Point(16, 62);
            this.infoTb.Multiline = true;
            this.infoTb.Name = "infoTb";
            this.infoTb.ReadOnly = true;
            this.infoTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTb.Size = new System.Drawing.Size(460, 100);
            this.infoTb.TabIndex = 15;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(435, 317);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 31);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // TechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 388);
            this.Controls.Add(this.groupBox);
            this.Name = "TechForm";
            this.Text = "IT - View Tickets";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TechForm_FormClosing_1);
            this.Load += new System.EventHandler(this.TechForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label reporterLabel;
        private System.Windows.Forms.Label assigneeLabel;
        private System.Windows.Forms.ComboBox assigneeBox;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox infoTb;
        private System.Windows.Forms.Button exitBtn;
    }
}