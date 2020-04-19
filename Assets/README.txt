_______________________

 IN-GAME SETTINGS MENU
_______________________


ABOUT
=====
Made by Øyvind Strømsvik (TwiiK)
http://twiik.net/projects/in-game-settings-menu

LICENSE/COPYRIGHT
=================
I enforce no restrictions for the use of this project, but whatever license 
Unity Technologies shipped the original project under also applies to this
project, the same goes for Pavel's SuperBlur and Unity's Post Processing Stack.

KNOWN ISSUES
============
- Some of my class names and code structure made the code harder to use in a namespace.
- The code is still quite rough. For example the SliderBase base class is mainly dedicated 
to graphics functionality, but I use it for the volume sliders as well.
- I want the tooltip to show at a fixed position in relation to the element, but I 
struggled with that and settled for showing it at the cursor's position instead.
- The tooltip doesn't disappear when you click a button while it's showing because the
mouse out event isn't called.
- I forgot to take keyboard/gamepad navigation into account when I created the tooltip.
- Basically the tooltip is shit at the moment. :p

ROADMAP
=======
- Read up on saving/loading settings and see if I want to implement that, perhaps using player prefs?
- Look at implementing something like this: http://www.alanzucconi.com/2015/12/16/color-blindness
- Add the ability to change resolution and fullscreen mode
- Make it possible to rebind key bindings

ADDITIONAL INFORMATION
======================
You'll have to build the GI and reflection probes. I deleted the data to reduce the file size.

The demo scene is this one: 
https://www.assetstore.unity3d.com/en/#!/content/33630

I shrunk all the textures to 1024x1024 to reduce the size of the project. Originally they were
2048x2048 or 4096x4096. I doubt you can tell the difference, but the project is now a fraction
of the size.

This is the Post Processing Stack used:
https://www.assetstore.unity3d.com/en/#!/content/83912

I deleted all the textures from it apart from the one lens dirt texture I'm using and I reduced
the size of it to further reduce the file size of the project.

The menu blur effect is made by Pavel Dobryakov. It is excellent, get it here:
https://github.com/PavelDoGreat/Super-Blur
