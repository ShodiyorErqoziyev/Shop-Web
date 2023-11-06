using ShopApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.Domain.Entities;

public class Human : Auditable
{
    [MaxLength(20)]
    public string FirstName { get; set; } = String.Empty;

    [MaxLength(20)]
    public string LastName { get; set; } = String.Empty;

    [MaxLength(9)]
    public string PassportSeria { get; set; } = String.Empty;
    public string PhoneNumber { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public string Salt { get; set; } = String.Empty;
    public Gender Gender { get; set; } = Gender.None;
    public string Region { get; set; } = String.Empty;
    public string ImagePath { get; set; } = String.Empty;
}
    