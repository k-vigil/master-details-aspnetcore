namespace MasterDetailExample.ViewModels;

public class OrderViewModel
{
    public string Customer { get; set; }
    public string DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public List<OrderItemViewModel> OrderItems { get; set; }
}

public class OrderItemViewModel
{
    public string Description { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
