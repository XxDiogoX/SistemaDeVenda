using System;
using System.Collections.Generic;
using System.Text;
using SistemaVenda.Entities.Enums;
using System.Globalization;

namespace SistemaVenda.Entities
{
    class Order
    {
        public DateTime Moment {get; set; }
        public OrderStatus Status { get; set; }
        public OrderItem OrderItem{ get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
      

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
            
        }

        public void AddItem(OrderItem orderitem)
        {
            Orders.Add(orderitem);
        }

        public void RemoveItem(OrderItem orderitem)
        {
            Orders.Remove(orderitem);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem order in Orders)
            {
                sum += order.SubTotal();
                
            }
            return sum;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Orders)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }




    }
}
