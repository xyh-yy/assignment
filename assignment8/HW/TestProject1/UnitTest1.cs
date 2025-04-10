using HW;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOrder_ShouldAddNewOrder()
        {
            // ׼��
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

            // ʹ�ú���
            var result = orderService.AddOrder(order);

            // ��֤
            Assert.IsTrue(result, "Order should be added successfully.");
        }

        [TestMethod]
        public void AddOrder_ShouldNotAddDuplicateOrder()
        {
            // ׼��
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

            // ʹ�ú���
            var result = orderService.AddOrder(order); // ���Լ����Ѵ��ڵ�order

            // ��֤
            Assert.IsFalse(result, "Duplicate order should not be added.");
        }

        [TestMethod]
        public void RemoveOrder_ShouldRemoveExistingOrder()
        {
            // ׼��
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 2)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // ʹ�ú���
            var result = orderService.RemoveOrder(order); 

            // ��֤
            Assert.IsTrue(result, "Order should be removed successfully.");
        }

        [TestMethod]
        public void RemoveOrder_ShouldNotRemoveNonExistingOrder()
        {
            // ׼��
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);

            // ʹ�ú���
            var result = orderService.RemoveOrder(order); // ����ɾ�������ڵ�order

            // ��֤
            Assert.IsFalse(result, "Non-existing order should not be removed.");
        }

        [TestMethod]
        public void ModifyOrder_ShouldModifyExistingOrder()
        {
            // ׼��
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

            // ʹ�ú���
            var result = orderService.ModifyOrder(modifiedOrder); 

            // ��֤
            Assert.IsTrue(result, "Order should be modified successfully.");
        }

        [TestMethod]
        public void QueryNum_ShouldReturnOrderWithMatchingNumber()
        {
            // ׼��
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // ʹ�ú���
            var result = orderService.QueryNum(1); 

            // ��֤
            Assert.IsTrue(result, "Order should be found with the matching number.");
        }

        [TestMethod]
        public void QueryProduct_ShouldReturnOrderWithMatchingProduct()
        {
            // ׼��
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // ʹ�ú���
            var result = orderService.QueryProduct("Product1"); 

            // ��֤
            Assert.IsTrue(result, "Order should be found with the matching product.");
        }

        [TestMethod]
        public void QueryClient_ShouldReturnOrderWithMatchingClient()
        {
            // ׼��
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // ʹ�ú���
            var result = orderService.QueryClient("Client1"); 

            // ��֤
            Assert.IsTrue(result, "Order should be found with the matching client.");
        }

        [TestMethod]
        public void QueryAmount_ShouldReturnOrderWithMatchingAmount()
        {
            // ׼��
            var orderService = new OrderService();

            var product1 = new Product { ProductName = "Product1", Price = 100 };
            var client = new Client { ClientName = "Client1" };
            var orderDetails = new List<OrderDetails>
            {
                new OrderDetails(product1, 1)
            };
            var order = new Order(1, new List<Product> { product1 }, client, orderDetails);
            orderService.AddOrder(order); 

            // ʹ�ú���
            var result = orderService.QueryAmount(100); 

            // ��֤
            Assert.IsTrue(result, "Order should be found with the matching amount.");
        }
    }
}