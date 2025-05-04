This is a template project for [Rocket Science](https://store.steampowered.com/app/890520) extensions. *Note*: extension support was added in the v0.24.x version of the game (it is currently not released to public).

## Getting started

You need to follow a few simple steps to get started:

- clone the repository or downlad a zip archive;
- set GamePath variable to the path to the Rocket Science folder in the RSExtension.csproj file;
- open RSExtensionTemplate.sln using Visual studio;
- you are ready to go!

Don't forget to rename project and `MyExtension.cs` file to something more meaningfull that will represent your extension functionality.

## Structure

You need to inherit you first class from `BaseExtention` class from `UnbeGames.API` namespace for your extension to be recognized by the game. This template already contains such class in the `MyExtension.cs`, but you can create your one and have more than one in the project. This will be an entry point to your extension. The next step is to override some virtual methods provided in the `BaseExtention` class depending on what you want.

