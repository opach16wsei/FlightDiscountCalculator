namespace OfferCalculator;

public class DatesVerificator
{
    private DateOnly currentDate = DateOnly.FromDateTime(DateTime.Today);

    public bool IsBaby(DateOnly dateOfBirth) => dateOfBirth > currentDate.AddYears(-2);

    public bool IsAdolescense(DateOnly dateOfBirth) =>
        dateOfBirth <= currentDate.AddYears(-2) && dateOfBirth > currentDate.AddYears(-18);

    public bool IsAdult(DateOnly dateOfBirth) => dateOfBirth <= currentDate.AddYears(-18);

    public bool IsSeasonal(DateOnly dateOfFlight)
    {
        bool isWinterSeasonDec = dateOfFlight.Month == 12 && dateOfFlight.Day >= 20;
        bool isWinterSeasonJan = dateOfFlight.Month == 1 && dateOfFlight.Day <= 10;
        bool isWinterSeason = isWinterSeasonDec || isWinterSeasonJan;
        bool isSpringSeason =
            (dateOfFlight.Month == 3 && dateOfFlight.Day >= 20)
            || (dateOfFlight.Month == 4 && dateOfFlight.Day <= 10);
        bool isSummerSeason = dateOfFlight.Month == 7 || dateOfFlight.Month == 8;
        return isWinterSeason || isSpringSeason || isSummerSeason;
    }

    public bool IsBoughtInAdvance(DateOnly dateOfFlight) =>
        dateOfFlight <= currentDate.AddMonths(5);
}
