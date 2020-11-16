# Unity3DGraphicsLightingDemo
This is a demonstration of various light constructions in Unity Engine
## Week 6
### First Commit Changes for this week
Changes:
- Created an enclosure in the SampleScene
- Changed the Color of the TransitionLight game object
- Created a new script (LightGenerationScript.cs) that created more TransitionLight objects and deletion of said objects
- Added Folder Structure of the files from the last commit

Problems:
- Would delete all instances of the object immediately
- Attaching a light object to a demo model for navigation/exploration purposes
### Second Commit Changes for this week
Changes:
- Implemented First Person Camera
- Attached a flashlight in sync with the camera
- Implemented a dummy model courtesy of Kevin Iglesias

Problems:
- Camera controls attached to the model is not synced and therefore disable at the moment
- Creating a LightSource increases light intensity each time.
## Week 7
### First Person Movement
Changes:
- Incorporated movement with the body model, camera, and light source
- The camera has sensitivity that is able to be adjusted
- Movement speed is able to be adjusted

Problems:
- None spotted
### Light Shadows

Changes:
- The light sources in the model are now using hard shadows
- The mouse cursor is now hidden and locked in place when the game is running
- Adjusted syntax part of the attempt to deal with the exponential problem of instantiated light sources

Problems:
- None spotted
## Week 8
### Light Projectile Generation
First Commit of the Week:

Changes:
- Github file changes that were messing with file upload
- Utilizing an environment asset Curosity of SpeedTutor
- Created an prefab of an sphere object that works with physics
- made the sphere object incorporate with a individual light source that can create shadows in real time
- Made the sphere obeject able to be created by hitting the 'E' key

Problems:
- The location of when the object gets instntatiated flown is off such so that sometimes these created light objects fall through the floor
- Sometimes the spheres just goes through walls
- Did not put an option to delete the light generated objects

### Direct Lighting Chnages
Second Big Commit of the week

Changes:
- Created a new script intended for directional lighting
- The script can rotate the angle of the light source by its y-axis
- I attempted to make the color of the light change based on the rotation of the directional light

Problems:
- The Light color does not change as the color rotates as intended
- The object doesn't delete as sooner as I would want to it deletes after one full rotation
## Week 9
### Water Creation (failed)

Only commit of the week

Changes:
- Pulled a new unity asset for water surface texture
- Attempted to make water using shaders for the first time and it did not work whatsoever
- Added the Universal Rendering Pipeline to the Project settings
- Fixed the textures of the assets in the scene and model that I had pulled earlier

Problems:
- The Water Shader failes to function as intended
- Ball thrown collision appears to be even less consistent
- Lights generated appear to be less dynamic compared to prior update
## Week 10
### Sunlight Transition Adjustment

First commit of the week

Chages:
- Fixed the problem of the light object not deleting itself past a certain point consistently
- Fixed the rotation of the object to make it more workable and more clear as to what is being adjusted
Problem:
- The sunlight still does not changes the light accordingly

### Proximity Detector (failed)

Second Commit of the week

Changes:
- attempted to make a proximity script that would work with the player as the user moved closer to the target location
- made another script to be used in tagent to the proximity detector script but that didn't work either
- fixed the projectile material to not have it show the pink error

Problems:
- Can not get the gameobject to disable itself when collider of the player and the "torch" collide
- Shaders are still a mess to work with
