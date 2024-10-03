namespace Sac.Backend.Login.Domain.Entities;

public class ContatoEntity : BaseEntity
{
    public string? PessoaResponsavel { get;}
    public string? Setor{ get; set; }
    public string? EmailPessoal { get; set; }
    public string? TelefonePessoal { get; set; }
    public string? CelularPessoal { get; set; }
    public string? EmailEmpresa { get; set; }
    public string? TelefoneEmpresa { get; set; }
    public string? CelularEmpresa { get; set; }
    public ClienteEntity? Cliente { get; set; }
}
