namespace Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textUesrName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.checkBoxMSWord = new System.Windows.Forms.CheckBox();
            this.checkBoxMSPower = new System.Windows.Forms.CheckBox();
            this.checkBoxMSExcel = new System.Windows.Forms.CheckBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Skills";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Subject";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 39);
            this.label9.TabIndex = 8;
            this.label9.Text = "Registration";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(192, 100);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(310, 22);
            this.textName.TabIndex = 9;
            // 
            // textUesrName
            // 
            this.textUesrName.Location = new System.Drawing.Point(192, 138);
            this.textUesrName.Name = "textUesrName";
            this.textUesrName.Size = new System.Drawing.Size(310, 22);
            this.textUesrName.TabIndex = 10;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(192, 170);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(310, 22);
            this.textEmail.TabIndex = 11;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(192, 201);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(310, 22);
            this.textPass.TabIndex = 12;
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(192, 253);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 22);
            this.dob.TabIndex = 13;
            // 
            // checkBoxMSWord
            // 
            this.checkBoxMSWord.AutoSize = true;
            this.checkBoxMSWord.Location = new System.Drawing.Point(192, 299);
            this.checkBoxMSWord.Name = "checkBoxMSWord";
            this.checkBoxMSWord.Size = new System.Drawing.Size(85, 20);
            this.checkBoxMSWord.TabIndex = 14;
            this.checkBoxMSWord.Text = "MS Word";
            this.checkBoxMSWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxMSPower
            // 
            this.checkBoxMSPower.AutoSize = true;
            this.checkBoxMSPower.Location = new System.Drawing.Point(301, 299);
            this.checkBoxMSPower.Name = "checkBoxMSPower";
            this.checkBoxMSPower.Size = new System.Drawing.Size(120, 20);
            this.checkBoxMSPower.TabIndex = 15;
            this.checkBoxMSPower.Text = "MS PowerPoint";
            this.checkBoxMSPower.UseVisualStyleBackColor = true;
            // 
            // checkBoxMSExcel
            // 
            this.checkBoxMSExcel.AutoSize = true;
            this.checkBoxMSExcel.Location = new System.Drawing.Point(447, 299);
            this.checkBoxMSExcel.Name = "checkBoxMSExcel";
            this.checkBoxMSExcel.Size = new System.Drawing.Size(85, 20);
            this.checkBoxMSExcel.TabIndex = 16;
            this.checkBoxMSExcel.Text = "MS Excel";
            this.checkBoxMSExcel.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(192, 344);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMale.TabIndex = 17;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(272, 346);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemale.TabIndex = 18;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Items.AddRange(new object[] {
            "English",
            "Bangla",
            "Math",
            "ICT"});
            this.comboBoxSub.Location = new System.Drawing.Point(192, 403);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSub.TabIndex = 19;
            this.comboBoxSub.Text = "English";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(269, 482);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 16);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Submit";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 625);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBoxSub);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.checkBoxMSExcel);
            this.Controls.Add(this.checkBoxMSPower);
            this.Controls.Add(this.checkBoxMSWord);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textUesrName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textUesrName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.CheckBox checkBoxMSWord;
        private System.Windows.Forms.CheckBox checkBoxMSPower;
        private System.Windows.Forms.CheckBox checkBoxMSExcel;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

