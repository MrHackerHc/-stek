namespace İstek
{
    partial class ListLogin
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstlogib = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.geri);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nebusama-American Captain", 19.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button2.Location = new System.Drawing.Point(99, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Giriş";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.lstLogin);
            // 
            // lstlogib
            // 
            this.lstlogib.Location = new System.Drawing.Point(99, 83);
            this.lstlogib.Name = "lstlogib";
            this.lstlogib.Size = new System.Drawing.Size(100, 22);
            this.lstlogib.TabIndex = 4;
            this.lstlogib.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPress);
            // 
            // ListLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(308, 228);
            this.Controls.Add(this.lstlogib);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListLogin";
            this.Load += new System.EventHandler(this.ListLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lstlogib;
    }
}