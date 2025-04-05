namespace LoginForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            text_UserName = new TextBox();
            text_pass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(405, 28);
            label1.Name = "label1";
            label1.Size = new Size(176, 45);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(170, 136);
            label2.Name = "label2";
            label2.Size = new Size(114, 26);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(182, 199);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // text_UserName
            // 
            text_UserName.Location = new Point(316, 135);
            text_UserName.Name = "text_UserName";
            text_UserName.Size = new Size(435, 27);
            text_UserName.TabIndex = 4;
            // 
            // text_pass
            // 
            text_pass.Location = new Point(316, 198);
            text_pass.Name = "text_pass";
            text_pass.Size = new Size(435, 27);
            text_pass.TabIndex = 5;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(456, 290);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(575, 242);
            button2.Name = "button2";
            button2.Size = new Size(176, 29);
            button2.TabIndex = 7;
            button2.Text = "Forgot your passwoed?";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(508, 386);
            button3.Name = "button3";
            button3.Size = new Size(114, 29);
            button3.TabIndex = 8;
            button3.Text = "Register Now";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(329, 389);
            label4.Name = "label4";
            label4.Size = new Size(173, 22);
            label4.TabIndex = 9;
            label4.Text = "Don't have account ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(478, 335);
            label5.Name = "label5";
            label5.Size = new Size(54, 33);
            label5.TabIndex = 10;
            label5.Text = "OR";
            // 
            // button4
            // 
            button4.Location = new Point(184, 482);
            button4.Name = "button4";
            button4.Size = new Size(100, 32);
            button4.TabIndex = 11;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(961, 619);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(text_pass);
            Controls.Add(text_UserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_UserName;
        private TextBox text_pass;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Button button4;
    }
}
