SCO ToolBox v1.2.7 (November 27th, 2011) - by Flitskikker
=========================================================

SCO ToolBox is designed for decoding, encoding and low level editing of SCO files, which are GTA IV / EFLC compiled scripts.


Usage
-----

The usage of SCO ToolBox is rather obvious.
Just launch it and you will be able to open a single file (for decoding/encoding and editing) and batch decode/encode a bunch of files.
After you open a single file, information about the file is displayed in the properties box. To low level edit it, click the "Open Code Editor" button. Please select the correct script version for the natives mode.
The advanced editor offers line numbering, syntax coloring, auto completing and a bunch of other useful features. However, it will take a while to load large chuncks of code into the advanced editor (decompiling and compiling itself is fast though). It is advised to use the basic editor for large files (>50000 bytes).

I hope you like the tool. :)

~ Flitskikker


Notes
-----

Please keep in mind the following notes before using SCO ToolBox:

- This is not Sanny Builder! SCO ToolBox only offers low level coding. It is certainly a bit harder, but after screwing around with it a while, you can create simple things such as spawning a car. But it works!

- I didn't do high level editing because that's harder to do and the Russians are probably working on their editor, so it would be lost time and effort. However, if you want to give it a try, ask me the source.

- As said above, you should really use the basic editor when opening a large file. The main.sco for example. It took 3 minutes to load it in on my quad core processor (1 second for the basic editor). I didn't make the advanced editor component (it is SyntaxBox by Roger Alsing), so I don't think it can be fixed. However, compiling and decompiling is fast. It processes main.sco in 4 seconds.

- Make sure you save your script as Encoded to make it work in the game.

- The program should now be able to compile for IV 1.0.7.0+ and EFLC. However, I am not sure that all the native hashes are correct.

- So, check the natives mode when you load and save files. Otherwise, the natives will be respectively displayed as hex values or compiled incorrectly.

- Hover your mouse over the auto complete function list to see if you should, and, if yes, what parameters you should add to a function. You can open existing SCO files or check out the GTAModding wiki to get a general view of how things work.

- Because this is actually more like a beta version, the tool may decompile and display things incorrectly. However, it will get compiled in the same (incorrect) way. I've decompiled and recompiled the full main.sco successfully. There were no binary differences (except float values).

- I've added some stuff to the Tools folder. You will find and completely empty script file if you want to create a new file. I've also added a list of vehicle hashes if you want to spawn a vehicle.

- Please note that this is a SCO utility, so it cannot extract it from or pack it into a IMG archive for you.

- I am not a SCO coder, so I can not tell you why your script crashes or how to use all the natives and script features. I can certainly have a try on checking your code, though. First thing to check if your code crashes would be if the correct natives mode is selected.


More information & support
--------------------------

Please refer to the tool's topic on GTAForums.com for more information and support:

http://www.gtaforums.com/index.php?showtopic=481229


Change log
----------

v1.2.7.2:
- Removed the requirement for a GTAIV or EFLC exe to launch the tool.
- Updated and added missing native hashes for 1.0.7.0+.
- Set default natives mode to 1.0.7.0+.

v1.2.7.1:
- 1.0.8.0/1.1.3.0 EXE (EFIGS/RUS/JPN) offsets for the AES key added. It will now detect them as valid EXEs.
- Update checker removed, download URL does not exist anymore and thus will throw an error everytime on launch/re-launch.

v1.2.7:
- Added 1.0.7.0 natives (Thanks OinkOink and sjaak327).
- Added description for code signature.
- Added update checker.
- Some other bug fixes.

v1.2.6:
- First public release.

(Didn't log previous versions)


Legal stuff
-----------

Licensed under the FreeBSD License.

© 2011 FlitskikkerSoftware. All rights reserved.
Contains code courtesy of SparkIV by aru.
Uses Puzzle SyntaxBox, licensed under the LGPL license.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met: 

1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer. 
2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution. 

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

The views and conclusions contained in the software and documentation are those
of the authors and should not be interpreted as representing official policies, 
either expressed or implied, of the FreeBSD Project.
