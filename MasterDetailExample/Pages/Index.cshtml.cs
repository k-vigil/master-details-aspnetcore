using MasterDetailExample.Data;
using MasterDetailExample.Models;
using MasterDetailExample.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MasterDetailExample.Pages;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    [BindProperty]
    public OrderViewModel OrderViewModel { get; set; }

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        Order order = new()
        {
            Customer = OrderViewModel.Customer,
            DocumentType = OrderViewModel.DocumentType,
            DocumentNumber = OrderViewModel.DocumentNumber,
            Date = DateTime.Now
        };

        _context.Orders.Add(order);
        _context.SaveChanges();

        foreach (var item in OrderViewModel.OrderItems)
        {
            OrderItem orderItem = new()
            {
                Description = item.Description,
                Quantity = item.Quantity,
                UnitPrice = item.UnitPrice,
                OrderId = order.Id
            };

            _context.OrderItems.Add(orderItem);
        }

        _context.SaveChanges();

        return RedirectToPage("./Index");
    }
}
