# 🧩 Custom UserControls

Modular, self-contained UI components in **Audio-256**, built using a **Model–View–Controller (MVC)** pattern and integrated via a centralized **Mediator** for decoupled communication. These controls form the visual foundation of the app and enable clean reuse across different views.

---

## 📚 Table of Contents

- 🎛️ [Controls Overview](#️-controls-overview)
    - 🔧 [Global UI Controls](#-global-ui-controls)
    - 🧑‍🎤 [Artist UI Components](#-artist-ui-components)
    - 💿 [Album UI Components](#-album-ui-components)
    - 🎵 [Track UI Components](#-track-ui-components)
    - 🎶 [Playlist UI Components](#-playlist-ui-components)
- 🧱 [Control Structure](#-control-structure)
- 🖼 [Integration Guidelines](#-integration-guidelines)

---
## 🎛️ Controls Overview

Reusable UserControl-based components used across **Audio-256**, grouped by domain. Each is self-contained (View + Model + Controller) and designed for composability in top-level views.

---

### 🔧 Global UI Controls

📂 `UI/Shared/`

| Component          | Location Path              | Used In        | Purpose                                                                  |
| ------------------ | -------------------------- | -------------- | ------------------------------------------------------------------------ |
| `NavBar`           | `Shared/NavBar/`           | `MainFormView` | Horizontal navigation bar across core views (Artists, Albums, Playlists) |
| `PlayerControlBar` | `Shared/PlayerControlBar/` | `MainFormView` | Docked playback controls: track info, play/pause, next, volume           |
| `SystemTrayIcon`   | `Shared/SystemTrayIcon/`   | App-wide       | Minimize-to-tray support with context menu playback controls             |

---

### 🧑‍🎤 Artist UI Components

📂 `UI/Artists/`

| Component             | Location Path                              | Used In       | Purpose                                 |
| --------------------- | ------------------------------------------ | ------------- | --------------------------------------- |
| `ArtistListThumbnail` | `Artists/Views/ArtistListThumbnailView.cs` | `ArtistsView` | Clickable artist preview (name + image) |

---

### 💿 Album UI Components

📂 `UI/Albums/, UI/ArtistAlbums/`

| Component              | Location Path                                    | Used In            | Purpose                                                         |
| ---------------------- | ------------------------------------------------ | ------------------ | --------------------------------------------------------------- |
| `AlbumListThumbnail`   | `Albums/Views/AlbumListThumbnailView.cs`         | `AlbumsView`       | Album preview with cover and title, in a responsive scroll grid |
| `ArtistAlbumThumbnail` | `ArtistAlbums/Views/ArtistAlbumThumbnailView.cs` | `ArtistAlbumsView` | Artist-specific album view with compact display and metadata    |

---

### 🎵 Track UI Components

📂 `UI/AlbumTracks/, UI/PlaylistTracks/`

| Component                 | Location Path                                         | Used In                 | Purpose                                           |
| ------------------------- | ----------------------------------------------------- | ----------------------- | ------------------------------------------------- |
| `AlbumTrackView`          | `AlbumTracks/Views/AlbumTrackView.cs`                 | `AlbumTracksListView`   | Displays track number, title, duration            |
| `PlaylistTrackItem`       | `PlaylistTracks/Views/PlaylistTrackItemView.cs`       | `PlaylistListView`      | Enhanced track row with drag-and-drop, delete     |
| `PlaylistSearchTrackItem` | `PlaylistTracks/Views/PlaylistSearchTrackItemView.cs` | `PlaylistSearchBoxView` | Search result preview used when adding new tracks |

---

### 🎶 Playlist UI Components

📂 `UI/Playlist/, UI/PlaylistTracks/`

| Component              | Location Path                                   | Used In              | Purpose                                                         |
| ---------------------- | ----------------------------------------------- | -------------------- | --------------------------------------------------------------- |
| `PlaylistThumbnail`    | `Playlist/Views/PlaylistThumbnailView.cs`       | `PlaylistView`       | Clickable playlist card with title, cover, and track count      |
| `PlaylistCreateButton` | `Playlist/Views/PlaylistCreateButtonView.cs`    | `PlaylistView`       | Initiates new playlist creation                                 |
| `PlaylistHeaderView`   | `PlaylistTracks/Views/PlaylistHeaderView.cs`    | `PlaylistTracksView` | Fixed top banner with playlist title, play/shuffle actions      |
| `PlaylistSearchBox`    | `PlaylistTracks/Views/PlaylistSearchBoxView.cs` | `PlaylistTracksView` | Inline search bar to locate and insert tracks into the playlist |

---

## 🧱 Control Structure

Each UserControl is implemented using the MVC pattern and resides in:

```plaintext
UI/<Domain>/<ComponentName>/
├── Models/        // Holds component-specific state
├── Views/         // Renders the component
└── Controllers/   // Handles user input and updates
```

For example:

```plaintext
UI/AlbumTracks/AlbumTrack/
├── Models/AlbumTrackItemModel.cs
├── Views/AlbumTrackView.cs
└── Controllers/AlbumTrackController.cs
```
---

## 🖼 Integration Guidelines

- ✅ Reusable: Components are designed to be shared across views without modification.
- 🎯 Consistent: All components follow unified styling (fonts, colors, padding).
- 🧩 Composable: Built to slot into higher-level containers like AlbumTracksListView or PlaylistListView.
- 🔄 State-driven: All visual states are derived from their Model, updated via the Controller.