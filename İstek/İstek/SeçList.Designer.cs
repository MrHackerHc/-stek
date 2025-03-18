namespace İstek
{
    partial class SeçList
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(123, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Şikayet Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.sklst);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Öneri Listele";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.onerilist);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.geri);
            // 
            // SeçList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(382, 263);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SeçList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeçList";
            this.Load += new System.EventHandler(this.SeçList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}