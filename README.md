# Flappy Bird - Unity

A 2D Flappy Bird-inspired game developed with **Unity** and **C#** as part of an academic project.

The goal of the project was to recreate the core mechanics of Flappy Bird while learning the fundamentals of 2D game development with Unity.

## Gameplay

<p align="center">
  <img src="docs/flappy-bird-gameplay.gif" alt="Flappy Bird gameplay" width="320">
</p>

## Features

- Bird movement controlled with the spacebar
- Automatic pipe spawning
- Randomized pipe height and gap positioning
- Score system
- Collision detection
- Game Over system
- Restart system
- Progressive difficulty
- Sound effects for jumps, scoring and collisions
- Random day/night background
- Random bird color
- Pipes turn red once the score reaches 25

## Controls

| Key | Action |
| --- | --- |
| `Space` | Make the bird jump |
| `R` | Restart the game after Game Over |

## Requirements

- Unity Hub
- Tested with Unity **6000.5.10f1**

## Technologies

- Unity
- C#
- Unity Input System
- Rigidbody2D and 2D Physics
- TextMesh Pro

## Project Structure

```text
Assets/
├── Animations/
├── Audios/
├── Prefabs/
├── Scenes/
├── Scripts/
├── Sprites/
└── TextMesh Pro/

Packages/
ProjectSettings/
```

The main game logic is located in:

```text
Assets/Scripts/
```

## Main Scripts

### `BirdController.cs`

Handles:

- Bird movement
- Jump input
- Collision detection
- Score detection

### `GameManager.cs`

Handles:

- Score management
- Game Over
- Game restart
- User interface
- Sound effects

### `PipeSpawner.cs`

Handles:

- Pipe generation
- Random pipe positioning
- Difficulty progression

### `PipeMover.cs`

Handles:

- Pipe movement
- Pipe speed

### `BirdColor.cs`

Handles the random appearance of the bird.

### `BackgroundRandomizer.cs`

Randomly selects the game background.

## Run the Project

### 1. Clone the repository

```bash
git clone https://github.com/myriamHAJI/flappy_bird_unity.git
```

### 2. Open the project

Open **Unity Hub** and select:

```text
Add project from disk
```

Then select the cloned `flappy_bird_unity` folder.

### 3. Open the Unity scene

Open:

```text
Assets/Scenes/SampleScene.unity
```

### 4. Start the game

Press the **Play** button in Unity.

Use the **Spacebar** to control the bird.

## Project Context

This project was created as part of an academic assignment focused on learning the fundamentals of game development with Unity.

It allowed me to work with:

- 2D physics
- C# scripting
- Collision management
- Object spawning
- Game state management
- UI and score management
- Audio integration
- Progressive game difficulty

## License

This project does not currently include an open-source license.

## Author

**Myriam Haji**
