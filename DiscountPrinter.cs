namespace OfferCalculator;

class DiscountPrinter
{
    private DiscountCalculator calculator = new DiscountCalculator();

    public void PrintData(PassengerInfo p)
    {
        string seasonal = p.IsSeasonalFlight ? "Lot w sezonie" : "Lot poza sezonem";
        string domestic = p.IsDomesticFlight ? "Lot krajowy" : "Lot międzynarodowy";
        string regular = p.IsRegularCustomer ? "Tak" : "Nie lub osoba niepełnoletnia";
        Console.WriteLine(
            $"""

            === Do obliczeń przyjęto:
            * Data urodzenia {p.DateOfBirth:dd.MM.yyyy}
            * Data lotu: {p.DateOfFlight:dddd, d, MMMM, yyyy}. {seasonal}
            * {domestic}
            * Stały klient: {regular}

            Przysługuje ci rabat w wysokości: {calculator.calculateDiscount(p)}%
            Data wygenerowania raportu: {DateTime.Now:yyyy-MM-dd HH:mm:ss}
            """
        );
    }
}
