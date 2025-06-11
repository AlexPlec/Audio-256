## 📚 Table of Contents

- [Project Structure](#-project-structure-example)
- [Technical Architecture](#-technical-architecture)
  - [Core Classes](#-core-classes)
  - [Forms / Views](#-forms--views)
  - [Custom UserControls](#-custom-usercontrols)
  - [Component Interaction](#-component-interaction)
  - [Data Structure](#-data-structure)
  - [External Libraries](#-external-libraries)

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

## 🛠 Technical Architecture

This section outlines the internal structure of **Audio-256**, including core components, views, and their interactions.

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

### 🎛️ Custom UserControls

| Control | Description |
|---------|-------------|
| `ArtistAlbumElement` | Represents a single album thumbnail in an artist view |
| `ArtistAlbumView` | Displays full album view with cover and tracklist |
| `ArtistAlbumSongsView` | Album detail with track number, title, duration |
| `PlaylistInfoElement` | Shows playlist title and cover in playlists view |
| `PlaylistSongElement` | Displays a song entry with option to add/remove |
| `PlaylistSearchElement` | Textbox for searching songs to add to playlists |

---

### 🔄 Component Interaction

- `AppInitializer` → sets up `MusicLibrary` using `LibraryLoader`
- `LibraryLoader` → loads and parses song metadata using `TagLibSharp`
- `MusicLibrary` → provides data to `ArtistView`, `AlbumView`, `SongView`
- `UserControls` → display data dynamically from the library (e.g. `ArtistAlbumElement` created in loop from `MusicLibrary`)
- `Player` → called from `PlaylistView` and `SongView` to manage playback
- On app start, last played playlist is restored from JSON via `LibraryLoader`

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