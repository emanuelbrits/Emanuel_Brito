using System.ComponentModel.DataAnnotations;

namespace Emanuel_Brito.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Nome do Banco")]
        public string NomeDoBanco {get; set;}
    }
}