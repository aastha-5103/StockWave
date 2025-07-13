using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_COP_4365
{
    internal class SmartCandlestick : Candlestick
    {
        // Declare the properties
        public decimal range { get; set; } // Range of the candlestick
        public decimal topPrice { get; set; } // Highest price within the candlestick
        public decimal bottomPrice { get; set; } // Lowest price within the candlestick
        public decimal bodyRange { get; set; } // Range of the body of the candlestick
        public decimal upperTail { get; set; } // Length of the upper tail or wick
        public decimal lowerTail { get; set; } // Length of the lower tail or wick
        public bool IsPeak { get; set; } // peak
        public bool IsValley { get; set; } // valley

        public Dictionary<string, bool> Dictionary_Pattern = new Dictionary<string, bool>();

        // Function for smartcandlestick
        public SmartCandlestick(string csvLine) : base(csvLine)
        {
            //Call functions to computer extra properties
            ComputeExtraProperties();
            ComputePatternProperties();
        }

        public SmartCandlestick(Candlestick cs)
        {
            // Candlestic related data
            date = cs.date;
            open = cs.open;
            close = cs.close;
            high = cs.high;
            low = cs.low;
            volume = cs.volume;
            ComputeExtraProperties();
        }

        /// <summary>
        /// Computes the extra properties of a smart candlestick and stores them in member variables.
        /// </summary>
        private void ComputeExtraProperties()
        {

            // Range of the candlestick
            range = high - low;

            // Higher price
            topPrice = Math.Max(open, close);

            // Lower price
            bottomPrice = Math.Min(open, close);

            // Range between higher and lower price
            bodyRange = topPrice - bottomPrice;

            // Length of upper tail
            upperTail = high - topPrice;

            // Length of lower tail
            lowerTail = bottomPrice - low;
        }


        /// <summary>
        /// Computes the pattern properties of a smart candlestick and stores them in the member dictionary.
        /// </summary>
        private void ComputePatternProperties()
        {
            // Figure out the pattern of the candlestick and store

            // Close price greater than open price
            bool bullish = close > open;
            Dictionary_Pattern.Add("Bullish", bullish);

            //Open price greater than close price
            bool bearish = open > close;
            Dictionary_Pattern.Add("Bearish", bearish);

            //Body range less than 20% of total range
            bool neutral = bodyRange < (range * 0.2m);
            Dictionary_Pattern.Add("Neutral", neutral);

            // Entire body encompasses high and low prices
            bool marubozu = (topPrice >= high) && (bottomPrice <= low);
            Dictionary_Pattern.Add("Marubozu", marubozu);

            // Small body and long lower tail
            bool hammer = (bodyRange < range * 0.25m) && (lowerTail > range * 0.66m);
            Dictionary_Pattern.Add("Hammer", hammer);

            // Very small body range
            bool doji = bodyRange <= (range * 0.01m);
            Dictionary_Pattern.Add("Doji", doji);

            // Doji with long lower tail
            bool dragonfly_doji = doji && (lowerTail > range * 0.66m);
            Dictionary_Pattern.Add("Dragonfly Doji", dragonfly_doji);

            //Doji with long upper tail
            bool gravestone_doji = doji && (upperTail > range * 0.66m);
            Dictionary_Pattern.Add("Gravestone Doji", gravestone_doji);
        }



    }
}
