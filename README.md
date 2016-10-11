# unityCharacterPushTest
Demo of Unity's Problem with Character Controller and Moving Kinematic Rigidbody Colliders

Including 5 different kinds of colliders

1. Normal
2. Animated
3. Animated with Kinematic Rigidbodies
4. Scripted Movement (iTween)
5. Scripted Movement (iTween) with Kinematic Rigidbodies

Step Offset is set to .3 and Skin Width is .08- so the max climbable collider hight should be .38 high- Green blocks are below that height, yellow blocks are exactly at that height, and red blocks are higher than that.

You'll notice that all moving colliders push the player away from the collider (as you'd expect) except for the ones with Kinematic Rigidbodies.

You might further notice that the Rigidbodies are on the parents of the colliders- not on the colliders themselves.
