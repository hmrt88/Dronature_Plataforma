using System;
namespace Dronature.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime ?FechaCreacion { get; set; }
        public DateTime FechaDelete { get; set; }
        public bool IsDelete { get; set; }
        public int UserIdDelete { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string  Email { get; set; }
        public int Telefono { get; set; }

        //agregar mas propiedades antes de hacer las migraciones

    }
}
