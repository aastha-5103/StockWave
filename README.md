# 📈 StockWave – A Windows-Based Stock Analysis & Prediction Tool

**StockWave** is a Windows Forms application built in C# that blends data visualization, technical analysis, and predictive modeling into one cohesive system. Developed across three iterative phases, it enables users to analyze stock price trends using candlestick charts, pattern recognition, Fibonacci retracement levels, and a custom "Beauty" function to estimate likely future price movements.

Whether you're a developer, student, or finance enthusiast, StockWave bridges the gap between programming and financial analysis through interactive, data-driven insights.

---

## 🔄 Project Evolution

### 🧩 **Project 1: Visualizing Stock Data**
- Loads OHLC stock data (Daily, Weekly, Monthly) from CSV files
- Displays interactive candlestick charts and volume bars using .NET chart controls
- Allows date range selection and period switching
- Applies color coding (green/red) and chart normalization for clarity

> ✅ Outcome: A functioning charting interface to explore stock price movements over time

---

### 🔍 **Project 2: Pattern Recognition & Multi-Stock Analysis**
- Introduces the `SmartCandlestick` class to detect formations: Doji, Hammer, Marubozu, etc.
- Identifies Peaks and Valleys with annotated lines across the chart
- Supports analysis of multiple stocks in parallel chart windows
- Removes DataGridView and normalizes charts to remove gaps (e.g., weekends)

> ✅ Outcome: Moves from basic visualization to intelligent trend recognition and multi-stock support

---

### 📈 **Project 3: Fibonacci-Based Market Prediction**
- Enables wave selection via mouse dragging or candlestick clicks
- Computes Fibonacci retracement levels from user-defined waves
- Implements a "Beauty" function that scores alignment between candlesticks and Fibonacci levels
- Plots Beauty vs. Price to visualize confluence zones and likely reversal points

> ✅ Outcome: Transforms StockWave into a prediction-oriented analysis tool using statistical and visual indicators

---

## 🚀 Key Achievements

- Visualizes historical stock trends using candlestick charting and volume overlays  
- Detects key price action patterns and technical indicators across multiple stocks  
- Analyzes Fibonacci zones and their relevance using a custom-built "Beauty" function  
- Projects potential price reversal zones through interactive Beauty vs. Price graphs

---

## 💡 Why StockWave Matters

- 🔁 **Bridges Finance & Technology** – Combines programming with technical market analysis  
- 📊 **Data-Driven Decisions** – Empowers users with insights beyond raw data  
- 🎓 **Educational Value** – Ideal for developers, students, and aspiring quants  
- 💼 **Real-World Techniques** – Mimics tools used by traders and analysts globally

---

## 🛠️ How to Use

1. **Clone the Repository**
   ```bash
   git clone https://github.com/aastha-5103/StockWave.git
2. **Open in Visual Studio**
- Launch the solution via StockWave.sln

3. **Build & Run**
- Press F5 or click Start

5. **Analyze Stocks**
- Load CSV data via OpenFileDialog
- Select date ranges and stock period (Day/Week/Month)
- Interact with charts, select waves, and visualize predictions

---

## 📌 Requirements

---

- Windows 10/11
- Visual Studio 2019 or later
- .NET Framework 4.7+ or .NET 5+

---

## 🔮 Future Enhancements

---

- Live stock data via APIs (e.g., Yahoo Finance, Alpha Vantage)
- Additional indicators: MACD, RSI, Moving Averages
- Enhanced UI with interactive chart customization
- Exportable reports and data insights
