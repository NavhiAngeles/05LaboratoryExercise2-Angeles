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
    public partial class FrmStudentRecord : Form
    {
        FrmRegistration frmReg = new FrmRegistration();

        public void DisplaytoList(string path)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            using (StreamReader streamReader = File.OpenText(path))
            {
                string _getText = "";
                while ((_getText = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(_getText);
                    lvViewRec.Items.Add(_getText);
                }
            }
        }

        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully Uploaded!");
            lvViewRec.Items.Clear();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmReg.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DisplaytoList(openFileDialog1.FileName);



        }
    }
}
