namespace Audio_256.App
{
    using Audio_256.Core;

    public static class AppInitializer
    {
        public static IMediator? Mediator { get; private set; }
        public static MusicLibrary? Library { get; private set; }

        public static void Initialize()
        {
            Mediator = new Mediator();
            Library = new MusicLibrary();

            var loader = new LibraryLoader(Library);
            loader.Load();

            // Now Mediator and Library are available globally
        }
    }
}
