Celeste Data Extractor
======================

This is a tool for converting the `.data` files used by the game [Celeste](http://www.celestegame.com/) into easily-readable png files. 

This has been tested with files from the MacOS Steam and Windows Steam versions of the game.

Requirements
------------

1. [.NET Core SDK](https://www.microsoft.com/net/download/)

Usage
-----

Just download the project and use `dotnet run` to run the code. This will automatically download dependencies from NuGet. 

You must pass in paths to Celeste .data files as arguments in order to convert them. For example, to convert all Celeste graphics assets (this will take a few minutes):

```
cd ~/Downloads/CelesteExtractor/CelesteExtractor
dotnet run `find ~/Library/Application\ Support/Steam/steamapps/common/Celeste/Celeste.app/Contents/MacOS/Content/Graphics/Atlases -type f -name "*.data"`
```

Or, on Windows with PowerShell:

```
cd CelesteExtractor
dotnet run $(((Get-ChildItem C:\Program Files (x86)\Steam\steamapps\common\Celeste\Content\Graphics\Atlases -recurse -include *.data).FullName) -Join ' ')
```

It won't print any output so be patient. Each converted .png file will be placed in the same directory as its original .data file. The total PNG-compressed size of Celeste's graphics assets is about 310MB.

Related projects
----------------

* [https://github.com/TeWu/CelesteExtractor](TeWu/CelesteExtractor) is a Java rewrite. **If you're not comfortable with the command line, this is probably your best bet.**
* [https://github.com/dragongling/CelesteExtractor](dragongling/CelesteExtractor) is a .NET fork which removes the XNA dependency.
* [https://github.com/wtdcode/CelesteExtractor](wtdcode/CelesteExtractor) appears to be based on decompiled code from the game.
