using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Client.ViewModels;

public partial class OrdersViewModel : ViewModelBase
{

    [ObservableProperty]
    public partial ObservableCollection<Orders> Order { get; set; } = [];

    public OrdersViewModel()
    {
        PageTitle = "Beställningar";
        LoadOrders();
    }

    private void LoadOrders()
    {
        try
        {
            IOrderService service = new OrderService();
            Order = new ObservableCollection<Orders>(service.ListAll());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
