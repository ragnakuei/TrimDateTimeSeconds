namespace TrimDateTimeSeconds;

public class ParkingMinutes01Calculator : IParkingMinutesCalculator
{
    public int? Minutes(DateTime from, DateTime to)
    {
        if (from > to)
        {
            return null;
        }

        var fromWithSecondZero = TirmSeconds(from);
        var toWithSecondZero   = TirmSeconds(to);

        var minutes = (int)Math.Ceiling((toWithSecondZero - fromWithSecondZero).TotalMinutes);
        return minutes;
    }

    private DateTime TirmSeconds(DateTime dt)
    {
        return new DateTime(
                            dt.Ticks - (dt.Ticks % TimeSpan.TicksPerMinute),
                            dt.Kind
                           );
    }
}
