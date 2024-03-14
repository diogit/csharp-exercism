using System;

class RemoteControlCar
{
    private int metersDriven;
    private int battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay()
    {
        return $"Battery " + (battery > 0 ? $"at {battery}%" : "empty");
    }

    public void Drive()
    {
        if (battery > 0)
        {
            metersDriven += 20;
            battery -= 1;
        }
    }
}
