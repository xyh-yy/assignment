namespace OrderAPI.Models
{
    public class Order
    {
        public int Id { get; set; }          // 订单ID
        public string ProductName { get; set; }  // 商品名称
        public int Quantity { get; set; }       // 商品数量
        public decimal Price { get; set; }      // 单价
        public decimal TotalPrice => Quantity * Price;  // 总价
    }
}
