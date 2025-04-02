using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        public Form3(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
