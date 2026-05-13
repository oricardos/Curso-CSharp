using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models;

public class Produto
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "O Nome é obrigatório")]
    [StringLength(80)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A Descrição é obrigatória")]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "O Preço é obrigatório")]
    [Column(TypeName ="decimal(10,2)")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "A Imagem é obrigatória")]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; }
    
    [JsonIgnore]
    public Categoria? Categoria { get; set; }
}
