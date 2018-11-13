using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaInventarioRopa_Web.Models
{
    public class Usuario : IUser
    {
        public int UserId { get; set; }
        public string NombreCompleto { get; set; }
        public string DUI { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int TipoUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }

        public string SecurityStamp { get; set; }
        string IUser<string>.Id => UserId.ToString();

    }
}