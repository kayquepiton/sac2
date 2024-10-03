namespace Sac.Backend.Login.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public bool Deletado { get; set; } = false;
}
