
using System.ComponentModel.DataAnnotations.Schema;

namespace Aprendendo.Models
{
    [Table(name:nameof(Cliente))]
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
    }
}