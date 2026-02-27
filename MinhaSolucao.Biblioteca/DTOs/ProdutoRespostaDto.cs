namespace MinhaCantina.Biblioteca.DTOs;

public class ProdutoRespostaDto
{
	public int Id { get; set; }
	public string Nome { get; set; } = string.Empty;
	public string Descricao { get; set; } = string.Empty;
	public decimal Preco { get; set; }
	public string ImagemURL { get; set; } = string.Empty;
	public string CategoriaNome { get; set; } = string.Empty;
}
