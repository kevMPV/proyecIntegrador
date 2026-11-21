namespace ContactosPlus.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string NombreUsuario { get; set; } = string.Empty; //En lugar de usar "", mejor usamos la función Empty, se ve las elegante
    public string NombreCompleto { get; set; } = string.Empty; 
    public string PasswordHash { get; set; } = string.Empty; 
    public string Rol { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public bool EstaActivo { get; set; }

    // Método con regla de negovcio
    public bool PuedeIniciarSesion() => EstaActivo;
}