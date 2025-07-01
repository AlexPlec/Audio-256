using System.Text.Json;
using static Audio_256.Core.DomainModels;

namespace Audio_256.Core
{
    public class LibraryLoader(MusicLibrary library)
    {
        private readonly MusicLibrary _library = library;

        public void Load()
        {
            MusicInitialization();
        }
        public void MusicInitialization()
        {
            string musicPath = @"C:\Users\accht\Documents\GitHub\Audio-256\Music";
            string jsonPath = @"C:\Users\accht\Documents\GitHub\Audio-256\Audio-256\App\Resources\music.json";

            if (!File.Exists(jsonPath))
            {
                Console.WriteLine("music.json not found. Rebuilding...");
                LoadMusic(musicPath);
                SaveMusicJson();
                return;
            }

            if (!IsMusicJsonUpToDate(jsonPath, musicPath))
            {
                Console.WriteLine("music.json is outdated. Rebuilding...");
                _library.Artists.Clear(); // reset existing data
                LoadMusic(musicPath);
                SaveMusicJson();
            }
            else
            {
                Console.WriteLine("music.json is up to date. Loading from JSON...");
                LoadFromMusicJson(jsonPath);
            }
        }
        private void LoadMusic(string musicPath)
        {
            var artistDirs = Directory.GetDirectories(musicPath);
            foreach (var artistDir in artistDirs)
            {
                var artistName = Path.GetFileName(artistDir);
                var artistCover = Path.Combine(artistDir, "artist.jpg");

                var artist = new Artist
                {
                    Title = artistName,
                    CoverPath = File.Exists(artistCover) ? artistCover : null
                };

                foreach (var albumDir in Directory.GetDirectories(artistDir))
                {
                    var albumName = Path.GetFileName(albumDir);
                    var albumCover = Path.Combine(albumDir, "cover.jpg");

                    var album = new Album
                    {
                        Title = albumName,
                        CoverPath = File.Exists(albumCover) ? albumCover : null
                    };

                    foreach (var file in Directory.GetFiles(albumDir, "*.mp3"))
                    {
                        var tagFile = TagLib.File.Create(file);
                        var track = new Track
                        {
                            Title = tagFile.Tag.Title,
                            FilePath = file,
                            Duration = tagFile.Properties.Duration,
                        };

                        album.Tracks.Add(track);
                    }

                    artist.Albums.Add(album);
                }

                _library.Artists.Add(artist);
            }
        }
        private void SaveMusicJson()
        {
            string outputPath = @"C:\Users\accht\Documents\GitHub\Audio-256\Audio-256\App\Resources\music.json";

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            var musicData = new
            {
                _library.Artists
            };

            var json = JsonSerializer.Serialize(musicData, options);
            File.WriteAllText(outputPath, json);
        }

        private static bool IsMusicJsonUpToDate(string jsonPath, string musicPath)
        {
            try
            {
                var json = File.ReadAllText(jsonPath);
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var jsonData = JsonSerializer.Deserialize<MusicJsonData>(json, options);

                if (jsonData == null) return false;

                var folderArtistCount = Directory.GetDirectories(musicPath).Length;
                if (folderArtistCount != jsonData.Artists.Count)
                    return false;

                foreach (var artistDir in Directory.GetDirectories(musicPath))
                {
                    var artistName = Path.GetFileName(artistDir);
                    var artistData = jsonData.Artists.FirstOrDefault(a => a.Title == artistName);
                    if (artistData == null) return false;

                    var albumDirs = Directory.GetDirectories(artistDir);
                    if (albumDirs.Length != artistData.Albums.Count) return false;

                    foreach (var albumDir in albumDirs)
                    {
                        var albumName = Path.GetFileName(albumDir);
                        var albumData = artistData.Albums.FirstOrDefault(a => a.Title == albumName);
                        if (albumData == null) return false;

                        var trackFiles = Directory.GetFiles(albumDir, "*.mp3");
                        if (trackFiles.Length != albumData.Tracks.Count) return false;
                    }
                }

                return true;
            }
            catch
            {
                return false; // on any error (e.g. corrupted json), assume it's not up to date
            }
        }

        private void LoadFromMusicJson(string path)
        {
            var json = File.ReadAllText(path);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = JsonSerializer.Deserialize<MusicJsonData>(json, options);

            if (data?.Artists != null)
            {
                _library.Artists.Clear();
                foreach (var artist in data.Artists)
                {
                    _library.Artists.Add(artist);
                }
            }
        }
    }
}
