using HW;
using System.ComponentModel;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public BindingList<Order> orders = new BindingList<Order>();
        public Form1()
        {
            InitializeComponent();

            //创建存放十个order对象的orderlist
            OrderService orderService = new OrderService(orders);
            var client = new Client { ClientName = "Client1" };
            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var product2 = new Product { ProductName = "Product2", Price = 150 };


            for (int i = 1; i <= 10; i++)// 创建10个Order对象
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
            // 确保已选中主表的行
            if (orderBindingSource.Position != -1)
            {
                // 获取当前选中的 Order 对象
                var selectedOrder = (Order)orderBindingSource.Current;

                // 更新从表绑定为当前选中订单的 Details
                orderDetailsBindingSource.DataSource = selectedOrder.Details;

                // 刷新从表的显示
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("请先选择一个订单！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 清空从表数据
            orderDetailsBindingSource.DataSource = new List<OrderDetails>();

            // 刷新从表的显示
            dataGridView2.Refresh();
        }

        private void 添加订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            dataGridView1.Refresh();
        }

        private void 修改订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
            dataGridView1.Refresh();
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show(); 
            dataGridView1.Refresh();
        }
    }
}
