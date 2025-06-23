using Audio_256.Core;

public static class AppInitializer
{
    public static IMediator Mediator { get; private set; }

    public static void Initialize()
    {
        Mediator = new Mediator();
        // Pass Mediator to controllers
    }
}
