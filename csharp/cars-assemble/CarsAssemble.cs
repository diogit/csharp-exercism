
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {   
        double successRate = 0;
        if (1 <= speed && speed <= 4)
        {
            successRate = 1;
        } else if (5 <= speed && speed <= 8)
        {
            successRate = 0.9;
        } else if (speed == 9)
        {
            successRate = 0.8;
        } else if (speed == 10)
        {
            successRate = 0.77;
        }
        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return 221 * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int) ProductionRatePerHour(speed) / 60;
    }
}
