
namespace Discord.NET_GUI_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_b = new System.Windows.Forms.Button();
            this.console_output_rtb = new System.Windows.Forms.RichTextBox();
            this.token_tb = new System.Windows.Forms.TextBox();
            this.token_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connect_b
            // 
            this.connect_b.Location = new System.Drawing.Point(706, 17);
            this.connect_b.Name = "connect_b";
            this.connect_b.Size = new System.Drawing.Size(97, 23);
            this.connect_b.TabIndex = 0;
            this.connect_b.Text = "Connect";
            this.connect_b.UseVisualStyleBackColor = true;
            this.connect_b.Click += new System.EventHandler(this.connect_b_Click);
            // 
            // console_output_rtb
            // 
            this.console_output_rtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.console_output_rtb.ForeColor = System.Drawing.SystemColors.Info;
            this.console_output_rtb.Location = new System.Drawing.Point(68, 46);
            this.console_output_rtb.Name = "console_output_rtb";
            this.console_output_rtb.Size = new System.Drawing.Size(623, 286);
            this.console_output_rtb.TabIndex = 1;
            this.console_output_rtb.Text = "";
            // 
            // token_tb
            // 
            this.token_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.token_tb.Location = new System.Drawing.Point(68, 17);
            this.token_tb.Name = "token_tb";
            this.token_tb.Size = new System.Drawing.Size(623, 23);
            this.token_tb.TabIndex = 2;
            // 
            // token_l
            // 
            this.token_l.AutoSize = true;
            this.token_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.token_l.ForeColor = System.Drawing.Color.Silver;
            this.token_l.Location = new System.Drawing.Point(7, 20);
            this.token_l.Name = "token_l";
            this.token_l.Size = new System.Drawing.Size(55, 16);
            this.token_l.TabIndex = 3;
            this.token_l.Text = "Token:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(850, 467);
            this.Controls.Add(this.token_l);
            this.Controls.Add(this.token_tb);
            this.Controls.Add(this.console_output_rtb);
            this.Controls.Add(this.connect_b);
            this.Name = "Form1";
            this.Text = "Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_b;
        private System.Windows.Forms.RichTextBox console_output_rtb;
        private System.Windows.Forms.TextBox token_tb;
        private System.Windows.Forms.Label token_l;
    }
}

