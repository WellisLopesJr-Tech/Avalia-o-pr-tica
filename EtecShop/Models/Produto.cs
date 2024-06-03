using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EtecShop.Models;

[Table("Produto")]
public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome do Produto")]
    [StringLength(100, ErrorMessage = "O Nome deve possuir até 100 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descricação")]
    [StringLength(1000, ErrorMessage = "A Descrição deve possuir até 1000 caracteres")]
    public string Descricao { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(10,2)")]
    [Required(ErrorMessage = "Informe o preço de venda")]
    public decimal Preco { get; set; }

    [Display(Name = "Qtde. Estoque")]
    [Required(ErrorMessage = "Informe a Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }
}