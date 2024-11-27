using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelecionado { get; set; } // Representa o quarto selecionado para a hospedagem
        public int QntAdultos { get; set; } // Representa a quantidade de adultos na hospedagem
        public int QntCriancas { get; set; } // Representa a quantidade de crianças na hospedagem
        public DateTime DataCheckIn { get; set; } // Representa a data de check-in da hospedagem

        public DateTime DataCheckOut { get; set; } // Representa a data de check-out da hospedagem

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days; // Calcula a quantidade de dias de estadia com base nas datas de check-in e check-out
        }

        public double ValorTotal
        {
            get
            {
                double Valor_adultos = QntAdultos * QuartoSelecionado.ValorDiariaAdulto; // Calcula o valor total dos adultos na hospedagem
                double Valor_criancas = QntCriancas * QuartoSelecionado.ValorDiariaCrianca; // Calcula o valor total das crianças na hospedagem

                double total = (Valor_adultos + Valor_criancas) * Estadia; // Calcula o valor total da hospedagem

                return total;
            }//fechaGet
        }//fechaValorTotal
    }//fechaHospedagem
}//fechaModels
