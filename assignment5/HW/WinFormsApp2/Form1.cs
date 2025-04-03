using HW;
using Org.BouncyCastle.Asn1;
using System.ComponentModel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public BindingList<Order> orders = new BindingList<Order>();
        private int Choice = 0;
        public Form1()
        {
            InitializeComponent();

            //�������ʮ��order�����orderlist
            OrderService orderService = new OrderService(orders);
            var client = new Client { ClientName = "Client1" };
            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var product2 = new Product { ProductName = "Product2", Price = 150 };


            for (int i = 1; i <= 10; i++)// ����10��Order����
            {
                var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, i),
                new OrderDetails(product2, i + 1)
            };
                var order = new Order(i, new List<Product> { product1, product2 }, client, orderDetails);
                orders.Add(order);
            }

            orderBindingSource.DataSource = orders;

            //orderDetailsBindingSource.DataSource = orderBindingSource;
            //orderDetailsBindingSource.DataMember = "Details";

            orderDetailsBindingSource.DataSource = new List<OrderDetails>();

        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ȷ����ѡ���������
            if (orderBindingSource.Position != -1)
            {
                // ��ȡ��ǰѡ�е� Order ����
                var selectedOrder = (Order)orderBindingSource.Current;

                // ���´ӱ��Ϊ��ǰѡ�ж����� Details
                orderDetailsBindingSource.DataSource = selectedOrder.Details;

                // ˢ�´ӱ����ʾ
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("����ѡ��һ��������");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ��մӱ�����
            orderDetailsBindingSource.DataSource = new List<OrderDetails>();

            // ˢ�´ӱ����ʾ
            dataGridView2.Refresh();
        }

        private void ��Ӷ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            dataGridView1.Refresh();
        }

        private void �޸Ķ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            dataGridView1.Refresh();
        }

        private void ɾ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            dataGridView1.Refresh();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice = 1;
        }

        private void �ͻ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice = 2;
        }

        private void ��ƷToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice = 3;
        }

        private void �ܽ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice = 4;
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numbertext = int.Parse(textBox1.Text);
            OrderService odsv = new OrderService(orders);
            Order result = new Order();
            bool exist = odsv.QueryNum(numbertext, result);
            if (exist)
            {
                string num = textBox1.Text;
                string c = result.ClientInf.ClientName;
                orderDetailsBindingSource.DataSource = result.Details;


                //¼���޸����ݣ�����new_order
                int new_num = int.Parse(textBox2.Text);


            }
            else
            {
                MessageBox.Show("�ö��������ڣ�", "ʧ��", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
