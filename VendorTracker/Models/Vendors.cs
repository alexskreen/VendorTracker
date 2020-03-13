using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Company { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
  }
}