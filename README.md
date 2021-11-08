# Elad---Assignment-4---SpceShip
This is the first part of the 4th assignment


#First part (Choosing 1 from 6 options to improve that were given to us).

I chose to do the first option (The shield appears randomly on the screen and when the player takes it, we see the shield embraces the player and fades gradually in 5 seconds)

As you can see in the picture beloew i've added the shiled5 object as a child to the PLayerSpaceShip , and added it a picture of shield using the Sprite Renderer.

![1](https://user-images.githubusercontent.com/57447475/140734602-99f15e27-8a38-4e24-9ae9-954f4d9cc848.jpeg)

To make it appers when the player takes it on the screen , i've added some lines of code to the existing script "ShieldThePlayer".

![2](https://user-images.githubusercontent.com/57447475/140734928-7c700b30-9297-460a-b514-5e29ffba4220.jpeg)

First i found the object with FindWithTag function and in the second highlighted line i got an access to it's Sprit Renderer so i can now show and unshow the picture of shield
on the player spaceship.

To make it randomly appears i used a script called "ShiledRespanwer" which i made and basically this script creates a new shiled icon on the screen only
when the older one was taken by the player and to do that i did an if statement which we will go into it only if the currentShield object is null - that means the player took it.
By the field "shieldApperance" i can determine the time in seconds that will pass from the moment the player took the shield untill a new one will appear.

![3](https://user-images.githubusercontent.com/57447475/140735776-d0707f03-bdd0-47e6-bcd9-633500d9af49.jpeg)


For the fade effect i used an external library called "Lean Tween" which was imported through the Asset Store.
this libray helps to make a nice animations and  by easily using it.

As we can see in the picture below in the highlated line - i used the function LeanTween.alpha which the first parameter
is the object we want to gradually disaper(the shield) ,the second is the alpha value i'm aiming for (0.0f will fade out the object completely),and the last one is the duration of the animation.
when finishing the fadeout  , we need to fade in for the next time the player takes the shield we could be able to see it again.(line 62).

![4](https://user-images.githubusercontent.com/57447475/140736178-49965def-666c-4456-8b52-b623698df9fd.jpeg)








