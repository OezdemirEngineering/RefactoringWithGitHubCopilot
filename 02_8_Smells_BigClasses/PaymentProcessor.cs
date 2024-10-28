namespace _02_8_Smells_BigClasses;

public class PaymentProcessor
{
    public string PaymentMethod { get; set; }
    public bool PaymentStatus { get; private set; }

    public PaymentProcessor(string paymentMethod)
    {
        PaymentMethod = paymentMethod;
    }

    public bool ProcessPayment()
    {
        // Simulated payment process
        PaymentStatus = PaymentMethod == "Credit Card";
        return PaymentStatus;
    }
}
