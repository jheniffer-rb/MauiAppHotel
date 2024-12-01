using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models // Namespace que representa o local onde a classe se encontra
{
    public class Quarto // Classe que representa um quarto do hotel
    {
        public string Descricao { get; set; } // Propriedade que representa a descrição do quarto

        public double ValorDiariaAdulto { get; set; } // Propriedade que representa o valor da diária para adultos

        public double ValorDiariaCrianca { get; set; } // Propriedade que representa o valor da diária para crianças
    }
}
