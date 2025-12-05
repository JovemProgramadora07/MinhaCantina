using Microsoft.AspNetCore.Mvc;

namespace MinhaCantina.Servidor.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	private readonly ILogger<WeatherForecastController> _logger;

	public WeatherForecastController(ILogger<WeatherForecastController> logger)
	{
		_logger = logger;
	}

	[HttpGet(Name = "GetWeatherForecast")]
	public IEnumerable<WeatherForecast> Get()
	{
		return Enumerable.Range(1, 5).Select(index => new WeatherForecast
		{
			Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			TemperatureC = Random.Shared.Next(-20, 55),
			Summary = Summaries[Random.Shared.Next(Summaries.Length)]
		})
		.ToArray();
	}

	// GET - Pegar, POST - Criar, PUT/PATCH - Atualização, DELETE - Exclusao
	[HttpGet("status")]
	public IActionResult Status()
	{
		return StatusCode(200, new 
		{
			Mensagem = "Hello, World"
		});
	}

	[HttpGet("saudacao/{nome}")]
	public IActionResult Saudacao(string nome)
	{
		return StatusCode(200, new
		{
			Mensagem = $"Boas vindas, {nome}"
		});
	}
}
