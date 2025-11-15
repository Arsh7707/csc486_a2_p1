CSC486 – Assignment 1
Name: Arshjot Singh
Student ID: V00977388
platform_assignment1_part2_csc486


1. Scene Layout and 2D Area 
Constructed a static 2D scene that fully utilizes both X and Y dimensions. The scene contains a main ground area, multiple elevated platforms, and decorative background element the graphiti art. The layout forms a complete platformer level that could be traversed by walking or jumping if movement were implemented.

2. Vertical Platforms 
Added two static vertical platforms positioned higher and lower than the ground level. Their height differences were chosen so that each is logically reachable by a jump or fall from the starting height. Grid snapping was used for alignment and proportional spacing.

3. Horizontal Platforms 
Created two static horizontal platforms at roughly the same height to form a reachable side-to-side jump area. The spacing allows smooth horizontal progression across the scene.

4. Use of Tilemap, Grid, and Tile Palette
Implemented a Grid object with multiple Tilemaps and constructed the level using the Tile Palette tools. All tiles were drawn onto the grid, aligned precisely with no pixel gaps. Each tile was generated from properly sliced spritesheets using Unity’s Sprite Editor.

5. Tilesheets
Used three different tilesheets for the scene:
1) Ground  main terrain tile in green
2) Background environment tiles such as the graphiti
3) Foreground decorative objects and tree art tile
All tilesheets were imported from external sources.

6. Sprite Atlas 
Created a Sprite Atlas named MainLevelAtlas in Assets/Atlas. Packed all tilesheets and static sprites into this atlas and enabled Include in Build. Verified that all sprites in the scene reference the atlas for optimized rendering.

7. Foreground and Background Layers (2 Marks)
Used at least two different Tilemaps to separate background and foreground elements. The background layer contains scenery objects such as zombie graphiti, while the foreground layer contains ground tiles and tree art white tile. Sorting Layers were used to ensure correct depth order.

8. Camera Clear Colour
Changed the Main Camera’s Clear Flags from Skybox to Solid Color. Selected a light blue tone to match the natural theme of the environment.

9. Quality
All sprites imported at 32 pixels per unit. Filter Mode set to Point (No Filter) to maintain crisp pixel art. No grid gaps or blurring present. Scene layout is logical, proportional, and non-random. Colours and transparency settings appear correct.

10. External Assets
https://kenney.nl/assets/new-platformer-pack
https://kenney.nl/assets/platformer-characters

11. Folder Structure
if the scene doesn/t open up, click the main folder then click on assets, then click on scene folder then open the samplescene.unity

