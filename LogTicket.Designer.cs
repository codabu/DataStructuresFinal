
namespace FinalProject
{
    partial class LogTicket
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
            this.numberLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoTb = new System.Windows.Forms.TextBox();
            this.numDisplayLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.reporterLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(292, 59);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(109, 15);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Ticket Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description of the problem:";
            // 
            // infoTb
            // 
            this.infoTb.Location = new System.Drawing.Point(96, 109);
            this.infoTb.Multiline = true;
            this.infoTb.Name = "infoTb";
            this.infoTb.Size = new System.Drawing.Size(357, 107);
            this.infoTb.TabIndex = 3;
            // 
            // numDisplayLabel
            // 
            this.numDisplayLabel.BackColor = System.Drawing.SystemColors.Info;
            this.numDisplayLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDisplayLabel.Location = new System.Drawing.Point(407, 59);
            this.numDisplayLabel.Name = "numDisplayLabel";
            this.numDisplayLabel.Size = new System.Drawing.Size(46, 15);
            this.numDisplayLabel.TabIndex = 4;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(93, 229);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(47, 13);
            this.priorityLabel.TabIndex = 5;
            this.priorityLabel.Text = "Priotrity :";
            // 
            // priorityBox
            // 
            this.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priorityBox.Location = new System.Drawing.Point(154, 226);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(299, 21);
            this.priorityBox.TabIndex = 7;
            // 
            // reporterLabel
            // 
            this.reporterLabel.AutoSize = true;
            this.reporterLabel.Location = new System.Drawing.Point(79, 256);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(61, 13);
            this.reporterLabel.TabIndex = 8;
            this.reporterLabel.Text = "Your name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 9;
            // 
            // LogTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reporterLabel);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.numDisplayLabel);
            this.Controls.Add(this.infoTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberLabel);
            this.Name = "LogTicket";
            this.Text = "Log a ticket";
            this.Load += new System.EventHandler(this.LogTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infoTb;
        private System.Windows.Forms.Label numDisplayLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label reporterLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}