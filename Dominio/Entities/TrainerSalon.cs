namespace Dominio.Entities;

public class TrainerSalon : EntidadBase
{
    public string IdPerTrainerFk { get; set; }
    public Persona Persona { get; set; }
    public int IdSalonFk { get; set; }
    public Salon Salon { get; set; }
}