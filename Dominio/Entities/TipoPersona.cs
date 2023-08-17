namespace Dominio.Entities;

public class TipoPersona : EntidadBase
{
    public int IdTipoPersona { get; set; }
    public string DescripcionTipoPersona { get; set; }
    public ICollection<Persona> Personas { get; set; }
}