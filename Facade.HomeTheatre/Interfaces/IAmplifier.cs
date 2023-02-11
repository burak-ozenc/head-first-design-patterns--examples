namespace Facade.HomeTheatre.Interfaces;

public interface IAmplifier
{
    void On();
    void SetVolume(int volume);
    void Off();
}