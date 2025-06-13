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
│   └── MainForm.cs                      // Main window for navigation, event handling, and layout control.
│
├── Views/                               // UI views and composite containers for major sections.
│   ├── ArtistsView.cs                    // Displays all artists in the music library.
│   ├── AlbumsView.cs                     // Displays all albums across all artists.
│   ├── ArtistAlbumView.cs                // Shows selected artist’s albums in detail.
│   ├── AlbumTracksView.cs                // Displays track list and metadata for a selected album.
│   ├── PlaylistView.cs                   // View for user-created playlists and current playback queue.
│   │
│   └── Elements/                        // Reusable UI components (UserControls), grouped by view usage.
│       ├── Artists/                      // Components used in ArtistsView.
│       │   └── ArtistListItem.cs         // Represents a single artist with name and image.
│       │
│       ├── Albums/                      // Components used in AlbumsView and ArtistAlbumView.
│       │   ├── AlbumListItem.cs          // Grid item with album cover and title.
│       │   └── ArtistAlbumThumbnail.cs   // Album card displayed inside an artist view.
│       │
│       ├── Tracks/                      // Components used in AlbumTracksView.
│       │   ├── TrackListItem.cs           // Generic track row showing title and artist.
│       │   └── AlbumTrackItem.cs         // Album-specific track item showing number and duration.
│       │
│       └── Playlists/                   // Components used in PlaylistView.
│           ├── PlaylistHeader.cs         // Displays playlist title, cover art, and metadata.
│           ├── PlaylistTrackItem.cs       // Track item in playlist with remove and reorder controls.
│           └── PlaylistSearchBox.cs      // Search box to find and add tracks to playlist.
│
├── Core/                                // Application logic, state management, and backend services.
│   ├── Player.cs                         // Manages audio playback (play, pause, stop, loop, volume).
│   ├── MusicLibrary.cs                   // In-memory structure of all tracks, albums, and artists.
│   ├── MetadataHelper.cs                 // Extracts metadata (title, album, duration) using TagLibSharp.
│   └── LibraryLoader.cs                  // Loads music files and playlists from disk into memory.
│
├── Resources/                           // Static assets (covers, icons, config files, sample data).
│   └── (Icons, Album Covers, JSON data, etc.)
│
└── AppInitializer.cs                    // Application entry setup; loads library and initializes views.
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