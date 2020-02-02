using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models {
    public class Livro {
        public Livro () {
            this.Autores = new List<Autor> ();
        }

        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Não pode ficar em branco")]
        [StringLength (30, MinimumLength = 3, ErrorMessage = "Não pode ficar em branco")]
        public string Nome { get; set; }
        public string ISBN { get; set; }

        [Required (ErrorMessage = "Não pode ficar em branco")]
        [DataType (DataType.Date)]
        public DateTime DataLancamento { get; set; }

        public int CategoriaID { get; set; }
        public Categoria Categoia { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}
