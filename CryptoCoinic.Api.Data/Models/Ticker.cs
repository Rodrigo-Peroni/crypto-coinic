using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoCoinic.Api.Data.Models
{
    public class Ticker
    {
        public string FiatCurrency { get; set; }
        /// <summary>
        /// Moeda a qual o Ticker se refere.
        /// </summary>
        [JsonPropertyName("symbol")]
        public string Symbol { get; set; }

        [JsonPropertyName("priceChange")]
        public string PriceChange { get; set; }

        [JsonPropertyName("priceChangePercent")]
        public string PriceChangePercent { get; set; }

        [JsonPropertyName("weightedAvgPrice")]
        public string WeightedAvgPrice { get; set; }

        [JsonPropertyName("openPrice")]
        public string OpenPrice { get; set; }

        /// <summary>
        /// Maior preço unitário de negociação das últimas 24 horas.
        /// </summary>
        [JsonPropertyName("highPrice")]
        public string HighPrice { get; set; }

        /// <summary>
        /// Menor preço unitário de negociação das últimas 24 horas.
        /// </summary>
        [JsonPropertyName("lowPrice")]
        public string LowPrice { get; set; }

        /// <summary>
        /// Preço unitário da última negociação.
        /// </summary>
        [JsonPropertyName("lastPrice")]
        public string LastPrice { get; set; }

        /// <summary>
        /// Quantidade negociada nas últimas 24 horas.
        /// </summary>
        [JsonPropertyName("volume")]
        public string Volume { get; set; }

        [JsonPropertyName("quoteVolume")]
        public string QuoteVolume { get; set; }

        [JsonPropertyName("openTime")]
        public long OpenTime { get; set; }

        /// <summary>
        /// Data e hora da informação em Era Unix.
        /// </summary>
        [JsonPropertyName("closeTime")]
        public long CloseTime { get; set; }

        [JsonPropertyName("firstId")]
        public long FirstId { get; set; }

        [JsonPropertyName("lastId")]
        public long LastId { get; set; }

        [JsonPropertyName("count")]
        public long Count { get; set; }










    }
}