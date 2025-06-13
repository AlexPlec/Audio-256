# 🛠 Technical Architecture

This section outlines the internal structure of **Audio-256**, including project structure, core components, views.

---

## 📚 Table of Contents

- 📁 [Project Structure](#-project-structure)
- 📦 [Core Classes](#-core-classes)
- 🖼 [Forms / Views](#-forms--views)
- 🗂 [Data Structure](#-data-structure)
- 📦 [External Libraries](#-external-libraries)
- 🛠 [Build & Run](#-build--run)

---

## 📁 Project Structure

```plaintext
Audio256/
│
├── Forms/
│   └── MainForm.cs                      // Main window UI and layout control
│
├── Views/                               // Main view containers and user-facing sections
│   ├── ArtistsView.cs
│   ├── AlbumsView.cs
│   ├── ArtistAlbumView.cs
│   ├── AlbumTracksView.cs
│   ├── PlaylistView.cs
│   ├── PlaylistTracksView.cs
│   │
│   └── Elements/                        // Reusable UI components grouped by domain
│       ├── Artists/
│       │   └── ArtistListItem.cs
│       │
│       ├── Albums/
│       │   ├── AlbumListItem.cs
│       │   └── ArtistAlbumThumbnail.cs
│       │
│       ├── Tracks/
│       │   ├── TrackListItem.cs
│       │   └── AlbumTrackItem.cs
│       │
│       ├── Playlists/
│       │    ├── PlaylistItem.cs
│       │    ├── PlaylistHeader.cs
│       │    ├── PlaylistTrackItem.cs
│       │    └── PlaylistSearchBox.cs
│       │
│       └── GlobalUI/                    // Shared components
│           ├── NavBar.cs               
│           ├── PlayerControlBar.cs     
│           └── SystemTrayIcon.cs 
├── Core/                                // Logic and backend services
│   ├── Player.cs
│   ├── MusicLibrary.cs
│   ├── MetadataHelper.cs
│   └── LibraryLoader.cs
│
├── Resources/                           // Static assets and data
│   └── (icons, covers, JSON, etc.)
│
└── AppInitializer.cs                    // Startup logic and dependency injection
```  

---

## 📦 Core Classes

| Class | Responsibility |
|-------|----------------|
| `Player` | Manages playback (play, pause, stop, volume, loop), built on NAudio |
| `MusicLibrary` | Stores and manages the collection of tracks, artists, and albums |
| `LibraryLoader` | Loads music data and playlists from disk (JSON, folders) |
| `MetadataHelper` | Extracts metadata (title, artist, album, length) from MP3 files using TagLibSharp |
| `AppInitializer` | Initializes application components, views, and state at startup |

---

## 🖼 Forms / Views

| Form / View | Description |
|-------------|-------------|
| `MainForm` | Main application window responsible for navigation, event handling, and layout control |
| `ArtistView` | Displays all artists in the music library, providing overview and navigation to artist details |
| `AlbumView` | Displays all albums across all artists, with album cover and title |
| `ArtistAlbumView` | Shows detailed view of a selected artist’s albums, including thumbnails and metadata |
| `AlbumTracksView` | Displays track list and detailed metadata for a selected album |
| `PlaylistView` | Shows user-created playlists and the current playback queue with controls |
| `PlaylistTracksView` | Displays the track list and controls for a selected user-created playlist|

---

## 🗂 Data Structure

- **MP3 files** organized in folders: `/Music/Artist/Album/*.mp3`
- **Playlists & history** stored in: `/Data/Playlists/*.json`
- **Metadata** loaded from file tags (ID3v2 or similar)

---

## 📦 External Libraries

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