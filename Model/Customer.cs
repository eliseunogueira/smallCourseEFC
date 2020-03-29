using System.Collections.Generic;

namespace smallCourseEFC.Model
{
  public class Customer
  {

    public int Id { get; set; }
    public string Firstname { get; set; }
    public string LastName { get; set; }
#nullable enable
    public string? Address { get; set; }

    public string? Phone { get; set; }
    public string? Email { get; set; }
#nullable disable
    public ICollection<Order> Orders { get; set; }
  }
}