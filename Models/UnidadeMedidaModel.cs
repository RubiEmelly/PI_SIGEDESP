using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEDESP_PI.Models;

[Table("unidademedida")]
public class UnidadeMedidaModel
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("descricao")]
    [Required(ErrorMessage = "A descrição do tipo de Instituição deve ser informada")]
    [Display(Name = "Descrição da Instituição")]
    [MinLength(1, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
    [MaxLength(100, ErrorMessage = "Descrição pode exceder {1} caracteres")]
    public string Descricao { get; set; }

    [Column("abreviatura")]
    [Required(ErrorMessage = "A sigla da Abreviatura deve ser informada")]
    [Display(Name = "Sigla da Abreviatura")]
    [MinLength(1, ErrorMessage = "Abreviatura deve ter no mínimo {1} caracteres")]
    [MaxLength(20, ErrorMessage = "Abreviatura pode exceder {1} caracteres")]
    public string Abreviatura { get; set; }
}