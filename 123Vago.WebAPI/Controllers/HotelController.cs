using _123Vago.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _123Vago.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelServico _servico;

        public HotelController(IHotelServico servico)
        {
            _servico = servico;
        }
        [HttpPost]
        public IActionResult Adicionar(HotelDto dto)
        {
            _servico.Adicionar(dto);
            return Ok("Hotel adicionado com sucesso");
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_servico.Listar());
        }
    }
}
