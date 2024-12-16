# **Shadow Slayer**

Shadow Slayer is an action-packed stealth game inspired by the popular mobile game **Hunter Assassin**, featuring advanced **State Machines** to manage dynamic enemy AI. Players face unique enemy behaviors and strategies, making for an immersive and challenging experience.

This project demonstrates the power of the **State Design Pattern** and **State Machines** in implementing scalable and dynamic enemy AI. Enemies exhibit a variety of behaviors, such as patrolling, chasing, shooting, and teleporting, which adapt based on game events like player actions.

---

## **Features**

- **State Machines for Enemy AI**:
  - Enemies dynamically switch between states like **Idle**, **Patrolling**, **Chasing**, and **Shooting**.
  - Unique enemy types (e.g., One Punch Man, Clone Man, Hitman) with distinct behaviors.

- **Stealth Gameplay**:
  - Players strategically navigate levels to avoid detection and eliminate enemies.

- **Scalable and Modular Architecture**:
  - Built with **Model-View-Controller (MVC)** and **Service Locator** patterns.
  - Easy integration of new enemies, states, and player abilities.

- **Customizable Levels**:
  - Configure levels, enemies, and AI behaviors using **Scriptable Objects**.

- **Dynamic UI**:
  - Interactive UI for level selection, gameplay, and post-game results.

---

## **Project Structure**

### **Core Components**

1. **Game Service**: Manages the overall game state and acts as the Service Locator.

2. **Sound Service**: Manages sound effects and background music.
   - `SoundType.cs`: Enum defining different sound types.
   - `SoundScriptableObject.cs`: Configurations for sound properties.

3. **Event Service**: Facilitates event-driven communication between components.
   - `EventController.cs`: Handles the execution of registered events.

4. **Player Service**: Handles player-related mechanics and interactions.
   - `PlayerController.cs`: Manages player actions and inputs.
   - `PlayerView.cs`: Handles the player’s visual representation.
   - `PlayerScriptableObject.cs`: Configures player stats and abilities.

5. **UI Service**: Manages UI elements like gameplay, level selection, and end screens.
   - `GameplayUIController.cs`: Controls in-game UI elements.
   - `GameplayUIView.cs`: Represents the in-game UI visually.
   - `LevelSelectionUIController.cs`: Manages the level selection UI.
   - `LevelSelectionUIView.cs`: Represents the level selection UI visually.
   - `LevelEndUIController.cs`: Displays the end-of-level results.
   - `LevelEndUIView.cs`: Represents the end-of-level UI visually.
   - `CameraShake.cs`: Perform camera shakes during gameplay.
   - `LevelButtonView.cs`: Represents level selection buttons.
   - `IUIController.cs`: Interface for all UI controllers.
   - `IUIView.cs`: Interface for all UI views.

6. **Level Service**: Configures level properties and enemy spawns using Scriptable Objects.
   - `LevelScriptableObject.cs`: Defines level properties like layout and enemies.

7. **Enemy Service**: Manages enemy AI logic, states, and transitions.
   - `EnemyController.cs`: Core controller for enemy mechanics.
     - **Sub-Controllers**:
       - `OnePunchManController.cs`: Manages One Punch Man behavior.
       - `PatrolManController.cs`: Controls Patrol Man enemy behavior.
       - `HitmanController.cs`: Manages Hitman enemy AI.
       - `CloneController.cs`: Handles Clone Man mechanics.
   - `EnemyView.cs`: Represents the enemy visually in the game.
   - `EnemyScriptableObject.cs`: Configurations for enemy stats and abilities.
   - `EnemyType.cs`: Enum defining the different enemy types.
   - **State Machines**:
     - `OnePunchManStateMachine.cs`: Handles One Punch Man states.
     - `PatrolManStateMachine.cs`: Manages Patrol Man state transitions.
     - `HitmanStateMachine.cs`: Manages Hitman behavior states.
     - `CloneStateMachine.cs`: Controls Clone Man state logic.
   - **States**:
     - `IdleState.cs`: Enemy is stationary and idle.
     - `ShootingState.cs`: Enemy attacks the player.
     - `RotatingState.cs`: Enemy rotates in search of the player at same point.
     - `PatrollingState.cs`: Enemy patrols a predefined path.
     - `ChasingState.cs`: Enemy actively pursues the player.
     - `TeleportingState.cs`: Enemy teleports to another location.
     - `CloningState.cs`: Enemy spawns clones of itself.

8. **Bullet Objects**: Contains all bullet-related scripts and configurations.
   - `BulletController.cs`: Controls the behavior of bullets in the game.
   - `BulletView.cs`: Handles the visual representation of bullets.
   - `BulletScriptableObject.cs`: Configures bullet properties like speed and damage.

9. **State Machine Framework**: Implements reusable state management for all enemies.
   - `GenericStateMachine.cs`: Handles state transitions and execution.
   - `IState.cs`: Interface for all states.
   - `States.cs`: Enum defining all possible states.

10. **Utilities**: Contains general-purpose reusable scripts.
    - `GenericMonoSingleton.cs`: Provides a generic implementation of the Singleton pattern.

---

## **Gameplay Elements**

### **Enemies**

1. **One Punch Man**:
   - Rotate around a single point and observes the surroundings.
   - States: Idle, Shooting, Rotating.

2. **Patrol Man**:
   - Patrols a predefined path and chases the player when detected.
   - States: Idle, Shooting, Patrolling, Chasing.

3. **Hitman**:
   - Patrols a predefined path, chases the player when detected and teleport on shooting.
   - States: Idle, Shooting, Patrolling, Chasing, Teleporting.

4. **Clone Man**:
   - Patrols a predefined path, chases the player when detected and creates clones and teleports on death.
   - States: Idle, Shooting, Patrolling, Chasing, Teleporting, Cloning.

### **States**

- **Idle**: Enemy remains stationary and observes the surroundings.
- **Shooting**: Enemy fires projectiles at the player.
- **Rotating**: Enemy rotates at a single point in search of the player.
- **Patrolling**: Enemy moves along a predefined path.
- **Chasing**: Enemy actively pursues the player.
- **Teleporting**: Enemy teleports to another location.
- **Cloning**: Enemy spawns duplicates of itself.

---

## **Setting Up the Project**

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/123rishiag/Shadow-Slayer.git
   ```

2. Open the project in Unity.

---

## __Video Demo__

[__Watch the Gameplay Video__](https://www.loom.com/share/674aa57a3e3549e9b891bd8d28ffa672?sid=00f9c0c0-e8e6-48b1-94f8-bd7ed573d746)

## __Play Link__

[__Play the Game__](https://outscal.com/narishabhgarg/game/play-shadow-slayer-1-game)