﻿using System.Reflection.Metadata;
using System.Runtime.InteropServices.JavaScript;
using Mini_Ecommerce.Models.Enums;

namespace Mini_Ecommerce.Models.Entity;

public class UserModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public Role Role { get; set; }
    public string Document { get; set; }
    public int PhoneNumber { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public DateOnly CreatedAt { get; set; }
}