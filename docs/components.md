# 🔄 Component Overview

Describes how key components of the application interact and initialize.

---

## 🔄 Component Interaction Flow

- `AppInitializer` → sets up `MusicLibrary` using `LibraryLoader`
- `LibraryLoader` → loads and parses song metadata using `TagLibSharp`
- `MusicLibrary` → provides data to `ArtistView`, `AlbumView`, `SongView`
- `UserControls` → dynamically created from data (e.g. `ArtistAlbumElement` list)
- `Player` → called from `PlaylistView` and `SongView` to manage playback
- Last played playlist restored from JSON on startup

---

## 🧬 Initialization Sequence

```mermaid
sequenceDiagram
    participant App as AppInitializer
    participant Loader as LibraryLoader
    participant Library as MusicLibrary
    participant UI as ArtistView / AlbumView / PlaylistView
    participant Player as Player

    App->>Loader: Load data from /Music and /Data
    Loader->>Library: Populate songs, albums, playlists
    App->>UI: Build views from Library
    UI->>Player: Play/Pause/Seek on user action