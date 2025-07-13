using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_2
{
    internal class SmartCandlestick : Candlestick
    {
        // Declare public properties for smart candlestick data
        public decimal range { get; set; } // Range of the candlestick
        public decimal topPrice { get; set; } // Highest price within the candlestick
        public decimal bottomPrice { get; set; } // Lowest price within the candlestick
        public decimal bodyRange { get; set; } // Range of the body of the candlestick
        public decimal topTail { get; set; } // Length of the upper tail or wick
        public decimal bottomTail { get; set; } // Length of the lower tail or wick
        public bool IsPeak { get; set; } // setup for peak
        public bool IsValley { get; set; } // setup for valley

        // Dictionary to store true/false values indicating presence of specific candlestick patterns
        public Dictionary<string, bool> Dictionary_Pattern = new Dictionary<string, bool>();

        // Constructor that initializes a SmartCandlestick object using CSV data
        public SmartCandlestick(string csvLine) : base(csvLine)
        {
            // Compute extra properties and pattern properties when constructing the object
            getMoreProperties();
            ComputePattern();
        }

        // Conversion constructor that creates a SmartCandlestick object from a Candlestick object
        public SmartCandlestick(Candlestick cs)
        {
            // Copy basic candlestick data
            date = cs.date;
            open = cs.open;
            close = cs.close;
            high = cs.high;
            low = cs.low;
            volume = cs.volume;
            // Compute extra properties when converting
            getMoreProperties();
        }

        /// <summary>
        /// Computes the extra properties of a smart candlestick and stores them in member variables.
        /// </summary>
        private void getMoreProperties()
        {
            // Calculate various properties based on candlestick data

            // Calculate the total range of the candlestick
            range = high - low;

            // Determine the higher price between open and close
            topPrice = Math.Max(open, close);

            // Determine the lower price between open and close
            bottomPrice = Math.Min(open, close);

            // Calculate the range of the candlestick's body
            bodyRange = topPrice - bottomPrice;

            // Calculate the length of the upper tail
            topTail = high - topPrice;

            // Calculate the length of the lower tail
            bottomTail = bottomPrice - low;
        }


        /// <summary>
        /// Computes the pattern properties of a smart candlestick and stores them in the member dictionary.
        /// </summary>
        private void ComputePattern()
        {
            // Determine and store the presence of different candlestick patterns

            // Bullish pattern: Close price greater than open price
            bool bullish = close > open;
            Dictionary_Pattern.Add("Bullish", bullish);

            // Bearish pattern: Open price greater than close price
            bool bearish = open > close;
            Dictionary_Pattern.Add("Bearish", bearish);

            // Neutral pattern: Body range less than 20% of total range
            bool neutral = bodyRange < (range * 0.2m);
            Dictionary_Pattern.Add("Neutral", neutral);

            // Marubozu pattern: Entire body encompasses high and low prices
            bool marubozu = (topPrice >= high) && (bottomPrice <= low);
            Dictionary_Pattern.Add("Marubozu", marubozu);

            // Hammer pattern: Small body and long lower tail
            bool hammer = (bodyRange < range * 0.25m) && (bottomTail > range * 0.66m);
            Dictionary_Pattern.Add("Hammer", hammer);

            // Doji pattern: Very small body range
            bool doji = bodyRange <= (range * 0.01m);
            Dictionary_Pattern.Add("Doji", doji);

            // Dragonfly doji pattern: Doji with long lower tail
            bool dragonfly_doji = doji && (bottomTail > range * 0.66m);
            Dictionary_Pattern.Add("Dragonfly Doji", dragonfly_doji);

            // Gravestone doji pattern: Doji with long upper tail
            bool gravestone_doji = doji && (topTail > range * 0.66m);
            Dictionary_Pattern.Add("Gravestone Doji", gravestone_doji);
        }


    }
}
