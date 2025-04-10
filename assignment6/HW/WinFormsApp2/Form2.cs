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
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public List<Product> products = new List<Product>();
        public List<OrderDetails> Details = new List<OrderDetails>();
        public bool result;

        private Form1 parentForm;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;  // 保存父窗体的引用
        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer6_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nametext = textBox3.Text;
            int quantitytext = int.Parse(textBox4.Text);
            double pricetext = double.Parse(textBox5.Text);

            Product p = new Product(nametext, pricetext);
            OrderDetails od = new OrderDetails(p, quantitytext);

            Details.Add(od);
            products.Add(p);
            foreach (Control control in splitContainer6.Panel1.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();  // 清空TextBox的内容
                }
            }

            MessageBox.Show("添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbertext = int.Parse(textBox1.Text);
            string clienttext = textBox2.Text;

            Client c = new Client(clienttext);
            Order odr = new Order(numbertext,products,c,Details);

            OrderService odsv = new OrderService(parentForm.orders);
            result = odsv.AddOrder(odr);

            if (result)
            {
                MessageBox.Show("添加成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("操作失败，请重试。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
