// ApplicationCore/UseCases/AutenticarUsuarioUseCase.cs
using ContactosPlus.ApplicationCore.DTOs;
using ContactosPlus.Domain.Ports;

namespace ContactosPlus.ApplicationCore.UseCases;

public class AutenticarUsuarioUseCase
{
    private readonly IUsuarioRepository _usuarioRepository;

    public AutenticarUsuarioUseCase(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<UsuarioSesionDto?> EjecutarAsync(LoginRequestDto request)
    {
        // 1. Obtener usuario desde el puerto
        var usuario = await _usuarioRepository.ObtenerPorUsernameAsync(request.Username);

        if (usuario == null || !usuario.PuedeIniciarSesion())
        {
            return null; // Usuario no encontrado o inactivo
        }

        // 2. Simulación de validación de contraseña (en producción usar BCrypt/Argon2)
        bool esPasswordValido = usuario.PasswordHash == request.Password;
        if (!esPasswordValido)
        {
            return null;
        }

        // 3. Mapear la entidad de Dominio a un DTO de respuesta para la vista
        return new UsuarioSesionDto {
            Id = usuario.Id,
            NombreCompleto = usuario.NombreCompleto,
            Rol = usuario.Rol
        };
    }
} 