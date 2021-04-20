
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
            this.assigneeLabel = new System.Windows.Forms.Label();
            this.reporterLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityCombo = new System.Windows.Forms.ComboBox();
            this.reporterTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.infoTb = new System.Windows.Forms.TextBox();
            this.filterCombo = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.assigneeCombo = new System.Windows.Forms.ComboBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.infoLabel);
            this.groupBox.Controls.Add(this.assigneeLabel);
            this.groupBox.Controls.Add(this.reporterLabel);
            this.groupBox.Controls.Add(this.priorityLabel);
            this.groupBox.Controls.Add(this.priorityCombo);
            this.groupBox.Controls.Add(this.reporterTb);
            this.groupBox.Controls.Add(this.saveBtn);
            this.groupBox.Controls.Add(this.editBtn);
            this.groupBox.Controls.Add(this.exitBtn);
            this.groupBox.Controls.Add(this.infoTb);
            this.groupBox.Controls.Add(this.filterCombo);
            this.groupBox.Controls.Add(this.filterLabel);
            this.groupBox.Controls.Add(this.prevBtn);
            this.groupBox.Controls.Add(this.nextBtn);
            this.groupBox.Controls.Add(this.assigneeCombo);
            this.groupBox.Controls.Add(this.numberLabel);
            this.groupBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(499, 354);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ticket Number:";
            // 
            // assigneeLabel
            // 
            this.assigneeLabel.AutoSize = true;
            this.assigneeLabel.Location = new System.Drawing.Point(20, 270);
            this.assigneeLabel.Name = "assigneeLabel";
            this.assigneeLabel.Size = new System.Drawing.Size(73, 15);
            this.assigneeLabel.TabIndex = 23;
            this.assigneeLabel.Text = "Assignee: ";
            // 
            // reporterLabel
            // 
            this.reporterLabel.AutoSize = true;
            this.reporterLabel.Location = new System.Drawing.Point(21, 228);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(72, 15);
            this.reporterLabel.TabIndex = 22;
            this.reporterLabel.Text = "Reporter: ";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(30, 193);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(63, 15);
            this.priorityLabel.TabIndex = 21;
            this.priorityLabel.Text = "Priority: ";
            // 
            // priorityCombo
            // 
            this.priorityCombo.Enabled = false;
            this.priorityCombo.FormattingEnabled = true;
            this.priorityCombo.Location = new System.Drawing.Point(99, 190);
            this.priorityCombo.Name = "priorityCombo";
            this.priorityCombo.Size = new System.Drawing.Size(369, 23);
            this.priorityCombo.TabIndex = 20;
            // 
            // reporterTb
            // 
            this.reporterTb.Location = new System.Drawing.Point(99, 225);
            this.reporterTb.Name = "reporterTb";
            this.reporterTb.ReadOnly = true;
            this.reporterTb.Size = new System.Drawing.Size(369, 23);
            this.reporterTb.TabIndex = 19;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(330, 317);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(74, 31);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(227, 317);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(74, 31);
            this.editBtn.TabIndex = 17;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(425, 317);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 31);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // infoTb
            // 
            this.infoTb.Location = new System.Drawing.Point(23, 84);
            this.infoTb.Multiline = true;
            this.infoTb.Name = "infoTb";
            this.infoTb.ReadOnly = true;
            this.infoTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTb.Size = new System.Drawing.Size(460, 100);
            this.infoTb.TabIndex = 15;
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
            this.prevBtn.Location = new System.Drawing.Point(16, 317);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(74, 31);
            this.prevBtn.TabIndex = 12;
            this.prevBtn.Text = "Previous";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(122, 317);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(74, 31);
            this.nextBtn.TabIndex = 11;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // assigneeCombo
            // 
            this.assigneeCombo.Enabled = false;
            this.assigneeCombo.FormattingEnabled = true;
            this.assigneeCombo.Location = new System.Drawing.Point(99, 267);
            this.assigneeCombo.Name = "assigneeCombo";
            this.assigneeCombo.Size = new System.Drawing.Size(369, 23);
            this.assigneeCombo.TabIndex = 10;
            // 
            // numberLabel
            // 
            this.numberLabel.BackColor = System.Drawing.SystemColors.Info;
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Location = new System.Drawing.Point(16, 19);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(66, 23);
            this.numberLabel.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(20, 66);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(90, 15);
            this.infoLabel.TabIndex = 24;
            this.infoLabel.Text = "Description: ";
            // 
            // TechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 390);
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
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.ComboBox assigneeCombo;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ComboBox filterCombo;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox infoTb;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.TextBox reporterTb;
        private System.Windows.Forms.ComboBox priorityCombo;
        private System.Windows.Forms.Label assigneeLabel;
        private System.Windows.Forms.Label reporterLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}