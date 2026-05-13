namespace AbsoluteCipher
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnAddNoise = new System.Windows.Forms.Button();
            this.btnClearNoise = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(460, 100);
            this.txtInput.TabIndex = 0;

            this.btnEncrypt.Location = new System.Drawing.Point(12, 118);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(110, 30);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            this.btnDecrypt.Location = new System.Drawing.Point(128, 118);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(110, 30);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            this.btnAddNoise.Location = new System.Drawing.Point(244, 118);
            this.btnAddNoise.Name = "btnAddNoise";
            this.btnAddNoise.Size = new System.Drawing.Size(110, 30);
            this.btnAddNoise.TabIndex = 3;
            this.btnAddNoise.Text = "Добавить шум";
            this.btnAddNoise.UseVisualStyleBackColor = true;
            this.btnAddNoise.Click += new System.EventHandler(this.btnAddNoise_Click);

            this.btnClearNoise.Location = new System.Drawing.Point(362, 118);
            this.btnClearNoise.Name = "btnClearNoise";
            this.btnClearNoise.Size = new System.Drawing.Size(110, 30);
            this.btnClearNoise.TabIndex = 4;
            this.btnClearNoise.Text = "Очистить шум";
            this.btnClearNoise.UseVisualStyleBackColor = true;
            this.btnClearNoise.Click += new System.EventHandler(this.btnClearNoise_Click);

            this.txtOutput.Location = new System.Drawing.Point(12, 154);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(460, 100);
            this.txtOutput.TabIndex = 5;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 266);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnClearNoise);
            this.Controls.Add(this.btnAddNoise);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Absolute Cipher v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnAddNoise;
        private System.Windows.Forms.Button btnClearNoise;
    }
}