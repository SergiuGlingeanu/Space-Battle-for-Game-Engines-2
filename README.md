Due to the request of updating this README file post submission and it's absence from both the brief and the rubric, this should not contribute to or deter from our grades.

# Space Battle for Game Engines 2
 
# Storyboard

Ender's Game.

I plan to make the space battle similar to the final battle from the movie. One side will have a few big ships, while the other side will have a lot of small ships.
I plan to make the camera follow the battle from a distant point to show the whole battle, sometimes showing the perspective from each faction as the battle progresses.

The smaller ships will use a swarming behaviour, while the big ships will try to destroy the planet and shoot down the smaller ships.

[Link to video](https://youtu.be/C0zZQbWycrg)

In the scene there are 3 ships. The yeach have the script to navigate to a specific point. The target points have a script on them that randomises their location whenever the ship reaches them. When the ship gets a new point it use A LookAt function to turn towards the point, then it gets a forcee pushing it towards it.
