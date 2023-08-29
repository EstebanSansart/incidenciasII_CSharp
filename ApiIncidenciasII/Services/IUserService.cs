using ApiIncidenciasII.Dtos;

namespace ApiIncidenciasII.Services;
public interface IUserService
{
    Task<string> RegisterAsync(RegisterDto model);
    Task<DatosUsuarioDto> GetTokenAsync(LoggingBuilderExtensions model);
    Task<string> AddRoleAsync(AddRoleDto model);
}