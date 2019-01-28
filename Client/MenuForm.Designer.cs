namespace Client
{
    partial class MenuForm
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
            this.singleplayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.multiPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // singleplayButton
            // 
            this.singleplayButton.Location = new System.Drawing.Point(236, 105);
            this.singleplayButton.Name = "singleplayButton";
            this.singleplayButton.Size = new System.Drawing.Size(100, 40);
            this.singleplayButton.TabIndex = 0;
            this.singleplayButton.Text = "혼자하기";
            this.singleplayButton.UseVisualStyleBackColor = true;
            this.singleplayButton.Click += new System.EventHandler(this.singleplayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(236, 197);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "종료하기";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // multiPlayButton
            // 
            this.multiPlayButton.Location = new System.Drawing.Point(236, 151);
            this.multiPlayButton.Name = "multiPlayButton";
            this.multiPlayButton.Size = new System.Drawing.Size(100, 40);
            this.multiPlayButton.TabIndex = 2;
            this.multiPlayButton.Text = "함께하기";
            this.multiPlayButton.UseVisualStyleBackColor = true;
            this.multiPlayButton.Click += new System.EventHandler(this.multiPlayButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.multiPlayButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.singleplayButton);
            this.Name = "MenuForm";
            this.Text = "Gomoku Game Project";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button singleplayButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button multiPlayButton;
    }
}