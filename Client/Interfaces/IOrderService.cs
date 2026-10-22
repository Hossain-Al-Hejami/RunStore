using System;
using System.Collections.Generic;
using Client.Models;

namespace Client.Interfaces
{
    public interface IOrderService
    {
    List<Orders> ListAll();
    void Add(Orders order);
    }
}