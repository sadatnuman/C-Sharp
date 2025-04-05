using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        string NAME, USERNAME, PASSWORD, EMAIL,DOB ,SKILLS,GANDER,SUBJECT;
        public Form1()
        {
            InitializeComponent();
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textName.Text != "")
                NAME = textName.Text;
            else { MessageBox.Show("Write your Name."); }
            if (textUesrName.Text != "")
                USERNAME = textUesrName.Text;
            else { MessageBox.Show("Write your UserName."); }
            if (textEmail.Text != "")
                EMAIL = textEmail.Text;
            else { MessageBox.Show("Write your Email."); }
            if (textPass.Text != "")
                PASSWORD = textPass.Text;
            else { MessageBox.Show("Enter the Password."); }
            DOB = dob.Value.ToString();
            if (checkBoxMSWord.Checked)
                SKILLS = "MS Word";
            if (checkBoxMSPower.Checked)
                SKILLS += ", MS Power Point";
            if (checkBoxMSExcel.Checked)
                SKILLS += ", MS Excel";
            if (radioButtonMale.Checked)
                GANDER = "Male";
            else if (radioButtonFemale.Checked)
                GANDER = "Female";
            else { 
            GANDER = " ";
            MessageBox.Show("Select the Gender."); }
            SUBJECT = comboBoxSub.Text;
            MessageBox.Show("Name: " + NAME + "\n User Name: " + USERNAME + "\n Email: " + EMAIL + "\n Password: " + PASSWORD + "\n Date of Birth: " + DOB + "\n Skills: " + SKILLS + "\n Gender: " + GANDER + "\n Subject: " + SUBJECT);
            
        }
    }
}
