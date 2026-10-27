using System.IO;
using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;
using Client.Views;

namespace Client.Services;

public class CustomerService : ICustomerService
{
    private readonly string _connectionString = string.Empty;
    public CustomerService()
    {
        _connectionString = "";
    }

    public void Add(Customer customer)
    {
        throw new NotImplementedException();
    }

    public List<Customer> ListAll()
    {
        try
        {
            List<Customer> customers = [];
            
            return customers;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    // private Customer CreateCustomer(SqliteDataReader reader)
    // {
    //     return new Customer()
    //     {
    //         Id = reader.GetString(0),
    //         FirstName = reader.GetString(1),
    //         LastName = reader.GetString(2),
    //         Email = reader.GetString(3),
    //         Phone = Convert.IsDBNull(reader[4]) ? "Saknas" : reader.GetString(4),
    //         AddressLine = reader.GetString(5),
    //         PostalCode = reader.GetString(6),
    //         City = reader.GetString(7)
    //     };
    // }
}
