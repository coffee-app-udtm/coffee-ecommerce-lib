﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeLibrary.Model
{
    public class Order
        {
            public string id { get; set; }
            public string user_id { get; set; }
            public string payment_method { get; set; } // vnpay momo cash
            public decimal total_payment { get; set; }
            public string order_status { get; set; }
            public string order_type { get; set; }
            public DateTime order_date { get; set; }
            public string order_note { get; set; }
            public decimal shipping_cost { get; set; }
            public string receiver_name { get; set; }
            public string phone_number { get; set; }
            public string address { get; set; }
            public int store_id { get; set; }
            public string voucher_id { get; set; }
            public string user_name { get; set; }
            public string email { get; set; }
            public string avatar { get; set; }
            public string store_name { get; set; }
            public string voucher_name { get; set; }
            public List<OrderItem> order_items { get; set; }
    }

    public class OrderItem {
        public int id;
        public string user_id { get; set; }
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_image { get; set; }
        public decimal product_price { get; set; }
        public int? size_id { get; set; }
        public string size_name { get; set; }
        public int quantity { get; set; }
        public List<int> toppings { get; set; }
        public decimal order_item_price { get; set; }
    }

    public class CreateOrder
    {
        public string order_id { get; set; }
        public string user_id { get; set; }
        public int total_payment { get; set; }
        public string payment_method { get; set; }
        public string order_type { get; set; }
        public string order_note { get; set; }
        public string order_status { get; set; }
        public decimal shipping_cost { get; set; }
        public string receiver_name { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public int store_id { get; set; }
        public int? voucher_id { get; set; }
        public List<Cart> order_items { get; set; }
    }

    public class OrderOnline
    {
        public bool isCompleted { get; set; }
        public Dictionary<string, OrderOnlineStatus> statuses { get; set; }
        public string userId { get; set; }
    }

    public class OrderOnlineStatus
    {
        public string status { get; set; }
        public string time { get; set; }
    }
}
