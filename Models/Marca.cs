using System.ComponentModel.DataAnnotations;

namespace Emanuel_Brito.Models
{
    public class Marca
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        
        [Display(Name = "Descrição")]
        public string Descricao {get; set;}
    }
}