using System;
using System.ComponentModel.DataAnnotations;

namespace RazorMovies.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título deve ter entre 3 e 60 caracteres!")]
        [Required(ErrorMessage = "Obrigatório informar o título!")]
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Caracteres inválidos!")]
        [Required(ErrorMessage = "Obrigatório informar o gênero!")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres!")]
        public string Genre { get; set; }
        [Range(1, 100, ErrorMessage = "Preço deve ser entre 1 e 100!")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Obrigatório informar o preço!")]
        public double Price { get; set; }

        public int DirectorID { get; set; }
        public Director Director { get; set; }
    }
}
