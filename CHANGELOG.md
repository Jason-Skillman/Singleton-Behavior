# Unity Singleton Behavior Changelog

## [2.0.5] - 2026/07/04
- Rename to Singleton Behavior.

## [2.0.4] - 2025/04/30
- Rename to Unity Singleton Behavior.

## [2.0.3] - 2024/08/30
- Fixed name of new game object.

## [2.0.2] - 2024/08/30
- Added DDOL to all singletons.

## [2.0.1] - 2022/12/02
- Updated namespace.

## [2.0.0] - 2022/09/24
- Removed unsused scripts.
- Removed `DontDestroyOnLoad()` from classes.
- Added `DontDestroyOnLoad.cs`.
- Updated `SingltonBehavior` to use `Component` instead of `MonoBehavior`.

## [1.4.0] - 2021/12/29
- Split `DontDestroyOnLoad()` logic from singleton script.

## [1.3.0] - 2021/09/27
- Split singleton scripts.

## [1.2.3] - 2021/07/24
- Updated assembly definition names.

## [1.2.2] - 2021/05/23
- Removed duplicate null checking.

## [1.2.1] - 2021/04/01
- Fixed a bug where a new object would get created OnApplicationQuit.

## [1.2.0] - 2021/03/30
- Fixed singleton when using multible game objects from the start.
- Add `dontDestroyOnLoad` to the inspector.

## [1.1.1] - 2021/03/04
- Updated package name to `SingletonBehavior`.

## [1.1.0] - 2020/12/20
- Updated `SingltonBehavior` script to be auto created if one does not exist.
- Added `DontDestroyOnLoad()`.

## [1.0.0] - 2020/11/09
- Unity singlton release.
