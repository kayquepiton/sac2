namespace Sac.Backend.Login.Domain.Entities;

public class ChamadoEntity : BaseEntity
{
    public StatusTicket Status { get; set; }
    public Guid ClienteId { get; set; } 
    public ClienteEntity? Cliente { get; set; }
    public Guid ProdutoId { get; set; }
    public ProdutoEntity? Produto { get; set; }
    public ICollection<AnexoEntity>? Anexos { get; set; }
}

public enum StatusTicket
{
    Aberto,
    EmProgresso,
    Concluido,
    Cancelado
}
