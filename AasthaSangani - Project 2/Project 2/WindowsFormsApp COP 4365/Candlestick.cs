using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_2
{
    /// <summary>
    /// Represents a candlestick, typically used in financial charting for stocks, forex, and other trading data.
    /// </summary>
    public class Candlestick
    {
        // Properties representing the candlestick data with getter and setter
        public decimal open { get; set; }  // Opening price of the candlestick
        public decimal high { get; set; }  // Highest price of the candlestick
        public decimal low { get; set; }   // Lowest price of the candlestick
        public decimal close { get; set; } // Closing price of the candlestick
        public ulong volume { get; set; }  // Trading volume during the candlestick period
        public DateTime date { get; set; } // Date of the candlestick

        /// <summary>
        /// Default constructor. Initializes a new instance of the Candlestick class with default values.
        /// </summary>
        public Candlestick()
        {
        }

        /// <summary>
        /// Constructor that parses a string of data to initialize the Candlestick properties.
        /// </summary>
        /// <param name="rowOfData">A single line of data, with values separated by commas, spaces, or quotes.</param>
        public Candlestick(string rowOfData)
        {
            // Define separators for splitting the input string
            char[] separators = new char[] { ',', ' ', '"' };

            // Split the input string into an array of substrings
            string[] subs = rowOfData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Parse the date using a custom format "dd-MM-yyyy"
            date = DateTime.ParseExact(subs[0], "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

            // Temporary variable for parsing decimal values
            decimal temp;

            // Parse and assign the 'open' price
            if (decimal.TryParse(subs[1], out temp)) open = temp;

            // Parse and assign the 'high' price
            if (decimal.TryParse(subs[2], out temp)) high = temp;

            // Parse and assign the 'low' price
            if (decimal.TryParse(subs[3], out temp)) low = temp;

            // Parse and assign the 'close' price
            if (decimal.TryParse(subs[4], out temp)) close = temp;

            // Temporary variable for parsing unsigned long values (volume)
            ulong tempVolume;

            // Parse and assign the 'volume'
            if (ulong.TryParse(subs[5], out tempVolume)) volume = tempVolume;
        }
    }
}
