using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Org.BouncyCastle.Asn1.Mozilla;
using System.ComponentModel;



namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
        }
    }

    public class Order//订单
    {
        public int Number { get; set; }//订单号
        public List<Product> ProductInf { get; set; }//商品
        public Client ClientInf { get; set; }//客户
        public double Amount { get; set; }//金额
        public List<OrderDetails> Details { get; set; }//订单明细

        //无参数的构造函数
        public Order()
        { 
            Number = 0;
            ProductInf = new List<Product>();
            ClientInf = new Client();
            Amount = 0;
            Details = new List<OrderDetails>();
        }

        //有参数的构造函数
        public Order(int number, List<Product> productInf, Client clientInf, List<OrderDetails> details)
        {
            Number = number;
            ProductInf = productInf;
            ClientInf = clientInf;
            Details = details;

            //计算总金额
            Amount = 0;
            foreach (OrderDetails od in details)
            {
                Amount += od.Price;
            }
        }

        public bool Equals(Order other)
        {
            //比较订单号
            if (this.Number != other.Number) return false;

            //比较所有商品
            if (this.ProductInf.Count != other.ProductInf.Count) return false;
            foreach (var item in ProductInf)
            {
                bool item_eq = false;
                foreach (var item2 in other.ProductInf)
                    if (item.Equals(item2)) item_eq = true;
                if (!item_eq) return false;
            }

            //比较客户信息
            if (!this.ClientInf.Equals(other.ClientInf)) return false;

            //比较成交金额
            if (this.Amount != other.Amount) return false;

            //比较订单明细
            if(this.Details.Count != other.Details.Count) return false;
            foreach (var item in Details)
            {
                bool item_eq = false;
                foreach(var item2 in other.Details)
                    if(item.Equals(item2)) item_eq = true;
                if (!item_eq) return false;
            }

            //所有信息都相同判定为同一订单
            return true;
        }
        public void ToString()
        {
            Console.WriteLine($"订单号：{Number}");
            Console.WriteLine();

            Console.WriteLine("商品信息：");
            foreach(var item in ProductInf)
            {
                item.ToString();
            }
            Console.WriteLine();

            Console.WriteLine("客户信息：");
            ClientInf.ToString();
            Console.WriteLine();

            Console.WriteLine($"总金额{Amount}");
            Console.WriteLine();

            Console.WriteLine("订单明细：");
            foreach(var item in Details)
            {
                item.ToString();
            }
        }
    }

    public class OrderDetails//订单明细
    {
        public Product ProductInf {  get; set; }//商品信息
        public int Quantity { get; set; }//商品数量
        public double Price { get; set; }//该类商品总金额

        public OrderDetails()
        {
            ProductInf = new Product();
            Quantity = 0;
            Price = 0;
        }

        public OrderDetails(Product product, int quantity)
        {
            if (quantity < 0)
            {
                quantity = 0;
                Console.WriteLine("错误！商品数量小于0");
                Console.WriteLine("已将商品数量修改为0");
            }
            ProductInf = product;
            Quantity = quantity;
            Price = product.Price*Quantity;
        }

        public bool Equals(OrderDetails other)
        {
            if (!this.ProductInf.Equals(other.ProductInf)) return false;
            if (this.Quantity!=other.Quantity) return false;
            if (this.Price!=other.Price) return false;
            return true;
        }
        public void ToString()
        {
            Console.WriteLine($"商品名称：{ProductInf.ProductName}");
            Console.WriteLine($"共{Quantity}件");
            Console.WriteLine($"总金额为{Price}");
        }
    }

    public class Client
    {
        public string ClientName { get; set; }

        public Client() 
        {
            ClientName = "None";
        }

        public Client(string clientName)
        {
            ClientName= clientName;
        }
        public bool Equals(Client other)
        {
            if(this.ClientName!=other.ClientName) return false;
            return true;
        }
        public void ToString()
        {
            Console.WriteLine($"客户：{ClientName}");
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product()
        {
            ProductName = "None";
            Price = 0.0;
        }

        public Product(string productName,double price)
        {
            if(price<0)
            {
                price = 0.0;
                Console.WriteLine("错误！商品价格不能小于0");
                Console.WriteLine("已将商品价格修改为0");
            }
            ProductName = productName;
            Price = price;
        }

        public bool Equals(Product other)
        {
            if( this.ProductName!=other.ProductName)return false;
            if (this.Price!=other.Price)return false;
            return true;
        }
        public void ToString()
        {
            Console.WriteLine($"商品：{ProductName}");
            Console.WriteLine($"单价：{Price}");
        }
    }

    public class OrderService
    {
        BindingList<Order> orders = new BindingList<Order>();//存储所有订单的列表
        public OrderService(BindingList<Order> orders)
            { this.orders = orders; }

        //添加订单
        public bool AddOrder(Order order)
        {
            //检查是否已经将该订单加入
            foreach(var item in orders)
                if (item.Equals(order)) return false;
            orders.Add(order);
            return true;
        }
        
        //删除订单
        public bool RemoveOrder(Order order)
        {
            //查找订单是否存在
            foreach (var item in orders)
            {
                if (item.Equals(order))
                {
                    orders.Remove(item);
                    return true;
                }
            }
            Console.WriteLine("订单不存在！");
            return false;
        }

        //修改订单
        public bool ModifyOrder(Order order)
        {
            //查找订单是否存在
            foreach( var item in orders)
            {
                if (item.Equals(order))
                {
                    orders.Remove(item);
                    orders.Add(order);
                    return true;
                }
            }
            Console.WriteLine("订单不存在！");
            return false;
        }

        //通过订单号查询订单
        public bool QueryNum(int num)
        {
            //查询订单号
            var NumberList = from item in orders
                              where item.Number == num
                              select item;
            //如果没有找到就返回false
            if (NumberList.Count() == 0)
            {
                Console.WriteLine($"不存在订单号为{num}的订单！");
                return false;
            }
            //按订单金额进行排序
            var sortedNumberList = NumberList.OrderBy(n=>n.Amount);
            foreach( var item in sortedNumberList)
                item.ToString();
            return true;
        }

        //通过商品名称查询订单
        public bool QueryProduct(string product)
        {
            //查询商品名称
            var NameList = from item in orders
                           where item.ProductInf.Any(n => n.ProductName == product)
                           select item;
            //没有找到就返回false
            if (NameList.Count() == 0)
            {
                Console.WriteLine($"不存在包含商品{product}的订单！");
                return false;
            }
            //按订单金额进行排序
            var sortedNameList = NameList.OrderBy(n => n.Amount);
            foreach( var item in sortedNameList)
                item.ToString();
            return true;
        }

        //通过客户查询订单
        public bool QueryClient(string client)
        {
            //查询客户
            var ClientList = from item in orders
                             where item.ClientInf.ClientName == client
                             select item;
            //没有找到就返回false
            if (ClientList.Count() == 0)
            {
                Console.WriteLine($"不存在客户{client}的订单！");
                return false;
            }
            //按照订单金额进行排序
            var sortedClientList = ClientList.OrderBy(n => n.Amount);
            foreach( var item in sortedClientList)
                item.ToString();
            return true;
        }

        //通过金额查询订单
        public bool QueryAmount(double amount)
        {
            //查询订单金额
            var AmountList = from item in orders
                             where item.Amount == amount
                             select item;
            //没有找到就返回false
            if (AmountList.Count() == 0)
            {
                Console.WriteLine($"不存在总金额为{amount}的订单！");
                return false;
            }
            foreach (var item in AmountList)
                item.ToString();
            return true;
        }
    }

}
