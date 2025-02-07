namespace GameScreens
{
    partial class InstructionScreen
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
            this.instructBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructBackButton
            // 
            this.instructBackButton.Location = new System.Drawing.Point(98, 115);
            this.instructBackButton.Name = "instructBackButton";
            this.instructBackButton.Size = new System.Drawing.Size(75, 23);
            this.instructBackButton.TabIndex = 0;
            this.instructBackButton.Text = "back";
            this.instructBackButton.UseVisualStyleBackColor = true;
            this.instructBackButton.Click += new System.EventHandler(this.instructBackButton_Click);
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.Controls.Add(this.instructBackButton);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(275, 272);
            this.Load += new System.EventHandler(this.InstructionScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instructBackButton;
    }
}
