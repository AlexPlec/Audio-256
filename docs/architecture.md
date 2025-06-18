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
├── App/                                   // 🎯 App-level config and bootstrap
│   ├── AppInitializer.cs
│   ├── Program.cs
│   └── Resources/                         // Static content (icons, covers, etc.)
│       └── ...
│
├── Core/                                  // ⚙️ Reusable application-wide logic
│   ├── Player.cs
│   ├── MusicLibrary.cs
│   ├── MetadataHelper.cs
│   └── LibraryLoader.cs
│
└── UI/                                    // 🎨 User interface grouped by feature
    │
    ├── MainForm/
    │   ├── Models/
    │   │   └── MainFormModel.cs
    │   ├── Views/
    │   │   └── MainFormView.cs
    │   └── Controllers/
    │       └── MainFormController.cs
    │
    ├── Shared/                            // UI Elements shared across modules
    │   ├── NavBar/
    │   │   ├── NavBarModel.cs
    │   │   ├── NavBarView.cs
    │   │   └── NavBarController.cs
    │   ├── PlayerControlBar/
    │   │   ├── PlayerControlBarModel.cs
    │   │   ├── PlayerControlBarView.cs
    │   │   └── PlayerControlBarController.cs
    │   └── SystemTrayIcon/
    │       ├── SystemTrayIconModel.cs
    │       ├── SystemTrayIconView.cs
    │       └── SystemTrayIconController.cs
    │ 
    ├── Artists/
    │   ├── Models/
    │   │   ├── ArtistsViewModel.cs
    │   │   └── ArtistListItemModel.cs
    │   ├── Views/
    │   │   ├── ArtistsView.cs
    │   │   └── ArtistListItemView.cs
    │   └── Controllers/
    │       ├── ArtistsViewController.cs
    │       └── ArtistListItemController.cs
    │ 
    ├── Albums/
    │   ├── Models/
    │   │   ├── AlbumsViewModel.cs
    │   │   ├── AlbumListItemModel.cs
    │   │   └── ArtistAlbumThumbnailModel.cs
    │   ├── Views/
    │   │   ├── AlbumsView.cs
    │   │   ├── AlbumListItemView.cs
    │   │   └── ArtistAlbumThumbnailView.cs
    │   └── Controllers/
    │       ├── AlbumsViewController.cs
    │       ├── AlbumListItemController.cs
    │       └── ArtistAlbumThumbnailController.cs
    │ 
    ├── AlbumDetails/
    │   ├── Models/
    │   │   ├── ArtistAlbumViewModel.cs
    │   │   ├── AlbumTracksViewModel.cs
    │   │   ├── TrackListItemModel.cs
    │   │   └── AlbumTrackItemModel.cs
    │   ├── Views/
    │   │   ├── ArtistAlbumView.cs
    │   │   ├── AlbumTracksView.cs
    │   │   ├── TrackListItemView.cs
    │   │   └── AlbumTrackItemView.cs
    │   └── Controllers/
    │       ├── ArtistAlbumViewController.cs
    │       ├── AlbumTracksViewController.cs
    │       ├── TrackListItemController.cs
    │       └── AlbumTrackItemController.cs
    │ 
    └── Playlists/
        ├── Models/
        │   ├── PlaylistViewModel.cs
        │   ├── PlaylistTracksViewModel.cs
        │   ├── PlaylistItemModel.cs
        │   ├── PlaylistTrackItemModel.cs
        │   ├── PlaylistHeaderModel.cs
        │   └── PlaylistSearchBoxModel.cs
        ├── Views/
        │   ├── PlaylistView.cs
        │   ├── PlaylistTracksView.cs
        │   ├── PlaylistItemView.cs
        │   ├── PlaylistTrackItemView.cs
        │   ├── PlaylistHeaderView.cs
        │   └── PlaylistSearchBoxView.cs
        └── Controllers/
            ├── PlaylistViewController.cs
            ├── PlaylistTracksViewController.cs
            ├── PlaylistItemController.cs
            ├── PlaylistTrackItemController.cs
            ├── PlaylistHeaderController.cs
            └── PlaylistSearchBoxController.cs
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