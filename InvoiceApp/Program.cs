internal class Program
{
    private static void Main()
    {
        var invoice = new Invoice();
        invoice.InvoiceDate = DateTime.Today;
        invoice.CustomerNumber = "123456";
        invoice.InvoiceNumber = "VX4356";

        Console.WriteLine("Vår Invoice App fungerar!");

        Console.WriteLine("Fakturanummer: {0} Fakturadatum: {1}",
            invoice.InvoiceNumber, invoice.InvoiceDate);
    }
}