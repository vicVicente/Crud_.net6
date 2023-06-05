using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Model;

[Table("Categorias")]// Nome da tabela
public class Categoria
{
    public Categoria() { 
        Produtos = new Collection<Produto>();
    }

    [Key] // Indica que é chave primária da tabela
    public int CategoriaId { get; set; }

    [Required]// Indica que esse membro é obrigatório.
    [StringLength(80)]// Indica o tamanho do campo que será usado no banco.
    public string? Nome { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    public ICollection<Produto>? Produtos { get; set; } // Isso define que Categoria pode ter um ou mais produtos.
}
