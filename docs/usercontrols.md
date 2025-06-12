# 🧩 Custom UserControls

Descriptions of reusable visual components that form the building blocks of Audio-256’s UI.

---

## 📚 Table of Contents

- 🎛️ [Controls Overview](#️-ui-controls-overview)
- 🖼 [Extension Notes](#-extension-notes)

---
# 🎛️ UI Controls Overview

A detailed reference of reusable `UserControl` components used across **Audio256** views. Organized by domain for easier maintainability and onboarding.

---

## 🎨 Artist-Related Controls (`ArtistAlbumView`)

| Control                 | Description                                             | Used In            | Notes / Features                          |
|-------------------------|---------------------------------------------------------|--------------------|-------------------------------------------|
| `ArtistAlbumElement`    | Thumbnail for an album under an artist                 | `ArtistAlbumView`  | Clickable, hover highlight, shows title   |
| `ArtistAlbumView`       | Container for an artist’s selected album(s)            | `MainForm`         | Shows selected artist’s albums in detail  |
| `ArtistAlbumSongsView`  | Track list for an album: number, title, duration       | `ArtistAlbumView`  | Scrollable; synced with album selection   |

---

## 💿 Album-Related Controls (`AlbumsView`, `AlbumTracksView`)

| Control                 | Description                                             | Used In               | Notes / Features                          |
|-------------------------|---------------------------------------------------------|------------------------|-------------------------------------------|
| `AlbumTrackItem`        | Track row with number, title, and duration             | `AlbumTracksView`      | Used only for album context               |
| `TrackListItem`         | Generic track row showing title and artist             | `AlbumTracksView`, `PlaylistView` | Reusable for multiple contexts      |
| `AlbumListItem`         | Album item with cover and title for grid display       | `AlbumsView`           | Responsive layout in grid                 |
| `ArtistAlbumThumbnail`  | Album card in an artist view (compact + styled)        | `ArtistAlbumView`      | Visual variant of `AlbumListItem`         |

---

## 🎶 Playlist-Related Controls (`PlaylistView`)

| Control                 | Description                                             | Used In            | Notes / Features                          |
|-------------------------|---------------------------------------------------------|--------------------|-------------------------------------------|
| `PlaylistInfoElement`   | Displays playlist title, cover art, and metadata       | `PlaylistView`     | Editable title, default fallback art      |
| `PlaylistSongElement`   | Song row in a playlist with remove/add buttons         | `PlaylistView`     | Supports drag-and-drop reorder            |
| `PlaylistSearchElement` | Search box to find and add songs to playlist           | `PlaylistView`     | Debounced input, autocomplete             |
| `PlaylistHeader`        | Header area with playlist summary metadata             | `PlaylistView`     | Sticky header with play/shuffle buttons   |
| `PlaylistTrackItem`     | Track info row with controls for managing playlist     | `PlaylistView`     | Icon buttons for remove and reorder       |
| `PlaylistSearchBox`     | Alternative naming for `PlaylistSearchElement`         | `PlaylistView`     | Same control; consider aliasing clearly   |

---

## 👤 Artist & Album List Controls (`ArtistsView`, `AlbumsView`)

| Control               | Description                                               | Used In         | Notes / Features                          |
|-----------------------|-----------------------------------------------------------|------------------|-------------------------------------------|
| `ArtistListItem`      | Artist entry with name and optional image                | `ArtistsView`    | Clickable to open artist detail view      |

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

<  [`ArtistAlbumElement`](Views/Elements/Albums/ArtistAlbumThumbnail.cs) >