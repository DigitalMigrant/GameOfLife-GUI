# 🧬 Game of Life (C#)

Welcome to my implementation of Conway's **Game of Life**, built in C# as a desktop application. This classic cellular automaton simulates how simple rules can lead to surprisingly complex behavior.

## ✨ Features

- Classic ruleset: birth, survival, and death based on neighbors
- Customizable grid size and tick speed
- Start, pause, clear, and randomize buttons
- Step-by-step simulation or automatic run
- Minimalist UI using Windows Forms

## 🚀 Getting Started

### Requirements

- .NET Framework 4.7.2 or later *(or adjust based on your setup)*
- Windows OS *(for the executable build)*

### Running from Source

1. Clone this repository:
   ```bash
   git clone https://github.com/DigitalMigrant/GameOfLife-GUI.git

2. Open the solution (GameOfLife.sln) in Visual Studio
3. Build and run the project

### Or, run the .exe directly:
If you'd rather not build the code:
- Download the latest release from Releases
- Unzip and launch GameOfLife.exe
  
⚠️ Always scan downloaded binaries before running. Trust your own code only!

## 🖼️Screenshots


## 🧠How It Works
Each cell is either alive or dead, and updates based on its eight neighbors.

### Sample Code
```csharp
// Count live neighbors
int liveCount = 0;
foreach (var neighbor in neighbors)
{
    if (neighbor.IsAlive) liveCount++;
}

// Apply Game of Life rules
if (cell.IsAlive && (liveCount < 2 || liveCount > 3))
    cell.Die();
else if (!cell.IsAlive && liveCount == 3)
    cell.Revive();
```
  
    
## 📚 Resources
- Wikipedia – Conway’s Game of Life
- GitHub Repo Overview
  
## 📝 License
This project is licensed under the [CC BY-NC-SA 4.0.](https://github.com/DigitalMigrant/GameOfLife-GUI/blob/main/LICENSE)  
Feel free to fork, adapt, and explore.


#### *“Life is not a problem to be solved, but a reality to be experienced.”* — *Kierkegaard*

