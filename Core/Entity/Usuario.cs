using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Usuario : EntityBase
    {
        public required string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string? Email { get; set; }
        public string? NickName { get; set; }
        public int SenhaHash { get; set; }
        public DateTime? UsuarioCriacao { get; set; }

    }
}
