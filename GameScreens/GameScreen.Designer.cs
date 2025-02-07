namespace GameScreens
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameBackButton = new System.Windows.Forms.Button();
            this.playsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameBackButton
            // 
            this.gameBackButton.Location = new System.Drawing.Point(94, 109);
            this.gameBackButton.Name = "gameBackButton";
            this.gameBackButton.Size = new System.Drawing.Size(75, 23);
            this.gameBackButton.TabIndex = 0;
            this.gameBackButton.Text = "back";
            this.gameBackButton.UseVisualStyleBackColor = true;
            this.gameBackButton.Click += new System.EventHandler(this.gameBackButton_Click);
            // 
            // playsLabel
            // 
            this.playsLabel.AutoSize = true;
            this.playsLabel.Location = new System.Drawing.Point(3, 0);
            this.playsLabel.Name = "playsLabel";
            this.playsLabel.Size = new System.Drawing.Size(46, 16);
            this.playsLabel.TabIndex = 1;
            this.playsLabel.Text = "plays: ";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.playsLabel);
            this.Controls.Add(this.gameBackButton);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(258, 253);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gameBackButton;
        private System.Windows.Forms.Label playsLabel;
    }
}
