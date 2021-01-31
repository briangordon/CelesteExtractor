Celeste Data Extractor
======================

This is a tool for converting the `.data` files used by the game [Celeste](http://www.celestegame.com/) into easily-readable png files. 

This has been tested with files from the MacOS Steam, Windows Steam, and Linux Steam versions of the game.

Requirements
------------

1. [.NET Core SDK](https://www.microsoft.com/net/download/)

Usage
-----

Just download the project and use `dotnet run` to run the code. This will automatically download dependencies from NuGet. It won't print any output so be patient. Each converted .png file will be placed in the same directory as its original .data file. The total PNG-compressed size of Celeste's graphics assets is about 310MB.

You must pass in paths to Celeste .data files as arguments in order to convert them. For example, to convert all Celeste graphics assets (this will take a few minutes):

```
cd ~/Downloads/CelesteExtractor/CelesteExtractor
dotnet run `find ~/Library/Application\ Support/Steam/steamapps/common/Celeste/Celeste.app/Contents/MacOS/Content/Graphics/Atlases -type f -name "*.data"`
```

On Linux, the default Steam library is elsewhere; try:

```
dotnet run `find ~/.local/share/Steam/steamapps/common/Celeste/Content/Graphics/Aliases -type f -name "*.data*"`
```

Or, on Windows with PowerShell try something like:

```
mkdir C:\celeste-atlases
cp -r "C:\Program Files (x86)\Steam\steamapps\common\Celeste\Content\Graphics\Atlases" C:\celeste-atlases
cd CelesteExtractor
dotnet run -- $(Get-ChildItem 'C:\celeste-atlases' -recurse -include *.data | % {'"' + $_.FullName + '"'})
```

Note that on Windows, you're going to run into [the 32,767 character limit](https://docs.microsoft.com/en-us/windows/win32/api/processthreadsapi/nf-processthreadsapi-createprocessa#parameters) from trying to pass in all of the filenames at once. Even moving the files to something short like `C:\celeste-atlases` isn't enough to come in under the limit. If you're on Windows and you *really* want to convert every .data file, you can do it a few subdirectories at a time. 

Related projects
----------------

* [TeWu/CelesteExtractor](https://github.com/TeWu/CelesteExtractor) is a Java rewrite. **If you're not comfortable with the command line, this is probably your best bet.**
* [dragongling/CelesteExtractor](https://github.com/dragongling/CelesteExtractor) is a .NET fork which removes the XNA dependency.
* [wtdcode/CelesteExtractor](https://github.com/wtdcode/CelesteExtractor) appears to be based on decompiled code from the game.
