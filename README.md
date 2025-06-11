# 🎵 Audio-256: Open Source Audio Player

**Audio-256** is a feature-rich, open source audio player for Windows. Built for performance and simplicity, it offers a modern and intuitive interface with efficient handling of music libraries in **MP3 format**. Designed to use minimal system resources, Audio-256 is perfect for both casual listening and power users who want control over their audio library.

---

## 🚀 Key Features

- 🖥️ **Windows Desktop Application** with clean, responsive UI  
- 📂 **Library View** for managing your complete audio collection  
- 🎨 **Artists View**, **Albums View**, **Songs View**, and **Playlists View** for versatile browsing  
- 📜 **Metadata-Based Organization** using embedded tags (Title, Album, Artist)  
- 🔁 **History of Last Playlist** automatically reloaded on app start  
- ➕ **User-Created Playlists** with persistent saving  
- 🎧 **MP3 Format Support**  
- 🧠 **Optimized for Low Resource Usage**  
- 🛠️ **System Tray Integration** for background control and quick access  

---

## ⚙️ Technical Specifications

- **Language & Framework**: C# (.NET Framework)  
- **UI Framework**: Windows Forms  
- **Audio Engine**: [NAudio](https://github.com/naudio/NAudio)  
- **Metadata Parsing**: [TagLibSharp](https://github.com/mono/taglib-sharp)  
- **Data Serialization**: [Newtonsoft.Json](https://www.newtonsoft.com/json)  

---

## 💡 User Experience Highlights

- 🎵 Seamless audio playback with reliable controls  
- 💽 Quick browsing via metadata-rich views  
- 💾 Automatically saves last-used playlist and restores it on launch  
- 🖱️ Right-click tray menu for basic control (play/pause, next, exit)  
- 📝 User playlists saved in structured JSON format  

---

## 📁 Project Structure *(Example)*

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
