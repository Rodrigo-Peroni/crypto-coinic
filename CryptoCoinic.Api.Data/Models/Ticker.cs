using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoCoinic.Api.Data.Models
{
    public class Ticker
    {
        /// <summary>
        /// Moeda a qual o Ticker se refere.
        /// </summary>
        //public string TickerCurrency { get; set; } //ENUM

        /// <summary>
        /// Maior preço unitário de negociação das últimas 24 horas.
        /// </summary>
        public decimal high { get; set; }

        /// <summary>
        /// Menor preço unitário de negociação das últimas 24 horas.
        /// </summary>
        public decimal Low { get; set; }

        /// <summary>
        /// Quantidade negociada nas últimas 24 horas.
        /// </summary>
        public decimal Vol { get; set; }

        /// <summary>
        /// Preço unitário da última negociação.
        /// </summary>
        public decimal Last { get; set; }

        /// <summary>
        /// Maior preço de oferta de compra das últimas 24 horas.
        /// </summary>
        public decimal Buy { get; set; }

        /// <summary>
        /// Menor preço de oferta de venda das últimas 24 horas.
        /// </summary>
        public decimal Sell { get; set; }

        /// <summary>
        /// Data e hora da informação em Era Unix.
        /// </summary>
        public int Date { get; set; }
    }
}