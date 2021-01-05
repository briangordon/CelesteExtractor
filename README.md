Celeste Data Extractor
======================

This is a tool for converting the `.data` files used by the game [Celeste](http://www.celestegame.com/) into easily-readable png files. 

This has been tested with files from the MacOS Steam and Windows Steam versions of the game.

Requirements
------------

1. [.NET Core SDK](https://www.microsoft.com/net/download/)

Usage
-----

Just download the project and use `dotnet run` to run the code. This will automatically download dependencies from NuGet. It won't print any output so be patient. Each converted .png file will be placed in the same directory as its original .data file. The total PNG-compressed size of Celeste's graphics assets is about 310MB.

You must pipe in paths to Celeste .data files in order to convert them. For example, to convert all Celeste graphics assets (this will take a few minutes):

```
cd CelesteExtractor
find ~/path/to/your/steam/dir/Celeste/Celeste.app/Contents/MacOS/Content/Graphics/Atlases -type f -name "*.data" | dotnet run
```

Or, on Windows with PowerShell try something like:

```
cd CelesteExtractor
$(Get-ChildItem 'C:\path\to\your\steam\dir\Celeste\Content\Graphics\Atlases' -recurse -include *.data | % {$_.FullName}) | dotnet run
```

Note that on Windows, you're going to need to pipe the data files into the project to avoid [the 32,767 character limit](https://docs.microsoft.com/en-us/windows/win32/api/processthreadsapi/nf-processthreadsapi-createprocessa#parameters). 

Related projects
----------------

* [TeWu/CelesteExtractor](https://github.com/TeWu/CelesteExtractor) is a Java rewrite. **If you're not comfortable with the command line, this is probably your best bet.**
* [dragongling/CelesteExtractor](https://github.com/dragongling/CelesteExtractor) is a .NET fork which removes the XNA dependency.
* [wtdcode/CelesteExtractor](https://github.com/wtdcode/CelesteExtractor) appears to be based on decompiled code from the game.
