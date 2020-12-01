﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    public class OrderItemLogic
    {
        OrderItemDAL orderItem_db = new OrderItemDAL();

        public void AddItemsToOrder(Order order)
        {
            try
            {
                orderItem_db.AddItemsToOrder(order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public List<OrderItem> GetOrdersKitchen()
        {
            try
            {
                return orderItem_db.Db_Get_OrdersKitchen();
            }
            catch
            {
                throw new Exception("Could not get orders from database");
            }
        }
        public List<OrderItem> GetOrdersBar()
        {
            try
            {
                return orderItem_db.Db_Get_OrdersBar();
            }
            catch
            {
                throw new Exception("Could not get orders from database");
            }
        }

        public void UpdateOrderItems(OrderItem orderItems, int stockAmount)
        {
            try
            {
                orderItem_db.UpdateOrderItems(orderItems, stockAmount);
            }
            catch
            {
                throw new Exception("Something went wrong while updating items");
            }
        }

        public void RemoveOrderItems(OrderItem orderItems)
        {
            try
            {
                orderItem_db.RemoveOrderItem(orderItems);
            }
            catch
            {
                throw new Exception("Something went wrong while removing items");
            }
        }
    }
}
