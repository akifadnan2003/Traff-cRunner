Got it! Let's update the README to include the task division between Akif Adnan and Sariea Almoughrabi. Here's an updated version:

---

# Unity Car Game

## Description
This Unity project is a 2D car game where the player controls a car to avoid obstacles and enemies while collecting power-ups and reaching checkpoints. The game features enemy collisions, health management, and a game over/finish line system with TextMeshPro for UI elements.

## Table of Contents
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [Contributing](#contributing)
- [License](#license)
- [Task Division](#task-division)

## Installation
1. **Clone the repository:**
   ```bash
   git clone https://github.com/akifadnan2003/Traff-cRunner.git
   ```
2. **Navigate to the project directory:**
   ```bash
   cd Traff-cRunner
   ```
3. **Open the project in Unity:**
   - Launch Unity Hub.
   - Add the project to Unity Hub by selecting the directory.
   - Open the project in Unity.

## Usage
1. **Run the game:**
   - Press the **Play** button in the Unity Editor to start the game.

2. **Player Controls:**
   - Use the arrow keys or WASD keys to control the car's movement.

3. **Game Mechanics:**
   - Avoid obstacles and enemies to maintain health.
   - Collect power-ups to gain points.
   - Reach checkpoints to progress in the game.

## Features
- **Collision Detection:** Player car collides with enemies and obstacles, reducing health.
- **Health Management:** Player health decreases upon collision, leading to game over if health reaches zero.
- **Game Over and Finish Line:** Displays appropriate messages using TextMeshPro when the player collides or finishes the race.
- **Enemy Movement:** Enemies move downward continuously and reset to the top when off-screen.
- **Track Movement:** Tracks move downward to give the illusion of forward movement.

## Task Division
### Akif Adnan - 20360859106
- **PlayerController Script:**
  - Implement and maintain the player's movement logic.
  - Handle player collisions with obstacles and enemies.
  - Manage player health and trigger game over conditions.
  - Display game over messages using TextMeshPro.
- **Track Movement:**
  - Develop and manage the logic to move the track objects downward.
  - Ensure seamless looping of track pieces.
- **UI Integration:**
  - Integrate TextMeshPro for displaying messages.
  - Set up the `gameOverText` UI element and ensure it updates correctly.

### Sariea Almoughrabi - 21392380222
- **EnemyManager Script:**
  - Implement and manage enemy spawning logic.
  - Handle the destruction of enemies and update enemy count.
  - Stop enemy spawning when the game is over or when the player reaches the finish line.
- **FinishLine Script:**
  - Develop the logic for detecting when the player crosses the finish line.
  - Display the game finished message using TextMeshPro.
- **Power-Ups and Checkpoints:**
  - Implement the logic for power-ups and checkpoints.
  - Manage triggers for collecting power-ups and reaching checkpoints.
  - Update player points upon collecting power-ups.

## Contributing
Contributions are welcome! If you have any suggestions or find any issues, please open an issue or submit a pull request.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Feel free to copy and paste this updated README content into your `README.md` file. Let me know if there's anything else you need help with! 😊