namespace MinhaCantina.Biblioteca.DTOs;

public class ProdutoRegistroDto
{
	public string Nome { get; set; } = string.Empty;
	public decimal Preco { get; set; }
	public string? Descricao { get; set; }
	public string ImagemURL { get; set; } = string.Empty;
	public int CategoriaId { get; set; }
}
