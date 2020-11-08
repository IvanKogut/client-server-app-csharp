﻿using System.ComponentModel.DataAnnotations;

namespace TodoList.Identity.API.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    public string? Name { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    [Required]
    [Compare(nameof(Password))]
    public string? ConfirmPassword { get; set; }

    public string? ReturnUrl { get; set; }
  }
}
