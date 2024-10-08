# Practical 3.1: Designing Environments
Earlier sessions have focused on the nuts and bolts of building interactive environments. In this session and the session afterwards, you’ll develop level design techniques using Unity and 3D assets. Today we’ll look both at indoor environments and designing such an environment to allow players to explore and discover elements of the environment.

This repository includes a Unity project with some assets that you will use to complete the tasks in this class. To get started make a copy of this repository on your GitHub account and clone it onto your local computer.

## Task 1: Planning a level in space and time.
Imagine this scenario: “You find yourself in abandoned underground military laboratory. As you progress through labs, corridors and storage areas, you start to feel you are not alone…”

First of all, have a good look at the different corridor assets. These are some simple blocks that can be combined to create an indoor environment. You can create copies, edit, and group objects together to create an interactive environment. They slot together to make corridors rooms and doorways. 

Roughly plan and sketch a map of the environment that contains 2 minutes of gameplay. Think carefully about the structure of the world you’re creating in relation to the above scenario. The environment should contain at least some of the following devices:

- A start point that introduces the environment
- Hidden passages or puzzles
- Hazards or traps
- Choke point sections which all players must pass through
- A goal that the player must attain (this could be objects or items to collect or an exit to reach).

Mark these clearly on your sketch. Think about furniture and props that you might want to include (don’t worry about the specific object details at this point).
 
## Task 2: Building the level
Use the corridor assets provided to build your level, following the map you have designed. Remember that you can align objects using their transforms. The Grid Snapping option button allows you to snap objects to the grid. Additional options can be found under Edit > Grid and Snap settings. 

 ![image](https://user-images.githubusercontent.com/5978932/194539613-27c379b8-4dc4-4b15-95fb-873ceb14eb7b.png)

Once you have finished building the level, test it out by importing a FPS controller into your project. Walk through the environment and see how long it takes without any props or objects. You may need to scale down the size of the standard FPS controller if it does not fit through the doors! 

## Task 3: Blocking out 
Now that you have a walkable environment, think about “extras” like furniture, monsters and props that you might want to add. Using the primitive objects provided by Unity, block out your level. Test out your level to ensure your extras aren’t stopping the player from progressing through the level. 

## Task 4: Blocks to ‘real’ objects
Browse the Unity store for free 3D assets that you could add to your level. You can also try and create them in Maya! Think about what kind of environment you are designing. Is there a specific aesthetic you are looking for? Task 3 should have helped you in knowing what size and shape of object you are looking to add. Replace your primitive blocks with these assets. You should now have a fully designed, indoor scene. Play through it or ask us to walk through it to see how a new player reacts to your environment. 

## Optional extensions: 
- Could you import your indoor environment into your terrain scene from last week’s practical? Are there any modifications that need to be made? 
- Designers often put in subtle hints in an environment to guide the user above and beyond just the layout. Can you think of any additions you can make to your level to lead the player down the optimal path? 
- Look at different materials available to you. Change the aesthetic and design of the environment to be a dream sequence rather than an underground military lab. 

