# 📋 Audio-256 Development Task List

## 🔹 Core / App

### App/
- [x] Setup application startup flow in `AppInitializer.cs` (load music, setup mediator, initialize views)
- [ ] Implement graceful shutdown and save session state in `AppInitializer.cs`
- [ ] Ensure `Program.cs` properly launches main form and handles exceptions
- [ ] Organize and optimize shared resources under `Resources/`

### Core/
- [ ] Complete `Player.cs` functionality: play, pause, stop, volume, looping, and event notifications
- [ ] Implement playback events and integration with Mediator (`TrackStarted`, `TrackEnded`, etc.)
- [ ] Finalize `MusicLibrary.cs` to provide centralized music data API (CRUD for tracks, albums, playlists)
- [x] Implement file scanning and loading logic in `LibraryLoader.cs`
- [ ] Complete `MetadataHelper.cs` to extract all relevant tags and album art from audio files
- [x] Implement and test `MediatorPattern.cs` as a global event bus

## 🔹 UI Modules

### MainForm/
- [x] Implement `MainFormModel.cs` for main app state (active view, window size, etc.)
- [x] Develop `MainFormView.cs` with layout hosting NavBar, PlayerControlBar, main content area
- [x] Create `MainFormController.cs` to coordinate UI events and mediator subscriptions

### Shared/

#### NavBar/
- [ ] Complete `NavBarModel` with navigation state
- [ ] Develop `NavBarView` with clickable navigation items
- [ ] Implement `NavBarController` event handlers to switch views

#### PlayerControlBar/

##### PlayerHeader/
- [ ] Develop `PlayerHeaderModel` for current track info
- [ ] Build `PlayerHeaderView` UI
- [ ] Implement `PlayerHeaderController` to update track display on events

##### PlayerBar/
- [ ] Implement `PlayerBarModel` (play/pause state, progress)
- [ ] Build `PlayerBarView` (playback buttons, progress bar)
- [ ] Implement `PlayerBarController` logic (button clicks, progress updates)

##### SoundBar/
- [ ] Implement `SoundBarModel` (volume level)
- [ ] Build `SoundBarView` (volume slider)
- [ ] Implement `SoundBarController` handling volume changes

#### SystemTrayIcon/
- [x] Develop `SystemTrayIconModel` to track tray icon state
- [x] Implement `SystemTrayIconView` to create and manage tray icon UI and context menu
- [x] Add `SystemTrayIconController` to handle tray events and communicate via Mediator

### Artists/
- [x] Implement `ArtistsViewModel.cs` with artist list and selected artist
- [x] Build `ArtistsView.cs` for artist grid/list display
- [x] Implement `ArtistsViewController.cs` for loading artist data and handling user interaction
- [x] Implement `ArtistThumbnailModel.cs`, `ArtistThumbnailView.cs`, and `ArtistThumbnailController.cs` for individual artist preview components

### Albums/
- [x] Implement `AlbumsViewModel.cs` to manage albums data and selection
- [x] Build `AlbumsView.cs` for album list/grid UI
- [x] Implement `AlbumsViewController.cs` to manage album loading, selection
- [x] Create `AlbumThumbnail` MVC to display album cover + title, add click handling

### ArtistAlbums/
- [x] Implement `ArtistAlbumsViewModel.cs` for albums filtered by artist
- [x] Build `ArtistAlbumsView.cs` for artist-specific album listing
- [x] Implement `ArtistAlbumsViewController.cs` for data loading and interaction
- [x] Create `ArtistAlbumThumbnail` MVC components for compact album previews

### AlbumTracks/
- [x] Implement `AlbumTracksViewModel.cs` with track list and current track
- [x] Develop `AlbumTracksView.cs` to show track listing UI
- [x] Implement `AlbumTracksViewController.cs` to load tracks for selected album and handle play requests
- [x] Create MVC for `AlbumTracksHeader`, `AlbumTracksList`, and `AlbumTrackItem` subcomponents

### Playlist/
- [ ] Implement `PlaylistViewModel.cs` for playlist collection and selected playlist
- [ ] Build `PlaylistView.cs` UI for playlist display
- [ ] Implement `PlaylistViewController.cs` to manage playlist loading, creation, deletion
- [ ] Create `PlaylistCreateButton` MVC for adding new playlists
- [ ] Create `PlaylistThumbnail` MVC components for displaying individual playlists

### PlaylistTracks/
- [ ] Implement `PlaylistTracksViewModel.cs` for tracks inside a playlist
- [ ] Develop `PlaylistTracksView.cs` UI with drag/drop, add/remove functionality
- [ ] Implement `PlaylistTracksViewController.cs` for managing playlist track actions
- [ ] Create MVC triplets for `PlaylistTrackItem`, `PlaylistHeader`, `PlaylistList`, `PlaylistSearchTrackItem`, `PlaylistSearchBox`

## 🔧 Cross-Cutting Tasks
- [ ] Wire Mediator events between all controllers and core services
- [ ] Implement error handling and logging throughout app layers
- [ ] Add unit and integration tests for Core services and UI Controllers
- [ ] Implement user preferences persistence (window size, last view, volume)
- [ ] Optimize UI responsiveness and handle large libraries efficiently
- [ ] Add keyboard shortcuts for common actions (play/pause, next, search)
- [ ] Add accessibility support (tab order, screen reader labels)

## 📝 Documentation & Maintenance
- [ ] Update architecture docs to reflect MVC + Mediator pattern usage
- [ ] Document all Mediator event types and payloads
- [ ] Write developer guide for adding new features or UI modules
- [ ] Maintain README with setup, build, and usage instructions
