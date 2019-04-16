
* lock to horiztonal mode

* introduce helper stuff with a black panel, and text, later figure out how to go without text

* hide controls in menu scene, instead of "press enter to continue", have a menu of contents:

* menu

  * game title
  * new game
  * load game
  * close
  
* decrease the size of the a, b, x, y button labels

* shake trees to get apples
 
  * shake trees like screen shake, or perhaps shake the whole game when we shake a tree, is there haptic feedback too on apple? android?
  
  * apples fall down with physics, adjust mass for effect, and put semi round collider on for them to roll
  
  * perhaps apples have some certain special abilities
  
  
* collecting apples goes well with the first leve, lots of gree, and pleasant easy terrain

* put up score for gold coins in the upper right hand corner

 * use the token class from the city builder project
 

* create a basic level with enough green forest, and apple shaking, and then also other color platforms with gold coins


* add gold coin pickup script

* perhaps add mist fog to certain levels if we can


* add the kind of style you would have in a classy vanilla, everything well chosen, extra ordinary classic, yet nothing out of place type aesthetic

* add power up abilities, like higher jumping allowing, or multiple jumping

* what other things to do to finish one level?

* choosing classy things are hard

* include farming, since already have the script, just get the x and y position, let the player just plant the seeds

* perhaps when they consume apples for health, they can then plant an apple tree

* this also gives the world permance

* as we shake the trees, we can get the fruit to plant those trees, perhaps we also have oranges

* the trees grow relativly quick, and can then be used as ways of getting more health points if we are fighting a boss, or a tough patch of the game

* simply show an "A" hovering above the tree, like the a bouncing in the cat game, copy and export that as a package, since that animation easing functionality is already set up, just show that when the player starts the game, so they know what to press

* add a voxel brown floor to the platform kind of like here: https://www.google.com/search?q=sonic+levels&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiZof-U7NLhAhXsSt8KHc23CHwQ_AUIDigB&biw=1260&bih=674#imgrc=VGw3Cb2_jVRSjM:

and that other voxel example on sketchfab

* light fog, and lighting would help, but not sure if mobile can handle the post processing

* when we shake the tree we get apples, and maybe we get one or two more (randomized) apples on the next shake, and maybe even 1 apple on the third shake randomly, but after that no matter times how many times we shake the tree there will be no more apples

* and of course we are going to need some enemies

* make simple voxel enemies, contract the rigid body mess, on contraction

* have to then make animations for the rigid bodies, see if can use the voxel animation asset

* make projectile enemies, different types, different ranges

* the enemies have random loot


* also need some fancy physics especially ones where we can jump off walls

* also have floating by voxel clouds

* perhaps can even ride the voxel clouds, this adds to the classy strange Murakami esque and Tove Jansson aesthetic


* other elements that are classy (sometimes hard to find):

 * water (could be going up and down, or flooding the area)
 
 * moving platforms
 
 * cute abstract enemy creatures
 
 * add pause screen - start buttons - takes us into menu as an efficent pause, while also showing other options, including back to game option

* take advantage of loot boxes

* have the game be as visceral as possible

* gold coins to collect, loot boxes, smooth graphics, for someone that just wants a real game

* really take advantage of skinner boxes

* fix the rotation on the platform so matches up with the player running direction, so we can keep running in a straight line on the platform

* purchase the 99 animations pack for rpg character, for special abilities, but first check how animations work with the moenen controller

* add A LOT of different weapon types

* add projectile magic weapons, since those are in "real games" and add to the visceral experience

* review the game feel video to make the projectile weapons more effective

 * screen shake
 
 * large clouds of effect
 
 * very thick laser beams, multiple laser beams, faster
 
 
 
Procedurally generate the levels!

Can make custom rules... 

Like as long as we know the random boundary of a platform we can extrapolate

Build up the procedural rules from basics, for example:

1) Generate a random platform

2) On this random platform generate items and structures based on probability settings, making sure nothing overlaps

