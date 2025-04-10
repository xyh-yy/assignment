using HW;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOrder_ShouldAddNewOrder()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var product2 = new Product { ProductName = "Product2", Price = 150 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1),
                new OrderDetails(product2, 2)
            };
            var order = new Order(1, new List<Product> { product1, product2 }, client, orderDetails);

            // 使用函数
            var result = orderService.AddOrder(order);

            // 验证
            Assert.IsTrue(result, "Order should be added successfully.");
        }

        [TestMethod]
        public void AddOrder_ShouldNotAddDuplicateOrder()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var product2 = new Product { ProductName = "Product2", Price = 150 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1),
                new OrderDetails(product2, 2)
            };
            var order = new Order(1, new List<Product> { product1, product2 }, client, orderDetails);

            orderService.AddOrder(order);

            // 使用函数
            var result = orderService.AddOrder(order); // 尝试加入已存在的order

            // 验证
            Assert.IsFalse(result, "Duplicate order should not be added.");
        }

        [TestMethod]
        public void RemoveOrder_ShouldRemoveExistingOrder()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 2)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // 使用函数
            var result = orderService.RemoveOrder(order); 

            // 验证
            Assert.IsTrue(result, "Order should be removed successfully.");
        }

        [TestMethod]
        public void RemoveOrder_ShouldNotRemoveNonExistingOrder()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);

            // 使用函数
            var result = orderService.RemoveOrder(order); // 尝试删除不存在的order

            // 验证
            Assert.IsFalse(result, "Non-existing order should not be removed.");
        }

        [TestMethod]
        public void ModifyOrder_ShouldModifyExistingOrder()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            var modifiedProduct = new Product { ProductName = "Product1", Price = 120 };
            var modifiedOrderDetails = new List<OrderDetails>
            {
                new OrderDetails(modifiedProduct, 1)
            };
            var modifiedOrder = new Order(1, new List<Product> { modifiedProduct }, client, modifiedOrderDetails);

            // 使用函数
            var result = orderService.ModifyOrder(modifiedOrder); 

            // 验证
            Assert.IsTrue(result, "Order should be modified successfully.");
        }

        [TestMethod]
        public void QueryNum_ShouldReturnOrderWithMatchingNumber()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // 使用函数
            var result = orderService.QueryNum(1); 

            // 验证
            Assert.IsTrue(result, "Order should be found with the matching number.");
        }

        [TestMethod]
        public void QueryProduct_ShouldReturnOrderWithMatchingProduct()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // 使用函数
            var result = orderService.QueryProduct("Product1"); 

            // 验证
            Assert.IsTrue(result, "Order should be found with the matching product.");
        }

        [TestMethod]
        public void QueryClient_ShouldReturnOrderWithMatchingClient()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // 使用函数
            var result = orderService.QueryClient("Client1"); 

            // 验证
            Assert.IsTrue(result, "Order should be found with the matching client.");
        }

        [TestMethod]
        public void QueryAmount_ShouldReturnOrderWithMatchingAmount()
        {
            // 准备
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // 使用函数
            var result = orderService.QueryAmount(100); 

            // 验证
            Assert.IsTrue(result, "Order should be found with the matching amount.");
        }
    }
}