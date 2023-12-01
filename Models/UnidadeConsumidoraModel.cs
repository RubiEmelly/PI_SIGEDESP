using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEDESP_PI.Models;

[Table("unidadeconsumidora")]
public class UnidadeConsumidoraModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("codigouc")]
    [Required(ErrorMessage = "O código da unidade consumidora deve ser informada")]
    [Display(Name = "Código Unidade Consumidora")]
    public int CodigoUC { get; set; }
}