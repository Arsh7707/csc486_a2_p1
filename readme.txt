Assignment 2 – Part 1
Name: Arshjot Singh
Student ID: V00977388
Course: CSC 486A



1. Player Character (Idle + Walk Animations)

 Idle animation implemented using spritesheet frames.
 Walk/run animation implemented using spritesheet frames.
 Animator Controller created with transitions between Idle ↔ Walk.
 Speed parameter correctly controls transitions.
 Character sprite flips left/right based on movement direction.
 Animations play smoothly without jitter.

2. Player Movement Script (Left, Right, Jump)

 Custom PlayerMovement.cs script implemented.
 Smooth left/right movement using Rigidbody2D physics.
 Jump implemented using AddForce / velocity (depending on version).
 Single-jump only when grounded (OverlapCircle ground detection).
 Jump triggers correctly when pressing Space.
 No wall sticking due to Physics Material (0 friction).
 Rigidbody2D rotation frozen so player does not rotate.

3. Reasonable Character Bounds

  Player collider size matches sprite correctly.  
  GroundCheck positioned below player feet.  
  Character visually aligns with world tilema


4. Physical World (Tilemap + Composite Collider)

  Tilemap created for environment/platform layout.
  Tilemap Collider 2D added for collisions.
  Composite Collider 2D used to smooth platform surfaces.
  Rigidbody2D (Static) on tilemap used by Composite Collider.
  Player makes smooth contact with tilemap platforms (no bumps).

5. Moving Platforms
  One horizontal moving platform implemented.
  One vertical moving platform implemented.
  Platforms oscillate between two points.
  Player remains stable on top of moving platforms.
  Used PlatformEffector 2D In Inspector for the moving platforms
  Platforms move at reasonable speeds for gameplay.

6.Playable Demo
 Multiple distinct regions created with tilemaps.
Vertical and horizontal traversal required.
World is fully traversable given movement abilities.
Scene designed to feel like a small playable demo.


KNOWN ISSUES (IF ANY)

- GroundCheck radius sometimes requires adjustment.
- Open the scene using the Sample Scene in Assets
