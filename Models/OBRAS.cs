using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PostoInformatica_ERP.Models
{
    public class OBRAS
    {

        [Key]
        [Column("INCREMENTO")]
        [Display(Name = "Incremento")]
        public int INCREMENTO { get; set; }

        [Column("OBRA")]
        [Display(Name = "Obra")]
        public int OBRA { get; set; }

        [Column("DESCRICAO")]
        [Display(Name = "Descrição")]
        public string DESCRICAO { get; set; }

        [Column("CLIENTE")]
        [Display(Name = "Cliente")]
        public string CLIENTE { get; set; }

        [Column("ENDERECO")]
        [Display(Name = "Endereço")]
        public string ENDERECO { get; set; }

        [Column("NUMERO")]
        [Display(Name = "Número")]
        public int NUMERO { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [Column("COMPLEMENTO")]
        [Display(Name = "Complemento")]
        public string COMPLEMENTO { get; set; }

        [Column("REFERENCIA")]
        [Display(Name = "Referência")]
        public string REFERENCIA { get; set; }

        [Column("BAIRRO")]
        [Display(Name = "Bairro")]
        public string BAIRRO { get; set; }

        [Column("CONTATO1")]
        [Display(Name = "Contato 1")]
        public string CONTATO1 { get; set; }

        [Column("CONTATO2")]
        [Display(Name = "Contato 2")]
        public string CONTATO2 { get; set; }

        [Column("CIDADE")]
        [Display(Name = "Cidade")]
        public int CIDADE { get; set; }

        [Column("ESTADO")]
        [Display(Name = "Estado")]
        public string ESTADO { get; set; }

        [Column("CEI")]
        [Display(Name = "CEI")]
        public string CEI { get; set; }

        [Column("CIDADE_DESCRICAO")]
        [Display(Name = "Descrição da Cidade")]
        public string CIDADE_DESCRICAO { get; set; }

        [Column("ISS")]
        [Display(Name = "ISS")]
        public decimal ISS { get; set; }

        [Column("CONTRATO")]
        [Display(Name = "Contrato")]
        public string CONTRATO { get; set; }

        [Column("CODIGOGIS")]
        [Display(Name = "Código GIS")]
        public string CODIGOGIS { get; set; }

        [Column("CODIGOGISRC")]
        [Display(Name = "Código GIS RC")]
        public string CODIGOGISRC { get; set; }

        [Column("CONCLUSAO")]
        [Display(Name = "Conclusão")]
        public DateTime? CONCLUSAO { get; set; }

        [Column("OBSERVACOES")]
        [Display(Name = "Observações")]
        public string OBSERVACOES { get; set; }

        [Column("VALOR_CONTRATO")]
        [Display(Name = "Valor do Contrato")]
        public decimal VALOR_CONTRATO { get; set; }

        [Column("ISENTA_ISS")]
        [Display(Name = "Isenta ISS")]
        public string ISENTA_ISS { get; set; }

        [Column("OFICIO")]
        [Display(Name = "Ofício")]
        public string OFICIO { get; set; }

        [Column("RETENCAO")]
        [Display(Name = "Retenção")]
        public string RETENCAO { get; set; }

        [Column("EMPRESA")]
        [Display(Name = "Empresa")]
        public int EMPRESA { get; set; }

        [Column("VALOREMPERMUTA")]
        [Display(Name = "Valor da Permuta")]
        public decimal VALOREMPERMUTA { get; set; }

        [Column("PERCENTUALPERMUTA")]
        [Display(Name = "Percentual de Permuta")]
        public decimal PERCENTUALPERMUTA { get; set; }

        [Column("VALORPERMUTADOANTERIOR")]
        [Display(Name = "Valor Permutado Anterior")]
        public decimal VALORPERMUTADOANTERIOR { get; set; }

    }
}
