namespace Sac.Backend.Login.Domain.Entities;

public class ProdutoEntity : BaseEntity
{
    public string? NotaFiscal { get; set; }
    public DateTime DataCompra { get; set; }
    public string? Loja { get; set; }
    public string? NumeroSerie_IMEI { get; set; }
    public string? TipoPeca { get; set; }
    public string? DefeitoApresentado { get; set; }
    public ChamadoEntity? Chamado { get; set; }
}

