namespace TrimDateTimeSeconds;

public class ParkingMinutes02Calculator : IParkingMinutesCalculator
{
    public int? Minutes(DateTime from, DateTime to)
    {
        if (from > to)
        {
            return null;
        }

        int hours   = to.Hour   - from.Hour;
        int minutes = to.Minute - from.Minute;

        return 60 * hours + minutes;
    }
}
