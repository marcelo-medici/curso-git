﻿namespace Course.Composicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            this.Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return this.Quantity * this.Price;
        }

    }
}
