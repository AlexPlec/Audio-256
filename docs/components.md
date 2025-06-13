# 🔄 Component Overview

Describes how key components of the application interact and initialize.

---

## 📚 Table of Contents

- 🔄 [Component Interaction Flow](#-component-interaction-flow)
- 🧬 [Initialization Sequence](#-initialization-sequence)

---

## 🔄 Component Interaction Flow
```mermaid
graph TD
    AppInitializer["🧭 AppInitializer"] -->|Initializes| LibraryLoader["📂 LibraryLoader"]
    LibraryLoader -->|Populates| MusicLibrary["🧠 MusicLibrary"]
    MusicLibrary -->|Provides Data To| Views["🖼️ Views"]
    Views -->|Render| UserControls["🧩 UserControls"]
    Views -->|Trigger Events| Player["🎵 Player"]
    UserControls -->|Send Actions| Player
    AppInitializer -->|Restore Session| Player
```

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
graph TD
    AppInitializer["🧭 AppInitializer"] -->|Scan /Music & /Data folders| LibraryLoader["📂 LibraryLoader"]
    LibraryLoader -->|Extract metadata with TagLibSharp| MusicLibrary["🧠 MusicLibrary"]
    LibraryLoader -->|Populate Artists Albums Tracks Playlists| MusicLibrary
    AppInitializer -->|Initialize views with Library data| Views["🖼️ UI Views"]
    Views -->|Create UserControls like ArtistListItem AlbumListItem PlaylistItem| UserControls["🧩 UserControls"]
    UserControls -->|Play Pause Seek on interaction| Player["🎵 Player"]
    AppInitializer -->|Restore last played state from JSON| Player

```