﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR.Domain
{
    public class Categoria
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        public DateTime DataDeCriacao = DateTime.Now;

        //public Subcategoria Subcategoria CPF { get; set; }
        public int Status { get; set; }
    }
}