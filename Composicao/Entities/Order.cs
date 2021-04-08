using System;
using System.Globalization;
using System.Text;
using Course.Composicao.Entities.Enums;
using System.Collections.Generic;

namespace Course.Composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status  { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            items.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            items.Remove(orderItem);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status.ToString());
            sb.AppendLine("Client: "
                + Client.name
                + " ("
                + Client.birthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Client.email);
            sb.AppendLine("Order items");

            double totalPrice = 0;

            foreach (OrderItem item in items)
            {
                sb.AppendLine(
                    item.Product.name
                    + ", $"
                    + item.Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Quantity: "
                    + item.Quantity
                    + ", Subtotal: $"
                    + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                totalPrice += item.Price * item.Quantity;
            }

            sb.Append("Total price: $" + totalPrice.ToString());

            return sb.ToString();
        }

    }
}
