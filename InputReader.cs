namespace OfferCalculator;

public class InputReader
{
    public DateOnly GetDateOfBirth() =>
        GetDate("Podaj swoją datę urodzenia w formacie RRRR-MM-DD: ", onlyPastDate: true);

    public DateOnly GetDateOfFlight() =>
        GetDate("Podaj datę lotu w formacie RRRR-MM-DD: ", onlyFutureDate: true);

    public bool GetIsDomesticInfo() => GetBool("Czy lot jest krajowy (T/N)? ");

    public bool GetIsRegularCustomerInfo() => GetBool("Czy jesteś stałym klientem (T/N)? ");

    private DateOnly GetDate(string input, bool onlyPastDate = false, bool onlyFutureDate = false)
    {
        DateOnly date;
        var today = DateOnly.FromDateTime(DateTime.Today);
        while (true)
        {
            Console.Write(input);
            if (DateOnly.TryParse(Console.ReadLine(), out date))
            {
                if (onlyPastDate && date >= today)
                {
                    Console.WriteLine("Data nie może być większa niż dzisiejsza");
                    Console.WriteLine();
                    continue;
                }
                if (onlyFutureDate && date <= today)
                {
                    Console.WriteLine("Data nie może być mniejsza niż dzisiejsza");
                    Console.WriteLine();
                    continue;
                }
                return date;
            }
            Console.WriteLine("Niepoprawny format daty. Spróbuj jeszcze raz.");
            Console.WriteLine();
        }
    }

    public bool GetBool(string input)
    {
        while (true)
        {
            Console.Write(input);
            string? regular = Console.ReadLine();
            if (string.IsNullOrEmpty(regular))
            {
                Console.WriteLine("Nie wprowadzono wartości. Spróbuj jeszcze raz.");
                Console.WriteLine();
                continue;
            }
            if (regular.ToUpper().Equals("T"))
                return true;
            if (regular.ToUpper().Equals("N"))
                return false;
            Console.WriteLine(
                "Niepoprawna wartość. \'T\' - TAK, \'N\' - NIE. Spróbuj jeszcze raz."
            );
            Console.WriteLine();
        }
    }
}
