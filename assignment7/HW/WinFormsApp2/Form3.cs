using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        private Form1 parentForm;
        private Order old_order = new Order();
        private Order new_order = new Order();
        public Form3(Form1 parentForm)
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
                old_order = result;
                string num = textBox1.Text;
                string c = result.ClientInf.ClientName;
                orderDetailsBindingSource.DataSource = result.Details;
                textBox2.Text = num;
                textBox3.Text = c;

                //录入修改数据，存入new_order
                int new_num = int.Parse(textBox2.Text);

                
            }
            else
            {
                MessageBox.Show("该订单不存在！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderService odsv = new OrderService(parentForm.orders);
            odsv.ModifyOrder(old_order, new_order);
        }
    }
}
