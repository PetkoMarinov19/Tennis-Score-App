# 🎾 Tennis Score App

**A simple console application written in C#** that simulates a tennis match between two players using real-world scoring rules.  
Built with focus on clean architecture and object-oriented principles.

---

## 📌 Overview

**Tennis Score App** is a terminal-based program that allows two players to compete in a simulated tennis match. The application keeps track of:

- 🎾 Points
- 🧮 Games
- 🧱 Sets
- 🏆 Match Winner

All based on the **official tennis scoring rules**.

---

## 🛠️ Technologies Used

| Tool / Language | Description              |
|------------------|--------------------------|
| C#               | Main programming language |
| .NET 6.0+        | Framework for the app     |
| Console UI       | Input/output via terminal |

---

## 📂 Project Structure

```bash
📁 TennisScoreApp/
├── Player.cs       # Player info & score
├── Game.cs         # Logic for single game
├── Set.cs          # Set tracking
├── Match.cs        # Full match logic
└── Program.cs      # Entry point / User input
