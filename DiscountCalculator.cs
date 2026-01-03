namespace OfferCalculator;

class DiscountCalculator
{
    public int calculateDiscount(PassengerInfo p)
    {
        int discount = 0;

        if (p.IsBaby)
        {
            discount += p.IsDomesticFlight ? 80 : 70;
        }

        discount += p.IsAdolescense ? 10 : 0;
        discount += (p.IsAdult && p.IsRegularCustomer) ? 15 : 0;
        discount += p.IsBoughtInAdvance ? 10 : 0;
        discount += (!p.IsDomesticFlight && !p.IsSeasonalFlight) ? 15 : 0;

        return Math.Min(discount, p.IsBaby ? 80 : 30);
    }
}
