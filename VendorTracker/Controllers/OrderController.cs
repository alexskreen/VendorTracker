using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;
using System.Collections.Generic;

namespace VendorTracker.Controllers
{
public class ItemsController : Controller
  {
    [HttpGet("/categories/{categoryId}/items/new")]
    public ActionResult New(int categoryId)
    {
      Category category = Category.Find(categoryId);
      return View(category);
    }

  [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
  public ActionResult Show(int vendorId, int orderId)
  {
    Order order = Order.Find(orderId);
    Vendor vendor = Vendor.Find(vendorId);
    Dictionary<string, object> model = new Dictionary<string, object>();
    model.Add("order", order);
    model.Add("vendor", vendor);
    return View(model);
  }
  }

}