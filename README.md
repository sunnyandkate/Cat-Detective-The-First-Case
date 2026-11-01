#  Cat Detective: The First Case (Unity / C#)

A simplified, real-time 2D deduction game inspired by the mechanics of classic mystery board games. Players take control of a cat detective walking around an open environment to gather clues, explore suspects and solve a randomized mystery case.

##  Game Concept & Mechanics
* **Top-Down Exploration:** Control the cat detective to navigate a layout and investigate interactive nodes to gather evidence.
* **Backend Randomization:** Every new case dynamically shuffles and selects a randomized correct combination of suspect, weapon, and house location in the backend logic.
* **State Machine & Progression:** Players must collect and cross-reference all three elements correctly. If a guess is incorrect, the collected items disappear from the player inventory, resetting the check state until the exact combination is cracked.

##  Technical Implementation
* **Dynamic Reset States:** Programmed conditional rule systems in C# to manage inventory states and clear asset arrays upon incorrect deductions.
* **Asset Creation:** Handcrafted all custom 2D pixel art elements, user menus, and interactive environment sprites inside Aseprite to ensure a charming, cozy visual aesthetic.
* **UI Feedback Loops:** Set up responsive user feedback screens and prompt layouts in Unity to guide the player through the investigation.




Link: https://sunnyandkate.github.io/games/CatDetective/