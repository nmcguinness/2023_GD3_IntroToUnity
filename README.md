# 2023 - GD3 - Intro To Unity

## Overview 
This repository contains Unity samples used to learn core Unity 
elements (events, states, animation, input) for this module.

## Useful 
- [Markdown](https://docs.github.com/en/enterprise-cloud@latest/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax) in GitHub
- Add emojis with [gitmoji](https://gitmoji.dev/) to your Git commits to improve readability

## Recommended Reading
- See Moodle "Getting Started With Unity" topic for core reading
- [Three Ways to Architect Your Game With Scriptableobjects](https://unity.com/how-to/architect-game-code-scriptable-objects)

## Additional Reading 
- [Three Ways to Architect Your Game With Scriptableobjects](https://unity.com/how-to/architect-game-code-scriptable-objects)

## Table of Contents - Examples 
| Topic | Description | Additional Reading |
| :---------------- | :--------------- | :--------------- | 
| Exercise 1 - Scriptable Objects | Sharing variables across multiple game objects using ScriptableObjects (SOs) | See RotationBehaviour and Variables in Common/Scripts/ScriptableObjects |
| Exercise 2 - Selecting Objects  & Design Patterns | Writing a better SelectionManager using Design Patterns (Abstract Factory, Strategy) | See SelectionManager and SimpleSelectionManager |
| Exercise 3 - Advanced Scriptable Objects | Writing an AdvancedSelectionManager capable of multiple responses (configurable using SOs) | AdvancedSelectionManager, [Writing Unity attributes and property drawers](https://www.youtube.com/watch?v=r3nwTGLHygI)

## Table of Contents - Design Patterns 
| Topic | Description | Additional Reading |
| :---------------- | :--------------- | :--------------- | 
| Abstract Factory | Using the Abstract Factory pattern to make interchangeable components | ICollectible, IInteractable, [Abstract Factory](https://refactoring.guru/design-patterns/abstract-factory) |
| Strategy | Using the Strategy pattern to separate interchangeable algorithms into components accessed through a context | SelectionManager, [Strategy](https://refactoring.guru/design-patterns/strategy) |
| Observer | Using the Observer pattern to notify game event subscribers | GameEvent, [Observer](https://refactoring.guru/design-patterns/observer) |
| Singleton | Using the Singleton pattern to prevent more than one entity from being instantiated | TimeTickSystem, InventoryManager, GameManager, [Singleton](https://refactoring.guru/design-patterns/singleton) | 

### To Do - Week 3
- [x] Scriptable Objects - Add a demo to demonstrate a centrally modified game variable

### To Do - Week 4
- [x] Discuss generic classes - see [Intro to C#](https://github.com/nmcguinness/2023_GD3_IntroToCSharp.git)
- [x] Scriptable Objects - Add a local/remote reference variable demo
- [x] Scriptable Objects - Add a framework for interactable, consumable, game, and level data
- [x] Add Editor tools (inspector lock, folder generation)
- [x] Add a SimpleSelectionManager as a starting point to discuss Abstract Factory and Strategy patterns

### To Do - Week 5
- [x] Apply Abstract Factory and Strategy patterns to make an improved SelectionManager
- [x] Use SOs to make an AdvancedSelectionManager
- [x] Add a RequireInterface attribute 
- [ ] Exercise: Modify UIRichTextPrompt to support multi-line output (see Exercise 1: Multi Text Rich Prompt - Using OnGUI)
- [ ] Exercise: Add Singleton pattern demo (see Exercise 2: Simple Inventory - Inventory and Singletons)
- [ ] Explain SerializableDictionary and demonstrate its use in InventoryManager 
- [ ] Explain GameEvent and GameEventListener
- [ ] Add Extensions demo (see Vector3Extensions)   
