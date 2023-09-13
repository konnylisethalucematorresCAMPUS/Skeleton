namespace Dominio.Entities;

    public class Rol : BaseEntity
    {
        public string ? Nombre { get; set; }
        public ICollection<Usuario> ? Usuarios { get; set; }
        public ICollection<UsuarioRol> ? UsuarioRoles { get; set; }
    }
