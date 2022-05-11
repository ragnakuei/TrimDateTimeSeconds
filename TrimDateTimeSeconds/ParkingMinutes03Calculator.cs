namespace TrimDateTimeSeconds;

public class ParkingMinutes03Calculator : IParkingMinutesCalculator
{
    public int? Minutes(DateTime from, DateTime to)
    {
        if (from > to)
        {
            return null;
        }
        
        var fromInMinutes = from.Ticks / TimeSpan.TicksPerMinute;
        var toInMinutes   = to.Ticks   / TimeSpan.TicksPerMinute;
        return Convert.ToInt32(toInMinutes - fromInMinutes);
    }
}
