
using System.Collections.ObjectModel;
using Client.Models;
using Client.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Client.ViewModels;

public partial class OrdersViewModel : ViewModelBase
{
    private readonly SalesOrderService _orderService;

    [ObservableProperty]
    public partial ObservableCollection<SalesOrder> Orders { get; set; } = [];

    public OrdersViewModel()
    {
        PageTitle = "Beställningar";
        _orderService = new SalesOrderService();
        LoadOrders();
    }

    private void LoadOrders()
    {
        Orders = new ObservableCollection<SalesOrder>(
            _orderService.ListAll()
        );
    }
}
