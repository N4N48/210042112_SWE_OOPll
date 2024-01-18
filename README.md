# CONWAY'S GAME OF LIFE

## Introduction

Welcome to the mesmerizing world of Conway's Game of Life, where cellular automata and SOLID principles unite! This project brings to life the classic Game of Life with a clean, modular, and maintainable design, thanks to the application of SOLID principles.

### What is Conway's Game of Life?

Conway's Game of Life is a captivating zero-player game that unfolds within a grid of cells. Governed by simple rules, the game's evolution is solely determined by its initial state. Cells live, die, and reproduce, creating intricate patterns that unfold over generations. Despite its simplicity, the Game of Life is a powerful demonstration of emergent complexity.

### Why SOLID Principles?

In the realm of software development, adhering to SOLID principles is akin to crafting a masterpiece. These principles—Single Responsibility, Open/Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion—serve as guiding lights for creating code that is modular, extensible, and easy to maintain.

### Project Highlights:

1. **Modular Design:**
   - Each component of the Game of Life, from grid representation to rule application, is encapsulated in modular classes, adhering to the Single Responsibility Principle.

2. **Extensibility:**
   - Embracing the Open/Closed Principle, the project invites extensibility. The `ExtendedGrid` class and the `GameOfLife` class can gracefully welcome new functionalities without disrupting existing code.

3. **Interchangeable Components:**
   - Liskov Substitution Principle ensures that objects of the `ExtendedGrid` class can seamlessly replace objects of the base `Grid` class, promoting compatibility and flexibility.

4. **Focused Interfaces:**
   - The Interface Segregation Principle guides the creation of focused interfaces (`IDisplay`, `IGrid`, `IRules`), allowing classes to implement only what they need.

5. **Abstraction Dependency:**
   - The Dependency Inversion Principle is embraced, with high-level modules like `GameOfLife` depending on abstractions, facilitating flexibility and reducing coupling.

### Get Started:

Explore the mesmerizing patterns and dynamic evolution of Conway's Game of Life with SOLID principles. Clone this repository and witness the magic unfold in the world of cellular automata.

Let the journey into the Game of Life begin! 🌌🎮
