namespace Sac.Backend.Login.Domain.Entities;

public class EnderecoEntity : BaseEntity
{
    public string? CEP { get; set; }
    public string? Endereco { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public EstadoEnum Estado { get; set; }
    public string? Cidade { get; set; }
    public ClienteEntity? Cliente { get; set; }
}

public enum EstadoEnum
{
    AC, AL, AP, AM, BA, CE, DF, ES, GO, MA, MG, MS, MT,
    PA, PB, PE, PI, PR, RJ, RN, RO, RR, RS, SC, SE, SP, TO
}
