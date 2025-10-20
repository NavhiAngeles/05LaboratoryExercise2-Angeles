using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingAFile
{
    public partial class FrmRegistration : Form
    {

        string StudentNum;
        string LastName;
        string FirstName;
        string MiddleInitial;
        string Program;
        string age;
        string birthday;
        string gender;
        string contactNum;

        public FrmRegistration()
        {
            InitializeComponent();
            ComboProgram.Items.Add("BSIT");
            ComboProgram.Items.Add("BSCS");
            ComboProgram.Items.Add("BSCPE");

            ComboGender.Items.Add("Male");
            ComboGender.Items.Add("Female");

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            StudentNum = txtStudentNum.Text;
            LastName = txtLastName.Text;
            FirstName = txtFirstName.Text;
            MiddleInitial = txtMI.Text;
            Program = ComboProgram.Text;
            age = txtAge.Text;
            birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
            gender = ComboGender.Text;
            contactNum = txtContactNum.Text;

            string relativePath = @"..\..\05LabExer(Angeles,Ivhan D.)";
            string docPath = Path.GetFullPath(relativePath);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            StudentNum + ".txt")))
            {
                outputFile.WriteLine("Student Number: " + StudentNum);
                outputFile.WriteLine("Full Name: " + LastName + "," + FirstName + "," + MiddleInitial + ".");
                outputFile.WriteLine("Program: " + Program);
                outputFile.WriteLine("Gender: " + gender);
                outputFile.WriteLine("Age: " + age);
                outputFile.WriteLine("Birthday: " + birthday);
                outputFile.WriteLine("Contact Number: " + contactNum);

                MessageBox.Show("Registration Successful!");
            }
        }

        private void BTNRECORDS_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show();
            this.Hide();
        }
    }
}
