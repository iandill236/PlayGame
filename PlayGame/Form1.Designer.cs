namespace PlayGame
{
    partial class AG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AG));
            this.button1 = new System.Windows.Forms.Button();
            this.countDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Mixage Bk BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(288, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // countDown
            // 
            this.countDown.Font = new System.Drawing.Font("mono 07_65", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDown.ForeColor = System.Drawing.Color.Crimson;
            this.countDown.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.countDown.Location = new System.Drawing.Point(55, 9);
            this.countDown.Name = "countDown";
            this.countDown.Size = new System.Drawing.Size(697, 295);
            this.countDown.TabIndex = 1;
            this.countDown.Text = "Game";
            this.countDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countDown.Click += new System.EventHandler(this.CountDown_Click);
            // 
            // AG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countDown);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AG";
            this.Text = "AG";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label countDown;
    }
}

