using _123Vago.Dominio;

namespace _123Vago.Repositorio
{
    public interface IHotelRepositorio
    {
        void salvar(Hotel hotel);
        IEnumerable<Hotel> Listar();
    }
}
