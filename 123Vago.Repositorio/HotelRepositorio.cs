using _123Vago.Dominio;

namespace _123Vago.Repositorio
{
    public class HotelRepositorio : IHotelRepositorio
    {
        private readonly AppDbContext _context;
        public HotelRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public void Salvar(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
        }

        public IEnumerable<Hotel> Listar()
        {
            return _context.Hotels.ToList();
        }

        // Fix for CS0535: Implementing the missing method from the interface  
        void IHotelRepositorio.salvar(Hotel hotel)
        {
            Salvar(hotel);
        }
    }
}
