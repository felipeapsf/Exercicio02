﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Projeto.Services.Models
{
    public class CompromissoCadastroModel
    {
        [Required(ErrorMessage = ("Campo obrigatório."))]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Mínimo de 6 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage ="Mínimo de 6 caracteres.")]
        public string Local { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public DateTime DataHora { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Descricao { get; set; }
    }
}
