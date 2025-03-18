using System.Windows.Forms;

namespace İstek
{
    partial class ŞikayetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtÖneri = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nebusama-American Captain", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şikayet";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.geri);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button2.Location = new System.Drawing.Point(62, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Şikayette Bulun";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Sikayet);
            // 
            // txtÖneri
            // 
            this.txtÖneri.Location = new System.Drawing.Point(65, 60);
            this.txtÖneri.Name = "txtÖneri";
            this.txtÖneri.Size = new System.Drawing.Size(217, 96);
            this.txtÖneri.TabIndex = 0;
            this.txtÖneri.Text = "";
            this.txtÖneri.TextChanged += new System.EventHandler(this.txtÖneri_TextChanged);
            this.txtÖneri.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SikayetKey);
            // 
            // ŞikayetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(348, 270);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtÖneri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ŞikayetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ŞikayetForm";
            this.Load += new System.EventHandler(this.ŞikayetForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private RichTextBox txtÖneri;
    }
}