using System;

namespace İstek
{
    partial class List
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
            this.sikayetlist = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sikayetlist)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button1.Location = new System.Drawing.Point(12, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sikayetlist
            // 
            this.sikayetlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sikayetlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sikayetlist.Location = new System.Drawing.Point(12, 12);
            this.sikayetlist.Name = "sikayetlist";
            this.sikayetlist.ReadOnly = true;
            this.sikayetlist.RowHeadersWidth = 51;
            this.sikayetlist.RowTemplate.Height = 24;
            this.sikayetlist.Size = new System.Drawing.Size(776, 383);
            this.sikayetlist.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("TR DoorsBlack", 10.2F);
            this.button2.Location = new System.Drawing.Point(698, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.sil);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sikayetlist);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sikayetlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private readonly EventHandler IdDelete_TextChanged;
        private System.Windows.Forms.DataGridView sikayetlist;
        private System.Windows.Forms.Button button2;
    }
}