
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
            this.reporterTb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(292, 18);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(109, 15);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Ticket Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Description of the problem:";
            // 
            // infoTb
            // 
            this.infoTb.Location = new System.Drawing.Point(12, 83);
            this.infoTb.Multiline = true;
            this.infoTb.Name = "infoTb";
            this.infoTb.Size = new System.Drawing.Size(441, 133);
            this.infoTb.TabIndex = 3;
            // 
            // numDisplayLabel
            // 
            this.numDisplayLabel.BackColor = System.Drawing.SystemColors.Info;
            this.numDisplayLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDisplayLabel.Location = new System.Drawing.Point(407, 18);
            this.numDisplayLabel.Name = "numDisplayLabel";
            this.numDisplayLabel.Size = new System.Drawing.Size(46, 15);
            this.numDisplayLabel.TabIndex = 4;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(297, 228);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(68, 15);
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
            this.priorityBox.Location = new System.Drawing.Point(371, 226);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(82, 21);
            this.priorityBox.TabIndex = 7;
            // 
            // reporterLabel
            // 
            this.reporterLabel.AutoSize = true;
            this.reporterLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reporterLabel.Location = new System.Drawing.Point(231, 255);
            this.reporterLabel.Name = "reporterLabel";
            this.reporterLabel.Size = new System.Drawing.Size(80, 15);
            this.reporterLabel.TabIndex = 8;
            this.reporterLabel.Text = "Your name:";
            // 
            // reporterTb
            // 
            this.reporterTb.Location = new System.Drawing.Point(317, 253);
            this.reporterTb.Name = "reporterTb";
            this.reporterTb.Size = new System.Drawing.Size(136, 20);
            this.reporterTb.TabIndex = 9;
            this.reporterTb.TextChanged += new System.EventHandler(this.reporterTb_TextChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(388, 290);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(65, 22);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(317, 290);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(65, 22);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(222, 331);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 12;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 290);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 22);
            this.exitBtn.TabIndex = 17;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LogTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 406);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.reporterTb);
            this.Controls.Add(this.reporterLabel);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.numDisplayLabel);
            this.Controls.Add(this.infoTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberLabel);
            this.Name = "LogTicket";
            this.Text = "Log a ticket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogTicket_FormClosing);
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
        private System.Windows.Forms.TextBox reporterTb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button exitBtn;
    }
}