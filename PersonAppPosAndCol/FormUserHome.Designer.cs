
namespace PersonAppPosAndCol
{
    partial class FormUserHome
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
            this.components = new System.ComponentModel.Container();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lblTimeShow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(374, 211);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(29, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "User";
            // 
            // lblTheme
            // 
            this.lblTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTheme.Location = new System.Drawing.Point(684, 417);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(119, 36);
            this.lblTheme.TabIndex = 1;
            this.lblTheme.Text = "Theme";
            this.lblTheme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTheme.Click += new System.EventHandler(this.lblTheme_Click);
            // 
            // lblTimeShow
            // 
            this.lblTimeShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTimeShow.Location = new System.Drawing.Point(0, 417);
            this.lblTimeShow.Name = "lblTimeShow";
            this.lblTimeShow.Size = new System.Drawing.Size(119, 36);
            this.lblTimeShow.TabIndex = 2;
            this.lblTimeShow.Text = "00:00:00";
            this.lblTimeShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormUserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeShow);
            this.Controls.Add(this.lblTheme);
            this.Controls.Add(this.lblUsername);
            this.Name = "FormUserHome";
            this.Text = "Form User Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUserHome_FormClosing);
            this.Load += new System.EventHandler(this.FormUserHome_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormUserHome_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lblTimeShow;
        private System.Windows.Forms.Timer timer1;
    }
}