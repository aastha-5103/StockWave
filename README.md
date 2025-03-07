# StockWave: A Windows-Based Stock Analysis & Prediction Tool  

## **Introduction**  

Financial markets are unpredictable, yet patterns often emerge when analyzing stock price movements. **StockWave** is a **Windows Forms application built in C#** that evolves across three projects, gradually integrating **data visualization, technical analysis, and predictive modeling**.  

At its core, **StockWave** provides an interactive platform for users to analyze stock market trends using **candlestick charts, pattern recognition, Fibonacci retracement levels, and a unique "Beauty" function** to evaluate potential future price movements.  

This project follows a structured learning path where each phase builds upon the last, **culminating in a sophisticated stock analysis tool that provides deeper insights into market trends**. Whether you are a student, developer, or finance enthusiast, **StockWave** bridges the gap between programming and financial analysis, making complex market predictions more accessible and interactive.  

---

## **Project Breakdown & Evolution**  

### **Project 1: Visualizing Stock Data**  
The foundation of StockWave begins with **loading and displaying stock data** in a structured format.  

✅ Loads **historical stock data** from **CSV files** (downloaded from Yahoo Finance).  
✅ Displays **candlestick charts**, a widely used method to visualize price movements.  
✅ Users can **select stocks, date ranges, and timeframes (Daily, Weekly, Monthly)**.  
✅ Volume bars provide additional insight into market activity.  

🔹 **Outcome:** At the end of this phase, we have a **basic stock charting application** that allows users to load and view stock trends over time.  

---

### **Project 2: Pattern Recognition & Multi-Stock Analysis**  
Building upon Project 1, StockWave enhances the user experience by introducing **pattern recognition and multi-stock support**.  

✅ Introduces **SmartCandlestick**, a custom class that categorizes each candlestick into key patterns:  
   - **Bullish, Bearish, Doji, Hammer, Marubozu, and more.**  
✅ Enables **peak and valley detection**, marking key turning points in stock trends.  
✅ Supports **multiple stock charts**—users can load and analyze different stocks simultaneously.  
✅ Removes **DataGridView**, shifting focus entirely to chart-based analysis.  
✅ Normalizes the chart for seamless visualization, eliminating unnecessary gaps (e.g., weekends and holidays).  

🔹 **Outcome:** At this stage, we move beyond raw visualization to **identifying key price movement patterns**, helping users understand trends in market behavior.  

---

### **Project 3: Fibonacci-Based Market Prediction**  
The final stage of StockWave takes stock analysis to a predictive level, **leveraging Fibonacci retracements and the Beauty function** to assess potential future highs and lows.  

✅ **Wave Selection & Validation**  
   - Users **define valid stock waves** by selecting key price points (peaks and valleys).  
   - Ensures **only logical and meaningful waves are analyzed**.  

✅ **Fibonacci Retracement Levels**  
   - Automatically computes **Fibonacci levels** (0%, 23.6%, 38.2%, 50%, 62.8%, 76.4%, 100%).  
   - Overlays these levels on the stock chart for easy reference.  
   - Helps identify **potential support and resistance levels** in price movements.  

✅ **Beauty Function** (Custom Predictive Metric)  
   - Measures how well a wave’s price movements **"confirm" Fibonacci levels**.  
   - Assigns **Beauty scores** to candlesticks based on Fibonacci confirmations.  
   - The **higher the Beauty score, the more likely a price level holds significance**.  

✅ **Beauty vs. Price Chart**  
   - Extends the wave beyond the selected range to see how Beauty scores evolve.  
   - Provides **insight into where price movements might stabilize** or reverse.  
   - Offers a graphical way to **observe correlations between Fibonacci alignments and future price shifts**.  

🔹 **Outcome:** With Fibonacci and Beauty analysis, StockWave becomes a **predictive tool**, helping users make **data-driven decisions about future stock movements**.  

---

## **What We Have Achieved**  

After completing all three projects, we have developed a **comprehensive stock analysis tool that allows users to:**

🔹 **Visualize** stock price movements using **candlestick charts**.  
🔹 **Detect** important price patterns such as peaks, valleys, and key candlestick formations.  
🔹 **Analyze** stock waves and Fibonacci retracement levels to identify potential **support and resistance zones**.  
🔹 **Evaluate** the significance of price points using a **custom "Beauty" metric**, which **highlights areas where price is likely to react**.  
🔹 **Predict** potential market trends based on historical patterns, Fibonacci relationships, and statistical confirmations.  

Ultimately, **StockWave transforms stock market analysis from raw data interpretation into a structured, visual, and interactive experience**, making it easier to spot key trends and patterns in financial data.

---

## **Why StockWave Matters**  

🚀 **Bridges Finance & Technology** – A practical example of how programming can be applied to financial markets.  
📊 **Enhances Data-Driven Decisions** – Provides an **interactive and statistical approach** to stock analysis.  
🔍 **Hands-On Learning** – A great tool for students, traders, and developers **interested in stock analysis and predictive modeling**.  
🖥 **Real-World Application** – Uses the same **charting techniques** that traders, analysts, and hedge funds use in financial markets.  

Whether you are looking to **build a finance-based application, explore predictive analytics, or simply gain a deeper understanding of stock trends**, **StockWave is a practical project that showcases the power of programming in real-world applications**.

---

## **How to Use StockWave**  

1️⃣ **Clone the Repository**  
   ```bash
   git clone https://github.com/aastha-5103/StockWave.git
   ```  
2️⃣ **Open in Visual Studio**  
   - Locate and open the `StockWave.sln` file.  

3️⃣ **Restore Dependencies**  
   - Visual Studio will handle this automatically. If needed, run:  
     ```powershell
     dotnet restore
     ```  
4️⃣ **Build & Run**  
   - Press **F5** or click **Start** in Visual Studio.  

5️⃣ **Load Stock Data & Analyze**  
   - Choose a CSV file with historical stock data (Daily, Weekly, Monthly).  
   - Select price ranges, **identify trends, apply Fibonacci retracements**, and **view Beauty scores**.  

📌 **System Requirements:**  
- Windows OS (10 or 11 recommended).  
- .NET Framework 4.7+ or .NET 5+.  
- Visual Studio 2019 or later.  

---

## **Final Thoughts & Future Enhancements**  

While **StockWave is not a trading platform**, it is a **valuable learning tool** that helps users explore **historical stock movements, key market indicators, and predictive analytics**.  

🔹 **Possible future features:**  
- **Live market data integration** via APIs.  
- **More technical indicators** (e.g., RSI, MACD, Moving Averages).  
- **Enhanced UI** with additional chart customization options.  

StockWave is an **excellent project for developers, finance enthusiasts, and students looking to blend programming and stock market analysis** in a meaningful way.

