﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAspNetAPI02.Services.Models
{
    public class ContatosConsultaModel
    {
        public Guid IdContato { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Foto { get; set; }
    }
}