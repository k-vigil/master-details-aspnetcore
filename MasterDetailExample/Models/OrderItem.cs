using System.ComponentModel.DataAnnotations.Schema;

namespace MasterDetailExample.Models;

public class OrderItem
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal UnitPrice { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}
