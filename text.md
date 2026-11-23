Objective: Create your first working version of Project Wildlands.

Your program should:

1. Display the game title.
2. Welcome the user to the wilderness research program.
3. Ask the player to enter their explorer name.
4. Store the name in a variable.
5. Display a personalized greeting using the entered name.
6. Ask the player whether they are ready to begin exploring.
   Concepts to practice: Console.WriteLine, Console.ReadLine, string variables, string interpolation, and basic conditionals.

Example behavior
=== PROJECT WILDLANDS ===

Welcome to the Wilderness Research Program.

Enter your explorer name: Alex

Welcome, Explorer Alex!

Are you ready to begin your adventure?
[Y] Yes
[N] No

Your selection: Y

Your adventure begins!

Success condition: You can run the application, enter a name, and get the correct response based on your choice without the application crashing.

## Extra credit: Handle unexpected answers such as "maybe" or an empty response.

Objective: Expand Project Wildlands by creating an interactive main menu that allows the player to navigate between different game features.

Your program should:

1. Display the main menu after the player completes registration and selects "Y" to begin their adventure.
2. Display four menu options:
   - [1] Explore Wilderness
   - [2] Research Journal
   - [3] Inventory
   - [4] Exit Game
3. Ask the player to select an option by entering a number between 1 and 4.
4. Store the player's selection in a variable.
5. Use conditional logic to determine which option the player selected.
6. Display a unique placeholder message for each option.
7. Return the player to the main menu after selecting options 1, 2, or 3.
8. Continue displaying the main menu until the player selects option 4.
9. Handle invalid selections without crashing or closing the application.
   Concepts to practice: Console.WriteLine, Console.ReadLine, strings, variables, if/else, switch, comparison operators, while loops, and do...while loops.

Concepts you're allowed to use: Variables, strings, conditionals, loops, comparison and logical operators, string methods such as Trim(), and basic console input/output. No classes, collections, or advanced C# concepts are required.

Example behavior
=== PROJECT WILDLANDS ===

Welcome, Explorer Alex!

===== MAIN MENU =====

[1] Explore Wilderness
[2] Research Journal
[3] Inventory
[4] Exit Game

Enter your choice: 1

You venture into the wilderness...

===== MAIN MENU =====

[1] Explore Wilderness
[2] Research Journal
[3] Inventory
[4] Exit Game

Enter your choice: 2

Opening your research journal...

===== MAIN MENU =====

[1] Explore Wilderness
[2] Research Journal
[3] Inventory
[4] Exit Game

Enter your choice: 7

Invalid selection. Please enter a number between 1 and 4.

===== MAIN MENU =====

[1] Explore Wilderness
[2] Research Journal
[3] Inventory
[4] Exit Game

Enter your choice: 4

Thank you for playing Project Wildlands!

Success condition: The player can navigate between all four menu options, receive the appropriate response for each selection, and return to the main menu automatically until they choose to exit. Invalid input must not crash the program.
Extra credit: Display the explorer's name in the main menu, handle selections with extra whitespace, and add an exit confirmation that allows the player to return to the menu.
