# ✅ Audio-256 Development To-Do List

## 🏗 Architecture & Core Framework
- [x] Refactor existing UI into proper MVC triplets (Model, View, Controller per feature)
- [x] Implement MediatorPattern for global event dispatching
- [ ] Add event type constants to `MediatorPattern.cs` to avoid magic strings
- [ ] Add unit tests for Mediator to verify subscriber propagation

## 🎛 Core Services
- [ ] Add `Shuffle` support in `Player.cs` with toggle via `Mediator`
- [ ] Add `SeekTo(position)` support to Player for scrubbing
- [ ] Add event for "TrackFinished" in Player → auto-advance logic
- [ ] Add method in `LibraryLoader` to re-scan new folders at runtime
- [ ] Move user config to a separate `UserSettings.cs` class

## 🎨 UI / UX Enhancements

### Global Controls
- [ ] Improve `PlayerControlBar` with animated feedback (playing/seeking)
- [ ] Add tooltip hints for `NavBar` buttons
- [ ] Add context menu to `SystemTrayIcon` with more controls (Shuffle, Repeat)

### Artists / Albums
- [ ] Add support for multiple genres per artist/album
- [ ] Display total track count + duration in `ArtistAlbumsView`

### AlbumTracks
- [ ] Highlight currently playing track
- [ ] Support drag-and-drop from album view into playlists
- [ ] Show track bitrate/quality as an optional column

### Playlists
- [ ] Enable reordering tracks in `PlaylistListView` with drag handles
- [ ] Add support for renaming/deleting user playlists
- [ ] Add "Save Playlist As..." duplicate option

## 💾 Persistence
- [ ] Save window size and last-selected view in user settings
- [ ] Add disk persistence to `MusicLibrary` state on app exit
- [ ] Add error handling to JSON deserialization (invalid format fallback)

## ⚙️ Development & Debugging
- [ ] Add logging to `MediatorPattern.cs` (e.g., Debug.WriteLine for all published events)
- [ ] Create test UI mode that uses mock data only
- [ ] Add developer shortcut keys (Ctrl+R to reload, Ctrl+Shift+T for test event)

## 📁 File & Folder Handling
- [ ] Implement drag-and-drop folder import into UI → calls `LibraryLoader`
- [ ] Add "Open in Explorer" context menu for albums and tracks

## 📖 Documentation
- [x] `README.md` with updated features, specs, and architecture
- [x] `architecture.md` with MVC + Mediator interaction flow
- [x] `customcontrols.md` with all shared components listed
- [ ] `mediator.md` to explain event system and usage
- [ ] Add `events.md`: a list of all Mediator events (e.g., `TrackPlayRequested`, `VolumeChanged`)
- [ ] Add `contributing.md` for open source collaboration

## 🌐 Stretch Goals (Future)
- [ ] Add support for `.flac`, `.wav` (requires metadata fallback)
- [ ] Add visualizations during playback (spectrum/level meter)
- [ ] Add global media hotkey support (next/prev/play from OS)
- [ ] Implement basic settings window (theme, audio output device, library path)

---