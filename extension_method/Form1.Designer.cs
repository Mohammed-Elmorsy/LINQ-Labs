namespace extension_method
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
            this.txt_print = new System.Windows.Forms.TextBox();
            this.print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_print
            // 
            this.txt_print.Location = new System.Drawing.Point(292, 111);
            this.txt_print.Name = "txt_print";
            this.txt_print.Size = new System.Drawing.Size(172, 20);
            this.txt_print.TabIndex = 0;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(341, 181);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 1;
            this.print.Text = "print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.txt_print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_print;
        private System.Windows.Forms.Button print;

    }
}

