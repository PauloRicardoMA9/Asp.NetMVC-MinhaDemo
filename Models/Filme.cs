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
        
        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60, ErrorMessage = "O título deve conter no máximo 60 caracteres")]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato incorreto")]
        public DateTime DataLancamento { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage = "O campo Gênero é obrigatório")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Gênero em formato inválido, a primeira letra deve ser maiúscula")]   // Primeira letra deve ser maiúscula, e as outras podem ser maiúsculas, minúsculas ou acentuações
        [StringLength(30, ErrorMessage = "O gênero deve conter no máximo 30 caracteres")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Range(1, 1000, ErrorMessage = "O valor deve estrar entre 1 e 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Avaliação deve estar entre 0 e 5")]    // Apenas números de 0 a 5
        public int Avaliacao { get; set; }
        
    }
}
