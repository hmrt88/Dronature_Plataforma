using System;
using System.ComponentModel.DataAnnotations;

namespace Dronature.API.DTOs
{
    public class UserForRegisterDto
    {
        [Required]
        public string  Username { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4,ErrorMessage = "La contraseña debe de ser entre 4 y 10 caracteres")]
        public string  Password { get; set; }
        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$",
            ErrorMessage = "Por favor ingrese un correo electronico valido")]
        public string Email { get; set; }
        [Required]
        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "El número de teléfono no es valido")]
        public int  Telefono { get; set; }
    }
}
