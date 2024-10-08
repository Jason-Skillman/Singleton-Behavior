# Singleton Behavior Changelog

## [2.0.3] - 08/30/2024
- Fixed name of new game object.

## [2.0.2] - 08/30/2024
- Added DDOL to all singletons.

## [2.0.1] - 12/02/2022
- Updated namespace.

## [2.0.0] - 09/24/2022
- Removed unsused scripts.
- Removed `DontDestroyOnLoad()` from classes.
- Added `DontDestroyOnLoad.cs`.
- Updated `SingltonBehavior` to use `Component` instead of `MonoBehavior`.

## [1.4.0] - 12/29/2021
- Split `DontDestroyOnLoad()` logic from singleton script.

## [1.3.0] - 09/27/2021
- Split singleton scripts.

## [1.2.3] - 07/24/2021
- Updated assembly definition names.

## [1.2.2] - 05/23/2021
- Removed duplicate null checking.

## [1.2.1] - 04/01/2021
- Fixed a bug where a new object would get created OnApplicationQuit.

## [1.2.0] - 03/30/2021
- Fixed singleton when using multible game objects from the start.
- Add `dontDestroyOnLoad` to the inspector.

## [1.1.1] - 03/04/2021
- Updated package name to `SingletonBehavior`.

## [1.1.0] - 12/20/2020
- Updated `SingltonBehavior` script to be auto created if one does not exist.
- Added `DontDestroyOnLoad()`.

## [1.0.0] - 11/09/2020
- Unity singlton release.
