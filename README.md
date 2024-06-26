# Ping

### Simple 3D Ping Pong Game

## Overview
Ping is a basic 3D ping pong game developed using Unity. The game simulates a ping pong match where the player controls paddles to hit a ball back and forth. The game's simplicity is enhanced by its minimalistic design, using basic geometric shapes and colors.

## Game Description
In Ping, the player interacts with the game environment using keyboard controls to move the paddles. The objective is to keep the ball in play for as long as possible, reflecting the ball's position and movement dynamics.

## Controls
- Move left paddle up: W key
- Move left paddle down: S key
- Move right paddle up: Up Arrow key
- Move right paddle down: Down Arrow key

## Project Structure
The project is organized into several directories and files, each serving a specific purpose in the game's development:

### Core Scripts
The core functionality of Ping is implemented through several C# scripts, each managing different aspects of the game. Below is an overview of the key scripts and how they connect to form the game's structure.

#### GameBuilder.cs
The `GameBuilder` script is responsible for setting up the main game elements when the game starts. It initializes the main camera, directional light, paddles, ball, and floor, and assigns basic materials and properties to these objects.

- **Key Responsibilities:**
  - Setting up the main camera with specified position, rotation, and field of view.
  - Creating and positioning the directional light to illuminate the game scene.
  - Initializing the left and right paddles, ball, and floor using Unity's primitive shapes.
  - Assigning materials and colors to game objects using the `HexColor` utility.

#### HexColor.cs
The `HexColor` script provides utility functions to convert hexadecimal color codes into Unity's `Color` objects. This script is used in `GameBuilder` to assign colors to various game elements.

- **Key Responsibilities:**
  - Converting hexadecimal color strings to `Color` objects.
  - Providing helper functions to handle hexadecimal string manipulations.

### ProjectSettings
This directory holds various configuration files that define project-wide settings, such as input management, audio settings, graphics settings, and quality settings.

### Packages
Contains the manifest file for managing project dependencies and Unity packages.

## Key Features
- **Minimalist Design:** The game features a simple, clean design using basic geometric shapes and colors, making it easy to understand and play.
- **Basic Gameplay Mechanics:** Simple controls and straightforward gameplay mechanics provide an accessible gaming experience for players of all ages.
- **Utility Functions:** The `HexColor` script offers a convenient way to handle color assignments using hexadecimal values, streamlining the development process.

## How to Run the Game
1. Clone the repository to your local machine.
2. Open the project in Unity.
3. Load the main scene from the `Assets/Main.unity` file.
4. Press the Play button in Unity to start the game.

## Future Improvements
- Adding more sophisticated gameplay mechanics, such as scoring and AI-controlled paddles.
- Implementing sound effects and background music to enhance the gaming experience.
- Enhancing the visual effects and animations for a more polished look.

Ping demonstrates a basic yet effective approach to game development, focusing on essential gameplay elements and a minimalist design. Enjoy playing this simple 3D ping pong game!
