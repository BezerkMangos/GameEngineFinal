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

Observer
The observer pattern in this tetris game allows the player to see the currently active amount of blocks, everytime an object from the object pool gets set active, the observer is updated to display that number.
This is a smart use the observer because it can be tied in with score to show players the more blocks they have on screen the better their score multiplier will be.
