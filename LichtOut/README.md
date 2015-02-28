# Lich-TeamProject
[C#2][TP] LICH -Telerik Academy 2015/2016 


# Team Members:


dentia - Mihaela Encheva

momo333 - Maria Koseva

FunnyBunny - Naditsa Lazarova

zdzdz - Ivan Ivanov

ilia.82 - Ilia Marchev

Nicca - Veronica Velkova

nikoloay.milenkov - Nikolay Milenkov

Tsoncheva_Nevena - Nevena Tsoncheva

teodor.mihov.9 - Teodor Mihov


# Project explanation

The project is based on the game Lights out: 
from Wikipedia:
Lights Out is an electronic game, released by Tiger Electronics in 1995. 
The game consists of a 5 by 5 grid of lights. When the game starts, a 
random number or a stored pattern of these lights is switched on. Pressing 
any of the lights will toggle it and the adjacent lights. The goal of the 
puzzle is to switch all the lights off, preferably in as few button 
presses as possible.
A similar electronic game Merlin was released by Parker Brothers in the 
1970s with similar rules on a 3x3 grid.

The game consists of:
Start screen, where the player can choose easy(3x3) or classic(5x5) mode
and can view the top 5 highscores.

When a game mode is selected, the user can choose the color of the on/off
tiles. Then a grid of customized buttons* is created. The player can go back to 
the start screen at any time. If the game is finished (all the lights are out),
the player can enter a nickname and his score is saved. If he beat his previous
highscore, a message box will notify him.

*customized buttons - custom class, that inherits the System.Windows.Forms.Button
class, but is linked to its neighbours, so when a button is clicked, all its neighbours
change their state (on/off) too.


# Git repository URL: 
https://github.com/dentia/Lich-TeamProject.git

