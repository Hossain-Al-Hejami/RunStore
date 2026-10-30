using System;
using System.Collections.Generic;
using Client.Interfaces;
using Client.Models;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Client.Services;

public class ProductService : IProductService
{
    private readonly string _connectionString = string.Empty;
    public ProductService()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        _connectionString = config.GetConnectionString("pgsql")!;
    }
    public void Add(Product product)
    {
        try
        {
            var sqlInsertString = "INSERT INTO Products(itemNumber,name,description,imageurl,price)";
            sqlInsertString += $"VALUES('{product.ItemNumber}','{product.Name}','Test','https://res.cloudinary.com/softtech-dev/image/upload/v1786556530/shoe-3_qbzcwy.jpg',{product.Price});";

            using NpgsqlConnection connection = new(_connectionString);
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsertString;
            connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Product> ListAll()
    {
        try
        {
            List<Product> products = [];

            using NpgsqlConnection connection = new(_connectionString);
            using NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT p.product_id,p.itemnumber,p.name,p.description,p.imageurl,p.price,s.name AS supplier_name FROM products AS p INNER JOIN suppliers AS s ON p.supplier_id = s.supplier_id;";
            connection.Open();
            using NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                products.Add(CreateProduct(reader));
            }

            return products;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    private Product CreateProduct(NpgsqlDataReader reader)
    {
        return new Product()
        {
            Id = reader.GetInt32(0),
            ItemNumber = reader.GetString(1),
            Name = reader.GetString(2),
            Description = reader.GetString(3),
            ImageUrl = reader.GetString(4),
            Price = (int)reader.GetFloat(5),
            SupplierName = reader.GetString(6)
        };
    }
}
