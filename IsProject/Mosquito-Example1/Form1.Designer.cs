namespace Mosquito_Example1
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
            this.buttonPublish = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUnSubcribes = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPublish
            // 
            this.buttonPublish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPublish.ForeColor = System.Drawing.Color.LawnGreen;
            this.buttonPublish.Location = new System.Drawing.Point(205, 240);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(149, 30);
            this.buttonPublish.TabIndex = 0;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = false;
            this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 297);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(495, 281);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Topic";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonUnSubcribes
            // 
            this.buttonUnSubcribes.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUnSubcribes.ForeColor = System.Drawing.Color.Orange;
            this.buttonUnSubcribes.Location = new System.Drawing.Point(395, 241);
            this.buttonUnSubcribes.Name = "buttonUnSubcribes";
            this.buttonUnSubcribes.Size = new System.Drawing.Size(157, 29);
            this.buttonUnSubcribes.TabIndex = 5;
            this.buttonUnSubcribes.Text = "Unsubcribe all topics";
            this.buttonUnSubcribes.UseVisualStyleBackColor = false;
            this.buttonUnSubcribes.Click += new System.EventHandler(this.buttonUnSubcribes_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 108);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 628);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonUnSubcribes);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonPublish);
            this.Name = "Form1";
            this.Text = "Mosquito-Example 1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonUnSubcribes;
        private System.Windows.Forms.TextBox textBox1;
    }
}

