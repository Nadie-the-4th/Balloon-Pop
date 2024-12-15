PROTOTYPE 2: TO THE MOON

TO THE MOON TO DO:
know everything you have to do on tasklist
game in one week hmmmmmmmmmm
butterfly thing
whattyado?

  How to design a game:

         What kind of PLAYER EXPERIENCE do you want to create?
                    curiousity n whimsy

           What gamedev skills do you know so far
           changing color
           2d movemment across 4 direcyions
           collision

           need:
           title screen, end screen
           particles / color gradients
           sound effects
           localized sound
           animation
           

        
             Design something that creates the Player Experience you want with the Skills you have

                  //Start with User Experience flow chart DONE

                
                           
                       Thing to make 1 -> a. character in 4 directions with floaty movement  DONE! 

                       new problem: make diagonal movement

                          b. character gameobject. :3

                          c. floaty physics  1.  learning how to do physics (its with velocity) :3



                       -> a.  make map bigger than camera Est. 1 hours

                                b.  set up main camera. Estimate time and Multiply by 2

                                c. big map and have camera track  

                                2.  practice the camera track

                                3.   Implement the tracking camera

                                        
                        Thing to make 3 -> a.  make temp flower that can be activated and deactivated. Est. 3 hours


                                b.  create game object. Estimate time and Multiply by 2

                                c.set up trigger that goes on and off with collision  1.  to learn triggers




TWO SPHERES DEVLOG
2:02 pm (been working since 1:00)
making a new character move wasnt too bad but i have so idea how to retain its momentum over time

devlog 2:19 pm i misplaced the first one, anyway im struggling with the velocity

2:28 fixed it! i had to add it to the parent in the inspector

2:45 got the diagonal movement! only issue is you can't undiagonal once it starts

TWO SPHERES PROJECT
DONE
// Making GO move triangle move method DONE
// Transform DONE
// make it change direction when it hits wall DONE
// make chart DONE + explanation 
3d ANIMATION PROJECT 
9/25/24
working on 3d animation
its not a half bad idea to cut an animation and reverse it fro the second half

9/26/24

turns out the tag 'objects' wasn't capitalized in the script, that was the error lol

get flowers to change color
est time: 1 hr
had too much trouble with the change color script, it kept making them turn invisible instead of a certain color
compromised and made them collectable for the player


but atm: spritesheet animation
est time: 2 hrs
Done!

                                         TRAIN HOP DEVLOGGGGGGGGGGGGGGGG

only rule: OCCAM'S RAZOR

10/2/24

TRAINHOP task list:

draw long, looping background   est. 1 hr

WE CAN DO ITTTT

draw train    est 20 minutes

DONE

make train move  est. 1 hr

DONE

get camera to follow train

DONE


animate train wheels   est. 1 hrt
DONE

questions:

how do i animate in unity?

create animation and import new image for each frame
go to project where we animated n shit

how do i make the background loop?

if traincar reaches trigger box for end of map

x coord = 0
didn't get that far, will do tmrw
plan: go to bed by 2 am flat


10/3/24 GOOOOD MOOOORNINNGGGGGGG


Goals:

get animation to play when moving est. 1 hr

state machines!!!
start with an entry, transition to the animation state, then transition out when you're done moving!

sounds SO much easier than it is lol

need to figure out the transition


right now its: entry -> still -> trainmovin = true -> trainmove -> trainmove = false -> exit

GOT IT

had to do debugging prints and it kinda solved itself
had do make input.anykey == false {x = 0f;}
so now it only moves when I press it, and it only animates when I press it!

now i want to make a debug print for the bool being set to true



To the Moon:
SPRITESHEETS
get an image select multiple
make the lines then slice it
if it actually worked
note to self don't use these



to make an animation stop, make an if -> else!

if (Input.GetKeyDown(KeyCode.Space))
{
    myfellaanimator.SetBool("Run", true);
}
else
{
    myfellaanimator.SetBool("Run", false);
}

//want player to stop when spacebar is no longer down


if (true) 
//compiler runs code

else 
// if it wasn't met this happens


if (true)
//compiler runs code

else if (ur epic)
// if above is false AND ur epic


TO DO:

make web gl build
DONE!

go to build settings
build as html, compress it, then upload that to itch.io


work out the build aspect ratio (900x600 w/ fullscreen) and little settings
set to web gl n run that bitch!





Statements:
assignment- assigning a value to a variable
conditional - ' The room is big' "is" is what makes it conditional 
Conditional statements resolve to a bool.
Method:
States: 
Classes:

Dot Notation = classname.variable


Struct is like a method, like a class
holds a lot of information


10/14/24 adding spritesheet to To the Moon and submitting
3:24 pm
spritesheet done, just need to
import into game est. 30 minutes
fix camera est 30 minutes
it keeps hoing purple
shoulda brought this to melanie

ok I stopped the rotation!

the animation is in the game but not playing 3:43 pm
OK IT WORKS 3:51 pm
I had to add an animator component to the butterfly
and the other one was invisible because it was on the wrong sorting layer

4:27 pm
trying to make the animation play when I move the guy
i dont understand the animation vs animator vs animator controller

I just organize my animation

4:37 the anim variable still hasn't been assigned

TIP: YOU WONT GET ANY WORK DONE IF YOUR SHIT ISNT ORGANIZED

8:23 I'm back and I added an idle state to the animation controller and aligned the name of the animation in the code

now its flapping but like once every little bit and not when I press the button
it says the 'animfrfrfr' needs to be assigned but I thought i did? I'll compare with the train one
I changed it to play the animation is the movespeed isn't 0
lets see if that works
its still says parameter butterflyclip doesn't exist
cuz i didn't set it in the parameter tab in the animator

Now I need to attach the wingflap to the animation
It worked! I had to set the transition to only have the bool be true






10/12/24

Balloon Pop

plan rn: create state machine in animation controller
go from there
statemachine done!! gotta add the bools now!

import addforce (done!) + make movement script est 1 hr. (done!)
I had to set up the axis in Melanie's script with the axis I was using, and plug in the gameobjects into the components in the inspector!
I went to the animation controller, and it looks like there isn't an off switch for a state when you stop pressing a button
the 'isgrounded' bool is broken

11/30/24
input manager broke
worked with Melanie but still couldn't fix it
I tried exporting as package but nothing worked
:<