﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cont.Dominio.Entidades
{
    public class Contato : EntidadeBase
    {
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Contato()
        {
                
        }
    }
}
