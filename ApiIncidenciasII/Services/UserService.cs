using ApiIncidenciasII.Dtos;
using ApiIncidenciasII.Helpers;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace ApiIncidenciasII.Services;
public class UserService : IUserService
{
    private readonly JwtBearerExtensions _jwt;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordHasher<Usuario> _usuario;
}