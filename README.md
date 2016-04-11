# 2016GestureProject
***John Conor Kenny and Dan Maloney***

## Purpose of the Application
The purpose of this application is to explore the use of alternative control methods in video games. In this project, we built a simple shooting gallery and set enemies to spawn randomly at 9 random points. Shooting these enemies gives you a score which is added to a leaderboard.

## Gestures Identified
The Myo armband comes with a series of gestures that you can make with your hand. These gestures include:
1. A Fist
2. Wave Left
3. Wave Right
4. Fingers Spread
5. Double Tap Fingers

There is also the ability to create your own gestures for use with the device, by combining these gestures with arm movements.
However the default gestures run the gamut of what may actually be useful, and most instances they will be all you need and more.

<img src="https://a.pomf.cat/bakisl.jpg">

The gun in the game had several functions. It would need to move, be able to fire, and be able to change the firing mode.

Movement was a no-brainier. Using Myo's panning and rotating, we were able to map the gun to essentially be the player's arm.
By setting up the gun's pivot point to line up with the player's shoulder, the resulting analogy worked very well. This also allows you to turn the gun sideways in the game.

For firing, we looked at the other available gestures. The two that stood out to us as being good choices for firing a gun were the closed fist gesture, and the double finger tap.
Both fit somewhat closely to their real-world counterpart of pulling a trigger. When we tested out each gesture, we found that the closed fist felt better.
The input felt more natural and responsive. The finger tap always felt a little delayed, and for that reason the fist gesture was decided upon. 
Haptic feedback was then added when this gesture was recognised, giving the player a solid indication that their input was definitely received.

For the firing selector, we originally decided upon using the wave left and wave right gestures as inputs. Going from a closed fist to flicking your hand left or right was quite quick.
However, it was not as responsive as we would've liked. And at other times, it was far too responsive. Many times, either nothing would happen when you move your wrist, or the armband would pickup on an input when you were only moving your arm to aim.
Eventually, it was decided to scrap the wrist inputs and to use the double finger tap gesture as a firing toggle. While the double tap seems to have a slight delay to it, the delay is far more preferable than the false inputs that the wrist movements were giving.

Another gesture that is in the game is the finger spread. This resets the armbands position to the centre, and is a default input of the Myo SDK.

## Hardware Used
The Myo armband was the main piece of this project. Developed by Thalmic Labs, the armband allows for hands-free control of computers, tablets and phones. It can be used to control a variety of different apps and games with your wrist and forearm..

The armband uses a set of electromyographic sensors that sense electrical activity in the forearm, combined with a gyroscope, accelerometer and magnetometer to recognize gestures in arm movement. The armband is unable to detect an arms position in 3D space, meaning that there is way to introduce "depth" to projects.
## Solution Architecture
<img src="https://a.pomf.cat/jvtubx.png">

Some of the main scripts in this project are:
- ThalmicMyo & ThalmicHub
These two scripts comes as standard with the Myo SDK and are what connects to the actual armband itself.

- Fire
This script is called by the gun and is what creates the bullets which then travel forward. Which means the gun fires.
This script also has a little detection script for if the bullet hits the object that controls if the game restarts or not.

- GameManager
This script contains the scoring of the game and also the script that restarts the game if needs be.

- SpawnEnemy
This script is the one that controls where the enemies spawn on the play screen.

- JointOrientation
This script is what controls the gun's movement. It allows the gun to move and rotate along a fixed joint in the game world.

- GunControls
This script contains all of the gestures needed to control the gun in the game. These include making a fist to shoot, to tapping fingers to change firing mode.

## Conclusions & Recommendations
While the Myo armband is an interesting idea, it is just that. An idea. The actual tracking of your arm does work, albeit in 2D. The gesture inputs are where the devices let's itself down. They either float between being far too sensitive, or not sensitive enough. Combine this with the fact that the Myo itself sometimes just does not work and requires it's software to be removed and reinstalled from the computer you are using, the Myo leaves a whole lot to be desired. However, if another version of the device was developed that addresses these issues, the the Myo may actually be something special.
