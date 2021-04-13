
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.assigneeBox = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.assigneeBox);
            this.groupBox.Controls.Add(this.assigneeLabel);
            this.groupBox.Controls.Add(this.reporterLabel);
            this.groupBox.Controls.Add(this.priorityLabel);
            this.groupBox.Controls.Add(this.infoLabel);
            this.groupBox.Controls.Add(this.numberLabel);
            this.groupBox.Location = new System.Drawing.Point(56, 47);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(702, 354);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "View Ticket";
            // 
            // assigneeLabel
            // 
            this.assigneeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assigneeLabel.Location = new System.Drawing.Point(97, 180);
            this.assigneeLabel.Name = "assigneeLabel";
            this.assigneeLabel.Size = new System.Drawing.Size(208, 23);
            this.assigneeLabel.TabIndex = 9;
            // 
            // reporterLabel
            // 
            this.reporterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reporterLabel.Location = new System.Drawing.Point(97, 148);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(208, 23);
            this.reporterLabel.TabIndex = 7;
            // 
            // priorityLabel
            // 
            this.priorityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priorityLabel.Location = new System.Drawing.Point(97, 119);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(208, 23);
            this.priorityLabel.TabIndex = 6;
            // 
            // infoLabel
            // 
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Location = new System.Drawing.Point(97, 91);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(208, 23);
            this.infoLabel.TabIndex = 5;
            // 
            // numberLabel
            // 
            this.numberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberLabel.Location = new System.Drawing.Point(97, 61);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(208, 23);
            this.numberLabel.TabIndex = 4;
            // 
            // assigneeBox
            // 
            this.assigneeBox.FormattingEnabled = true;
            this.assigneeBox.Items.AddRange(new object[] {
            "Unassigned",
            "Jarrod",
            "Corry",
            "Alexis"});
            this.assigneeBox.Location = new System.Drawing.Point(97, 215);
            this.assigneeBox.Name = "assigneeBox";
            this.assigneeBox.Size = new System.Drawing.Size(207, 21);
            this.assigneeBox.TabIndex = 10;
            // 
            // TechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox);
            this.Name = "TechForm";
            this.Text = "IT - View Tickets";
            this.Load += new System.EventHandler(this.TechForm_Load);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label reporterLabel;
        private System.Windows.Forms.Label assigneeLabel;
        private System.Windows.Forms.ComboBox assigneeBox;
    }
}