using EF.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace EF
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=OrderDb;User=root;Password=xu2365651;",
                new MySqlServerVersion(new Version(8, 0, 21)));

            var context = new ApplicationDbContext(optionsBuilder.Options);

            // 示例操作
            await CreateOrderAsync(context);
            await DisplayOrdersAsync(context);
            await UpdateOrderAsync(context, 1); // 假设我们更新 ID 为 1 的订单
            await DeleteOrderAsync(context, 1); // 假设我们删除 ID 为 1 的订单
            await DisplayOrdersAsync(context);
        }

        // 添加订单
        public static async Task CreateOrderAsync(ApplicationDbContext context)
        {
            var order = new Order
            {
                CustomerName = "John Doe",
                OrderDate = DateTime.Now,
                TotalAmount = 100.50m
            };

            context.Orders.Add(order);
            await context.SaveChangesAsync();
            Console.WriteLine("Order Added!");
        }

        // 显示所有订单
        public static async Task DisplayOrdersAsync(ApplicationDbContext context)
        {
            var orders = await context.Orders.ToListAsync();
            Console.WriteLine("\n--- Orders ---");
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Customer: {order.CustomerName}, Total: {order.TotalAmount}");
            }
        }

        // 更新订单
        public static async Task UpdateOrderAsync(ApplicationDbContext context, int orderId)
        {
            var order = await context.Orders.FindAsync(orderId);
            if (order != null)
            {
                order.CustomerName = "Jane Doe"; // 修改客户名称
                order.TotalAmount = 150.75m; // 修改订单金额

                await context.SaveChangesAsync();
                Console.WriteLine($"Order {orderId} updated!");
            }
            else
            {
                Console.WriteLine($"Order {orderId} not found.");
            }
        }

        // 删除订单
        public static async Task DeleteOrderAsync(ApplicationDbContext context, int orderId)
        {
            var order = await context.Orders.FindAsync(orderId);
            if (order != null)
            {
                context.Orders.Remove(order);
                await context.SaveChangesAsync();
                Console.WriteLine($"Order {orderId} deleted!");
            }
            else
            {
                Console.WriteLine($"Order {orderId} not found.");
            }
        }

    }
}
