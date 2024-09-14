using System.ComponentModel.DataAnnotations;

namespace FEAasp.Models
{
    public class Parceiro
    {
        public int idParceiro { get; set; }
        public string nomeEmpresa { get; set; }
        public int CNPJ { get; set; }
        public int telefoneEmpresa { get; set; }

        public string EmailEmpresa { get; set; }

        public string Website { get; set; }
    }
}
