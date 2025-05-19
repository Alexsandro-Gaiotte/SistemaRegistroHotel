using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123Vago.Servico
{
    public class HotelDto
    {
        public string Nome { get; set; } = string.Empty; // Fix: Initialize with a default non-null value
        public int Quarto { get; set; }
        public string Localizacao { get; set; } = string.Empty; // Fix: Initialize with a default non-null value
        public string Descricao { get; set; } = string.Empty; // Fix: Initialize with a default non-null value
    }
}
