using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Avalonia.Metadata;
using Client.Interfaces;
using Client.Models;
using Microsoft.Data.Sqlite;

namespace Client.Services;

public class OrderService : IOrderService
{
    private readonly string _connectionString = string.Empty;
    public OrderService()
    {
        _connectionString = "Data Source=runstore.db";
    }
    public void Add(Orders order)
    {
        try
        {
            var sqlInsertString = "INSERT INTO Orders(id,OrderDate)";
            sqlInsertString += $"VALUES('{order.Id}','{order.OrdersDate}';";

            using SqliteConnection connection = new(_connectionString);
            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = sqlInsertString;

            connection.Open();

            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Orders> ListAll()
    {
        try
        {
            List<Orders> orders = [];

            using SqliteConnection connection = new(_connectionString);
            using SqliteCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Orders";
            connection.Open();

            using SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                orders.Add(CreateOrder(reader));
            }

            return orders;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private Orders CreateOrder(SqliteDataReader reader)
    {
        return new Orders()
        {
            Id = reader.GetString(0),
            OrdersDate = reader.GetDateTime(1),
        };
    }
}
