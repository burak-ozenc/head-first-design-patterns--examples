using Facade.HomeTheatre.Facade;
using Facade.HomeTheatre.Objects;

PopcornPopper _popcornPopper = new PopcornPopper();
Screen _screen = new Screen();
Light _light = new Light();
Projector _projector = new Projector();
Amplifier _amplifier = new Amplifier();
DvdPlayer _dvdPlayer = new DvdPlayer();

HomeTheatreFacade homeTheatreFacade = new HomeTheatreFacade(
    _popcornPopper,
    _screen,
    _light,
    _projector,
    _amplifier,
    _dvdPlayer
);

homeTheatreFacade.WatchMovie();

Console.WriteLine();

homeTheatreFacade.EndMovie();