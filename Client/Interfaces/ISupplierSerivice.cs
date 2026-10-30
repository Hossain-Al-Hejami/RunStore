using System;
using System.Collections.Generic;
using Client.Models;


namespace Client.Interfaces
{
    public interface ISupplierSerivice
    {
        List<Supplier>ListAll();
        Supplier Find(int id);
    }
}