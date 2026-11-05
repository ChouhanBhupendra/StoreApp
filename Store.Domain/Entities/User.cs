
using Store.Domain.Enums;

namespace Store.Domain.Entities;

public class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public Role Role { get; set; } = Role.Customer;

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
