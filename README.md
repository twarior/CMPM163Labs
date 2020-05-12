# CMPM163Labs

//Lab 2 Cubes Video
https://drive.google.com/file/d/1TaiHmrjy326l5j7phbM1IykEN_uD7bBQ/view?usp=sharing

//Lab 2 Part 2 Image
![](Lab%202/Part2.PNG)

//Lab 3 Cubes Video
https://drive.google.com/file/d/1rJpXl3KB4JAraUWA9NN8ZP23WenOCsyC/view?usp=sharing

//Lab 3 Explination:
For the top cube, I mainly looked at the code here:
https://gist.github.com/kylemcdonald/9593057 ,
but changed it a bit to make it more look like a grid as well as fit into the separate
files for the fragment shader. 
For the bottom left cube, I used a wireframe material to give the outline of the cube as
it is being rendered. 
For the bottom middle cube, I use the Phong model to highlight a section fo the cube. 
For the bottom right cube, I interpolated between green and purple. 

//Lab 4 Questions
24.a: uv = (u+1)/8
24.b: uv = ((u)/(-8)) + 1
24.c: Grey

//Lab 4 cube discriptions:
The bottom left cube is just using the image as a texture with no normal.
Next to that, the bottom middle cube is the same image, but now with a normal texture 
as well so it has shadows. 
Above that, the top middle is another image texture and normal combo.
The bottom right cube is one with our own code for the texture instead of using THREE.js.
The top right is the same, but we wrap it by modding the vec 2 'vUv' by .5, and then 
multiplying that by 2.0;

//Lab 4 Video
https://drive.google.com/file/d/1C9i-PbvrksryoOz3Hyd9rXY1xYifBf1R/view?usp=sharing

//I did part 1 for Lab 5

//Lab 5 Video
https://drive.google.com/file/d/1CdyJHf5rzuhiVAnbgQjO0g8JpkzWkmeM/view?usp=sharing

//Lab 5 Explination:
I changed the material for the kart body by making it more mattalic, less smooth, adding
emmision and giving it the color of another asset in the game. I also made the track more 
transparent and added a flame trail and rainbow trail to the player's head. 

//Lab 6 Lights: 
Directional Light: Behaves like the sun, lights all objects in the scene based on the direction of the light 
source. Position is irrelevant. 
Point LIght: Works light a lightbulb, illuminates object in the scene based on the lights position and 
direction does not affect the illumination as it creates light equally in all directions. 
Area Light: Only work when baking a light map. Shine in all directions to one side of a rectangular plane. 

//Material: 
I tried to emulate my water bottle, which has a somewhat reflective grey plastic body. I have no idea how 
to make a material reflective, as when I try to add metallic to the material, it just makes the object 
black. 

//Texture: 
I added a couple of the textures from the list given in the ealier THREE.js Lab and plaved them onto a 
cyllindrical object and a spherical object.

//Skybox: 
I added the default skybox, but that didn't look very cool so I changed it to a wireframe mesh which, 
though it doesn't look much like a sky, looks much cooler in my opinion. 

//Lab 6 Images:
![](Lab%206/Lab6.PNG)
![](Lab%206/waterbottle.jpg)
