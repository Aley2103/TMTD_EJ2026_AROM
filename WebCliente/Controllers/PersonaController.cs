using Microsoft.AspNetCore.Mvc;

namespace WebCliente.Controllers
{
    public class PersonaController : Controller
    {
        private string urlBase;
        private string cadena;
        private readonly IHttpClientFactory _httpClientFactory;

        public PersonaController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            urlBase = configuration["baseurl"];
            _httpClientFactory = httpClientFactory;

            cadena = "Holaaaa";
        }
        //traer datos como un string
        public async Task<string> listarPersonas()
        {
            var cliente = _httpClientFactory.CreateClient();
            cliente.BaseAddress = new Uri(urlBase);
            string cadena = await cliente.GetStringAsync("persona");

            return cadena;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
