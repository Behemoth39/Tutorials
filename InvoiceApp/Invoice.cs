public class Invoice
{
    // Våra fält
    public string InvoiceNumber = "";
    public DateTime InvoiceDate;
    public string PaymentTerms = "";
    public string PurchaseOrder = "";
    public string OrderNumber = "";
    public string CustomerNumber = "";
    public string Currency = "";
    public double InvoiceTotal;
    public double Taxes;
    public double NetTotal;

    // Våra metoder (operations)
    public void SendInvoice()
    {
        Console.WriteLine("Fakturan skickas!");
    }
}