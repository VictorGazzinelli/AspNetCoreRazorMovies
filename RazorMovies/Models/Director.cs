using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorMovies.Models
{
    public class Director
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 60 caracteres!")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Name { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
