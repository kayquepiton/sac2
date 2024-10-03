namespace Sac.Backend.Login.Domain.Entities;

public class AnexoEntity : BaseEntity
{
    public string? URL { get; set; }
    public Guid ChamadoId { get; set; }
    public ChamadoEntity? Chamado { get; set; }
}
