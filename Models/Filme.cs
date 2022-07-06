using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Titulo deve ser obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor deve ser obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O campo genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duração deve conter no min 1 e no máx 600 minutos")]
        public int Duracao { get; set; }
    }
}