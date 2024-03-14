using System;

class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _batteryRemain;
    private int _distance;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
        this._batteryRemain = 100;
    }

    public bool BatteryDrained()
    {
        return this._batteryRemain < this._batteryDrain;
    }

    public int DistanceDriven()
    {
        return this._distance;
    }

    public void Drive()
    {
        if (!this.BatteryDrained())
        {
            this._distance += this._speed;
            this._batteryRemain -= this._batteryDrain;
        }
    }

    public int Capacity()
    {
        return this._speed * (100 / this._batteryDrain);
    }
    

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _length;

    public RaceTrack(int length)
    {
        this._length = length;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return this._length <= car.Capacity();
    }
}
