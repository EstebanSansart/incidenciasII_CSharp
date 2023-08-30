using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Aplicacion.Contratos;
using Dominio.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Seguridad.TokenSeguridad;
public class JwtGenerador : IJwtGenerador
{
    public string CrearToken(Usuario usuario)
    {
        var claims = new List<Claim>{
            new Claim(JwtRegisteredClaimNames.NameId, usuario.Username)
        };
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("rgfZs3pNboV0hbg6Fat"));
        var credenciales = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);
        var tokenDescripcion = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddMinutes(20),
            SigningCredentials = credenciales
        };
        var tokenManejador = new JwtSecurityTokenHandler();
        var token = tokenManejador.CreateToken(tokenDescripcion);
        return tokenManejador.WriteToken(token);
    }
}