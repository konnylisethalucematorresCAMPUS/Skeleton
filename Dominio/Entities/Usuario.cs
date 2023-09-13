using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities;

    public class Usuario : BaseEntity
    {
        public string ? Username { get; set; }
        public string ? Email { get; set; }
        public string? Password { get; set; }
        public ICollection<Rol> ? Rols { get; set; } = new HashSet<Rol>();
        public ICollection<UsuarioRol>? UsuarioRoles { get; set; } = new HashSet<UsuarioRol>();
        

    }
