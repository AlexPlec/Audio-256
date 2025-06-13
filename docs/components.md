# 🔄 Component Overview

Describes how key components of the application interact and initialize.

---

## 📚 Table of Contents

- 🔄 [Component Interaction Flow](#-component-interaction-flow)
- 🧬 [Initialization Sequence](#-initialization-sequence)

---

## 🔄 Component Interaction Flow

## 🔁 1. `AppInitializer`

- Entry point of the application.
- Triggers `LibraryLoader` to scan local music and data files.
- Loads previous session state (e.g., last playlist or track).
- Constructs primary views using `MusicLibrary` data.

---

## 📂 2. `LibraryLoader`

- Scans local directories (`/Music`, `/Data`) for audio and playlist files.
- Uses `TagLibSharp` to extract:
  - Track title, album, artist
  - Duration and cover image
- Parses and builds:
  - `Artist`, `Album`, `Track`, `Playlist` objects
- Feeds structured data into `MusicLibrary`.

---

## 🧠 3. `MusicLibrary`

- Central in-memory data store for:
  - Artists and Albums
  - Tracks and Playlists
- Offers queryable APIs for views to access relevant data.
- Ensures a consistent, centralized source of truth across the app.

---

## 🖼️ 4. Views

Includes: `ArtistsView`, `AlbumsView`, `ArtistAlbumView`, `AlbumTracksView`, `PlaylistView`

- Pull data from `MusicLibrary` to display UI.
- Dynamically instantiate `UserControls`, such as:
  - `ArtistListItem`, `AlbumListItem`, `TrackListItem`, etc.
- Bind user events:
  - Selection
  - Playback
  - Playlist modification

---

## 🧩 5. `UserControls`

Path: `Views/Elements/<Domain>/`

- Reusable interactive UI components.
- Examples:
  - `PlaylistTrackItem`, `AlbumTrackItem`, `ArtistAlbumThumbnail`
- Emit user actions to relevant views or the `Player`.
- Fully encapsulated; follow MVU-like separation.

---

## 🎵 6. `Player`

- Core playback engine:
  - Play, Pause, Stop
  - Seek, Loop, Volume
- Listens to input from UI elements or views.
- Maintains current playback state and persists:
  - Last played track
  - Playback queue
- Triggered by `PlaylistView`, `AlbumTracksView`, and `UserControls`.

---

## 📌 Notes

- Views depend solely on `MusicLibrary` for data access.
- Playback is isolated in `Player`, minimizing tight coupling.
- `UserControls` act as bridges between UI and logic without direct dependencies.
- Session state is restored for seamless continuity.

---

## 🧬 Initialization Sequence

```mermaid
sequenceDiagram
    participant App as AppInitializer
    participant Loader as LibraryLoader
    participant Library as MusicLibrary
    participant Views as UI Views<br/>(ArtistsView, AlbumsView, PlaylistView)
    participant Controls as UserControls
    participant Player as Player

    App->>Loader: Scan /Music and /Data folders
    Loader->>Library: Extract metadata using TagLibSharp
    Loader->>Library: Populate Artists, Albums, Tracks, Playlists
    App->>Views: Initialize views with Library data
    Views->>Controls: Create ArtistListItem, AlbumListItem, etc.
    Controls->>Player: Play/Pause/Seek on user interaction
    App->>Player: Restore last played state from JSON