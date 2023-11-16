using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PostoInformatica_ERP.Models
{
    public class USUARIO
    {
        [Column("USUARIO")]
        [Display(Name = "Código")]
        [Key]
        public int ID { get; set; }

        [Column("NOME")]
        [Display(Name = "Nome")]
        public string? NOME { get; set; }

        [Column("SENHA")]
        [Display(Name = "Senha")]
        public string? SENHA { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string? CPF { get; set; }

        [Column("USUARIO_EMAIL")]
        [Display(Name = "E-mail Usuário")]
        public string? USUARIO_EMAIL { get; set; }

        [Column("SENHA_EMAIL")]
        [Display(Name = "Senha E-mail")]
        public string? SENHA_EMAIL { get; set; }
    }
}