# CMP5402 Mobile Development
## Milestone 1: Game Design Proposal

**Game Title:** Street Dasher  
**Development Engine:** Unity  
**Programming Language:** C#  
**Target Platform:** Android smartphones  
**Game Orientation:** Portrait  
**Genre:** 2D Endless Runner

## 1. Game Concept

Street Dasher is a 2D endless runner set in a futuristic city filled with neon lights, obstacles and collectibles. The player controls a character running through the city, avoiding obstacles and collecting coins to achieve the highest possible score.

The character runs automatically, allowing the player to focus on movement and reactions. As the game progresses, the running speed increases, making it more challenging to avoid obstacles and collect rewards.

The main objective is to survive for as long as possible, collect coins and beat the player's previous high score. The game will feature a main menu, gameplay screen, pause menu and game-over screen with an option to restart.

## 2. Target Audience

Street Dasher is aimed at casual mobile gamers aged 10 and above who enjoy fast-paced games that are easy to learn but become more challenging over time.

The game is designed for short play sessions, making it suitable for people who want a quick gaming experience on their phone. Simple swipe controls and clear visual feedback will make the game accessible to new players.

## 3. Target Mobile Platform

The primary target platform for Street Dasher will be Android smartphones. The game will be developed using Unity and C#, with a design focused on touchscreen interaction and portrait orientation.

The interface will use responsive Unity Canvas layouts to accommodate different screen sizes and aspect ratios. Swipe gestures will provide the main gameplay controls, while vibration feedback will be explored to improve player interaction on supported devices.

The game will be tested on a physical Android device to evaluate control responsiveness, interface usability, performance and compatibility. Android has been selected as the target platform because Unity supports building Android applications directly from a Windows development computer once the required Android build tools are installed.

## 4. Core Gameplay Loop

The core gameplay loop will be:

1. The player opens the game and selects Play.
2. The character begins running automatically.
3. The player swipes to move between lanes or jump over obstacles.
4. The player collects coins to increase their score.
5. The game gradually increases in difficulty as the running speed rises.
6. A collision ends the run and displays the final score.
7. The player can restart and attempt to beat their previous high score.

This gameplay loop is intended to be simple, repeatable and suitable for mobile devices.

## 5. Main Features

Street Dasher will aim to include the following features:

- **Automatic running:** The character moves forward without requiring continuous input.
- **Swipe controls:** Players use touchscreen gestures to control movement.
- **Obstacle avoidance:** Obstacles require quick reactions.
- **Collectibles:** Coins reward players and increase their score.
- **Progressive difficulty:** The game becomes faster and more challenging over time.
- **Score system:** The player's score increases during a run.
- **High-score persistence:** The best score is saved locally between sessions.
- **Game states:** The game includes menu, gameplay, pause and game-over states.
- **Mobile-specific feature:** Vibration feedback will be investigated for events such as collisions or coin collection, subject to device support and testing.

## 6. Interface Wireframes

The following wireframes show the planned layout of the main screens. These are initial designs and will be refined during development.

### 6.1 Main Menu

```text
+---------------------------+
|                           |
|        Street Dasher      |
|                           |
|     [ Character Art ]     |
|                           |
|       HIGH SCORE: 0       |
|                           |
|       [ PLAY GAME ]       |
|                           |
|       [ SETTINGS ]        |
|                           |
+---------------------------+
```

The main menu will display the game title, the player's high score and a prominent Play button. A Settings button may provide options such as sound and vibration.

### 6.2 Gameplay Screen

```text
+---------------------------+
| SCORE: 250       [ PAUSE ]|
|                           |
|       [ OBSTACLE ]        |
|                           |
|           [COIN]          |
|                           |
|     [ PLAYER CHARACTER ]  |
|                           |
|             CITY          |
|          BACKGROUND       |
+---------------------------+
```

The gameplay screen will display the current score and a pause button. The character, obstacles and coins will be clearly visible, with enough space for comfortable touchscreen interaction.

### 6.3 Game-Over Screen

```text
+---------------------------+
|                           |
|         GAME OVER         |
|                           |
|       FINAL SCORE: 250    |
|       BEST SCORE: 400     |
|                           |
|        [ TRY AGAIN ]      |
|                           |
|        [ MAIN MENU ]      |
|                           |
+---------------------------+
```

