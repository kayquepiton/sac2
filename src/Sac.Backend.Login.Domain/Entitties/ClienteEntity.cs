namespace Sac.Backend.Login.Domain.Entities;

public class ClienteEntity : BaseEntity
{
    public string? Nome_RazaoSocial { get; set; }
    public string? CPF_CNPJ { get; set; }
    public Guid EnderecoId { get; set; }
    public EnderecoEntity? Endereco { get; set; }
    public Guid ContatoId { get; set; }
    public ContatoEntity? Contato { get; set; }
    public TipoPessoaEnum TipoPessoa { get; set; }
    public TipoClienteEnum TipoCliente { get; set; }
    public ICollection<ChamadoEntity>? Chamados { get; set; }
}

public enum TipoPessoaEnum
{
    Fisica,
    Juridica
}

public enum TipoClienteEnum
{
    ConsumidorFinal,
    EmpresaLicitacao
}
