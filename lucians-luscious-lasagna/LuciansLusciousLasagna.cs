public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesAlreadyInOven) => ExpectedMinutesInOven() - minutesAlreadyInOven;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * 2;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberOfLayers, int minutesAlreadyInOven) => PreparationTimeInMinutes(numberOfLayers) + minutesAlreadyInOven;
}
