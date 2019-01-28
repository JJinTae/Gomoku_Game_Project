namespace Client
{
    partial class SinglePlayForm
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
            this.bordPictur = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bordPictur)).BeginInit();
            this.SuspendLayout();
            // 
            // bordPictur
            // 
            this.bordPictur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.bordPictur.Location = new System.Drawing.Point(20, 20);
            this.bordPictur.Name = "bordPictur";
            this.bordPictur.Size = new System.Drawing.Size(500, 500);
            this.bordPictur.TabIndex = 0;
            this.bordPictur.TabStop = false;
            this.bordPictur.Click += new System.EventHandler(this.bordPictur_Click);
            this.bordPictur.Paint += new System.Windows.Forms.PaintEventHandler(this.bordPictur_Paint);
            this.bordPictur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bordPictur_MouseDown);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(653, 20);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "게임시작";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(568, 84);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(272, 15);
            this.status.TabIndex = 2;
            this.status.Text = "게임을 시작해 주세요.";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SinglePlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.status);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.bordPictur);
            this.Name = "SinglePlayForm";
            this.Text = "SinglePlayForm";
            this.Load += new System.EventHandler(this.SinglePlayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bordPictur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bordPictur;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label status;
    }
}