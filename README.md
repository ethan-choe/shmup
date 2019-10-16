# **Shmup REmix!!**
  

In this remix I want to create a shmup similar to galaga but with an expanding hitbox. 

## Additions
I want to add to new mechanics:
* *Expanding hitbox*
	* Towing a group of survivors
* *Kidnapping enemies*
	* Steal their projectile type for firing.
	* Tractor beam to kidnap
	* If enemies are hit, only enemy is damaged.
          
## Base Game
The basic mechanics and ruleset are taken from "Introduction to Game Design, Prototyping, and Development: From Concept to Playable Game with Unity and C#, 2nd Edition" Chapter 30. This includes movement, collsion, shield, and player projectiles.

## Process

### Ideation
**Snake tail / towing survivors**
* Fullerton’s Formal elements
	* The main element that I will be adjusting here would be objective as the survivors would more so be bonus points instead of a necessity. However this will also expand the player’s hitbox forcing the procedure and rules to slightly alter. The general conflict of shooting and surviving will stay the same.
* Puzzles / challenges
	* The main challenge here will be to predict enemy attack patterns more precisely so that you don’t lose survivors to the attack.
* Basic rules
	* Increase the hitbox size of you ship as you pick up survivors. Run over them like power ups to start towing them behind you. As you add more survivors the tow tail grows longer. If the tail is attacked you lose all of those survivors, losing bonus points. The point of impact and behind the tail will be lost.

**Kidnap enemies**
* Fullerton’s Formal elements
	* This changes the rules and procedures as the only way to gain upgrades is to kidnap an enemy with traits you desire. You can only kidnap enemies that come close to you through flight patterns. The conflict and objective remains the same.
* Puzzles / challenges
	* Some new puzzles or changes could be that some enemies are only able to die by certain types of projectiles. For example elements could be introduced so that you must kidnap a fire based enemy to defeat a poison based enemy. Or certain asteroids may require a mining themed enemy that usually tries to hit the player with its drill side.
* Basic rules
	* The player can only kidnap enemies that are nearby it. This means the player can only take an enemy whose flight path they intercept as it tries to attack the player. The kidnapping would be slow, similar to the tractor beam in galaga that turns one of your ship against you, but not as slow.

**Dodge with ship position**
* Fullerton’s Formal elements
	* This will change the rules and objective but procedure and objective will stay the same. In order to get past certain energy walls or asteroids, the player must dodge them by flipping their ship in a different orientation. This is similar to the hole-in-the-wall game where contestants must align their body in silly positions to get past a barrier that’s approaching them.
* Puzzles / challenges
	* There will be a timing challenge where the player must bait enemy attacks to one side of the screen in order to provide ample time to rush to the barrier exit location and dodge through. The player will also have to remember the dodge pattern located at the dodge site to efficiently get through without getting shot at.
* Basic rules
	* Barriers will approach the player in a top down scrolling environment where the player can only move left to right. Barriers will have icons that have a ship position that the player must adjust using different buttons to rotate their ship. This rotation will control the direction of the players weapon fire as the ship will only shoot forward.
	
	
	
### 9/30
* Copied the snake function from youtube video
	* <a href="http://www.youtube.com/watch?feature=player_embedded&v=xz8Ga9er3_8
" target="_blank"><img src="http://img.youtube.com/vi/xz8Ga9er3_8/0.jpg" 
alt="YouTube Video" width="240" height="180" border="10" /></a>

### 8/16
The snake function possesses issues with dissappearing. Also Enemies don't spawn although the code is the same as the working code. I need to translate the snake function to the x y axis rather than the x z axis and I need to give the enemies projectiles and scrolling spawn patterns.
