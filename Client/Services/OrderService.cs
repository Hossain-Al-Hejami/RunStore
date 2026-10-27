using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;

namespace Client.Services;

public class OrderService : ISalesOrderService
{
    private readonly string _connectionString = string.Empty;
    public OrderService()
    {
        _connectionString = "";
    }

    public void Add(SalesOrder salesOrders)
    {
        throw new NotImplementedException();
    }

    public List<SalesOrder> ListAll()
    {
        try
        {
            List<SalesOrder> salesOrders = [];
            
            return salesOrders;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
