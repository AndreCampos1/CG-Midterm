# CG Midterm

Controls
A to move Left
D to move Right
Space to jump (just hold it and you fly, didnt have enough time to fix it)

Reflection 

Its different from the one that we did in class because I combined a checker texture with the uv and color in order to combibne with the reflection to make this good looking effecty.
I used the reflection shader graph in tutorial 3. Also downloaded assets online for the cube map from the unity assets store.

Tiling and water

I used my own knowledge for this one, but I make a moving shader with the offset with the sin time and combined it with a noise texture. I then stretched the noise texture to make lines like a water fall. since they move now it makes it look like a water moving. I then combined it with colors to make it look like water.
It Suites the scene because it looks like water moving vertically, especialling since its moving so fast that you cant tell that its a noise texture.

Multiple UV

I made 3 uvs for sonics character a default, damage, and death. The default shold be blue to represent sonics apperance (I didnt make shader for this one since they take forever to make)
I then made one where you take damage and another for death where it shows when the player dies or takes damage. I havent coded for it to change but Imagine that it does and also imagine I added shaders. It would work perfectly on how to tell the player that they took a hit or died since grey and black are very notisable to the human eye. So I think it works for the enviroment and the game. I made them with UVS with colors, I then combine all 3 into an Enum in order to appear in the inspector for the coder to change it. Also I copied the shader graph from the slides of lecture 3.

Toggle Shader

I was going to copy from lecture 4 of the diffuse, ambient, and specular. This was going to be the last shader that I needed to add, but I cant do it timne of writing this text. At least I am done.
