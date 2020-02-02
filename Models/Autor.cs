using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models {
    public class Autor {
        public Autor () {
            this.Livros = new List<Livro> ();
        }

        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Não pode ficar em branco")]
        [StringLength (30, MinimumLength = 3, ErrorMessage = "Não pode ficar em branco")]
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}
