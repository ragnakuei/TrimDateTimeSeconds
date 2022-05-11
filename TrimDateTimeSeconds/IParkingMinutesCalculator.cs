namespace TrimDateTimeSeconds;

public interface IParkingMinutesCalculator
{
    int? Minutes(DateTime from, DateTime to);
}
