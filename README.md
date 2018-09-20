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
cp -r ~/Library/Application\ Support/Steam/steamapps/common/Celeste/Celeste.app/Contents/MacOS/Content/Graphics/Atlases/ ~/Desktop
cd ~/Downloads/CelesteExtractor/CelesteExtractor
dotnet run `find /Users/brian/Desktop/Atlases/ -type f -name "*.data"`
```

Each converted .png file will be placed in the same directory as its original .data file. The total PNG-compressed size of Celeste's graphics assets is about 310MB.
