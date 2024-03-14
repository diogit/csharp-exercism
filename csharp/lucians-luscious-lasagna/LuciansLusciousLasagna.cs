class Lasagna
{
    private int cookTime = 40;

    public int ExpectedMinutesInOven() {
        return this.cookTime;
    }

    public int RemainingMinutesInOven(int currentTime) {
        return this.cookTime - currentTime;
    }

    public int PreparationTimeInMinutes(int layers) {
        return 2 * layers;
    }

    public int ElapsedTimeInMinutes(int layers, int currentTime) {
        return this.PreparationTimeInMinutes(layers) + currentTime;
    }
}
