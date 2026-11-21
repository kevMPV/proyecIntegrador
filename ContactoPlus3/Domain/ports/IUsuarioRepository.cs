using ContactosPlus.Domain.Entities;

namespace ContactosPlus.Domain.Ports;

public interface IUsuarioRepository
{
    Task<Usuario?> ObtenerPorUsernameAsync(string username);
}