The game-over screen will display the final score and saved high score. The player will be able to restart immediately or return to the main menu.

## 7. Touch-Control Scheme

The game will use touchscreen controls designed for one-handed portrait play.

- **Swipe left:** Move one lane to the left.
- **Swipe right:** Move one lane to the right.
- **Swipe up:** Jump over an obstacle.
- **Tap pause:** Pause the game and display the pause menu.
- **Tap Try Again:** Restart the current run.

Unity's touch-input functionality will be used to detect swipe gestures. Controls will be tested on an Android device to ensure they respond consistently and feel comfortable during gameplay.

## 8. Mobile-Specific Feature

The proposed mobile-specific feature is vibration feedback. The game will investigate using the Android device's supported vibration functionality to provide feedback when the player collides with an obstacle or collects a coin.

This feature is intended to make important gameplay events feel more responsive without requiring the player to look away from the screen.

The implementation will depend on the available Unity functionality and Android device support. If suitable vibration feedback cannot be implemented reliably, an alternative mobile-specific feature will be considered and documented.

## 9. Technical Approach

Unity will be used to develop the game, with C# scripts controlling the main gameplay systems.

The planned technical systems include:

- **Player controller:** Handles swipe input, lane movement and jumping.
- **Obstacle system:** Creates and manages obstacles.
- **Collectible system:** Detects coin collection and updates the score.
- **Score manager:** Tracks the current score and best score.
- **Game manager:** Controls menu, gameplay, pause and game-over states.
- **Save system:** Stores the high score locally using Unity's PlayerPrefs.
- **User interface:** Displays the score, menus and game-state information.
- **GitHub version control:** Tracks development progress and allows work to continue between computers.

Reusable prefabs will be used for objects such as the player, obstacles and coins. The project will be organised into suitable folders for scripts, scenes, prefabs, sprites, audio and other assets.

## 10. Development Plan

The project will be managed through GitHub Issues or a GitHub Project board. Tasks will be prioritised according to their importance to the playable game.

| Priority | Task | Expected outcome |
|---|---|---|
| High | Create Unity project and GitHub repository | Project setup and version control |
| High | Create the player controller | Character movement and swipe input |
| High | Implement obstacles and collisions | Main challenge and failure condition |
| High | Implement scoring and coin collection | Working score system |
| High | Create game states and restart functionality | Complete basic gameplay loop |
| Medium | Build the main menu and gameplay UI | Usable mobile interface |
| Medium | Save the high score | Persistent player progress |
| Medium | Implement and test vibration feedback | Mobile-specific feature |
| Medium | Build and test on an Android device | Device testing and issue identification |
| Low | Improve visuals, audio and difficulty balance | More polished game experience |

Progress will be recorded through meaningful Git commits made throughout development. GitHub Issues or the project board will be updated as tasks are started and completed.
(i will be adding more task as i go, aslo to my project board)
## 11. Testing Strategy

Testing will take place throughout development rather than only at the end.

The following areas will be tested:

- Swipe controls respond correctly to player input.
- The player can avoid obstacles and collect coins.
- Collisions trigger the game-over state.
- The score updates correctly.
- The high score remains saved after closing and reopening the game.
- Pause, resume and restart work correctly.
- The interface remains usable on the target Android screen.
- Performance remains acceptable during gameplay.
- Vibration feedback works as intended on supported hardware.
- The game behaves appropriately when interrupted or returned to from the background.

Issues found during testing will be recorded and prioritised before the release candidate is prepared.

## 12. Project Objectives

The objectives for Street Dasher are to:

1. Develop a playable 2D endless runner using Unity and C#.
2. Implement a complete gameplay loop with controls, obstacles, scoring and restart functionality.
3. Create a clear interface suitable for portrait mobile gameplay.
4. Implement local high-score persistence.
5. Investigate and test a mobile-specific feature.
6. Use GitHub for version control and project management.
7. Build and test the game on a physical Android device and evaluate its usability and performance.

## 13. Assets, References and AI Use

Visual and audio assets will be created by me or sourced from appropriately licensed resources. Any external assets used will be recorded with their source and licence information.

AI tools may be used to support learning, investigate technical problems and assist with debugging. Any AI assistance will be declared in accordance with the module's assessment requirements. The design decisions, implementation, testing and evaluation will remain my own work.
