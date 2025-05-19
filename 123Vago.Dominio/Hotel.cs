namespace _123Vago.Dominio
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public int Quarto { get; private set; }
        public string Localizacao { get; private set; }
        public string Descricao { get; private set; }

        public Hotel(string nome, int quarto, string localizacao, string descricao)
        {
            Nome = nome;
            Quarto = quarto;
            Localizacao = localizacao;
            Descricao = descricao;
        }

        public bool Disponivel()
        {
            return Quarto >= 1;
        }
    }
}

