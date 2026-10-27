using System;
using System.Collections.ObjectModel;
using Client.Interfaces;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class SalesOrdersViewModel : ViewModelBase
{

    [ObservableProperty]
    public partial ObservableCollection<SalesOrder> SalesOrder { get; set; } = [];

    public SalesOrdersViewModel()
    {
        PageTitle = "Beställningar";
        LoadSalesOrders();
    }

    private void LoadSalesOrders()
    {
        try
        {
            ISalesOrderService service = new OrderService();
            SalesOrder = new ObservableCollection<SalesOrder>(service.ListAll());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
