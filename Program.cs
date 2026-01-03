namespace OfferCalculator;

class Program
{
    static void Main()
    {
        InputReader ir = new InputReader();
        PassengerInfo p = new PassengerInfo(
            ir.GetDateOfBirth(),
            ir.GetDateOfFlight(),
            ir.GetIsDomesticInfo(),
            ir.GetIsRegularCustomerInfo(),
            new DatesVerificator()
        );
        DiscountPrinter printer = new DiscountPrinter();
        printer.PrintData(p);
    }
}
