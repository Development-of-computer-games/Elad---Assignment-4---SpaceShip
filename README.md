# Elad---Assignment-4---SpaceShip
This is the first part of the 4th assignment


# First part (Choosing 1 from 6 options to improve that were given to us).

I chose to do the first option (The shield appears randomly on the screen and when the player takes it, we see the shield embraces the player and fades gradually in 5 seconds)

As you can see in the picture beloew i've added the shiled5 object as a child to the PLayerSpaceShip , and added it a picture of shield using the Sprite Renderer.

![1](https://user-images.githubusercontent.com/57447475/140734602-99f15e27-8a38-4e24-9ae9-954f4d9cc848.jpeg)

To make it appers when the player takes it on the screen , i've added some lines of code to the existing script "ShieldThePlayer".

![2](https://user-images.githubusercontent.com/57447475/140734928-7c700b30-9297-460a-b514-5e29ffba4220.jpeg)

First i found the object with FindWithTag function and in the second highlighted line i got an access to it's Sprit Renderer so i can now show and unshow the picture of shield
on the player spaceship.

To make it randomly appears i used a script called "ShiledRespanwer" which i made and basically this script creates a new shield icon on the screen only
when the older one was taken by the player and to do that i did an if statement which we will go into it only if the currentShield object is null - that means the player took it.(because when a player takes the shield we destroy the object , and it becomes null untill we create a new one).
By the field "shieldApperance" i can determine the time in seconds that will pass from the moment the player took the shield untill a new one will appear.

![3](https://user-images.githubusercontent.com/57447475/140735776-d0707f03-bdd0-47e6-bcd9-633500d9af49.jpeg)


For the fade effect i used an external library called "Lean Tween" which was imported through the Asset Store.
this libray helps to make a nice animations and  by easily using it.

As we can see in the picture below in the highlated line - i used the function LeanTween.alpha which the first parameter
is the object we want to gradually disaper(the shield) ,the second is the alpha value i'm aiming for (0.0f will fade out the object completely),and the last one is the duration of the animation.
when finishing the fadeout  , we need to fade in for the next time the player takes the shield we could be able to see it again.(line 62).

![4](https://user-images.githubusercontent.com/57447475/140736178-49965def-666c-4456-8b52-b623698df9fd.jpeg)

Finally when taking shield it will look like this (and gradually disapper in 5 seconds):

![3](https://user-images.githubusercontent.com/57447475/140759954-9d3d122b-1c1d-4709-9c83-a7d1ed3e9f54.jpeg)





# Second part - add an original change

I chose to add a boss space ship enemy which appears every 'x' seconds and it goes from top to the bottom of the screen and it can also shot lasers like the player space ship
and if the laser hits the player , the player will be destroyed.


![5](https://user-images.githubusercontent.com/57447475/140737219-5ecb7544-d093-4d82-b5a0-b784d4ead650.jpeg)


For that task i created "BossSpwaner" object that will be on charge for the boss apperance every 'x' seconds.

I've added to it the existing "Time Spanwer" script to make it appears every 'x' seconds.

I also made a new Prefab object "Boss Space Ship " which i gave to it all the requested scripts :
1) Sprite Renderer - to be able to see the image of it on screen.
2) Mover - to be able to move it from top to bottm
3) Destroy on trigger 2d - this boss will be destroyed by player laser
4) RigidBody2d and circle collider2d - to make the collide event 
5) Time Spanwer - for it's laser to be shot every 'x' seconds.

I also added to the PlayerSpaceship object a new destroy on trigger 2d which called "Destroy On Laser Boss Trigger" - and gave it the "Boss Laser" tag
so now when the laser of the boss hits the player , it will be destroyed.


# Update :

Three heart lives were added on the left side of the screen.
Now the player is dead only if it gets hit 3 times (by space enemies or boss enemy).
In each hit the player scale reduces ( i used the existing "Health System" script and added to it a few more code line).
In addition after three hits the player is destroyed and a Mesh text shows on the screen : "Game Over!".


![WhatsApp Image 2021-11-09 at 16 02 15](https://user-images.githubusercontent.com/57447475/140938185-20994be8-7699-4ee1-8072-3eebd2d1a259.jpeg)


After one hit : 

![WhatsApp Image 2021-11-09 at 16 02 29](https://user-images.githubusercontent.com/57447475/140938281-31787128-aabc-4a5a-9cfc-cc4396326572.jpeg)

After two hits: (the player is really small now)

![WhatsApp Image 2021-11-09 at 16 02 37](https://user-images.githubusercontent.com/57447475/140938334-9d5250fc-eedd-4111-96e8-14fda3746027.jpeg)

After three hits (Game over):


![WhatsApp Image 2021-11-09 at 16 02 45](https://user-images.githubusercontent.com/57447475/140938424-eb43c2f5-909c-408a-a8ab-16434f708dee.jpeg)




[link for the game](https://eladwd.itch.io/spaceship)


