using System.ComponentModel.DataAnnotations;

namespace FEAasp.Models
{
    public class contatos
    {
        public int idContato { get; set; }
        public string nomeContato { get; set; }
        public string emailcontato { get; set; }
        public int telefoneContato { get; set; }
        public string mensagem { get; set; }
    }
}
