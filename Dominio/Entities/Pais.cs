namespace Dominio.Entities;

public class Pais : EntidadBase
{
    public string IdPais { get; set; }
    public string NombrePais { get; set; }
    public ICollection<Departamento> Departamentos { get; set; }
    public string Id { get; set; }
}