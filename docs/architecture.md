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
    ├── Shared/                            // 🔁 Shared visual/UI modules
    │   ├── NavBar/
    │   │   ├── Models/
    │   │   │   └── NavBarModel.cs
    │   │   ├── Views/
    │   │   │   └── NavBarView.cs
    │   │   └── Controllers/
    │   │       └── NavBarController.cs
    │   │
    │   ├── PlayerControlBar/
    │   │   ├── PlayerHeader/
    │   │   │   ├── Models/
    │   │   │   │   └── PlayerHeaderModel.cs
    │   │   │   ├── Views/
    │   │   │   │   └── PlayerHeaderView.cs
    │   │   │   └── Controllers/
    │   │   │        └── PlayerHeaderController.cs
    │   │   │  
    │   │   ├── PlayerBar/
    │   │   │   ├── Models/
    │   │   │   │   └── PlayerBarModel.cs
    │   │   │   ├── Views/
    │   │   │   │   └── PlayerBarView.cs
    │   │   │   └── Controllers/
    │   │   │        └── PlayerBarController.cs
    │   │   │
    │   │   └── SoundBar/
    │   │       ├── Models/
    │   │       │   └── SoundBarModel.cs
    │   │       ├── Views/
    │   │       │   └── SoundBarView.cs
    │   │       └── Controllers/
    │   │           └── SoundBarController.cs
    │   │
    │   └── SystemTrayIcon/
    │       ├── Models/
    │       │   └── SystemTrayIconModel.cs
    │       ├── Views/
    │       │   └── SystemTrayIconView.cs
    │       └── Controllers/
    │           └── SystemTrayIconController.cs
    │
    ├── Artists/
    │   ├── Models/
    │   │   ├── ArtistsViewModel.cs
    │   │   └── ArtistListThumbnailModel.cs
    │   ├── Views/
    │   │   ├── ArtistsView.cs
    │   │   └── ArtistListThumbnailView.cs
    │   └── Controllers/
    │       ├── ArtistsViewController.cs
    │       └── ArtistListThumbnailController.cs
    │
    ├── Albums/
    │   ├── Models/
    │   │   ├── AlbumsViewModel.cs
    │   │   └── AlbumListThumbnailModel.cs
    │   ├── Views/
    │   │   ├── AlbumsView.cs
    │   │   └── AlbumListThumbnailView.cs
    │   └── Controllers/
    │       ├── AlbumsViewController.cs
    │       └── AlbumListThumbnailController.cs
    │
    ├── ArtistAlbums/
    │   ├── Models/
    │   │   ├── ArtistAlbumsViewModel.cs
    │   │   └── ArtistAlbumThumbnailModel.cs
    │   ├── Views/
    │   │   ├── ArtistAlbumsView.cs
    │   │   └── ArtistAlbumThumbnailView.cs
    │   └── Controllers/
    │       ├── ArtistAlbumsViewController.cs
    │       └── ArtistAlbumThumbnailController.cs
    │   
    ├── AlbumTracks/
    │   ├── Models/
    │   │   ├── AlbumTracksViewModel.cs
    │   │   ├── AlbumTracksHeaderModel.cs
    │   │   ├── AlbumTracksListModel.cs
    │   │   └── AlbumTrackItemModel.cs
    │   ├── Views/
    │   │   ├── AlbumTracksView.cs
    │   │   ├── AlbumTracksHeaderView.cs
    │   │   ├── AlbumTracksListView.cs
    │   │   └── AlbumTrackView.cs
    │   └── Controllers/
    │       ├── AlbumTracksViewController.cs
    │       ├── AlbumTracksHeaderController.cs
    │       ├── AlbumTracksListController.cs
    │       └── AlbumTrackController.cs
    │
    ├── Playlist/
    │   ├── Models/
    │   │   ├── PlaylistViewModel.cs
    │   │   ├── PlaylistCreateButtonModel.cs
    │   │   └── PlaylistThumbnailModel.cs
    │   ├── Views/
    │   │   ├── PlaylistView.cs
    │   │   ├── PlaylistCreateButtonView.cs
    │   │   └── PlaylistThumbnailView.cs
    │   └── Controllers/
    │       ├── PlaylistViewController.cs
    │       ├── PlaylistCreateButtonController.cs
    │       └── PlaylistThumbnailController.cs
    │
    └── PlaylistTracks/
        ├── Models/
        │   ├── PlaylistTracksViewModel.cs
        │   ├── PlaylistTrackItemModel.cs
        │   ├── PlaylistHeaderModel.cs
        │   ├── PlaylistListModel.cs
        │   ├── PlaylistSearchTrackItemModel.cs
        │   └── PlaylistSearchBoxModel.cs
        ├── Views/
        │   ├── PlaylistTracksView.cs
        │   ├── PlaylistTrackItemView.cs
        │   ├── PlaylistHeaderView.cs
        │   ├── PlaylistListView.cs
        │   ├── PlaylistSearchTrackItemView.cs
        │   └── PlaylistSearchBoxView.cs
        └── Controllers/
            ├── PlaylistTracksViewController.cs
            ├── PlaylistTrackItemController.cs
            ├── PlaylistHeaderController.cs
            ├── PlaylistListController.cs
            ├── PlaylistSearchTrackItemController.cs
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