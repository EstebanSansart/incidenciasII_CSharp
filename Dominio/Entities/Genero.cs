namespace Dominio.Entities;

public class Genero : EntidadBase
{
    public int IdGenero { get; set; }
    public string NombreGenero { get; set; }
    public ICollection<Persona> Personas { get; set; }
}