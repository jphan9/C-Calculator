namespace CSharpCalculator
{
    partial class Form1
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
            this.acButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acButton
            // 
            this.acButton.Location = new System.Drawing.Point(12, 121);
            this.acButton.Name = "acButton";
            this.acButton.Size = new System.Drawing.Size(80, 50);
            this.acButton.TabIndex = 0;
            this.acButton.Text = "AC";
            this.acButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(12, 190);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(80, 46);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(119, 190);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(80, 46);
            this.eightButton.TabIndex = 2;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(227, 190);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(80, 46);
            this.nineButton.TabIndex = 3;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(341, 190);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(80, 46);
            this.multiplicationButton.TabIndex = 4;
            this.multiplicationButton.Text = "X";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 548);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.acButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button acButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button multiplicationButton;
    }
}

