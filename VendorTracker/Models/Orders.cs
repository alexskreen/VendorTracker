using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Details { get; set; }
    public int Id { get; }
    public string Date { get; set; }
    public string Address { get; set; }
    public string Payment { get; set; }

    private static List<Order> _instances = new List<Order> { };

    public Order(string details, string date, string address, string payment)
    {
      Details = details;
      _instances.Add(this);
      Id = _instances.Count;
      Date = date;
      Address = address;
      Payment = payment;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
