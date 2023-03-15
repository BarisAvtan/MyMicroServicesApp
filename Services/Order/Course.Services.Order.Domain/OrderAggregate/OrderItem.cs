using Course.Services.Order.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Services.Order.Domain.OrderAggregate
{
    public class OrderItem : Entity
    {
        public string ProductId { get; private set; }// propların set edilmesi bizim kontrolümüzde olması için private yaptık dış dünyaya kapalı
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
        public Decimal Price { get; private set; }

        public OrderItem()
        {
        }

        public OrderItem(string productId, string productName, string pictureUrl, decimal price)
        {
            ProductId = productId;
            ProductName = productName;
            PictureUrl = pictureUrl;
            Price = price;
        }
        // propların set edilmesi bizim kontrolümüzde olması için private yaptık dış dünyaya kapalı demiştik
        //metodlar yazarak bizim dışımızda kimsenin prop değerlerini değiştirmesini engelledik
        //sadece burada yazılan UpdateOrderItem gibi metodları kullanarak update edilecek.
        public void UpdateOrderItem(string productName, string pictureUrl, decimal price)
        {
            ProductName = productName;
            Price = price;
            PictureUrl = pictureUrl;
        }
    }
}