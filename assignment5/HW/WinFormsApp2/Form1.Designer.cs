namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            功能ToolStripMenuItem = new ToolStripMenuItem();
            添加订单ToolStripMenuItem = new ToolStripMenuItem();
            修改订单ToolStripMenuItem = new ToolStripMenuItem();
            删除订单ToolStripMenuItem = new ToolStripMenuItem();
            查询订单ToolStripMenuItem = new ToolStripMenuItem();
            订单号ToolStripMenuItem = new ToolStripMenuItem();
            客户ToolStripMenuItem = new ToolStripMenuItem();
            商品ToolStripMenuItem = new ToolStripMenuItem();
            总金额ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            button1 = new Button();
            splitContainer2 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            dataGridView1 = new DataGridView();
            numberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientInfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            button2 = new Button();
            splitContainer6 = new SplitContainer();
            dataGridView2 = new DataGridView();
            productInfDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailsBindingSource = new BindingSource(components);
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(779, 486);
            splitContainer1.SplitterDistance = 72;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(button1);
            splitContainer3.Size = new Size(779, 72);
            splitContainer3.SplitterDistance = 359;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label1);
            splitContainer4.Panel1.Controls.Add(menuStrip1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(textBox1);
            splitContainer4.Panel2.Paint += splitContainer4_Panel2_Paint;
            splitContainer4.Size = new Size(359, 72);
            splitContainer4.SplitterDistance = 148;
            splitContainer4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "查询条件";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 功能ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(148, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_2;
            // 
            // 功能ToolStripMenuItem
            // 
            功能ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 添加订单ToolStripMenuItem, 修改订单ToolStripMenuItem, 删除订单ToolStripMenuItem, 查询订单ToolStripMenuItem });
            功能ToolStripMenuItem.Name = "功能ToolStripMenuItem";
            功能ToolStripMenuItem.Size = new Size(53, 24);
            功能ToolStripMenuItem.Text = "功能";
            // 
            // 添加订单ToolStripMenuItem
            // 
            添加订单ToolStripMenuItem.Name = "添加订单ToolStripMenuItem";
            添加订单ToolStripMenuItem.Size = new Size(152, 26);
            添加订单ToolStripMenuItem.Text = "添加订单";
            添加订单ToolStripMenuItem.Click += 添加订单ToolStripMenuItem_Click;
            // 
            // 修改订单ToolStripMenuItem
            // 
            修改订单ToolStripMenuItem.Name = "修改订单ToolStripMenuItem";
            修改订单ToolStripMenuItem.Size = new Size(152, 26);
            修改订单ToolStripMenuItem.Text = "修改订单";
            修改订单ToolStripMenuItem.Click += 修改订单ToolStripMenuItem_Click;
            // 
            // 删除订单ToolStripMenuItem
            // 
            删除订单ToolStripMenuItem.Name = "删除订单ToolStripMenuItem";
            删除订单ToolStripMenuItem.Size = new Size(152, 26);
            删除订单ToolStripMenuItem.Text = "删除订单";
            删除订单ToolStripMenuItem.Click += 删除订单ToolStripMenuItem_Click;
            // 
            // 查询订单ToolStripMenuItem
            // 
            查询订单ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 订单号ToolStripMenuItem, 客户ToolStripMenuItem, 商品ToolStripMenuItem, 总金额ToolStripMenuItem });
            查询订单ToolStripMenuItem.Name = "查询订单ToolStripMenuItem";
            查询订单ToolStripMenuItem.Size = new Size(152, 26);
            查询订单ToolStripMenuItem.Text = "查询订单";
            // 
            // 订单号ToolStripMenuItem
            // 
            订单号ToolStripMenuItem.Name = "订单号ToolStripMenuItem";
            订单号ToolStripMenuItem.Size = new Size(137, 26);
            订单号ToolStripMenuItem.Text = "订单号";
            // 
            // 客户ToolStripMenuItem
            // 
            客户ToolStripMenuItem.Name = "客户ToolStripMenuItem";
            客户ToolStripMenuItem.Size = new Size(137, 26);
            客户ToolStripMenuItem.Text = "客户";
            // 
            // 商品ToolStripMenuItem
            // 
            商品ToolStripMenuItem.Name = "商品ToolStripMenuItem";
            商品ToolStripMenuItem.Size = new Size(137, 26);
            商品ToolStripMenuItem.Text = "商品";
            // 
            // 总金额ToolStripMenuItem
            // 
            总金额ToolStripMenuItem.Name = "总金额ToolStripMenuItem";
            总金额ToolStripMenuItem.Size = new Size(137, 26);
            总金额ToolStripMenuItem.Text = "总金额";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(19, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Location = new Point(9, 27);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "搜索";
            button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer5);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer6);
            splitContainer2.Size = new Size(779, 410);
            splitContainer2.SplitterDistance = 447;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(dataGridView1);
            splitContainer5.Panel1.Paint += splitContainer5_Panel1_Paint;
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(button2);
            splitContainer5.Size = new Size(447, 410);
            splitContainer5.SplitterDistance = 351;
            splitContainer5.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { numberDataGridViewTextBoxColumn, clientInfDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            dataGridView1.DataSource = orderBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(447, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            numberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            numberDataGridViewTextBoxColumn.HeaderText = "订单号";
            numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // clientInfDataGridViewTextBoxColumn
            // 
            clientInfDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clientInfDataGridViewTextBoxColumn.DataPropertyName = "ClientInf";
            clientInfDataGridViewTextBoxColumn.HeaderText = "客户";
            clientInfDataGridViewTextBoxColumn.MinimumWidth = 6;
            clientInfDataGridViewTextBoxColumn.Name = "clientInfDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "总金额";
            amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(HW.Order);
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(447, 55);
            button2.TabIndex = 0;
            button2.Text = "显示选中订单的明细";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(0, 0);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(dataGridView2);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(button3);
            splitContainer6.Size = new Size(328, 410);
            splitContainer6.SplitterDistance = 352;
            splitContainer6.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { productInfDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView2.DataSource = orderDetailsBindingSource;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(328, 352);
            dataGridView2.TabIndex = 0;
            // 
            // productInfDataGridViewTextBoxColumn
            // 
            productInfDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productInfDataGridViewTextBoxColumn.DataPropertyName = "ProductInf";
            productInfDataGridViewTextBoxColumn.HeaderText = "商品";
            productInfDataGridViewTextBoxColumn.MinimumWidth = 6;
            productInfDataGridViewTextBoxColumn.Name = "productInfDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "金额";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // orderDetailsBindingSource
            // 
            orderDetailsBindingSource.DataSource = typeof(HW.OrderDetails);
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(328, 54);
            button3.TabIndex = 0;
            button3.Text = "清空";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 486);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer4;
        private TextBox textBox1;
        private Button button1;
        private SplitContainer splitContainer5;
        private BindingSource orderBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientInfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private SplitContainer splitContainer6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn productInfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource orderDetailsBindingSource;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 功能ToolStripMenuItem;
        private ToolStripMenuItem 添加订单ToolStripMenuItem;
        private ToolStripMenuItem 修改订单ToolStripMenuItem;
        private ToolStripMenuItem 删除订单ToolStripMenuItem;
        private ToolStripMenuItem 查询订单ToolStripMenuItem;
        private ToolStripMenuItem 订单号ToolStripMenuItem;
        private ToolStripMenuItem 客户ToolStripMenuItem;
        private ToolStripMenuItem 商品ToolStripMenuItem;
        private ToolStripMenuItem 总金额ToolStripMenuItem;
        private Label label1;
    }
}
