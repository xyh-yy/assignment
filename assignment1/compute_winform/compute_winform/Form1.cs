namespace compute_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int item_count = checkedListBox1.Items.Count;
            if (item_count == 1) return;
            for (int i = 0; i < ((CheckedListBox)sender).Items.Count; i++)
            {
                ((CheckedListBox)sender).SetItemChecked(i, false);//将所有选项设为不选中
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = (double)numericUpDown1.Value;
            double b = (double)numericUpDown2.Value;
            double result = 0;
            bool valid = true;

            string op = null;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                op = item.ToString();
                break; // 退出循环，只处理第一个选中的项
            }
            if (op == "+") result = a + b;
            else if (op == "-") result = a - b;
            else if (op == "*") result = a * b;
            else if (op == "/" && b != 0) result = a / b;
            else if (op == "%" && b != 0) result = a % b;
            else valid = false;

            if (valid) MessageBox.Show($"{result}");
            else MessageBox.Show("Invalid operation");
        }
    }
}
