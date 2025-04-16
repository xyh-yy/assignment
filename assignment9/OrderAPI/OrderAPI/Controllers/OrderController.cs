using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using OrderAPI.Models;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        private static List<Order> orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Quantity = 2, Price = 5000 },
            new Order { Id = 2, ProductName = "Smartphone", Quantity = 5, Price = 1000 }
        };

        // 获取所有订单
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            return Ok(orders);
        }

        // 根据 ID 获取订单
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        // 创建订单
        [HttpPost]
        public ActionResult<Order> CreateOrder([FromBody] Order order)
        {
            order.Id = orders.Max(o => o.Id) + 1;
            orders.Add(order);
            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, order);
        }

        // 更新订单
        [HttpPut("{id}")]
        public IActionResult UpdateOrder(int id, [FromBody] Order order)
        {
            var existingOrder = orders.FirstOrDefault(o => o.Id == id);
            if (existingOrder == null)
            {
                return NotFound();
            }

            existingOrder.ProductName = order.ProductName;
            existingOrder.Quantity = order.Quantity;
            existingOrder.Price = order.Price;

            return NoContent(); // 成功没有返回内容
        }

        // 删除订单
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            orders.Remove(order);
            return NoContent(); // 成功删除没有返回内容
        }
    }
}
