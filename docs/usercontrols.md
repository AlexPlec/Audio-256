# 🧩 Custom UserControls

Descriptions of reusable visual components that form the building blocks of Audio-256’s UI.

---

## 📚 Table of Contents

- 🎛️ [Controls Overview](#️-controls-overview)
- 🖼 [Extension Notes](#-extension-notes)

---
## 🎛️ Controls Overview

| Control Name          | Description                               | Used In View(s)         | Notes / Features                       |
|----------------------|-------------------------------------------|------------------------|--------------------------------------|
| 🎵 `ArtistAlbumElement`  | Single album thumbnail in artist view     | ArtistAlbumView        | Clickable, hover effects              |
| 📀 `ArtistAlbumView`     | Full album with cover and tracklist       | ArtistAlbumView        | Container for album details           |
| 📃 `ArtistAlbumSongsView`| Track list with number, title, duration   | ArtistAlbumView        | Displays detailed track info          |
| 📋 `PlaylistInfoElement` | Playlist title and cover art               | PlaylistView           | Editable title, cover support         |
| 🎶 `PlaylistSongElement` | Song entry with add/remove button          | PlaylistView           | Supports drag and reorder             |
| 🔍 `PlaylistSearchElement`| Search box to add songs to playlist       | PlaylistView           | Autocomplete, debounce input          |

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