using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CryptoCoinic.Api.Data
{
    public static class Broker
    {
        public static String MercadoBitcoin { get { return "MercadoBitcoin"; } }
    }

    public static class Currency
    {
        public static String BTC { get { return "BTC"; } }
        public static String LTC { get { return "LTC"; } }
        public static String BCH { get { return "BCH"; } }
    }
}