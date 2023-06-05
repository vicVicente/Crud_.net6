using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Model;

[Table("Produtos")]// Nome da tabela
public class Produto
{
    [Key] // Indica que é chave primária da tabela
    public int ProdutoId { get; set; }

    [Required]// Indica que esse membro é obrigatório.
    [StringLength(80)]// Indica o tamanho do campo que será usado no banco.
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? Descricao { get; set; }

    [Required]
    [Column(TypeName ="decimal(10,2)")]//Indica o tamanho do valor decimal e quandas casas decimais após a vírgula.
    public decimal Preco { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    public int CategoriaId { get; set; } //Chave estrangeira da entidade categoria.

    [JsonIgnore]//Essa tag faz com que essa propriedade seja ignorada ao serializar/desserializar como json.
    public Categoria? Categoria { get; set; } // Isso indica que ele vai "conexão" com categoria.
}
