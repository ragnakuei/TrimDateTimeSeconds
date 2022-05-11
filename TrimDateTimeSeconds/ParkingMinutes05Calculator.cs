namespace TrimDateTimeSeconds;

public class ParkingMinutes05Calculator : IParkingMinutesCalculator
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
        var format = "yyyy-MM-dd HH:mm";
        return DateTime.ParseExact(dt.ToString(format), format, null);
    }
}
