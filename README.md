Explanation & Documentation 

Command Pattern
The command pattern was used to deal with the rotations of the falling peices. A is rotate left, D is rotate right, and Spacebar is to undo the last rotation. The command pattern works by
taking each input and storing it in a stack. it then allows for the undoing of that game object until it it no longer the controllable one. The object that is controlled by the stak is the 
tetris peice that is falling. 

Object Pooling
The object pool works by taking in prefabs of the tetris peices i want to spawn then creating a pool of them to be used. In the game currently the pieces are being spawnt correctly and with the right
amount set but their render component is not spawning with them. The object pool still functionally works by spawning a set pool of objects to be used. The object pool helps optimization because it will
reuse objects instead of creating and destryoing them over and over again. For a game like tetris this is really important because objects are constantly being destroyed and created, using hte object pool we 
save a ton of CPU resources by removing the need to destroy and create often and just set active and deactive instead.

Observer (Additonal Design Pattern)
The observer pattern in this tetris game allows the player to see the currently active amount of blocks, everytime an object from the object pool gets set active, the observer is updated to display that number. This is a smart use the observer because it can be tied in with score to show players the more blocks they have on screen the better their score multiplier will be.

DLL (Addtional Design Pattern)
I also implemented a DLL for the game that I created, i gave this DLL a simple feature of setting the time scale, better know as pausing and unpausing the game. In the DLL script itself I chose not to hard bind the inputs for the functions incase i wanted to keep the functions modular which could allow for custom button remapping which is another use for the command pattern.



The Whole Project
The way I completed this project was as followed. First I had to put together the design patterns I wanted to implement with their in game functionailty, 
this meant Command pattern with the rotattion of the blocks, object pooling with the creation of the blocks and 1 other pattern of my choosing. First I made the command pattern to control the blocks. I made a test block and then I start to make the command interface and set what the command pattern would be doing. I made an execute function that would take a target game object, rotate it left or right depending on input, and an undo function which would undo the last rotation. To then make the objects work like tetris I added ad downward vector to the objects scaling with time. This meant the object would always move down until it hit something. Next I started to work on the object pool. The first thing I did was make prefabs of different objects and added some materials to them, these objects are in my prefab folder. The next thing I did was set up the object pool to be controlled by a piece manager which just created a pool and made a few variables public for later use. Next I made it so the prefabs in the target list would spawn, this list is an array of prefabs the pool can spawn. The pool succeded at spawning random objects from the pool but i did run into an issue because none of the prefabs would have any components but their transform. This meant mesh renders and materials were missing. After that I made an observer to keep track of the active amount of items in the pool. This observer observers the piece manager for that information then sends it to the UI to be displayed for the player. My goal with this was to use the observer to get rid of circualr dependancies and also to be used for a score, if i had time the score would have been calculated as activePoolObjects * Time to give you a score, this meant the more peices on screen the better your score as well as time played.

