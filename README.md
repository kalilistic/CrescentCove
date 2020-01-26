<h1 align="center">
  <br><a href="https://github.com/kalilistic/crescentcove"><img src="img/bannerIcon.png" alt="Crescent Cove"></a>
  <br>Crescent Cove<br>
</h1>
<h4 align="center">Library to easily reference FFXIV Game Data.</h4>

<p align="center">
  <a href="https://github.com/kalilistic/crescentcove/releases/latest"><img src="https://img.shields.io/github/v/release/kalilistic/crescentcove"></a>
  <a href="https://ci.appveyor.com/project/kalilistic/crescentcove/branch/master"><img src="https://img.shields.io/appveyor/ci/kalilistic/crescentcove"></a>
  <a href="https://ci.appveyor.com/project/kalilistic/crescentcove/branch/master/tests"><img src="https://img.shields.io/appveyor/tests/kalilistic/crescentcove"></a>
  <a href="https://codecov.io/gh/kalilistic/crescentcove/branch/master"><img src="https://img.shields.io/codecov/c/gh/kalilistic/crescentcove"></a>
  <a href="https://github.com/kalilistic/crescentcove/blob/master/LICENSE"><img src="https://img.shields.io/github/license/kalilistic/crescentcove?color=lightgrey"></a>
  <a href="https://discord.gg/ftn4k7x"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg"></a>
</p>

## Background

Small .NET framework library to reference FFXIV Game Data from Saint Coinach extracts and other sources.

## Key Features

* Reference game data through repository pattern.
* Handles saint coinach extract and transformation.
* Supports English, French, German, and Japanese.

## Data Models

* ClassJob
* ContentFinderCondition
* Item
* Language
* Map
* PlaceName
* TerritoryType
* World

## How To Install

You can install from <a href="https://www.nuget.org/packages/CrescentCove/">nuget</a>, <a href="https://github.com/kalilistic/CrescentCove/packages">github packages</a>, or <a href="https://github.com/kalilistic/CrescentCove/releases/latest">github releases</a>.

## How To Use

```csharp
// create game data manager
var gameDataManager = new GameDataManager();

// create repository object of desired data
var worldRepository = new GameDataRepository<CrescentCove.World>(gameDataManager.World);

// get data from repository
var world = worldRepository.GetById(12);
var worldName = world.Name;
```

## Software Used

* <a href="https://github.com/ufx/SaintCoinach">SaintCoinach</a>

## How To Contribute

Feel free to open an issue or submit a PR.