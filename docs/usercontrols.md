# 🧩 Custom UserControls

Descriptions of reusable visual components that form the building blocks of Audio-256’s UI.

---

## 📚 Table of Contents

- [Controls Overview](#️-controls-overview)
- [Extension Notes](#-extension-notes)

---

## 🎛️ Controls Overview

| Control | Description |
|---------|-------------|
| `ArtistAlbumElement` | Represents a single album thumbnail in an artist view |
| `ArtistAlbumView` | Displays full album view with cover and tracklist |
| `ArtistAlbumSongsView` | Album detail with track number, title, duration |
| `PlaylistInfoElement` | Shows playlist title and cover in playlists view |
| `PlaylistSongElement` | Displays a song entry with option to add/remove |
| `PlaylistSearchElement` | Textbox for searching songs to add to playlists |

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