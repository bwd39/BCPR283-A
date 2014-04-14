namespace WindowsFormsApplication1
{
    partial class LevelCreator
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
            this.exiting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exiting
            // 
            this.exiting.Location = new System.Drawing.Point(1071, 443);
            this.exiting.Name = "exiting";
            this.exiting.Size = new System.Drawing.Size(112, 118);
            this.exiting.TabIndex = 0;
            this.exiting.Text = "Exit";
            this.exiting.UseVisualStyleBackColor = true;
            this.exiting.Click += new System.EventHandler(this.button1_Click);
            this.exiting.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exiting_MouseClick);
            // 
            // LevelCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 986);
            this.Controls.Add(this.exiting);
            this.Name = "LevelCreator";
            this.Text = "Theseus vs. Minotaur Level Creator";
            this.Load += new System.EventHandler(this.LevelCreator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exiting;
    }
}

