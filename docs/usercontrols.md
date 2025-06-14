# 🧩 Custom UserControls

Descriptions of reusable visual components that form the building blocks of Audio-256’s UI.

---

## 📚 Table of Contents

- 🎛️ [Controls Overview](#️-ui-controls-overview)
- 🖼 [Extension Notes](#-extension-notes)

---
# 🎛️ UI Controls Overview

Reusable `UserControl` components used across **Audio256**, grouped by domain and file structure. Descriptions include usage context, view locations, and key UI behavior.

---

## 🔧 Global UI Controls

📂 `Forms/Elements/`

| Control             | Description                                         | Used In View(s)    | Features / Notes                         |
|---------------------|-----------------------------------------------------|---------------------|-------------------------------------------|
| `NavBar`            | Top horizontal navigation (Artists, Albums, Playlists) | `MainForm`            | Hosts navigation buttons, highlights active view |
| `PlayerControlBar`  | Bottom docked control with playback, track info, and volume | `MainForm`       | 	Shows current track, play/pause, next, volume slider, etc. |
| `SystemTrayIcon`    | Tray integration for background play with context menu | `MainForm (App-wide)` | Adds minimize-to-tray, right-click menu with playback options |

---

## 🧑‍🎤 Artist-Related Controls

📂 `Views/Elements/Artists/`

| Control             | Description                                         | Used In View(s)    | Features / Notes                         |
|---------------------|-----------------------------------------------------|---------------------|-------------------------------------------|
| `ArtistListItem`    | Represents a single artist with name and optional image | `ArtistsView`   | Clickable; opens detailed artist album view |

---

## 💿 Album-Related Controls

📂 `Views/Elements/Albums/`

| Control                   | Description                                      | Used In View(s)      | Features / Notes                          |
|---------------------------|--------------------------------------------------|------------------------|-------------------------------------------|
| `AlbumListItem`           | Album grid item with cover and title             | `AlbumsView`           | Responsive layout in a scrollable grid     |
| `ArtistAlbumThumbnail`    | Card-style album display within an artist view   | `ArtistAlbumView`      | Compact and styled; optimized for grouping |

---

## 🎵 Track-Related Controls

📂 `Views/Elements/Tracks/`

| Control             | Description                                              | Used In View(s)             | Features / Notes                          |
|---------------------|----------------------------------------------------------|------------------------------|-------------------------------------------|
| `TrackListItem`     | General-purpose row showing track title and artist      | `AlbumTracksView`, `PlaylistView` | Shared across multiple views       |
| `AlbumTrackItem`    | Album-specific row showing track number and duration    | `AlbumTracksView`            | Intended for full album playback layout   |

---

## 🎶 Playlist-Related Controls

📂 `Views/Elements/Playlists/`

| Control               | Description                                           | Used In View(s)   | Features / Notes                              |
|-----------------------|-------------------------------------------------------|--------------------|-----------------------------------------------|
| `PlaylistHeader`      | Header block with title, metadata, and play controls | `PlaylistTracksView`     | Sticky top; includes shuffle/play actions     |
| `PlaylistTrackItem`   | Track row with metadata and reorder/delete buttons   | `PlaylistTracksView`     | Drag-and-drop supported; editable             |
| `PlaylistSearchBox`   | Search box to locate and add tracks                  | `PlaylistTracksView`     | Autocomplete; debounced for performance       |
| `PlaylistItem`        | Clickable preview of a playlist (title, cover, count)| `PlaylistView`           | Selects and opens a playlist                  |

---

✅ **Note**: All controls follow this path convention:
`Views/Elements/<Domain>/<ControlName>.cs`, ensuring clean modularity and ease of reuse across views.

---

## 🖼 Extension Notes

- **To add a new control**, inherit from `UserControl`, bind to `MusicLibrary`, and follow layout consistency.
- **Each control is modular**, focused on either display (`InfoElement`) or interaction (`SearchElement`, `SongElement`).
- **Styling**: Use unified font, color, and padding for a consistent visual hierarchy.

---

## 📷 Optional Enhancements

Consider including:
- Screenshots of each control
- A style guide for colors, padding, and font sizes
- UX behaviors like hover, click, and drag if implemented