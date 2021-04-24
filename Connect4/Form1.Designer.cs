
namespace Connect4
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
            this.btn_col1 = new System.Windows.Forms.Button();
            this.btn_col2 = new System.Windows.Forms.Button();
            this.btn_col3 = new System.Windows.Forms.Button();
            this.btn_col4 = new System.Windows.Forms.Button();
            this.btn_col5 = new System.Windows.Forms.Button();
            this.btn_col6 = new System.Windows.Forms.Button();
            this.btn_col7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_col1
            // 
            this.btn_col1.Location = new System.Drawing.Point(75, 15);
            this.btn_col1.Name = "btn_col1";
            this.btn_col1.Size = new System.Drawing.Size(50, 25);
            this.btn_col1.TabIndex = 0;
            this.btn_col1.Text = "V";
            this.btn_col1.UseVisualStyleBackColor = true;
            this.btn_col1.Click += new System.EventHandler(this.btn_col1_Click);
            // 
            // btn_col2
            // 
            this.btn_col2.Location = new System.Drawing.Point(175, 15);
            this.btn_col2.Name = "btn_col2";
            this.btn_col2.Size = new System.Drawing.Size(50, 25);
            this.btn_col2.TabIndex = 1;
            this.btn_col2.Text = "V";
            this.btn_col2.UseVisualStyleBackColor = true;
            // 
            // btn_col3
            // 
            this.btn_col3.Location = new System.Drawing.Point(275, 15);
            this.btn_col3.Name = "btn_col3";
            this.btn_col3.Size = new System.Drawing.Size(50, 25);
            this.btn_col3.TabIndex = 2;
            this.btn_col3.Text = "V";
            this.btn_col3.UseVisualStyleBackColor = true;
            // 
            // btn_col4
            // 
            this.btn_col4.Location = new System.Drawing.Point(375, 15);
            this.btn_col4.Name = "btn_col4";
            this.btn_col4.Size = new System.Drawing.Size(50, 25);
            this.btn_col4.TabIndex = 3;
            this.btn_col4.Text = "V";
            this.btn_col4.UseVisualStyleBackColor = true;
            // 
            // btn_col5
            // 
            this.btn_col5.Location = new System.Drawing.Point(475, 15);
            this.btn_col5.Name = "btn_col5";
            this.btn_col5.Size = new System.Drawing.Size(50, 25);
            this.btn_col5.TabIndex = 4;
            this.btn_col5.Text = "V";
            this.btn_col5.UseVisualStyleBackColor = true;
            // 
            // btn_col6
            // 
            this.btn_col6.Location = new System.Drawing.Point(575, 15);
            this.btn_col6.Name = "btn_col6";
            this.btn_col6.Size = new System.Drawing.Size(50, 25);
            this.btn_col6.TabIndex = 5;
            this.btn_col6.Text = "V";
            this.btn_col6.UseVisualStyleBackColor = true;
            // 
            // btn_col7
            // 
            this.btn_col7.Location = new System.Drawing.Point(675, 15);
            this.btn_col7.Name = "btn_col7";
            this.btn_col7.Size = new System.Drawing.Size(50, 25);
            this.btn_col7.TabIndex = 6;
            this.btn_col7.Text = "V";
            this.btn_col7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 729);
            this.Controls.Add(this.btn_col7);
            this.Controls.Add(this.btn_col6);
            this.Controls.Add(this.btn_col5);
            this.Controls.Add(this.btn_col4);
            this.Controls.Add(this.btn_col3);
            this.Controls.Add(this.btn_col2);
            this.Controls.Add(this.btn_col1);
            this.Name = "Form1";
            this.Text = "Connect 4 - My Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_col1;
        private System.Windows.Forms.Button btn_col2;
        private System.Windows.Forms.Button btn_col3;
        private System.Windows.Forms.Button btn_col4;
        private System.Windows.Forms.Button btn_col5;
        private System.Windows.Forms.Button btn_col6;
        private System.Windows.Forms.Button btn_col7;
    }
}