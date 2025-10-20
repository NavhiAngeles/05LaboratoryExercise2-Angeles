using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingAFile
{
    public partial class FrmStudentRecord : Form
    {
        FrmRegistration frmReg = new FrmRegistration();

        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully Uploaded!");
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmReg.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
