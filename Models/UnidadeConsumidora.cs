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
    [MinLength(1, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(100, ErrorMessage = "Descrição pode exceder {1} caracteres")]
    public int CodigoUC { get; set; }
}