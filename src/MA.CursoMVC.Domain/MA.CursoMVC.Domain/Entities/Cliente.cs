using System;
using System.Collections.Generic;

namespace MA.CursoMVC.Domain.Entities
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string  CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }

        public Cliente()
        {
            ClienteId = Guid.NewGuid();
        }
    }
}
