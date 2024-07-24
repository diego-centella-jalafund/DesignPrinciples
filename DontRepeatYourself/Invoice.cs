namespace DontRepeatYourself;

public class Invoice
{
  public Order Order { get; set; }

  public void GenerateInvoice()
  {
    decimal total = OrderCalculator.CalculateTotal(order);
    Console.WriteLine($"Invoice Total: {total:C}");
  }
}
