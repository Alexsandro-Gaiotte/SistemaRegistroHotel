using _123Vago.Dominio;
using _123Vago.Repositorio;

namespace _123Vago.Servico
{
    public class HotelServico : IHotelServico
    {
        private readonly IHotelRepositorio _repositorio;

        public HotelServico(IHotelRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(HotelDto hotelDto)
        {
            var hotel = new Hotel(hotelDto.Nome, hotelDto.Quarto, hotelDto.Localizacao, hotelDto.Descricao);
            _repositorio.salvar(hotel);
        }

        public IEnumerable<HotelDto> Listar()
        {
            return _repositorio.Listar().Select(hotel => new HotelDto
            {
                Nome = hotel.Nome,
                Quarto = hotel.Quarto,
                Localizacao = hotel.Localizacao,
                Descricao = hotel.Descricao

            });
        }
    }
}
