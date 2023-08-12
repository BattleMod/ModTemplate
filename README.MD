# BattleMod Mod Template

Minimal mod example that prints a message to the console uppon loading in.  

You need to have the .NET 6 SDK installed and have launched the game at least once with BepinEx to build mods.  
To build this mod, you need to fix the paths to the assembly references in [the .csproj file](/PluginTemplate.csproj).  
After they're correct, build the project as normal with `dotnet build` and put the assemblies in `BepInEx/plugins/mypluginname`.  