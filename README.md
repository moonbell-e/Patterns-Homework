# Game Architecture Patterns Course - Homework

This repository contains my solutions for the homework assignments from the Game Architecture Patterns course. The assignments explore various design patterns commonly used in game development.

## Overview

This project demonstrates the application of various design patterns in the context of game development. The assignments cover a range of common game development scenarios, such as AI behavior, enemy spawning, character customization, UI management and game mechanics. The goal was to gain practical experience with these patterns and understand their benefits in terms of code organization, maintainability and extensibility.

## Patterns Implemented

*   **Abstract Factory:** Used for dynamic enemy spawning, allowing the creation of different enemy types (Orcs and Elves) at runtime.
*   **Factory Method:**  Used within the Abstract Factory to create specific enemy variations (e.g., Orc Paladin, Elf Mage).
*   **Strategy:** Implemented a weapon system where different weapon types have distinct firing behaviors, providing flexibility and easy extension.
*   **Template Method:**  Applied to an NPC Trader, defining a base trading process that can be customized for different trading scenarios (e.g., armor trading, fruit trading).
*   **State:** Used extensively for managing AI behavior (NPCs transitioning between working, resting, and moving), player movement (walking, running, sprinting) and NPC trading states.
*   **Mediator:** Facilitated communication between different parts of the game, such as updating the UI when the player levels up or receives damage and displaying the win screen in the mini-game.
*   **Visitor:** Employed for controlling enemy spawning based on the total weight of spawned enemies.
*   **Decorator:** Enabled dynamic modification of character stats through race, class and passive ability modifiers.
*   **Dependency Injection:** Applied in the Mediator example to decouple components and improve testability.
