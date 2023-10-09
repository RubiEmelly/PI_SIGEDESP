using System.ComponentModel.DataAnnotations;

namespace SIGEDESP_PI.Models
{
    public class TipoDespesaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo Descrição")]
        public string Descricao { get; set; }
    }
}