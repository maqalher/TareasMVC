using System;
using System.ComponentModel.DataAnnotations;

namespace TareasMVC.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "Error.Requerido")]
    [EmailAddress(ErrorMessage = "El campo debe ser un correo electronico valido")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Error.Email")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Display(Name = "Recuérdame")]
    public bool Recuerdame { get; set; }
}
