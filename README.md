# Unity Stat System

## Overview

This repository contains the work I did to implement a **stat system** for a game in Unity. Throughout the process, I developed systems for player stats, save functionality, user interfaces, and various gameplay features like health bars, damage calculations, and level progression. I also delved into Unity’s UI Toolkit, UI Builder, and GraphView API to create custom editor windows, HUDs, and other visual elements. Here’s an overview of what I’ve learned and implemented in this project.

## Features Implemented

### Stat System

I created a flexible stat system for characters, allowing for attributes like health, attack, defense, and magic to be defined and modified dynamically. I used mathematical formulas to adjust these values, and stats were linked to the player's level, allowing for the stat progression system to scale with leveling up. The system also accounts for player base stats and stat modifiers, which are influenced by items, buffs, and debuffs.

### Save System

I developed a **save system** to ensure that the player's progress is retained across game sessions. This system serializes player data, including stats, inventory, and level, and stores it in a file. The save system integrates with the stat system, so stat values are preserved even after the game is closed and reopened.

### Leveling System

The **level system** works alongside the stat system, increasing the player’s stats as they level up. I set a maximum health increase for each level, and other stats (like attack and defense) scale based on the player's level. The level system also includes a progress bar to visually represent how close the player is to leveling up.

### Health & Damage System

I implemented a **health bar** using Unity’s built-in UI system, which updates dynamically as the player takes damage. The **damage system** differentiates between physical and magical attacks, calculating damage based on the character’s stats (attack, defense, etc.) and includes a chance for **critical hits**. Additionally, I incorporated a system to display the damage taken by a character in the UI.

### UI Toolkit & UI Builder

I utilized **Unity’s UI Toolkit** and **UI Builder** to create various user interfaces for the game. I built custom **editor windows** to make stat management and level tracking easier within the Unity Editor. I also designed a **Heads Up Display (HUD)** that shows important information such as health, mana, and other stat values during gameplay.

### Animation System

To make gameplay more dynamic, I implemented a feature that modifies the speed of character animations based on certain stats. For example, a character’s **speed stat** influences how fast their movement and attack animations play.

### Custom Editor Window

I learned how to create a **custom editor window** using the UI Builder and Unity's Editor API. This allows for easy management of player stats and other game data within the editor. The window lets me quickly update stat values, track leveling progress, and see live stats without needing to play the game.

### C# Assembly Definitions

I implemented **C# Assembly Definitions** to organize the project’s code into modular assemblies. This helped me manage dependencies and optimize compilation times, especially as the project grew in size.

### Play Mode Tests

To ensure everything worked as expected, I wrote **Play Mode tests** using Unity's testing framework. These tests verified that the stat system, damage calculations, and save system function correctly and maintain their integrity throughout development.

### GraphView API

I explored and utilized Unity’s **GraphView API** to build visual editors that represent relationships between stats, leveling, and gameplay mechanics. This allowed me to create more intuitive ways of interacting with the underlying systems.

## Key Concepts Learned

- **Stat Values as Functions:** I learned how to make stat values dynamic, such that they are functions of other variables (such as level or item modifiers). This allowed for more complex systems that can scale over time.
- **Critical Hits & Damage Types:** The damage system I implemented considers multiple factors like critical hits, different damage types (physical/magical), and defensive stats (e.g., armor or magic resistance). I now have a better understanding of how to create more nuanced combat systems.

- **UI Toolkit & UI Builder:** I had to familiarize myself with Unity’s UI Toolkit and UI Builder to create interfaces that are both functional and visually appealing. These tools are powerful for building complex user interfaces without the need for third-party libraries.

- **Editor Customization:** Through custom editor windows and using the GraphView API, I was able to streamline my workflow and make it easier to manage the game’s systems. The ability to build tools that interact directly with the Unity Editor is something I greatly improved upon.

- **Leveling & Progression Systems:** Creating a **leveling system** that also influences stats taught me how to design progression systems that feel rewarding to players. Balancing stat growth with difficulty scaling is an important skill I developed throughout this process.

- **Save System Integration:** I learned how to integrate a save system into a game that works seamlessly with other gameplay mechanics, ensuring that data persists even after the game is closed and reopened.

## Future Improvements

- **Expanded Stat System:** The stat system could be expanded to include more attributes such as agility, luck, and magic resistance, which would open up further gameplay options.
- **More Complex Damage System:** Adding more complexity to the damage system, such as elemental effects or status conditions (poison, burn, etc.), would increase the depth of combat.

- **UI Enhancements:** Although the current UI is functional, I’d like to improve its visual design, adding animations and transitions to make the experience more polished.

## Requirements

- Unity 2023.x or newer
- C# 9.0 or newer
- .NET Core 3.1 or newer (for testing)
- Unity UI Toolkit package

## Installation

1. Clone the repository to your local machine.
2. Open the project in Unity.
3. Ensure you have the required packages for **UI Toolkit**, **UI Builder**, and **GraphView**.
4. You’re ready to go! Use the custom editor window to modify stats and test features.

## License

This repository is licensed under the MIT License. Feel free to use and modify the code for personal or commercial projects.

---

Thanks for checking out my stat system project! Feel free to fork or submit issues if you find any bugs or have suggestions for improvements.
