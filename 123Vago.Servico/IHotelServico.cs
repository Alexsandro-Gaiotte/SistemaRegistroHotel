namespace _123Vago.Servico
{
    public interface IHotelServico
    {
        void Adicionar(HotelDto hotelDto);
        IEnumerable<HotelDto> Listar();
    }
}
