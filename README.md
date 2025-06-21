# 🎵 Audio-256: Open Source Audio Player

**Audio-256** is a lightweight, modular, and extensible MP3 audio player for Windows. Built with a clean **MVC architecture** and an event-driven **Mediator pattern**, it offers intuitive user experiences and well-structured, maintainable code. Whether you're a music lover or a developer, **Audio-256** balances performance, usability, and design flexibility.

---

## 📚 Table of Contents

- 🚀 [Key Features](#-key-features)
- 🧩 [Architecture Overview](#-architecture-overview)
- ⚙️ [Technical Specifications](#️-technical-specifications)
- 💡 [User Experience Highlights](#-user-experience-highlights)
- 📖 [Technical Documentation](#-technical-documentation)
- 📝 [License](#-license)

---

## 🚀 Key Features

- 🪟 **Modern Windows Desktop UI** with modular UserControls
- 📁 **Dynamic Library Management** with metadata-based indexing
- 🧑‍🎨 **Artists, Albums, Tracks, Playlists Views** for flexible browsing
- 🔁 **Persistent Playlist History** restored on app launch
- ➕ **User-Created Playlists** stored in structured JSON
- 📦 **MVC Pattern** for clear separation of state, rendering, and logic
- 🔄 **Mediator Pattern** for decoupled component communication
- 🎧 **Smooth MP3 Playback** via NAudio
- 📌 **System Tray Integration** for background control

---

## 🧩 Architecture Overview

**Audio-256** follows a modular **Model–View–Controller (MVC) pattern** in the UI layer and a global **Mediator** for event-driven communication.

| Layer          | Responsibility                                                                 |
| -------------- | ------------------------------------------------------------------------------ |
| **Model**      | Stores UI state (selected track, volume, playlists, etc.)                      |
| **View**       | Renders layout, binds UI elements to the model                                 |
| **Controller** | Handles user input and state logic; interacts with services via Mediator       |
| **Mediator**   | Facilitates decoupled messaging between views, services, and shared components |

This structure ensures maintainability, reusability, and testability throughout the app.

---

## ⚙️ Technical Specifications

| Tech          | Description                                         |
| ------------- | --------------------------------------------------- |
| Language      | [C# (.NET Framework)](https://dotnet.microsoft.com/en-us/languages/csharp)                                 |
| UI Framework  | [Windows Forms](https://github.com/dotnet/winforms) |
| Audio Engine  | [NAudio](https://github.com/naudio/NAudio)          |
| Metadata      | [TagLibSharp](https://github.com/mono/taglib-sharp) |
| Messaging     | In-house [Mediator pattern](docs/mediator.md) for pub/sub decoupling |
| Serialization | [Newtonsoft.Json](https://www.newtonsoft.com/json)  |

---

## 💡 User Experience Highlights

- 🎵 Seamless Playback with Play, Pause, Seek, Loop, Volume
- 🧠 Low Memory Footprint and fast load times for large libraries
- 💾 Session Persistence – automatically restores last playlist and playback state
- 🖱️ System Tray Menu for playback control without opening the main window
- 🗂️ Metadata-Driven Views – Artists, Albums, Tracks, and Playlists
- 🧩 Custom UserControls for track items, thumbnails, search bars, and more

---

## 📖 Technical Documentation

- 📐 [Technical Architecture](docs/architecture.md) — Overview of the system layout
- 🧩 [Custom UserControls](docs/usercontrols.md) —  Modular design patterns
- 🔄 [Component Overview](docs/components.md) — Initialization and interaction diagrams

---

## 📝 License

This project is licensed under the [MIT License](LICENSE).
