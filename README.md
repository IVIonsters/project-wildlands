# Project Wildlands

A beginner-friendly C# console project about exploring a wilderness, encountering original creatures, and recording discoveries. It is designed to grow into a small text-based RPG as new C# concepts are learned.

The focus is on building a finished project one small milestone at a time—not starting with a game engine or complex systems. The exploration-and-collection idea takes broad inspiration from creature-discovery games; Project Wildlands is an independent learning project and is not affiliated with or endorsed by any game publisher.

## Current status

The project is at its initial setup stage. The current program prints a welcome message. The first challenge is to add explorer registration and a readiness choice; the later game features below are planned, not implemented yet.

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

1. **Project setup and welcome screen** — Display the title, ask for the explorer's name, and show a personalized greeting.
2. **Main menu** — Add a loop and choices for exploring, viewing the journal or inventory, and exiting.
3. **First creature** — Represent a creature with a class and basic data.
4. **Wild encounters** — Use collections and randomness to generate encounters.
5. **Capture system** — Add a basic capture decision and outcome.
6. **Research journal** — Record and display discovered creatures.
7. **Player resources and progression** — Track resources and simple progress.
8. **Save research** — Persist progress to files.

### First challenge: Explorer Registration

The first playable step is to:

1. Display the Project Wildlands title and welcome message.
2. Ask for and store the explorer's name.
3. Greet the explorer by name.
4. Ask whether they are ready to begin.
5. Respond to their choice without crashing on unexpected or empty input.

Concepts: `Console.WriteLine`, `Console.ReadLine`, strings, string interpolation, and basic conditionals.

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
