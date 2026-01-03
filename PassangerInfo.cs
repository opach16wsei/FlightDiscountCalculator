namespace OfferCalculator;

class PassengerInfo
{
    public DateOnly DateOfBirth { get; }
    public DateOnly DateOfFlight { get; }
    public bool IsDomesticFlight { get; }
    public bool IsRegularCustomer { get; }
    public bool IsBaby { get; }
    public bool IsAdolescense { get; }
    public bool IsAdult { get; }
    public bool IsSeasonalFlight { get; }
    public bool IsBoughtInAdvance { get; }

    public PassengerInfo(
        DateOnly dateOfBirth,
        DateOnly dateOfFlight,
        bool isDomesticFlight,
        bool isRegularCustomer,
        DatesVerificator datesVerifier
    )
    {
        this.DateOfBirth = dateOfBirth;
        this.DateOfFlight = dateOfFlight;
        this.IsDomesticFlight = isDomesticFlight;
        this.IsRegularCustomer = isRegularCustomer;
        this.IsBaby = datesVerifier.IsBaby(dateOfBirth);
        this.IsAdolescense = datesVerifier.IsAdolescense(dateOfBirth);
        this.IsAdult = datesVerifier.IsAdult(dateOfBirth);
        this.IsSeasonalFlight = datesVerifier.IsSeasonal(dateOfFlight);
        this.IsBoughtInAdvance = datesVerifier.IsBoughtInAdvance(dateOfFlight);
    }
}
