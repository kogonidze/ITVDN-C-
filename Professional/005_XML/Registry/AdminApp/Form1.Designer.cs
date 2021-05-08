
namespace AdminApp
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
            this.welcomeMsg_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.setWelcomeMsg_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.setBackgroundColor_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // welcomeMsg_textBox
            // 
            this.welcomeMsg_textBox.Location = new System.Drawing.Point(176, 16);
            this.welcomeMsg_textBox.Name = "welcomeMsg_textBox";
            this.welcomeMsg_textBox.Size = new System.Drawing.Size(141, 20);
            this.welcomeMsg_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome msg in client app:";
            // 
            // setWelcomeMsg_button
            // 
            this.setWelcomeMsg_button.Location = new System.Drawing.Point(345, 16);
            this.setWelcomeMsg_button.Name = "setWelcomeMsg_button";
            this.setWelcomeMsg_button.Size = new System.Drawing.Size(75, 23);
            this.setWelcomeMsg_button.TabIndex = 2;
            this.setWelcomeMsg_button.Text = "Set";
            this.setWelcomeMsg_button.UseVisualStyleBackColor = true;
            this.setWelcomeMsg_button.Click += new System.EventHandler(this.setWelcomeMsg_button_Click);
            // 
            // setBackgroundColor_button
            // 
            this.setBackgroundColor_button.Location = new System.Drawing.Point(345, 65);
            this.setBackgroundColor_button.Name = "setBackgroundColor_button";
            this.setBackgroundColor_button.Size = new System.Drawing.Size(75, 23);
            this.setBackgroundColor_button.TabIndex = 3;
            this.setBackgroundColor_button.Text = "Set";
            this.setBackgroundColor_button.UseVisualStyleBackColor = true;
            this.setBackgroundColor_button.Click += new System.EventHandler(this.setBackgroundColor_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Background color in client app:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "                                            ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 113);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setBackgroundColor_button);
            this.Controls.Add(this.setWelcomeMsg_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeMsg_textBox);
            this.Name = "Form1";
            this.Text = "AdminApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox welcomeMsg_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setWelcomeMsg_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button setBackgroundColor_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

