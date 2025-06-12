# 🛠 Technical Architecture

This section outlines the internal structure of **Audio-256**, including project structure, core components, views.

---

## 📚 Table of Contents

- [Project Structure](#-project-structure)
- [Core Classes](#-core-classes)
- [Forms / Views](#-forms--views)
- [Data Structure](#-data-structure)
- [External Libraries](#-external-libraries)
- [Build & Run](#-build--run)

---

## 📁 Project Structure

```plaintext
Audio256/
│
├── Forms/
│   ├── Form1.cs
│   ├── ArtistView.cs
│   ├── AlbumView.cs
│   └── PlaylistView.cs
│
├── Controls/
│   ├── ArtistAlbumElement.cs
│   ├── ArtistAlbumView.cs
│   ├── ArtistAlbumSongsView.cs
│   ├── PlaylistInfoElement.cs
│   ├── PlaylistSongElement.cs
│   └── PlaylistSearchElement.cs
│
├── Core/
│   ├── Player.cs
│   ├── MusicLibrary.cs
│   ├── MetadataHelper.cs
│   └── LibraryLoader.cs
│
├── Resources/
│   └── Icons, Covers, JSON data, etc.
│
└── AppInitializer.cs
```  

---

### 📦 Core Classes

| Class | Responsibility |
|-------|----------------|
| `Player` | Manages playback (play, pause, stop, volume, loop), built on NAudio |
| `MusicLibrary` | Stores and manages the collection of songs, artists, and albums |
| `LibraryLoader` | Loads music data and playlists from disk (JSON, folders) |
| `MetadataHelper` | Extracts metadata (title, artist, album, length) from MP3 files using TagLibSharp |
| `AppInitializer` | Initializes application components, views, and state at startup |

---

### 🖼 Forms / Views

| Form / View | Description |
|-------------|-------------|
| `Form1` | Main window and controller for all navigation and interactions |
| `ArtistView` | Displays list of artists and their albums |
| `AlbumView` | Shows all albums and related metadata |
| `SongView` | Lists all available songs |
| `PlaylistView` | Displays user playlists and the current playing queue |

---

### 🗂 Data Structure

- **MP3 files** organized in folders: `/Music/Artist/Album/*.mp3`
- **Playlists & history** stored in: `/Data/Playlists/*.json`
- **Metadata** loaded from file tags (ID3v2 or similar)

---

### 📦 External Libraries

| Library | Purpose |
|--------|---------|
| [NAudio](https://github.com/naudio/NAudio) | Audio playback engine |
| [TagLibSharp](https://github.com/mono/taglib-sharp) | Metadata extraction |
| [Newtonsoft.Json](https://www.newtonsoft.com/json) | Reading/writing JSON files for playlists and history |

---

## 🛠 Build & Run

1. Open `Audio256.sln` in Visual Studio
2. Restore NuGet packages (NAudio, TagLibSharp, Newtonsoft.Json)
3. Build and run

Minimum Requirements:
- .NET Framework 4.7.2+
- Visual Studio 2019 or later