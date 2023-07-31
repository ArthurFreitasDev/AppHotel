using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AppHotel.Model
{
    public class Hospedagem
    {
        int qnt_Adultos;
        Suite Quarto_Escolhido;

        public Suite QuartoEscolhido
        {
            get => Quarto_Escolhido;
            set
            {
                if (value == null)
                    throw new Exception("Por favor, selecione sua acomodação");

                Quarto_Escolhido = value;
            }
        }
        public int QntAdultos
        {
            get => qnt_Adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Por favor, selecione a quantidade de adultos");

                qnt_Adultos = value;
            }
        }

        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set;}

        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }

        public double ValorTotal
        {
            get => (QntAdultos * QuartoEscolhido.DiariaAdulto) +
                (QntCriancas * QuartoEscolhido.DiariaCrianca) * Estadia;
        }
    }
}
