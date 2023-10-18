using System.ComponentModel.DataAnnotations;

namespace SIGEDESP_PI.Models
{
    public class UnidadeMedidaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o campo Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite o campo de Abreviação")]
        public string Abreviatura { get; set; }
    }
}