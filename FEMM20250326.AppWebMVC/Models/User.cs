using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FEMM20250326.AppWebMVC.Models;

public partial class User
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre de Usuario es obligatorio")]
    public string Username { get; set; } = null!;

    [Required(ErrorMessage = "El Email es obligatorio")]
    [EmailAddress(ErrorMessage = "El formato del correo no es valido")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "La contraseña es obligatoria")]
    [DataType(DataType.Password)]
    [StringLength(15, MinimumLength = 4, ErrorMessage = "La contraseña debe tener entre 4 a 15 caracteres")]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "Un rol debe ser asignado")]
    public string Role { get; set; } = null!;

    [NotMapped]
    [StringLength(40, MinimumLength = 5, ErrorMessage = "El password debe tener entre 4 y 15 caracteres.")]
    [Display(Name = "Confirmar Password")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Las contraseñas no coinciden.")]
    public string? ConfirmarPassword { get; set; } = null!;

}
