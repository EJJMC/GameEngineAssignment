# GameEnginesAssignment
 EoinMcSharry c17304091

## Initial Concept

For this assignment, I would like to make a procedurally generated idea based on the "Vapor Wave" aesthetic.
I would like to have 3d objects from this asetic decorate the screen and have a procedurally generated grid/landscape encompass it.

##Final Concept

For my final concept, I still went for the Vaper Wave asethic but made it more streamlined. There is now an audio visuliser element to the game.

## Development

The first implimentation I made was the terrain. The terrain is made through a mesh. The mesh has a filter and a render. In code, the mesh terrain was made with quads from verticies. Perlin noise was used to make the terrain more sperratic. The terrain size and with can be edited in the inspector.

The audio was gathered from samples. Thses samples distrubute different wave frequencies that can be assigned into bands. The strenght and size of these bands can be edited in the inspector as well as the choice of music.

The movement of the camera was done by adding force using rigidbodies. Once it moves to a cartin point, the box collider on the object activiates the trigger resseting its position to a start transform.

The pattern on the ground was done by shaders. The lenght, with and colour of this shader can be edited in the inspector.

## Conclusion

I was very happy with how this project turned out. I did have a github/shader issue causing me to re do the unity project and copy assets over which took some time. I very much like the way this project looks astetically. This project has tought me so much about procedural genoration in unity.
