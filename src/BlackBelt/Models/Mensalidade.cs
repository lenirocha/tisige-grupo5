using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackBelt.Models
{
    public class Mensalidade
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Id_Aluno { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        public DateOnly DataVencimento { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? DataPagamento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

        public string Status { get; set; } // Em dia, Atrasado, Pendente

        [ForeignKey("Id_Aluno")]
        public Aluno Aluno { get; set; }
    }
}
