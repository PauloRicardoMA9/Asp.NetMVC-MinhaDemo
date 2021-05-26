using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemo.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, ErrorMessage = "O título deve conter no máximo 60 caracteres")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido")]   // Primeira letra deve ser maiúscula, e as outras podem ser maiúsculas, minúsculas ou acentuações
        [StringLength(30, ErrorMessage = "O gênero deve conter no máximo 30 caracteres")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "O valor deve estrar entre 1 e 1000")]
        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Avaliação em formato inválido")]    // Apenas números de 0 a 5
        [Display(Name = "Avaliação")]
        public string Avaliacao { get; set; }
        
    }
}