3) Then get the end of the platform, and generate a random gap after this, afterwhich we generate the next platform

4) And then on that next procedurally generated platform we generate items 

5) and so 

So first as an experiment and MVP, generate simply platforms with gaps one after the other

1) generate random platform
2) generate gap
3) generate another platform after the gap


So we have a procedurally generated rogue 3D platformer

Have a really smooth difficulty curve, where later levels are as challening as the game from that Jon Blow video, where we will have lots moving objects that can cause damage

The key is to simply have moving objects arranged differently, in the Spikes game, all they had was spikes, the same graphic everytime, so we can different graphics, but the point is that the basic mechanism is just to have lots of these moving objects around as an obstacle course to derive gameplay 

we can also derive gameplay with the ingame economy / market / supply demand 



if animations are difficult or the moene player controller, can use the santa controller, and either way get that cool spell effect, that would look nice lighting up the darkness


* review all the 50 camera mistakes from the Journey talk 

A procedurally generated platformer... 


Another classy Murakami esque thing that is hard to find -- abstract levels, like in the old dungeon levels

We could procedurally generate almost escher like levels

When we use light in the dungeon, that is almost enough to make those levels look good, combined with procedural generation there will be a lot of gameplay 


How many levels? 

how about 10?

Or 5 to start? 

1 - forest
2 - dungeon
3 - magic forest
4 - ice world - penguins (lots of them, can't fight them but they all compete for space, while you're sliding off the platform (the physics should be easy), cool mechanic
5 - dungeon 2

Each level having their own unique characters adds to qualities of a visceral "real game" 


Since the game will be a procedural rogue, add rare items which can only be collected on every other playthrough 

Add the inventory bar from the previous game (already made as an exported package) to add to the visceral hoarding of a "real game"

- really like that blocky villain creature from the moenen model collection, that kind of weird, super round, aesthetic

- certain enemies have different ways of fighting, so you have to fight differently against them, which is where the rogue mastery comes in 

- have some kind of safety mechanisms against speed running a level, so if a player tries to run and avoid the creatures as obstacles, perhaps that creatur will shoot a projectile to hurt them, if they have instead used their shield or something

- just having a shield to use could be a mechanic of getting through levels

- also have classy orchestral music like Desplat and Wes Anderson, so even for the dungeon levels we could use some low timpany and nylon guitar rhythms (record guitar) like in the Grand Budapest Hotel 

- have some really nice smooth impressive combat

 - where we jump and can do directional attacks in the air, like dragon ball z, combined with the game feel video of vlambeer, and screenshake, just very smooth and impressive stuff, quick and elegant, a real game


* spice up things by having the world turn like in Fez, so let's say the aesthetic is like a platformer where we are walking along in one direction, well let's say then that we get to the end of the hallway, and then we turn the camera and game around, allowing us to take a 90 degree angle, and then keep walking straight in the direction, like fez but better

* we could even do a similar effect and apply that to an Escher level, where instead of just a 90 degree turn, we turn the world sideways, or upside down, and then we have a new gravity

* this would be really cool for procedural level generation, since we wouldn't be able to speed run that fast since everytime we would have a new challenge, also imagine when the coins are revolving on the side, and then we turn the world, and collect the coins on the side, (using ambient occlusion and bloom the coins would look very nice rotating on the sides of the abstract structures, even simple stuff would work here)

* try to study the work of that one escher game to check how they made that in terms of level design

* similar voxel style as the character: https://sketchfab.com/3d-models/test-model-suspicious-mathuu-lookalike-9c473ff9076e43f8b24ed8ca511e2cc5

* could make the little character from above as some sort of checkpoint, where we talk to him and he tells us a story


* Joystick average at 11:42 of: https://www.youtube.com/watch?v=nGYObojmkO4

    Vector2 movementAimVector = new Vector2(CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce; // not sure if we need moveForce, since the example is applying a force, but perhaps we could set the sensitivity here 
