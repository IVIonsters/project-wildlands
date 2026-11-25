![Project Wildlands logo](<Project Wildlands_ Teal Mountain Crest.png>)

# Project Wildlands

A beginner-friendly C# console project about exploring a wilderness, encountering original creatures, and recording discoveries. It is designed to grow into a small text-based RPG as new C# concepts are learned.

The focus is on building a finished project one small milestone at a time—not starting with a game engine or complex systems. The exploration-and-collection idea takes broad inspiration from creature-discovery games; Project Wildlands is an independent learning project and is not affiliated with or endorsed by any game publisher.

## Table of Contents

- [Current status](#current-status)
- [Technologies Used](#technologies-used)
- [Getting started](#getting-started)
- [Learning goals](#learning-goals)
- [Stage 1 roadmap](#stage-1-roadmap)
  - [Next challenge](#next-challenge)
- [Possible release milestones](#possible-release-milestones)
- [Learning approach](#learning-approach)
- [Future directions](#future-directions)
- [License](#license)

## Current status

The project is a playable console prototype. It displays the title, asks for a non-empty explorer name, validates the explorer's Y/N readiness choice, and shows a repeating main menu when the explorer is ready. The Explore Wilderness option randomly selects and displays one of five creatures, including its type, level, capture difficulty, and description. Each exploration can generate another encounter, and the menu continues until the player exits. The Research Journal and Inventory options still show placeholder messages. Invalid menu choices are reported without ending the program, and surrounding whitespace is ignored.

The creature collection and random encounter system are implemented. Capture mechanics, a functional research journal and inventory, player progression, and saving progress remain future work.

## Technologies Used

[![C#](https://img.shields.io/badge/C%23-68217A?style=for-the-badge&logo=dotnet&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)

- **C#** — The programming language used to build the game.
- **.NET 10** — The target framework used to run the application.

## Getting started

You need the .NET 10 SDK. From the repository root, run:

```bash
dotnet run --project ProjectWildlands/ProjectWildlands.csproj
```

## Learning goals

This project practices C# fundamentals as they are introduced:

- Variables, data types, operators, and strings
- User input, conditionals, and switch statements
- Loops, arrays, and `List<T>`
- Methods, classes, objects, and enums
- Randomized encounters and basic game decisions
- File handling for a later save/load challenge

The initial scope intentionally avoids LINQ, async programming, databases, APIs, dependency injection, game engines, advanced inheritance, and complex design patterns.

## Stage 1 roadmap

These are milestones for one evolving application, not separate projects.

1. **Explorer registration** — Display the title, ask for the explorer's name, show a personalized greeting, and ask whether they are ready. **Complete.**
2. **Main menu** — Add a loop and choices for exploring, viewing the journal or inventory, and exiting. **Complete with placeholder responses.**
3. **First creature** — Represent creatures with a class and basic data. **Complete.**
4. **Wild encounters** — Store creatures in a collection and use randomness to generate encounters. **Complete with five creatures.**
5. **Capture system** — Add a basic capture decision and outcome. **Next challenge.**
6. **Research journal** — Record and display discovered creatures.
7. **Player resources and progression** — Track resources and simple progress.
8. **Save research** — Persist progress to files.

### Next challenge

The next roadmap milestone is the **Capture System**: let the player respond to a wild encounter and determine whether they capture the creature.

## Possible release milestones

| Version | Goal |
| --- | --- |
| `v0.1` | Welcome screen and working menu |
| `v0.2` | Creatures and random encounters |
| `v0.3` | Capture mechanics |
| `v0.4` | Research journal |
| `v0.5` | Player progression and resources |
| `v1.0` | Save/load and a polished playable console game |

## Learning approach

This is a portfolio and learning project. Implement each challenge using the concepts already covered, test it, and commit meaningful progress. When using help or documentation, focus on understanding specific concepts and methods rather than copying a complete implementation.

## Future directions

After Stage 1, the project could grow to include turn-based encounters and more advanced object-oriented design, then potentially move to a visual C#-compatible game engine. Persistent data and more sophisticated systems can come later as those topics are learned.

## License

This project is licensed under the [MIT License](LICENSE).

---

Made with &lt;3 by Zachary
