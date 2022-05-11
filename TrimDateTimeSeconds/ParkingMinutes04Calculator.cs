namespace TrimDateTimeSeconds;

public class ParkingMinutes04Calculator : IParkingMinutesCalculator
{
    public int? Minutes(DateTime from, DateTime to)
    {
        if (from > to)
        {
            return null;
        }
        
        var minutes = (int)Math.Ceiling((TrimSeconds(to) - TrimSeconds(from)).TotalMinutes);
        return minutes;
    }

    private DateTime TrimSeconds(DateTime dt)
    {
        return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, 0);
    }
}
