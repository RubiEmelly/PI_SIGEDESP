using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGEDESP_PI.Models;

[Table("instituicao")]
public class InstituicaoModel
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
 }

