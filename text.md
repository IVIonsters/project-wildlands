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

---

Objective: Create your first custom C# class to represent a wild creature in Project Wildlands. Each creature should have its own name, type, level, and capture difficulty.

Your program should:

1. Create a new C# file named Creature.cs in your project.
2. Inside that file, create a class named Creature.
3. Give the Creature class four attributes:
   - Name: The creature's name (string).
   - Type: The creature's elemental type, such as Fire, Water, or Grass (string).
   - Level: The creature's current level (integer).
   - CaptureDifficulty: A number between 1 and 10 representing how difficult the creature is to capture (integer).
4. Use public fields or properties to store these attributes.
5. In Program.cs, create your first Creature object and assign values to all four attributes.
6. Create at least two additional Creature objects with different names and attributes.
7. Modify the Explore Wilderness option in your existing main menu to display information about your creatures.
8. Display each creature's name, type, level, and capture difficulty in a readable format.
9. Ensure the player can return to the main menu after viewing the creatures.
   Concepts to practice: Classes, objects, fields, properties, data types (string, int), object instantiation using new, member access using ., variables, and Console.WriteLine.

Concepts you're allowed to use:

- Classes: Create a reusable blueprint for creatures.
- Objects: Create individual instances of your Creature class.
- Fields or properties: Store each creature's attributes.
- Data types: Use string and int to represent creature information.
- Object instantiation: Use the new keyword to create creature objects.
- Member access: Use the . operator to assign and retrieve attribute values.
- Conditionals and loops: Continue using your existing menu system.
- String interpolation: Display creature information using $"...".
- Console input/output: Display creature details and interact with the player.
  You do not need constructors, inheritance, interfaces, collections, or advanced OOP concepts for this challenge.

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

===== WILD CREATURES =====

Creature #1
Name: Emberfox
Type: Fire
Level: 5
Capture Difficulty: 3/10

---

Creature #2
Name: Mossling
Type: Grass
Level: 3
Capture Difficulty: 2/10

---

Creature #3
Name: Aquafin
Type: Water
Level: 7
Capture Difficulty: 5/10

---

Returning to main menu...

===== MAIN MENU =====

[1] Explore Wilderness
[2] Research Journal
[3] Inventory
[4] Exit Game

Enter your choice: \_

Success condition: You can create three different Creature objects using your custom class, assign unique attributes to each creature, and display their information through the Explore Wilderness menu option. After displaying the creatures, the program must return to the main menu without crashing.
Extra credit: Add a fifth attribute called Description to each creature. Display a unique description beneath its information. Then experiment with changing a creature's level after creating it and verify that the displayed value updates correctly.
