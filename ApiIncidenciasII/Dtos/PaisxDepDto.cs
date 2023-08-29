namespace ApiIncidenciasII.Dtos;
public class PaisxDepDto
{
    public string Id { get; set; }
    public string NombrePais { get; set; }
    public List<DepartamentoDto> Departamentos { get; set; }
}