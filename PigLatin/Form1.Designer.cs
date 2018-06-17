namespace PigLatin
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
            this.LblHeader = new System.Windows.Forms.Label();
            this.TxtBoxUserInput = new System.Windows.Forms.TextBox();
            this.LblPigLatin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(16, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(447, 26);
            this.LblHeader.TabIndex = 0;
            this.LblHeader.Text = "Type something to convert it to Pig Latin!";
            // 
            // TxtBoxUserInput
            // 
            this.TxtBoxUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxUserInput.Location = new System.Drawing.Point(30, 38);
            this.TxtBoxUserInput.Multiline = true;
            this.TxtBoxUserInput.Name = "TxtBoxUserInput";
            this.TxtBoxUserInput.Size = new System.Drawing.Size(415, 34);
            this.TxtBoxUserInput.TabIndex = 1;
            // 
            // LblPigLatin
            // 
            this.LblPigLatin.AutoSize = true;
            this.LblPigLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPigLatin.Location = new System.Drawing.Point(21, 96);
            this.LblPigLatin.Name = "LblPigLatin";
            this.LblPigLatin.Size = new System.Drawing.Size(288, 20);
            this.LblPigLatin.TabIndex = 2;
            this.LblPigLatin.Text = "This will be the converted Pig Latin Text!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 154);
            this.Controls.Add(this.LblPigLatin);
            this.Controls.Add(this.TxtBoxUserInput);
            this.Controls.Add(this.LblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.TextBox TxtBoxUserInput;
        private System.Windows.Forms.Label LblPigLatin;
    }
}