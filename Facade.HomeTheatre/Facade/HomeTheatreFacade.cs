using Facade.HomeTheatre.Interfaces;
using Facade.HomeTheatre.Objects;

namespace Facade.HomeTheatre.Facade;

public class HomeTheatreFacade
{
    private IPopcornPopper _popcornPopper;
    private IScreen _screen;
    private ILight _light;
    private IProjector _projector;
    private IAmplifier _amplifier;
    private IDvdPlayer _dvdPlayer;
    

    public HomeTheatreFacade(IPopcornPopper popcornPopper, IScreen screen, ILight light, IProjector projector, IAmplifier amplifier, IDvdPlayer dvdPlayer)
    {
        _popcornPopper = popcornPopper;
        _screen = screen;
        _light = light;
        _projector = projector;
        _amplifier = amplifier;
        _dvdPlayer = dvdPlayer;
    }

    public void WatchMovie()
    {
        Console.WriteLine("Setting the movie environment.");
        _popcornPopper.On();
        _popcornPopper.Pop();
        _screen.Down();
        _light.Dim(10);
        _projector.On();
        _projector.WideScreen();
        _amplifier.On();
        _amplifier.SetVolume(10);
        _dvdPlayer.On();
        _dvdPlayer.SetDVD("Lord Of");
    }

    public void EndMovie()
    {
        _popcornPopper.Off();
        _screen.Up();
        _light.Dim(15);
        _projector.Off();
        _amplifier.Off();
        _dvdPlayer.Off();
    }
}