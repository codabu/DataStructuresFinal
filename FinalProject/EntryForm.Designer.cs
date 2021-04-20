
namespace FinalProject
{
    partial class EntryForm
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
            this.logBtn = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.techBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(151, 219);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(107, 39);
            this.logBtn.TabIndex = 0;
            this.logBtn.Text = "Log a ticket";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(114, 53);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(341, 58);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome to the IT ticketing system. \r\nPlease select an option below.";
            // 
            // techBtn
            // 
            this.techBtn.Location = new System.Drawing.Point(285, 219);
            this.techBtn.Name = "techBtn";
            this.techBtn.Size = new System.Drawing.Size(107, 39);
            this.techBtn.TabIndex = 2;
            this.techBtn.Text = "I.T Login";
            this.techBtn.UseVisualStyleBackColor = true;
            this.techBtn.Click += new System.EventHandler(this.techBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(507, 358);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(51, 31);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 392);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.techBtn);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.logBtn);
            this.Name = "EntryForm";
            this.Text = "Ticketing System";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button techBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

