using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD6502_Assignment1part2_QiangZhang2173138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Re_enrolStudent
        {
            public string surname;
            public string firstname;
            public string dateofbirth;
            public string gender;
            public int studentid;
            public string houseNumber;
            public string streerName;
            public string city, country;
            public int postCode;
            public string email;
            public int mobile;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Re_enrolStudent student;

            
            student.surname = textBoxSurname.Text;
            student.firstname = textBoxFirstName.Text;            
            student.dateofbirth = dateTimePickerDateofbirth.Text;
            student.gender = comboBoxGender.Text;
            student.studentid = int.Parse(textBoxStudentID.Text);
            student.houseNumber = textBoxHouseNumber.Text;
            student.streerName = textBoxStreetName.Text;
            student.city = textBoxCity.Text;
            student.country = textBoxCountry.Text;
            student.postCode =int.Parse(textBoxPostcode.Text);
            student.email = textBoxEmail.Text;
            student.mobile =int.Parse(textBoxMobile.Text);

            string name = "Student Name: "+student.surname + student.firstname+"\n";
            string dateofbirth = "Date of Birth:" + student.dateofbirth + "\n";
            string gender = "Gender: " + student.gender + "\n";
            string ID = "Student ID: " + student.studentid + "\n";
            string address = "Address: " + student.houseNumber+" " + student.streerName + " " + student.city + " " + student.country + " " + "\n" + "Post Code: " + student.postCode + "\n";
            string email = "Email: " + student.email + "\n";
            string mobile = "Mobile: " + student.mobile + "\n";


            MessageBox.Show(name+dateofbirth+gender+ID+address+email+mobile);

        

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBoxHouseNumber_TextChanged(object sender, EventArgs e)
        {
  

        }
    }
}
