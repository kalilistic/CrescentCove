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
</p>

## Background

Small .NET framework library to reference FFXIV Game Data from Saint Coinach extracts and other sources.

## Key Features

* Reference game data through repository pattern.
* Handles saint coinach extract and transformation.

## Data Models

* ClassJob
* ContentFinderCondition
* Item
* World

## How To Install

You can install from nuget, github packages, or github releases.

## How To Use

```csharp
// create game data manager
var gameDataManager = new GameDataManager();

// create repository objects of desired data
var itemRepository = new GameDataRepository<GameDataItem>(gameDataManager.Item);
var worldRepository = new GameDataRepository<GameDataWorld>(gameDataManager.World);

// get data from repository
int worldId = 12;
var world = worldRepository.GetById(worldId);
```

## Considerations

* This has a limited data set but I'm happy to add new models or data elements if there's interest.

## How To Update for Patch

### 1. Set variables in game-data-config.bat.

```shell
SET DEVENV="C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\devenv.com"
SET FFXIV_DIR="C:/games/FINAL FANTASY XIV Online"
SET GAME_DATA_DIR="C:\workspaces\CrescentCove"
```

### 2. Update game data in local from command line.

```shell
cd CrescentCove
build.ps1
update-game-data.bat
```

### 3. Push changes to GitHub.

```shell
git checkout -b patch-5.1
git add .\src\CrescentCove\Properties\*
git commit -m "update for patch 5.1"
git push --set-upstream origin patch-5.1
```

### 4. Create PR to merge into master.

* <a href="https://help.github.com/en/desktop/contributing-to-projects/creating-a-pull-request">Create a Pull Request</a>

## Software Used

* <a href="https://github.com/ufx/SaintCoinach">SaintCoinach</a>

## How To Contribute

Feel free to open an issue or submit a PR.