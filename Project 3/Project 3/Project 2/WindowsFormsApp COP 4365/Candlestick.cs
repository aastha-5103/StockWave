using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_COP_4365
{
    /// <summary>
    /// Represents a candlestick, typically used in financial charting for stocks, forex, and other trading data.
    /// </summary>
    public class Candlestick
    {
        // Properties for the candlestick 
        public decimal open { get; set; }  // Opening price
        public decimal high { get; set; }  // Highest price
        public decimal low { get; set; }   // Lowest price
        public decimal close { get; set; } // Closing price
        public ulong volume { get; set; }  // Trading volume for particular session
        public DateTime date { get; set; } // Date

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
            // Seperators for the string
            char[] separators = new char[] { ',', ' ', '"' };

            // Splitting the string using the seperators
            string[] subs = rowOfData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Parse the date using "dd-MM-yyyy" format
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

            // Variable for unassigned variables
            ulong tempVolume;

            // Assign to volume
            if (ulong.TryParse(subs[5], out tempVolume)) volume = tempVolume;
        }
    }
}
