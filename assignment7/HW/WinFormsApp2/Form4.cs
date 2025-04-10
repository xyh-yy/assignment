using HW;
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
    public partial class Form4 : Form
    {
        private Form1 parentForm;
        Order old_order = new Order();
        public Form4(Form1 parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbertext = int.Parse(textBox1.Text);
            OrderService odsv = new OrderService(parentForm.orders);
            Order result = new Order();
            bool exist = odsv.QueryNum(numbertext, result);
            if (exist)
            {
                string num = textBox1.Text;
                string c = result.ClientInf.ClientName;
                orderDetailsBindingSource.DataSource = result.Details;
                textBox2.Text = num;
                textBox3.Text = c;
            }
            else
            {
                MessageBox.Show("该订单不存在！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderService odsv = new OrderService(parentForm.orders);
            odsv.RemoveOrder(old_order);
        }
    }
}
