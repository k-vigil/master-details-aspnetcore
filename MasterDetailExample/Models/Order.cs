namespace MasterDetailExample.Models;

public class Order
{
    public int Id { get; set; }
    public string Customer { get; set; }
    public string DocumentType { get; set; }
    public string DocumentNumber { get; set; }
    public DateTime Date { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }
}
