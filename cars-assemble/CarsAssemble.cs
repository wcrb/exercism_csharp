using System;

static class AssemblyLine
{
    const int maxNumberOfCarsProducedPerHour = 221;
    public static double SuccessRate(int speed)
    {
        if (speed == 10) return 0.77;
        else if (speed == 9) return 0.8;
        else if (speed >= 5) return 0.9;
        else if (speed >= 1) return 1;

        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return SuccessRate(speed) * speed * maxNumberOfCarsProducedPerHour;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
