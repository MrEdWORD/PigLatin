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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtBoxUserInput = new System.Windows.Forms.TextBox();
            this.picBoxPiggy = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPiggy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(16, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(447, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Type something to convert it to Pig Latin!";
            // 
            // txtBoxUserInput
            // 
            this.txtBoxUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUserInput.Location = new System.Drawing.Point(32, 32);
            this.txtBoxUserInput.Multiline = true;
            this.txtBoxUserInput.Name = "txtBoxUserInput";
            this.txtBoxUserInput.Size = new System.Drawing.Size(308, 110);
            this.txtBoxUserInput.TabIndex = 1;
            // 
            // picBoxPiggy
            // 
            this.picBoxPiggy.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPiggy.Image")));
            this.picBoxPiggy.Location = new System.Drawing.Point(346, 32);
            this.picBoxPiggy.Name = "picBoxPiggy";
            this.picBoxPiggy.Size = new System.Drawing.Size(117, 89);
            this.picBoxPiggy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPiggy.TabIndex = 4;
            this.picBoxPiggy.TabStop = false;
            this.picBoxPiggy.Click += new System.EventHandler(this.picBoxPiggy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click da Piggy!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxUserInput);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.picBoxPiggy);
            this.Name = "Form1";
            this.Text = "Pig Latin Translator";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPiggy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtBoxUserInput;
        private System.Windows.Forms.PictureBox picBoxPiggy;
        private System.Windows.Forms.Label label1;
    }
}