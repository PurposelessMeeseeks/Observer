namespace Observer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.receiver3 = new Observer.Receiver();
            this.receiver2 = new Observer.Receiver();
            this.receiver1 = new Observer.Receiver();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(534, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // receiver3
            // 
            this.receiver3.Location = new System.Drawing.Point(534, 14);
            this.receiver3.Margin = new System.Windows.Forms.Padding(5);
            this.receiver3.Name = "receiver3";
            this.receiver3.Size = new System.Drawing.Size(250, 140);
            this.receiver3.TabIndex = 4;
            // 
            // receiver2
            // 
            this.receiver2.Location = new System.Drawing.Point(274, 14);
            this.receiver2.Margin = new System.Windows.Forms.Padding(5);
            this.receiver2.Name = "receiver2";
            this.receiver2.Size = new System.Drawing.Size(250, 140);
            this.receiver2.TabIndex = 3;
            // 
            // receiver1
            // 
            this.receiver1.Location = new System.Drawing.Point(14, 14);
            this.receiver1.Margin = new System.Windows.Forms.Padding(5);
            this.receiver1.Name = "receiver1";
            this.receiver1.Size = new System.Drawing.Size(250, 140);
            this.receiver1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.receiver3);
            this.Controls.Add(this.receiver2);
            this.Controls.Add(this.receiver1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Observer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Receiver receiver3;
        private Receiver receiver2;
        private Receiver receiver1;
    }
}

