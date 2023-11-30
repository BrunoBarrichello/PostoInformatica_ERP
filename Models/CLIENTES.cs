using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PostoInformatica_ERP.Models
{
    [Table("CLIENTES")]
    public class CLIENTES
    {

        [Column("CNPJ_CPF")]
        [Display(Name = "CNPJ / CPF")]
        [Key]
        public string? CNPJ_CPF { get; set; }

        [Column("RG_INSCRICAO")]
        [Display(Name = "RG / Inscrição")]
        public string? RG_INSCRICAO { get; set; }

        [Column("INSCRICAOMUNICIPAL")]
        [Display(Name = "Inscrição Municipal")]
        public string? INSCRICAOMUNICIPAL { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string? NOME { get; set; }

        [Column("FANTASIA")]
        [Display(Name = "Fantasia")]
        public string? FANTASIA { get; set; }

        [Column("COLIGADA")]
        [Display(Name = "Coligada")]
        public string? COLIGADA { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string? CEP { get; set; }

        [Column("CEP_COBRANCA")]
        [Display(Name = "CEP")]
        public string? CEP_COBRANCA { get; set; }

        [Column("ENDERECO")]
        [Display(Name = "Endereço")]
        public string? ENDERECO { get; set; }

        [Column("ENDERECO_COBRANCA")]
        [Display(Name = "Endereço")]
        public string? ENDERECO_COBRANCA { get; set; }

        [Column("NUMERO")]
        [Display(Name = "Número")]
        public int? NUMERO { get; set; }

        [Column("NUMERO_COBRANCA")]
        [Display(Name = "Número")]
        public int? NUMERO_COBRANCA { get; set; }

        [Column("COMPLEMENTO")]
        [Display(Name = "Complemento")]
        public string? COMPLEMENTO { get; set; }

        [Column("COMPLEMENTO_COBRANCA")]
        [Display(Name = "Complemento")]
        public string? COMPLEMENTO_COBRANCA { get; set; }

        [Column("BAIRRO")]
        [Display(Name = "Bairro")]
        public string? BAIRRO { get; set; }

        [Column("BAIRRO_COBRANCA")]
        [Display(Name = "Bairro")]
        public string? BAIRRO_COBRANCA { get; set; }

        [Column("CIDADE")]
        [Display(Name = "Cidade")]
        public string? CIDADE { get; set; }

        [Column("CIDADE_COBRANCA")]
        [Display(Name = "Cidade")]
        public string? CIDADE_COBRANCA { get; set; }

        [Column("CIDADE_IBGE")]
        [Display(Name = "Código IBGE")]
        public string? CIDADE_IBGE { get; set; }

        [Column("ESTADO")]
        [Display(Name = "UF")]
        public string? ESTADO { get; set; }

        [Column("ESTADO_COBRANCA")]
        [Display(Name = "UF")]
        public string? ESTADO_COBRANCA { get; set; }

        [Column("CAIXA_POSTAL")]
        [Display(Name = "Cx. Postal")]
        public string? CAIXA_POSTAL { get; set; }

        [Column("CAIXA_POSTAL_COBRANCA")]
        [Display(Name = "Cx. Postal")]
        public string? CAIXA_POSTAL_COBRANCA { get; set; }

        [Column("PAIS")]
        [Display(Name = "País")]
        public string? PAIS { get; set; }

        [Column("FONE")]
        [Display(Name = "Fone")]
        public string? FONE { get; set; }

        [Column("FONE_RAMAL")]
        [Display(Name = "Ramal")]
        public string? FONE_RAMAL { get; set; }

        [Column("CELULAR")]
        [Display(Name = "Celular")]
        public string? CELULAR { get; set; }

        [Column("INTERNET")]
        [Display(Name = "Site")]
        public string? INTERNET { get; set; }

        [Column("CONTATO")]
        [Display(Name = "Contato")]
        public string? CONTATO { get; set; }

        [Column("EMAIL")]
        [Display(Name = "E-mail")]
        public string? EMAIL { get; set; }

        [Column("COND_PAGAMENTO")]
        [Display(Name = "Condições de Pagamento")]
        public string? COND_PAGAMENTO { get; set; }

        [Column("CLIENTES")]
        [Display(Name = "Código")]
        public int? CODIGO { get; set; }
        
        [Column("LOGIN")]
        [Display(Name = "Nome de Usuário")]
        public string? LOGIN { get; set; }

        [Column("SENHA")]
        [Display(Name = "Senha")]
        public string? SENHA { get; set; }

        [Column("VENDEDOR")]
        [Display(Name = "Vendedor")]
        public string? VENDEDOR { get; set; }

        [Column("OPTANTE_SIMPLES")]
        [Display(Name = "Optante Simples")]
        public string? OPTANTE_SIMPLES { get; set; }

    }
}